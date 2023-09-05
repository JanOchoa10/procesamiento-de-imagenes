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
            this.Filtros = new System.Windows.Forms.TabPage();
            this.Reconocimiento = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirImagenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.básicosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Acerca_de = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertirCambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.básicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertirColoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rojoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amarilloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.violetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aberraciónCromáticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeGrisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            this.materialTabControl1.SuspendLayout();
            this.Filtros.SuspendLayout();
            this.Reconocimiento.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.Acerca_de.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialCard3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.materialTabControl1.Location = new System.Drawing.Point(0, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1134, 695);
            this.materialTabControl1.TabIndex = 1;
            // 
            // Filtros
            // 
            this.Filtros.BackColor = System.Drawing.Color.White;
            this.Filtros.Controls.Add(this.materialCard3);
            this.Filtros.ImageKey = "filtrar.png";
            this.Filtros.Location = new System.Drawing.Point(4, 39);
            this.Filtros.Name = "Filtros";
            this.Filtros.Padding = new System.Windows.Forms.Padding(3);
            this.Filtros.Size = new System.Drawing.Size(1126, 652);
            this.Filtros.TabIndex = 3;
            this.Filtros.Text = "Filtros";
            // 
            // Reconocimiento
            // 
            this.Reconocimiento.BackColor = System.Drawing.Color.White;
            this.Reconocimiento.Controls.Add(this.materialCard1);
            this.Reconocimiento.ImageKey = "reconocimiento-facial.png";
            this.Reconocimiento.Location = new System.Drawing.Point(4, 39);
            this.Reconocimiento.Name = "Reconocimiento";
            this.Reconocimiento.Padding = new System.Windows.Forms.Padding(3);
            this.Reconocimiento.Size = new System.Drawing.Size(1126, 652);
            this.Reconocimiento.TabIndex = 1;
            this.Reconocimiento.Text = "Reconocimiento";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.menuStrip2);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 3);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1120, 646);
            this.materialCard1.TabIndex = 0;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(676, 206);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "materialButton1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem1,
            this.básicosToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(14, 14);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1092, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // archivoToolStripMenuItem1
            // 
            this.archivoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagenToolStripMenuItem1});
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem1.Text = "Archivo";
            // 
            // abrirImagenToolStripMenuItem1
            // 
            this.abrirImagenToolStripMenuItem1.Name = "abrirImagenToolStripMenuItem1";
            this.abrirImagenToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.abrirImagenToolStripMenuItem1.Text = "Abrir Imagen";
            // 
            // básicosToolStripMenuItem1
            // 
            this.básicosToolStripMenuItem1.Name = "básicosToolStripMenuItem1";
            this.básicosToolStripMenuItem1.Size = new System.Drawing.Size(58, 20);
            this.básicosToolStripMenuItem1.Text = "Básicos";
            // 
            // Acerca_de
            // 
            this.Acerca_de.BackColor = System.Drawing.Color.White;
            this.Acerca_de.Controls.Add(this.materialCard2);
            this.Acerca_de.ImageKey = "informacion.png";
            this.Acerca_de.Location = new System.Drawing.Point(4, 39);
            this.Acerca_de.Name = "Acerca_de";
            this.Acerca_de.Padding = new System.Windows.Forms.Padding(3);
            this.Acerca_de.Size = new System.Drawing.Size(1126, 652);
            this.Acerca_de.TabIndex = 2;
            this.Acerca_de.Text = "Acerca de Chinchi";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(3, 3);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1120, 646);
            this.materialCard2.TabIndex = 0;
            this.materialCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard2_Paint);
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
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.panel2);
            this.materialCard3.Controls.Add(this.panel1);
            this.materialCard3.Controls.Add(this.menuStrip1);
            this.materialCard3.Depth = 0;
            this.materialCard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(3, 3);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(1120, 646);
            this.materialCard3.TabIndex = 0;
            this.materialCard3.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard3_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.básicosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(14, 14);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1092, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagenToolStripMenuItem,
            this.revertirCambiosToolStripMenuItem,
            this.guardarImagenToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirImagenToolStripMenuItem
            // 
            this.abrirImagenToolStripMenuItem.Name = "abrirImagenToolStripMenuItem";
            this.abrirImagenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirImagenToolStripMenuItem.Text = "Abrir imagen";
            this.abrirImagenToolStripMenuItem.Click += new System.EventHandler(this.abrirImagenToolStripMenuItem_Click_1);
            // 
            // revertirCambiosToolStripMenuItem
            // 
            this.revertirCambiosToolStripMenuItem.Name = "revertirCambiosToolStripMenuItem";
            this.revertirCambiosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.revertirCambiosToolStripMenuItem.Text = "Revertir cambios";
            this.revertirCambiosToolStripMenuItem.Click += new System.EventHandler(this.revertirCambiosToolStripMenuItem_Click);
            // 
            // guardarImagenToolStripMenuItem
            // 
            this.guardarImagenToolStripMenuItem.Name = "guardarImagenToolStripMenuItem";
            this.guardarImagenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarImagenToolStripMenuItem.Text = "Guardar imagen";
            // 
            // básicosToolStripMenuItem
            // 
            this.básicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertirColoresToolStripMenuItem,
            this.colorearToolStripMenuItem,
            this.aberraciónCromáticaToolStripMenuItem,
            this.escalaDeGrisesToolStripMenuItem});
            this.básicosToolStripMenuItem.Name = "básicosToolStripMenuItem";
            this.básicosToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.básicosToolStripMenuItem.Text = "Básicos";
            // 
            // invertirColoresToolStripMenuItem
            // 
            this.invertirColoresToolStripMenuItem.Name = "invertirColoresToolStripMenuItem";
            this.invertirColoresToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.invertirColoresToolStripMenuItem.Text = "Invertir colores";
            this.invertirColoresToolStripMenuItem.Click += new System.EventHandler(this.invertirColoresToolStripMenuItem_Click);
            // 
            // colorearToolStripMenuItem
            // 
            this.colorearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rojoToolStripMenuItem,
            this.verdeToolStripMenuItem,
            this.azulToolStripMenuItem,
            this.amarilloToolStripMenuItem,
            this.violetaToolStripMenuItem,
            this.cyanToolStripMenuItem});
            this.colorearToolStripMenuItem.Name = "colorearToolStripMenuItem";
            this.colorearToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.colorearToolStripMenuItem.Text = "Colorear";
            // 
            // rojoToolStripMenuItem
            // 
            this.rojoToolStripMenuItem.Name = "rojoToolStripMenuItem";
            this.rojoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rojoToolStripMenuItem.Text = "Rojo";
            // 
            // verdeToolStripMenuItem
            // 
            this.verdeToolStripMenuItem.Name = "verdeToolStripMenuItem";
            this.verdeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verdeToolStripMenuItem.Text = "Verde";
            // 
            // azulToolStripMenuItem
            // 
            this.azulToolStripMenuItem.Name = "azulToolStripMenuItem";
            this.azulToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.azulToolStripMenuItem.Text = "Azul";
            // 
            // amarilloToolStripMenuItem
            // 
            this.amarilloToolStripMenuItem.Name = "amarilloToolStripMenuItem";
            this.amarilloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.amarilloToolStripMenuItem.Text = "Amarillo";
            // 
            // violetaToolStripMenuItem
            // 
            this.violetaToolStripMenuItem.Name = "violetaToolStripMenuItem";
            this.violetaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.violetaToolStripMenuItem.Text = "Violeta";
            // 
            // cyanToolStripMenuItem
            // 
            this.cyanToolStripMenuItem.Name = "cyanToolStripMenuItem";
            this.cyanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cyanToolStripMenuItem.Text = "Cyan";
            // 
            // aberraciónCromáticaToolStripMenuItem
            // 
            this.aberraciónCromáticaToolStripMenuItem.Name = "aberraciónCromáticaToolStripMenuItem";
            this.aberraciónCromáticaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.aberraciónCromáticaToolStripMenuItem.Text = "Aberración cromática";
            // 
            // escalaDeGrisesToolStripMenuItem
            // 
            this.escalaDeGrisesToolStripMenuItem.Name = "escalaDeGrisesToolStripMenuItem";
            this.escalaDeGrisesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.escalaDeGrisesToolStripMenuItem.Text = "Escala de grises";
            this.escalaDeGrisesToolStripMenuItem.Click += new System.EventHandler(this.escalaDeGrisesToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(14, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 563);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 128);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox4_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialSlider1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(14, 601);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 54);
            this.panel2.TabIndex = 4;
            // 
            // materialSlider1
            // 
            this.materialSlider1.Depth = 0;
            this.materialSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider1.Location = new System.Drawing.Point(44, 8);
            this.materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider1.Name = "materialSlider1";
            this.materialSlider1.RangeMax = 19;
            this.materialSlider1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialSlider1.ShowValue = false;
            this.materialSlider1.Size = new System.Drawing.Size(561, 40);
            this.materialSlider1.TabIndex = 1;
            this.materialSlider1.Text = "Zoom 0%";
            this.materialSlider1.Value = 9;
            this.materialSlider1.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.materialSlider1_onValueChanged);
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
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 3);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "    CHINCHI";
            this.materialTabControl1.ResumeLayout(false);
            this.Filtros.ResumeLayout(false);
            this.Reconocimiento.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.Acerca_de.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abrirImagenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem básicosToolStripMenuItem1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revertirCambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem básicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertirColoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rojoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amarilloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem violetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aberraciónCromáticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaDeGrisesToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSlider materialSlider1;
    }
}

