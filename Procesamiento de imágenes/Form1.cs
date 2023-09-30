using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Procesamiento_de_imágenes
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        private Bitmap original;
        //private Bitmap resultante;
        private Bitmap aux;
        //private PictureBox org;
        private int[] histograma = new int[256];
        private int[,] conv3x3 = new int[3, 3];
        private int factor;
        private int offset;

        // Variables para el double buffer y evitar el flicker

        //private int anchoVentana, altoVentana;

        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);


            // Creamos el bitmap resultante del cuadro
            //original = new Bitmap(800, 600);

            // Colocamos los valores para el dibujo con scrolls
            //anchoVentana = 800;
            //altoVentana = 600;
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {
            // Agrega aquí la lógica que deseas que se ejecute cuando se hace clic en el FAB.
            MessageBox.Show("FAB clickeado"); // Ejemplo de mensaje
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Agrega aquí la lógica que deseas que se ejecute cuando se hace clic en el FAB.
            MessageBox.Show("MaterialButton clickeado"); // Ejemplo de mensaje
        }


        private void abrirImagenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                original = (Bitmap)(Bitmap.FromFile(openFileDialog1.FileName));
                //anchoVentana = original.Width;
                //altoVentana = original.Height;

                // Mantén una copia de la imagen original en 'aux'
                aux = new Bitmap(original);

                //resultante = original;

                //org = new PictureBox();
                //org.Image = original; // Carga la imagen original en el PictureBox org
                pcImagenCargada.Image = aux;
                pcImagenCargada.Invalidate();
            }

        }

        private void guardarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!validacionDeImagenCargada())
            {
                return;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                original.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        

        private void invertirColoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!validacionDeImagenCargada())
            {
                return;
            }

            // Invertimos los colores
            // Crear una copia de la imagen original
            Bitmap resultante = new Bitmap(original.Width, original.Height, original.PixelFormat);

            // Invertir la imagen original y guardarla en resultante
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color oColor = original.GetPixel(x, y);
                    Color rColor = Color.FromArgb(oColor.A, 255 - oColor.R, 255 - oColor.G, 255 - oColor.B);
                    resultante.SetPixel(x, y, rColor);
                }
            }

            original = resultante;
            pcImagenEditada.Image = resultante;
            pcImagenEditada.Invalidate();
        }

        #region Colorear
        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!validacionDeImagenCargada())
            {
                return;
            }

            // Filtro de color, solo presenta los pixeles de un componente y elimina los otros dos
            // Crear una copia de la imagen original
            Bitmap resultante = new Bitmap(original.Width, original.Height, original.PixelFormat);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    // Obtenemos el color del pixel
                    Color oColor = original.GetPixel(x, y);

                    // Procesamos y obtenemos el nuevo color
                    Color rColor = Color.FromArgb(oColor.R, 0, 0);

                    // Colocamos el color en resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }
            original = resultante;
            pcImagenEditada.Image = resultante;
            pcImagenEditada.Invalidate();
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!validacionDeImagenCargada())
            {
                return;
            }

            // Filtro de color, solo presenta los pixeles de un componente y elimina los otros dos
            // Crear una copia de la imagen original
            Bitmap resultante = new Bitmap(original.Width, original.Height, original.PixelFormat);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    // Obtenemos el color del pixel
                    Color oColor = original.GetPixel(x, y);

                    // Procesamos y obtenemos el nuevo color
                    Color rColor = Color.FromArgb(0, oColor.G, 0);

                    // Colocamos el color en resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }
            original = resultante;
            pcImagenEditada.Image = resultante;
            pcImagenEditada.Invalidate();
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!validacionDeImagenCargada())
            {
                return;
            }

            // Filtro de color, solo presenta los pixeles de un componente y elimina los otros dos
            // Crear una copia de la imagen original
            Bitmap resultante = new Bitmap(original.Width, original.Height, original.PixelFormat);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    // Obtenemos el color del pixel
                    Color oColor = original.GetPixel(x, y);

                    // Procesamos y obtenemos el nuevo color
                    Color rColor = Color.FromArgb(0, 0, oColor.B);

                    // Colocamos el color en resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }
            original = resultante;
            pcImagenEditada.Image = resultante;
            pcImagenEditada.Invalidate();
        }

        private void amarilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!validacionDeImagenCargada())
            {
                return;
            }

            // Filtro de color, solo presenta los pixeles de un componente y elimina los otros dos
            // Crear una copia de la imagen original
            Bitmap resultante = new Bitmap(original.Width, original.Height, original.PixelFormat);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    // Obtenemos el color del pixel
                    Color oColor = original.GetPixel(x, y);

                    // Procesamos y obtenemos el nuevo color
                    Color rColor = Color.FromArgb(oColor.R, oColor.G, 0);

                    // Colocamos el color en resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }
            original = resultante;
            pcImagenEditada.Image = resultante;
            pcImagenEditada.Invalidate();
        }

        private void violetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!validacionDeImagenCargada())
            {
                return;
            }

            // Filtro de color, solo presenta los pixeles de un componente y elimina los otros dos
            // Crear una copia de la imagen original
            Bitmap resultante = new Bitmap(original.Width, original.Height, original.PixelFormat);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    // Obtenemos el color del pixel
                    Color oColor = original.GetPixel(x, y);

                    // Procesamos y obtenemos el nuevo color
                    Color rColor = Color.FromArgb(oColor.R, 0, oColor.B);

                    // Colocamos el color en resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }
            original = resultante;
            pcImagenEditada.Image = resultante;
            pcImagenEditada.Invalidate();
        }

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!validacionDeImagenCargada())
            {
                return;
            }

            // Filtro de color, solo presenta los pixeles de un componente y elimina los otros dos
            // Crear una copia de la imagen original
            Bitmap resultante = new Bitmap(original.Width, original.Height, original.PixelFormat);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    // Obtenemos el color del pixel
                    Color oColor = original.GetPixel(x, y);

                    // Procesamos y obtenemos el nuevo color
                    Color rColor = Color.FromArgb(0, oColor.G, oColor.B);

                    // Colocamos el color en resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }
            original = resultante;
            pcImagenEditada.Image = resultante;
            pcImagenEditada.Invalidate();
        }
        #endregion

        private void revertirCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!validacionDeImagenCargada())
            {
                return;
            }

            // Revierte los cambios en la imagen, regresandola a su estado original
            // Crear una copia de la imagen original
            Bitmap resultante = new Bitmap(aux.Width, aux.Height, aux.PixelFormat);

            for (int x = 0; x < aux.Width; x++)
            {
                for (int y = 0; y < aux.Height; y++)
                {
                    // Obtenemos el color del pixel
                    Color oColor = aux.GetPixel(x, y);

                    // Procesamos y obtenemos el nuevo color
                    Color rColor = Color.FromArgb(oColor.A, oColor.R, oColor.G, oColor.B);

                    // Colocamos el color en resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }

            original = resultante;
            pcImagenEditada.Image = resultante;
            pcImagenEditada.Invalidate();
        }

        private void aberraciónCromáticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!validacionDeImagenCargada())
            {
                return;
            }

            int a = 5; // Tamaño de la aberración

            Bitmap resultante = new Bitmap(original.Width, original.Height, original.PixelFormat);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    int r = 0;
                    int g = original.GetPixel(x, y).G;
                    int b = 0;

                    // Obtenemos el rojo
                    if (x + a < original.Width)
                    {
                        r = original.GetPixel(x + a, y).R;
                    }

                    // Obtenemos el azul
                    if (x - a >= 0)
                    {
                        b = original.GetPixel(x - a, y).B;
                    }

                    // Colocamos el pixel
                    resultante.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            original = resultante;
            pcImagenEditada.Image = resultante;
            pcImagenEditada.Invalidate();
        }


        private void escalaDeGrisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!validacionDeImagenCargada())
            {
                return;
            }

            // Crear una copia de la imagen original con el mismo tamaño y formato
            Bitmap resultante = new Bitmap(original.Width, original.Height, original.PixelFormat);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    // Obtenemos el color del pixel
                    Color oColor = original.GetPixel(x, y);

                    // Procesamos y obtenemos el nuevo color
                    float g = oColor.R * 0.299f + oColor.G * 0.587f + oColor.B * 0.114f;

                    // Conservamos el canal alfa original
                    Color rColor = Color.FromArgb(oColor.A, (int)g, (int)g, (int)g);

                    // Colocamos el color resultante en la copia
                    resultante.SetPixel(x, y, rColor);
                }
            }

            original = resultante;
            pcImagenEditada.Image = resultante;
            pcImagenEditada.Invalidate();
        }

        private bool validacionDeImagenCargada()
        {
            if (original == null)
            {
                MessageBox.Show("Cargue una imagen primero.");
                return false;
            }

            return true;
        }


        #region Reconocimiento


        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        Image auxReconocimientoFacial;

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cbCamara.Items.Add(filterInfo.Name);
            cbCamara.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();

            // Llena el combobox de resoluciones con las 5 resoluciones deseadas
            string[] resolutions = { "1920 x 1080", "1280 x 720", "1024 x 576", "864 x 480", "640 x 480" };
            cbResolucion.Items.AddRange(resolutions);
            cbResolucion.SelectedIndex = 0;
        }

        private void btnEncenderCamara_CheckedChanged(object sender, EventArgs e)
        {
            if (btnEncenderCamara.Checked)
            {
                encenderCamara();
            }
            else
            {
                apagarCamara();
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbTiempoReal.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            apagarCamara();
        }

        private void cbCamara_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnEncenderCamara.Checked)
            {
                apagarCamara();
                encenderCamara();
            }
        }

        private void cbResolucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnEncenderCamara.Checked)
            {
                apagarCamara();
                encenderCamara();
            }
        }

        private void apagarCamara()
        {
            if (videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
                pbTiempoReal.Image = auxReconocimientoFacial;
            }
        }

        private void encenderCamara()
        {
            auxReconocimientoFacial = pbTiempoReal.Image;
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbCamara.SelectedIndex].MonikerString);

            // Obtener la resolución seleccionada en cbResolucion
            string selectedResolutionString = cbResolucion.SelectedItem.ToString();
            string[] dimensions = selectedResolutionString.Split('x');
            int selectedWidth = int.Parse(dimensions[0].Trim());
            int selectedHeight = int.Parse(dimensions[1].Trim());

            // Iterar sobre las resoluciones y seleccionar la primera compatible hacia abajo
            VideoCapabilities selectedResolution = null;
            foreach (VideoCapabilities resolution in videoCaptureDevice.VideoCapabilities)
            {
                if (resolution.FrameSize.Width >= selectedWidth && resolution.FrameSize.Height >= selectedHeight)
                {
                    selectedResolution = resolution;
                    break;
                }
            }


            // Establecer la resolución deseada si se encontró
            if (selectedResolution != null)
            {
                videoCaptureDevice.VideoResolution = selectedResolution;

                // Imprimir la información de la resolución seleccionada
                Console.WriteLine($"Resolución seleccionada: {selectedResolution.FrameSize.Width} x {selectedResolution.FrameSize.Height}");
            }

            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }


        #endregion

        
    }

}
