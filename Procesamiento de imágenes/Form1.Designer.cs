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
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.imagen = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFrames = new MaterialSkin.Controls.MaterialLabel();
            this.menuVideo = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirVídeoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revetirCambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosBásicosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.invertirColoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aberraciónCromáticaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaDeGrisesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Reconocimiento = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnEncenderCamara = new MaterialSkin.Controls.MaterialSwitch();
            this.materialSwitch2 = new MaterialSkin.Controls.MaterialSwitch();
            this.cbCamara = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.cbResolucion = new MaterialSkin.Controls.MaterialComboBox();
            this.Acerca_de = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcImagenCargada = new System.Windows.Forms.PictureBox();
            this.pcImagenEditada = new System.Windows.Forms.PictureBox();
            this.pcHistogramaRIC = new System.Windows.Forms.PictureBox();
            this.pcHistogramaGIC = new System.Windows.Forms.PictureBox();
            this.pcHistogramaBIC = new System.Windows.Forms.PictureBox();
            this.pcHistogramaRIE = new System.Windows.Forms.PictureBox();
            this.pcHistogramaGIE = new System.Windows.Forms.PictureBox();
            this.pcHistogramaBIE = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbFrame = new System.Windows.Forms.PictureBox();
            this.pbTiempoReal = new System.Windows.Forms.PictureBox();
            this.pbManualDeUsuario = new System.Windows.Forms.PictureBox();
            this.btnFlechaIzquierda = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.btnFlechaDerecha = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialTabControl1.SuspendLayout();
            this.Filtros.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.imagen.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.video.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.menuVideo.SuspendLayout();
            this.Reconocimiento.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.Acerca_de.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagenCargada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagenEditada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHistogramaRIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHistogramaGIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHistogramaBIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHistogramaRIE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHistogramaGIE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHistogramaBIE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTiempoReal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManualDeUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivos JPEG (*.jpg; *.jpeg)|*.jpg;*.jpeg|Archivos PNG (*.png)|*.png|Archivos GI" +
    "F (*.gif)|*.gif|Archivos BMP (*.bmp)|*.bmp";
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
            this.tableLayoutPanel1.Controls.Add(this.pcImagenCargada, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pcImagenEditada, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel7, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pcHistogramaRIC, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pcHistogramaGIC, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pcHistogramaBIC, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.pcHistogramaRIE, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.pcHistogramaGIE, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.pcHistogramaBIE, 5, 3);
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
            this.video.Controls.Add(this.tableLayoutPanel4);
            this.video.Controls.Add(this.menuVideo);
            this.video.ImageIndex = 4;
            this.video.Location = new System.Drawing.Point(4, 39);
            this.video.Name = "video";
            this.video.Padding = new System.Windows.Forms.Padding(3);
            this.video.Size = new System.Drawing.Size(1227, 533);
            this.video.TabIndex = 1;
            this.video.Text = "Vídeo";
            this.video.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Controls.Add(this.axWindowsMediaPlayer1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.pbFrame, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblFrames, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1221, 503);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // lblFrames
            // 
            this.lblFrames.AutoSize = true;
            this.lblFrames.Depth = 0;
            this.lblFrames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFrames.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblFrames.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblFrames.Location = new System.Drawing.Point(857, 251);
            this.lblFrames.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFrames.Name = "lblFrames";
            this.lblFrames.Size = new System.Drawing.Size(361, 252);
            this.lblFrames.TabIndex = 2;
            this.lblFrames.Text = "¡Comencemos a editar!";
            this.lblFrames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuVideo
            // 
            this.menuVideo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem1,
            this.filtrosBásicosToolStripMenuItem1});
            this.menuVideo.Location = new System.Drawing.Point(3, 3);
            this.menuVideo.Name = "menuVideo";
            this.menuVideo.Size = new System.Drawing.Size(1221, 24);
            this.menuVideo.TabIndex = 0;
            this.menuVideo.Text = "menuStrip2";
            // 
            // archivoToolStripMenuItem1
            // 
            this.archivoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirVídeoToolStripMenuItem,
            this.revetirCambiosToolStripMenuItem});
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem1.Text = "Archivo";
            // 
            // abrirVídeoToolStripMenuItem
            // 
            this.abrirVídeoToolStripMenuItem.Name = "abrirVídeoToolStripMenuItem";
            this.abrirVídeoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.abrirVídeoToolStripMenuItem.Text = "Abrir vídeo";
            this.abrirVídeoToolStripMenuItem.Click += new System.EventHandler(this.abrirVídeoToolStripMenuItem_Click);
            // 
            // revetirCambiosToolStripMenuItem
            // 
            this.revetirCambiosToolStripMenuItem.Name = "revetirCambiosToolStripMenuItem";
            this.revetirCambiosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.revetirCambiosToolStripMenuItem.Text = "Revertir cambios";
            this.revetirCambiosToolStripMenuItem.Click += new System.EventHandler(this.revetirCambiosToolStripMenuItem_Click);
            // 
            // filtrosBásicosToolStripMenuItem1
            // 
            this.filtrosBásicosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertirColoresToolStripMenuItem1,
            this.colorearToolStripMenuItem1,
            this.aberraciónCromáticaToolStripMenuItem1,
            this.escalaDeGrisesToolStripMenuItem1});
            this.filtrosBásicosToolStripMenuItem1.Name = "filtrosBásicosToolStripMenuItem1";
            this.filtrosBásicosToolStripMenuItem1.Size = new System.Drawing.Size(93, 20);
            this.filtrosBásicosToolStripMenuItem1.Text = "Filtros básicos";
            // 
            // invertirColoresToolStripMenuItem1
            // 
            this.invertirColoresToolStripMenuItem1.Name = "invertirColoresToolStripMenuItem1";
            this.invertirColoresToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.invertirColoresToolStripMenuItem1.Text = "Invertir colores";
            this.invertirColoresToolStripMenuItem1.Click += new System.EventHandler(this.invertirColoresToolStripMenuItem1_Click);
            // 
            // colorearToolStripMenuItem1
            // 
            this.colorearToolStripMenuItem1.Name = "colorearToolStripMenuItem1";
            this.colorearToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.colorearToolStripMenuItem1.Text = "Colorear";
            // 
            // aberraciónCromáticaToolStripMenuItem1
            // 
            this.aberraciónCromáticaToolStripMenuItem1.Name = "aberraciónCromáticaToolStripMenuItem1";
            this.aberraciónCromáticaToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.aberraciónCromáticaToolStripMenuItem1.Text = "Aberración cromática";
            // 
            // escalaDeGrisesToolStripMenuItem1
            // 
            this.escalaDeGrisesToolStripMenuItem1.Name = "escalaDeGrisesToolStripMenuItem1";
            this.escalaDeGrisesToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.escalaDeGrisesToolStripMenuItem1.Text = "Escala de grises";
            this.escalaDeGrisesToolStripMenuItem1.Click += new System.EventHandler(this.escalaDeGrisesToolStripMenuItem1_Click);
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.materialLabel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pbTiempoReal, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnEncenderCamara, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.materialSwitch2, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.cbCamara, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.materialLabel5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.materialLabel10, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.cbResolucion, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
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
            // btnEncenderCamara
            // 
            this.btnEncenderCamara.Depth = 0;
            this.btnEncenderCamara.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEncenderCamara.Location = new System.Drawing.Point(864, 199);
            this.btnEncenderCamara.Margin = new System.Windows.Forms.Padding(0);
            this.btnEncenderCamara.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnEncenderCamara.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEncenderCamara.Name = "btnEncenderCamara";
            this.btnEncenderCamara.Ripple = true;
            this.btnEncenderCamara.Size = new System.Drawing.Size(371, 28);
            this.btnEncenderCamara.TabIndex = 0;
            this.btnEncenderCamara.Text = "Encender cámara";
            this.btnEncenderCamara.UseVisualStyleBackColor = true;
            this.btnEncenderCamara.CheckedChanged += new System.EventHandler(this.btnEncenderCamara_CheckedChanged);
            // 
            // materialSwitch2
            // 
            this.materialSwitch2.Depth = 0;
            this.materialSwitch2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialSwitch2.Location = new System.Drawing.Point(864, 227);
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
            // cbCamara
            // 
            this.cbCamara.AutoResize = false;
            this.cbCamara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCamara.Depth = 0;
            this.cbCamara.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCamara.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbCamara.DropDownHeight = 174;
            this.cbCamara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamara.DropDownWidth = 121;
            this.cbCamara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbCamara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbCamara.FormattingEnabled = true;
            this.cbCamara.IntegralHeight = false;
            this.cbCamara.ItemHeight = 43;
            this.cbCamara.Location = new System.Drawing.Point(867, 60);
            this.cbCamara.MaxDropDownItems = 4;
            this.cbCamara.MouseState = MaterialSkin.MouseState.OUT;
            this.cbCamara.Name = "cbCamara";
            this.cbCamara.Size = new System.Drawing.Size(365, 49);
            this.cbCamara.StartIndex = 0;
            this.cbCamara.TabIndex = 1;
            this.cbCamara.SelectedIndexChanged += new System.EventHandler(this.cbCamara_SelectedIndexChanged);
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
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(867, 123);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(365, 19);
            this.materialLabel10.TabIndex = 3;
            this.materialLabel10.Text = "Seleccionar resolución";
            // 
            // cbResolucion
            // 
            this.cbResolucion.AutoResize = false;
            this.cbResolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbResolucion.Depth = 0;
            this.cbResolucion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbResolucion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbResolucion.DropDownHeight = 174;
            this.cbResolucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResolucion.DropDownWidth = 121;
            this.cbResolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbResolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbResolucion.FormattingEnabled = true;
            this.cbResolucion.IntegralHeight = false;
            this.cbResolucion.ItemHeight = 43;
            this.cbResolucion.Location = new System.Drawing.Point(867, 145);
            this.cbResolucion.MaxDropDownItems = 4;
            this.cbResolucion.MouseState = MaterialSkin.MouseState.OUT;
            this.cbResolucion.Name = "cbResolucion";
            this.cbResolucion.Size = new System.Drawing.Size(365, 49);
            this.cbResolucion.StartIndex = 0;
            this.cbResolucion.TabIndex = 4;
            this.cbResolucion.SelectedIndexChanged += new System.EventHandler(this.cbResolucion_SelectedIndexChanged);
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
            this.tableLayoutPanel2.Controls.Add(this.pbManualDeUsuario, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel3, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnFlechaIzquierda, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnFlechaDerecha, 2, 1);
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
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Filter = "Archivos de video|*.mp4;*.avi;*.mkv;*.wmv;*.mov";
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
            // pcImagenCargada
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pcImagenCargada, 3);
            this.pcImagenCargada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcImagenCargada.Location = new System.Drawing.Point(3, 53);
            this.pcImagenCargada.Name = "pcImagenCargada";
            this.pcImagenCargada.Size = new System.Drawing.Size(603, 295);
            this.pcImagenCargada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcImagenCargada.TabIndex = 0;
            this.pcImagenCargada.TabStop = false;
            // 
            // pcImagenEditada
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pcImagenEditada, 3);
            this.pcImagenEditada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcImagenEditada.Location = new System.Drawing.Point(612, 53);
            this.pcImagenEditada.Name = "pcImagenEditada";
            this.pcImagenEditada.Size = new System.Drawing.Size(606, 295);
            this.pcImagenEditada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcImagenEditada.TabIndex = 0;
            this.pcImagenEditada.TabStop = false;
            // 
            // pcHistogramaRIC
            // 
            this.pcHistogramaRIC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcHistogramaRIC.Location = new System.Drawing.Point(3, 404);
            this.pcHistogramaRIC.Name = "pcHistogramaRIC";
            this.pcHistogramaRIC.Size = new System.Drawing.Size(195, 96);
            this.pcHistogramaRIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcHistogramaRIC.TabIndex = 5;
            this.pcHistogramaRIC.TabStop = false;
            // 
            // pcHistogramaGIC
            // 
            this.pcHistogramaGIC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcHistogramaGIC.Location = new System.Drawing.Point(204, 404);
            this.pcHistogramaGIC.Name = "pcHistogramaGIC";
            this.pcHistogramaGIC.Size = new System.Drawing.Size(201, 96);
            this.pcHistogramaGIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcHistogramaGIC.TabIndex = 6;
            this.pcHistogramaGIC.TabStop = false;
            // 
            // pcHistogramaBIC
            // 
            this.pcHistogramaBIC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcHistogramaBIC.Location = new System.Drawing.Point(411, 404);
            this.pcHistogramaBIC.Name = "pcHistogramaBIC";
            this.pcHistogramaBIC.Size = new System.Drawing.Size(195, 96);
            this.pcHistogramaBIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcHistogramaBIC.TabIndex = 7;
            this.pcHistogramaBIC.TabStop = false;
            // 
            // pcHistogramaRIE
            // 
            this.pcHistogramaRIE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcHistogramaRIE.Location = new System.Drawing.Point(612, 404);
            this.pcHistogramaRIE.Name = "pcHistogramaRIE";
            this.pcHistogramaRIE.Size = new System.Drawing.Size(195, 96);
            this.pcHistogramaRIE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcHistogramaRIE.TabIndex = 8;
            this.pcHistogramaRIE.TabStop = false;
            // 
            // pcHistogramaGIE
            // 
            this.pcHistogramaGIE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcHistogramaGIE.Location = new System.Drawing.Point(813, 404);
            this.pcHistogramaGIE.Name = "pcHistogramaGIE";
            this.pcHistogramaGIE.Size = new System.Drawing.Size(201, 96);
            this.pcHistogramaGIE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcHistogramaGIE.TabIndex = 9;
            this.pcHistogramaGIE.TabStop = false;
            // 
            // pcHistogramaBIE
            // 
            this.pcHistogramaBIE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcHistogramaBIE.Location = new System.Drawing.Point(1020, 404);
            this.pcHistogramaBIE.Name = "pcHistogramaBIE";
            this.pcHistogramaBIE.Size = new System.Drawing.Size(198, 96);
            this.pcHistogramaBIE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcHistogramaBIE.TabIndex = 10;
            this.pcHistogramaBIE.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.tableLayoutPanel4.SetRowSpan(this.axWindowsMediaPlayer1, 2);
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(848, 497);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // pbFrame
            // 
            this.pbFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFrame.Location = new System.Drawing.Point(857, 3);
            this.pbFrame.Name = "pbFrame";
            this.pbFrame.Size = new System.Drawing.Size(361, 245);
            this.pbFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFrame.TabIndex = 1;
            this.pbFrame.TabStop = false;
            // 
            // pbTiempoReal
            // 
            this.pbTiempoReal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTiempoReal.Image = global::Procesamiento_de_imágenes.Properties.Resources.reconocimiento_facial_;
            this.pbTiempoReal.Location = new System.Drawing.Point(3, 60);
            this.pbTiempoReal.Name = "pbTiempoReal";
            this.tableLayoutPanel3.SetRowSpan(this.pbTiempoReal, 6);
            this.pbTiempoReal.Size = new System.Drawing.Size(858, 513);
            this.pbTiempoReal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTiempoReal.TabIndex = 0;
            this.pbTiempoReal.TabStop = false;
            // 
            // pbManualDeUsuario
            // 
            this.pbManualDeUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbManualDeUsuario.Image = global::Procesamiento_de_imágenes.Properties.Resources.Diapositiva1;
            this.pbManualDeUsuario.Location = new System.Drawing.Point(126, 60);
            this.pbManualDeUsuario.Name = "pbManualDeUsuario";
            this.pbManualDeUsuario.Size = new System.Drawing.Size(982, 454);
            this.pbManualDeUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbManualDeUsuario.TabIndex = 1;
            this.pbManualDeUsuario.TabStop = false;
            // 
            // btnFlechaIzquierda
            // 
            this.btnFlechaIzquierda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFlechaIzquierda.Depth = 0;
            this.btnFlechaIzquierda.Icon = ((System.Drawing.Image)(resources.GetObject("btnFlechaIzquierda.Icon")));
            this.btnFlechaIzquierda.Location = new System.Drawing.Point(64, 259);
            this.btnFlechaIzquierda.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFlechaIzquierda.Name = "btnFlechaIzquierda";
            this.btnFlechaIzquierda.Size = new System.Drawing.Size(56, 56);
            this.btnFlechaIzquierda.TabIndex = 5;
            this.btnFlechaIzquierda.Text = "materialFloatingActionButton1";
            this.btnFlechaIzquierda.UseVisualStyleBackColor = true;
            this.btnFlechaIzquierda.Click += new System.EventHandler(this.btnFlechaIzquierda_Click);
            // 
            // btnFlechaDerecha
            // 
            this.btnFlechaDerecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFlechaDerecha.Depth = 0;
            this.btnFlechaDerecha.Icon = ((System.Drawing.Image)(resources.GetObject("btnFlechaDerecha.Icon")));
            this.btnFlechaDerecha.Location = new System.Drawing.Point(1114, 259);
            this.btnFlechaDerecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFlechaDerecha.Name = "btnFlechaDerecha";
            this.btnFlechaDerecha.Size = new System.Drawing.Size(56, 56);
            this.btnFlechaDerecha.TabIndex = 6;
            this.btnFlechaDerecha.Text = "materialFloatingActionButton2";
            this.btnFlechaDerecha.UseVisualStyleBackColor = true;
            this.btnFlechaDerecha.Click += new System.EventHandler(this.btnFlechaDerecha_Click);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.Filtros.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.imagen.ResumeLayout(false);
            this.imagen.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.video.ResumeLayout(false);
            this.video.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.menuVideo.ResumeLayout(false);
            this.menuVideo.PerformLayout();
            this.Reconocimiento.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.Acerca_de.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagenCargada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcImagenEditada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHistogramaRIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHistogramaGIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHistogramaBIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHistogramaRIE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHistogramaGIE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHistogramaBIE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTiempoReal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManualDeUsuario)).EndInit();
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
        private System.Windows.Forms.PictureBox pcImagenCargada;
        private System.Windows.Forms.PictureBox pcImagenEditada;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pbManualDeUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnFlechaIzquierda;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnFlechaDerecha;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.PictureBox pbTiempoReal;
        private MaterialSkin.Controls.MaterialSwitch btnEncenderCamara;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch2;
        private MaterialSkin.Controls.MaterialComboBox cbCamara;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialComboBox cbResolucion;
        private System.Windows.Forms.PictureBox pcHistogramaRIC;
        private System.Windows.Forms.PictureBox pcHistogramaGIC;
        private System.Windows.Forms.PictureBox pcHistogramaBIC;
        private System.Windows.Forms.PictureBox pcHistogramaRIE;
        private System.Windows.Forms.PictureBox pcHistogramaGIE;
        private System.Windows.Forms.PictureBox pcHistogramaBIE;
        private System.Windows.Forms.MenuStrip menuVideo;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abrirVídeoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revetirCambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrosBásicosToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.PictureBox pbFrame;
        private System.Windows.Forms.ToolStripMenuItem invertirColoresToolStripMenuItem1;
        private MaterialSkin.Controls.MaterialLabel lblFrames;
        private System.Windows.Forms.ToolStripMenuItem colorearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aberraciónCromáticaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem escalaDeGrisesToolStripMenuItem1;
    }
}

