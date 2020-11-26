using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Cvb;


namespace SegmentaciondeColor
{
    public partial class FormPrincipal : Form
    {
        #region Variables globales
        Image<Bgr, byte> img;
        Image<Bgr, byte> redImage;
        Image<Bgr, byte> greenImage;
        Image<Bgr, byte> blueImage;
        Image<Bgr, byte> combinadaImg;
        Image<Gray, byte> GverdeImage;
        Image<Gray, byte> GazulImage;
        Image<Gray, byte> GrojoImage;
        byte redAux;
        byte greenAux;
        byte blueAux;

        #endregion

        #region Inicialización
        public FormPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region TrackBar
        private void trackRed_ValueChanged(object sender, EventArgs e)
        {
            lbRed.Text ="R: "+ trackRed.Value.ToString();
            
        }

        private void trackYell_ValueChanged(object sender, EventArgs e)
        {
            lbGreen.Text = "G: " + trackGreen.Value.ToString();
            
        }

        private void trackBlue_ValueChanged(object sender, EventArgs e)
        {
            lbBlue.Text = "B: " + trackBlue.Value.ToString();
            
        }
        #endregion

        #region Importar
        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importarImage();
            descomponer();
        }
        private void importarImage()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        img = new Image<Bgr, byte>(ofd.FileName);
                        pictureFirst.Image = img.ToBitmap();
                    }
                }
            }catch(Exception)
            {
                MessageBox.Show("El formato del archivo no es un formato de imagen válido", "Error de formato",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }


        private void btnImportar_Click(object sender, EventArgs e)
        {
            importarImage();
            descomponer();
        }
        #endregion

        #region descomponer

        private void descomponer()
        {
            if (img == null)
            {
                importarImage();
            } else
            {
                blueImage = new Image<Bgr, byte>(img.Width,img.Height);
                redImage = new Image<Bgr, byte>(img.Width, img.Height);
                greenImage = new Image<Bgr, byte>(img.Width, img.Height);

                for(int i=0;i<img.Height;i++)
                {
                    for(int j=0;j<img.Width;j++)
                    {
                        redAux = (byte)img[i, j].Red;
                        greenAux = (byte)img[i, j].Green;
                        blueAux = (byte)img[i, j].Blue;

                        if (blueAux>trackBlue.Value & redAux<trackBlue.Value & greenAux<trackBlue.Value)
                            blueImage[i, j] = new Bgr(255, 0, 0);
                       if (redAux>trackRed.Value & blueAux<trackRed.Value & greenAux<trackRed.Value)
                            redImage[i, j] = new Bgr(0,0,img[i,j].Red);
                       if (greenAux > trackGreen.Value & redAux < trackGreen.Value & blueAux < trackGreen.Value)
                            greenImage[i, j] = new Bgr(0, img[i, j].Green, 0);                       
                    }
                }
                pictureBlue.Image = blueImage.Bitmap;
                pictureGreen.Image = greenImage.Bitmap;
                pictureRed.Image = redImage.Bitmap;
            }
        }

        private void btnSegment_Click(object sender, EventArgs e)
        {
            if(img==null)
            {
                importarImage();
            }

            descomponer();
        }

        #endregion

        #region Intercambio
        private void btnIntercambio_Click(object sender, EventArgs e)
        {
            
            if(img!=null)
            {
                if (btnIntercambio.Text == "ORIGINAL")
                {
                    btnIntercambio.Text = "COMBINAR";
                    pictureFirst.Image = img.ToBitmap();
                }
                else
                {
                    btnIntercambio.Text = "ORIGINAL";
                    componer();           
                    pictureFirst.Image = combinadaImg.ToBitmap();
                }
            }
            else
            {
                MessageBox.Show("Debe cargar una imagen","Sin imagen cargada",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
  
           
        }
        #endregion

        #region Componer
        private void componer()
        {
            combinadaImg = new Image<Bgr, byte>(img.Width,img.Height);
            for(int i=0;i<combinadaImg.Height;i++)
            {
                for(int j=0;j<combinadaImg.Width;j++)
                {
                    combinadaImg[i, j] = new Bgr(blueImage[i, j].Blue, greenImage[i, j].Green, redImage[i, j].Red);
                }
            }
        }


        #endregion

        private void btnEtiquetar_Click(object sender, EventArgs e)
        {
            GrojoImage = redImage.Convert<Gray, byte>().ThresholdBinary(new Gray(10), new Gray(255));
            Emgu.CV.Util.VectorOfVectorOfPoint contoursRed = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat matRed = new Mat();
            CvInvoke.FindContours(GrojoImage,contoursRed,matRed, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            for (int i = 0; i < contoursRed.Size; i++)
            {
                var area = CvInvoke.ContourArea(contoursRed[i]);
                if (area > (int)numericSize.Value)
                {
                    var blob = CvInvoke.BoundingRectangle(contoursRed[i]);
                    blob.Y -= 5;
                    CvInvoke.PutText(img, "Rojo" , blob.Location, Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.5, new MCvScalar(255, 255, 255));
                    CvInvoke.PutText(combinadaImg, "Rojo", blob.Location, Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.5, new MCvScalar(255, 255, 255));
                }

            }
            GverdeImage = greenImage.Convert<Gray, byte>().ThresholdBinary(new Gray(10), new Gray(255));
            Emgu.CV.Util.VectorOfVectorOfPoint contoursGreen = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat matVer = new Mat();
            CvInvoke.FindContours(GverdeImage, contoursGreen, matVer, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            for (int i = 0; i < contoursGreen.Size; i++)
            {
                var area = CvInvoke.ContourArea(contoursGreen[i]);
                if (area > (int)numericSize.Value)
                {
                    var blob = CvInvoke.BoundingRectangle(contoursGreen[i]);
                    blob.Y -= 5;
                    CvInvoke.PutText(img, "Verde", blob.Location, Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.5, new MCvScalar(255, 255, 255));
                    CvInvoke.PutText(combinadaImg, "Verde", blob.Location, Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.5, new MCvScalar(255, 255, 255));
                }

            }
            GazulImage = blueImage.Convert<Gray, byte>().ThresholdBinary(new Gray(10), new Gray(255));
            Emgu.CV.Util.VectorOfVectorOfPoint contoursBlue = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat matAzu = new Mat();
            CvInvoke.FindContours(GazulImage, contoursBlue, matAzu, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            for (int i = 0; i < contoursBlue.Size; i++)
            {
                var area = CvInvoke.ContourArea(contoursBlue[i]);
                if (area > (int)numericSize.Value)
                {
                    var blob = CvInvoke.BoundingRectangle(contoursBlue[i]);
                    blob.Y -= 5;
                    CvInvoke.PutText(img, "Azul", blob.Location, Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.5, new MCvScalar(255, 255, 255));
                    CvInvoke.PutText(combinadaImg, "Azul", blob.Location, Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.5, new MCvScalar(255, 255, 255));
                }

            }
            if(btnIntercambio.Text=="ORIGINAL")
            {
                pictureFirst.Image = combinadaImg.ToBitmap();
            }else
            {
                pictureFirst.Image = img.ToBitmap();
            }
            
            



        }
    }
}
