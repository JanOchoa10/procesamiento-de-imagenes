namespace Procesamiento_de_imágenes
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Reconocimiento = new System.Windows.Forms.TabPage();
            this.Acerca_de = new System.Windows.Forms.TabPage();
            this.Filtros = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Imagenes PNG|*.png|Imagenes JPG|*.jpg|Imagenes BitMap|*.bmp";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Imagenes PNG|*.png";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Filtros);
            this.materialTabControl1.Controls.Add(this.Reconocimiento);
            this.materialTabControl1.Controls.Add(this.Acerca_de);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1131, 695);
            this.materialTabControl1.TabIndex = 1;
            // 
            // Reconocimiento
            // 
            this.Reconocimiento.BackColor = System.Drawing.Color.White;
            this.Reconocimiento.ImageKey = "reconocimiento-facial.png";
            this.Reconocimiento.Location = new System.Drawing.Point(4, 39);
            this.Reconocimiento.Name = "Reconocimiento";
            this.Reconocimiento.Padding = new System.Windows.Forms.Padding(3);
            this.Reconocimiento.Size = new System.Drawing.Size(1123, 652);
            this.Reconocimiento.TabIndex = 1;
            this.Reconocimiento.Text = "Reconocimiento";
            // 
            // Acerca_de
            // 
            this.Acerca_de.BackColor = System.Drawing.Color.White;
            this.Acerca_de.ImageKey = "informacion.png";
            this.Acerca_de.Location = new System.Drawing.Point(4, 39);
            this.Acerca_de.Name = "Acerca_de";
            this.Acerca_de.Padding = new System.Windows.Forms.Padding(3);
            this.Acerca_de.Size = new System.Drawing.Size(1123, 652);
            this.Acerca_de.TabIndex = 2;
            this.Acerca_de.Text = "Acerca de Chinchi";
            // 
            // Filtros
            // 
            this.Filtros.BackColor = System.Drawing.Color.White;
            this.Filtros.ImageKey = "filtrar.png";
            this.Filtros.Location = new System.Drawing.Point(4, 39);
            this.Filtros.Name = "Filtros";
            this.Filtros.Padding = new System.Windows.Forms.Padding(3);
            this.Filtros.Size = new System.Drawing.Size(1123, 652);
            this.Filtros.TabIndex = 3;
            this.Filtros.Text = "Filtros";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "sliders-solid.jpg");
            this.imageList1.Images.SetKeyName(1, "eye-solid.jpg");
            this.imageList1.Images.SetKeyName(2, "circle-info-solid.jpg");
            this.imageList1.Images.SetKeyName(3, "filtrar.png");
            this.imageList1.Images.SetKeyName(4, "reconocimiento-facial.png");
            this.imageList1.Images.SetKeyName(5, "informacion.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 762);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "    CHINCHI";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.materialTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Reconocimiento;
        private System.Windows.Forms.TabPage Acerca_de;
        private System.Windows.Forms.TabPage Filtros;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

