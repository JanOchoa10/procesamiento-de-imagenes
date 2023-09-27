﻿namespace Procesamiento_de_imágenes
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
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.imagen = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertirCambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosBásicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.video = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Reconocimiento = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.Acerca_de = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialSwitch2 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.Filtros.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.imagen.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.Reconocimiento.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.Acerca_de.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.materialTabControl1.Size = new System.Drawing.Size(1277, 653);
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
            this.Filtros.Size = new System.Drawing.Size(1269, 610);
            this.Filtros.TabIndex = 3;
            this.Filtros.Text = "Filtros";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.tabControl1);
            this.materialCard3.Depth = 0;
            this.materialCard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(3, 3);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(1263, 604);
            this.materialCard3.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.imagen);
            this.tabControl1.Controls.Add(this.video);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(14, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1235, 576);
            this.tabControl1.TabIndex = 0;
            // 
            // imagen
            // 
            this.imagen.Controls.Add(this.panel1);
            this.imagen.Controls.Add(this.menuStrip1);
            this.imagen.ImageIndex = 3;
            this.imagen.Location = new System.Drawing.Point(4, 39);
            this.imagen.Name = "imagen";
            this.imagen.Padding = new System.Windows.Forms.Padding(3);
            this.imagen.Size = new System.Drawing.Size(1227, 533);
            this.imagen.TabIndex = 0;
            this.imagen.Text = "Imagen";
            this.imagen.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 503);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanel1.Controls.Add(this.materialLabel9, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel7, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1221, 503);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.materialLabel9, 3);
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel9.Location = new System.Drawing.Point(612, 351);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(606, 50);
            this.materialLabel9.TabIndex = 4;
            this.materialLabel9.Text = "Histogramas IE";
            this.materialLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.materialLabel8, 3);
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel8.Location = new System.Drawing.Point(3, 351);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(603, 50);
            this.materialLabel8.TabIndex = 3;
            this.materialLabel8.Text = "Histogramas IC";
            this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox4, 3);
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(3, 53);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(603, 295);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox5, 3);
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Location = new System.Drawing.Point(612, 53);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(606, 295);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.materialLabel6, 3);
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel6.Location = new System.Drawing.Point(3, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(603, 50);
            this.materialLabel6.TabIndex = 1;
            this.materialLabel6.Text = "Imagen cargada";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.materialLabel7, 3);
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel7.Location = new System.Drawing.Point(612, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(606, 50);
            this.materialLabel7.TabIndex = 2;
            this.materialLabel7.Text = "Imagen editada";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.filtrosBásicosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1221, 24);
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
            this.abrirImagenToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.abrirImagenToolStripMenuItem.Text = "Abrir imagen";
            this.abrirImagenToolStripMenuItem.Click += new System.EventHandler(this.abrirImagenToolStripMenuItem_Click_1);
            // 
            // revertirCambiosToolStripMenuItem
            // 
            this.revertirCambiosToolStripMenuItem.Name = "revertirCambiosToolStripMenuItem";
            this.revertirCambiosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.revertirCambiosToolStripMenuItem.Text = "Revertir cambios";
            this.revertirCambiosToolStripMenuItem.Click += new System.EventHandler(this.revertirCambiosToolStripMenuItem_Click);
            // 
            // guardarImagenToolStripMenuItem
            // 
            this.guardarImagenToolStripMenuItem.Name = "guardarImagenToolStripMenuItem";
            this.guardarImagenToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.guardarImagenToolStripMenuItem.Text = "Guardar imagen";
            this.guardarImagenToolStripMenuItem.Click += new System.EventHandler(this.guardarImagenToolStripMenuItem_Click);
            // 
            // filtrosBásicosToolStripMenuItem
            // 
            this.filtrosBásicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertirColoresToolStripMenuItem,
            this.colorearToolStripMenuItem,
            this.aberraciónCromáticaToolStripMenuItem,
            this.escalaDeGrisesToolStripMenuItem});
            this.filtrosBásicosToolStripMenuItem.Name = "filtrosBásicosToolStripMenuItem";
            this.filtrosBásicosToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.filtrosBásicosToolStripMenuItem.Text = "Filtros básicos";
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
            this.rojoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.rojoToolStripMenuItem.Text = "Rojo";
            this.rojoToolStripMenuItem.Click += new System.EventHandler(this.rojoToolStripMenuItem_Click);
            // 
            // verdeToolStripMenuItem
            // 
            this.verdeToolStripMenuItem.Name = "verdeToolStripMenuItem";
            this.verdeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.verdeToolStripMenuItem.Text = "Verde";
            this.verdeToolStripMenuItem.Click += new System.EventHandler(this.verdeToolStripMenuItem_Click);
            // 
            // azulToolStripMenuItem
            // 
            this.azulToolStripMenuItem.Name = "azulToolStripMenuItem";
            this.azulToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.azulToolStripMenuItem.Text = "Azul";
            this.azulToolStripMenuItem.Click += new System.EventHandler(this.azulToolStripMenuItem_Click);
            // 
            // amarilloToolStripMenuItem
            // 
            this.amarilloToolStripMenuItem.Name = "amarilloToolStripMenuItem";
            this.amarilloToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.amarilloToolStripMenuItem.Text = "Amarillo";
            this.amarilloToolStripMenuItem.Click += new System.EventHandler(this.amarilloToolStripMenuItem_Click);
            // 
            // violetaToolStripMenuItem
            // 
            this.violetaToolStripMenuItem.Name = "violetaToolStripMenuItem";
            this.violetaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.violetaToolStripMenuItem.Text = "Violeta";
            this.violetaToolStripMenuItem.Click += new System.EventHandler(this.violetaToolStripMenuItem_Click);
            // 
            // cyanToolStripMenuItem
            // 
            this.cyanToolStripMenuItem.Name = "cyanToolStripMenuItem";
            this.cyanToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.cyanToolStripMenuItem.Text = "Cyan";
            this.cyanToolStripMenuItem.Click += new System.EventHandler(this.cyanToolStripMenuItem_Click);
            // 
            // aberraciónCromáticaToolStripMenuItem
            // 
            this.aberraciónCromáticaToolStripMenuItem.Name = "aberraciónCromáticaToolStripMenuItem";
            this.aberraciónCromáticaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.aberraciónCromáticaToolStripMenuItem.Text = "Aberración cromática";
            this.aberraciónCromáticaToolStripMenuItem.Click += new System.EventHandler(this.aberraciónCromáticaToolStripMenuItem_Click);
            // 
            // escalaDeGrisesToolStripMenuItem
            // 
            this.escalaDeGrisesToolStripMenuItem.Name = "escalaDeGrisesToolStripMenuItem";
            this.escalaDeGrisesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.escalaDeGrisesToolStripMenuItem.Text = "Escala de grises";
            this.escalaDeGrisesToolStripMenuItem.Click += new System.EventHandler(this.escalaDeGrisesToolStripMenuItem_Click);
            // 
            // video
            // 
            this.video.ImageIndex = 4;
            this.video.Location = new System.Drawing.Point(4, 39);
            this.video.Name = "video";
            this.video.Padding = new System.Windows.Forms.Padding(3);
            this.video.Size = new System.Drawing.Size(1084, 575);
            this.video.TabIndex = 1;
            this.video.Text = "Vídeo";
            this.video.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "filtrar.png");
            this.imageList1.Images.SetKeyName(1, "reconocimiento-facial.png");
            this.imageList1.Images.SetKeyName(2, "informacion.png");
            this.imageList1.Images.SetKeyName(3, "edicion-de-imagen.png");
            this.imageList1.Images.SetKeyName(4, "edicion-de-video.png");
            // 
            // Reconocimiento
            // 
            this.Reconocimiento.BackColor = System.Drawing.Color.White;
            this.Reconocimiento.Controls.Add(this.materialCard1);
            this.Reconocimiento.ImageKey = "reconocimiento-facial.png";
            this.Reconocimiento.Location = new System.Drawing.Point(4, 39);
            this.Reconocimiento.Name = "Reconocimiento";
            this.Reconocimiento.Padding = new System.Windows.Forms.Padding(3);
            this.Reconocimiento.Size = new System.Drawing.Size(1269, 610);
            this.Reconocimiento.TabIndex = 1;
            this.Reconocimiento.Text = "Reconocimiento";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.tableLayoutPanel3);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 3);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1263, 604);
            this.materialCard1.TabIndex = 0;
            // 
            // Acerca_de
            // 
            this.Acerca_de.BackColor = System.Drawing.Color.White;
            this.Acerca_de.Controls.Add(this.materialCard2);
            this.Acerca_de.ImageKey = "informacion.png";
            this.Acerca_de.Location = new System.Drawing.Point(4, 39);
            this.Acerca_de.Name = "Acerca_de";
            this.Acerca_de.Padding = new System.Windows.Forms.Padding(3);
            this.Acerca_de.Size = new System.Drawing.Size(1269, 610);
            this.Acerca_de.TabIndex = 2;
            this.Acerca_de.Text = "Acerca de Chinchi";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.tableLayoutPanel2);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(3, 3);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1263, 604);
            this.materialCard2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.materialLabel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel3, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.materialFloatingActionButton1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialFloatingActionButton2, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1235, 576);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(126, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(982, 57);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Manual de Usuario";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(126, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(982, 454);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(126, 517);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(982, 28);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Chinchi v1.0.2";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel3.Location = new System.Drawing.Point(126, 545);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(982, 31);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "© 2023 By Jan Ochoa. Todos los derechos reservados.";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialFloatingActionButton1
            // 
            this.materialFloatingActionButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialFloatingActionButton1.Depth = 0;
            this.materialFloatingActionButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialFloatingActionButton1.Icon")));
            this.materialFloatingActionButton1.Location = new System.Drawing.Point(64, 259);
            this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton1.TabIndex = 5;
            this.materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.UseVisualStyleBackColor = true;
            // 
            // materialFloatingActionButton2
            // 
            this.materialFloatingActionButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialFloatingActionButton2.Depth = 0;
            this.materialFloatingActionButton2.Icon = ((System.Drawing.Image)(resources.GetObject("materialFloatingActionButton2.Icon")));
            this.materialFloatingActionButton2.Location = new System.Drawing.Point(1114, 259);
            this.materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton2.TabIndex = 6;
            this.materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            this.materialFloatingActionButton2.UseVisualStyleBackColor = true;
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.materialLabel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.materialSwitch1, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.materialSwitch2, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.materialComboBox1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.materialLabel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1235, 576);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel4.Location = new System.Drawing.Point(3, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(858, 57);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Reconocimiento facial";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::Procesamiento_de_imágenes.Properties.Resources.reconocimiento_facial_;
            this.pictureBox3.Location = new System.Drawing.Point(3, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.tableLayoutPanel3.SetRowSpan(this.pictureBox3, 4);
            this.pictureBox3.Size = new System.Drawing.Size(858, 513);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialSwitch1.Location = new System.Drawing.Point(864, 114);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(371, 28);
            this.materialSwitch1.TabIndex = 0;
            this.materialSwitch1.Text = "Encender cámara";
            this.materialSwitch1.UseVisualStyleBackColor = true;
            // 
            // materialSwitch2
            // 
            this.materialSwitch2.Depth = 0;
            this.materialSwitch2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialSwitch2.Location = new System.Drawing.Point(864, 142);
            this.materialSwitch2.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch2.Name = "materialSwitch2";
            this.materialSwitch2.Ripple = true;
            this.materialSwitch2.Size = new System.Drawing.Size(371, 28);
            this.materialSwitch2.TabIndex = 0;
            this.materialSwitch2.Text = "Activar reconocimiento facial";
            this.materialSwitch2.UseVisualStyleBackColor = true;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(867, 60);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(365, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 1;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(867, 38);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(365, 19);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "Seleccionar cámara";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 3);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "    CHINCHI";
            this.materialTabControl1.ResumeLayout(false);
            this.Filtros.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.imagen.ResumeLayout(false);
            this.imagen.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Reconocimiento.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.Acerca_de.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage imagen;
        private System.Windows.Forms.TabPage video;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revertirCambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrosBásicosToolStripMenuItem;
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
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}

