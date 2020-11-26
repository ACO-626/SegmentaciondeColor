namespace SegmentaciondeColor
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureFirst = new System.Windows.Forms.PictureBox();
            this.pictureRed = new System.Windows.Forms.PictureBox();
            this.pictureGreen = new System.Windows.Forms.PictureBox();
            this.pictureBlue = new System.Windows.Forms.PictureBox();
            this.trackRed = new System.Windows.Forms.TrackBar();
            this.trackGreen = new System.Windows.Forms.TrackBar();
            this.trackBlue = new System.Windows.Forms.TrackBar();
            this.lbBlue = new System.Windows.Forms.Label();
            this.lbGreen = new System.Windows.Forms.Label();
            this.lbRed = new System.Windows.Forms.Label();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnSegment = new System.Windows.Forms.Button();
            this.btnIntercambio = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1238, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.importarToolStripMenuItem.Text = "Importar";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(117, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // pictureFirst
            // 
            this.pictureFirst.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pictureFirst.Location = new System.Drawing.Point(35, 151);
            this.pictureFirst.Name = "pictureFirst";
            this.pictureFirst.Size = new System.Drawing.Size(863, 489);
            this.pictureFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFirst.TabIndex = 1;
            this.pictureFirst.TabStop = false;
            // 
            // pictureRed
            // 
            this.pictureRed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pictureRed.Location = new System.Drawing.Point(965, 55);
            this.pictureRed.Name = "pictureRed";
            this.pictureRed.Size = new System.Drawing.Size(221, 136);
            this.pictureRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRed.TabIndex = 3;
            this.pictureRed.TabStop = false;
            // 
            // pictureGreen
            // 
            this.pictureGreen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pictureGreen.Location = new System.Drawing.Point(965, 321);
            this.pictureGreen.Name = "pictureGreen";
            this.pictureGreen.Size = new System.Drawing.Size(221, 136);
            this.pictureGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGreen.TabIndex = 4;
            this.pictureGreen.TabStop = false;
            // 
            // pictureBlue
            // 
            this.pictureBlue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pictureBlue.Location = new System.Drawing.Point(963, 577);
            this.pictureBlue.Name = "pictureBlue";
            this.pictureBlue.Size = new System.Drawing.Size(221, 136);
            this.pictureBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBlue.TabIndex = 5;
            this.pictureBlue.TabStop = false;
            // 
            // trackRed
            // 
            this.trackRed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackRed.Location = new System.Drawing.Point(965, 197);
            this.trackRed.Maximum = 255;
            this.trackRed.Name = "trackRed";
            this.trackRed.Size = new System.Drawing.Size(221, 45);
            this.trackRed.TabIndex = 6;
            this.trackRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackRed.Value = 127;
            this.trackRed.ValueChanged += new System.EventHandler(this.trackRed_ValueChanged);
            // 
            // trackGreen
            // 
            this.trackGreen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackGreen.Location = new System.Drawing.Point(965, 463);
            this.trackGreen.Maximum = 255;
            this.trackGreen.Name = "trackGreen";
            this.trackGreen.Size = new System.Drawing.Size(221, 45);
            this.trackGreen.TabIndex = 7;
            this.trackGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackGreen.Value = 127;
            this.trackGreen.ValueChanged += new System.EventHandler(this.trackYell_ValueChanged);
            // 
            // trackBlue
            // 
            this.trackBlue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBlue.Location = new System.Drawing.Point(965, 719);
            this.trackBlue.Maximum = 255;
            this.trackBlue.Name = "trackBlue";
            this.trackBlue.Size = new System.Drawing.Size(221, 45);
            this.trackBlue.TabIndex = 8;
            this.trackBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBlue.Value = 127;
            this.trackBlue.ValueChanged += new System.EventHandler(this.trackBlue_ValueChanged);
            // 
            // lbBlue
            // 
            this.lbBlue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbBlue.AutoSize = true;
            this.lbBlue.BackColor = System.Drawing.Color.Transparent;
            this.lbBlue.ForeColor = System.Drawing.SystemColors.Control;
            this.lbBlue.Location = new System.Drawing.Point(1149, 700);
            this.lbBlue.Name = "lbBlue";
            this.lbBlue.Size = new System.Drawing.Size(27, 13);
            this.lbBlue.TabIndex = 9;
            this.lbBlue.Text = "Azul";
            // 
            // lbGreen
            // 
            this.lbGreen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbGreen.AutoSize = true;
            this.lbGreen.BackColor = System.Drawing.Color.Transparent;
            this.lbGreen.ForeColor = System.Drawing.SystemColors.Control;
            this.lbGreen.Location = new System.Drawing.Point(1149, 444);
            this.lbGreen.Name = "lbGreen";
            this.lbGreen.Size = new System.Drawing.Size(35, 13);
            this.lbGreen.TabIndex = 10;
            this.lbGreen.Text = "Verde";
            // 
            // lbRed
            // 
            this.lbRed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbRed.AutoSize = true;
            this.lbRed.BackColor = System.Drawing.Color.Transparent;
            this.lbRed.ForeColor = System.Drawing.SystemColors.Control;
            this.lbRed.Location = new System.Drawing.Point(1155, 178);
            this.lbRed.Name = "lbRed";
            this.lbRed.Size = new System.Drawing.Size(29, 13);
            this.lbRed.TabIndex = 11;
            this.lbRed.Text = "Rojo";
            this.lbRed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImportar.Location = new System.Drawing.Point(35, 77);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(116, 50);
            this.btnImportar.TabIndex = 12;
            this.btnImportar.Text = "IMPORTAR";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnSegment
            // 
            this.btnSegment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSegment.Location = new System.Drawing.Point(782, 77);
            this.btnSegment.Name = "btnSegment";
            this.btnSegment.Size = new System.Drawing.Size(116, 50);
            this.btnSegment.TabIndex = 13;
            this.btnSegment.Text = "SEGMENTAR";
            this.btnSegment.UseVisualStyleBackColor = true;
            this.btnSegment.Click += new System.EventHandler(this.btnSegment_Click);
            // 
            // btnIntercambio
            // 
            this.btnIntercambio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIntercambio.Location = new System.Drawing.Point(421, 77);
            this.btnIntercambio.Name = "btnIntercambio";
            this.btnIntercambio.Size = new System.Drawing.Size(116, 50);
            this.btnIntercambio.TabIndex = 14;
            this.btnIntercambio.Text = "COMBINAR";
            this.btnIntercambio.UseVisualStyleBackColor = true;
            this.btnIntercambio.Click += new System.EventHandler(this.btnIntercambio_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1238, 805);
            this.Controls.Add(this.btnIntercambio);
            this.Controls.Add(this.btnSegment);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.lbRed);
            this.Controls.Add(this.lbGreen);
            this.Controls.Add(this.lbBlue);
            this.Controls.Add(this.trackBlue);
            this.Controls.Add(this.trackGreen);
            this.Controls.Add(this.trackRed);
            this.Controls.Add(this.pictureBlue);
            this.Controls.Add(this.pictureGreen);
            this.Controls.Add(this.pictureRed);
            this.Controls.Add(this.pictureFirst);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Segmentado por color";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureFirst;
        private System.Windows.Forms.PictureBox pictureRed;
        private System.Windows.Forms.PictureBox pictureGreen;
        private System.Windows.Forms.PictureBox pictureBlue;
        private System.Windows.Forms.TrackBar trackRed;
        private System.Windows.Forms.TrackBar trackGreen;
        private System.Windows.Forms.TrackBar trackBlue;
        private System.Windows.Forms.Label lbBlue;
        private System.Windows.Forms.Label lbGreen;
        private System.Windows.Forms.Label lbRed;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnSegment;
        private System.Windows.Forms.Button btnIntercambio;
    }
}

