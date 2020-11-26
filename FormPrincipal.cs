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
                    pictureFirst.Image = combinadaImg.Bitmap;
                }
            }
            else
            {
                MessageBox.Show("Debe cargar una imagen","Sin imagen cargada",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
                

                
           
        }
        #endregion


    }
}
