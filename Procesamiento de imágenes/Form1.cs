using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using AForge.Video;
using AForge.Video.DirectShow;
using Accord.Video.FFMPEG;
using System.Runtime.InteropServices;

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

                // Carga los histogramas
                cargarHistogramasIC(original);
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

            cargarHistogramasIE(original);
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

            cargarHistogramasIE(original);
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

            cargarHistogramasIE(original);
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

            cargarHistogramasIE(original);
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

            cargarHistogramasIE(original);
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

            cargarHistogramasIE(original);
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


            cargarHistogramasIE(original);
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

            cargarHistogramasIE(original);
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
            cargarHistogramasIE(original);
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

            cargarHistogramasIE(original);
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


        private void cargarHistogramasIC(Bitmap imagen)
        {
            // Calcula los histogramas
            int[] histogramaR = new int[256];
            int[] histogramaG = new int[256];
            int[] histogramaB = new int[256];

            for (int x = 0; x < imagen.Width; x++)
            {
                for (int y = 0; y < imagen.Height; y++)
                {
                    Color pixel = imagen.GetPixel(x, y);
                    histogramaR[pixel.R]++;
                    histogramaG[pixel.G]++;
                    histogramaB[pixel.B]++;
                }
            }

            // Muestra los histogramas en los Picturebox correspondientes
            mostrarHistograma(histogramaR, pcHistogramaRIC, Color.Red);
            mostrarHistograma(histogramaG, pcHistogramaGIC, Color.Green);
            mostrarHistograma(histogramaB, pcHistogramaBIC, Color.Blue);
        }

        private void cargarHistogramasIE(Bitmap imagen)
        {
            // Calcula los histogramas
            int[] histogramaR = new int[256];
            int[] histogramaG = new int[256];
            int[] histogramaB = new int[256];

            for (int x = 0; x < imagen.Width; x++)
            {
                for (int y = 0; y < imagen.Height; y++)
                {
                    Color pixel = imagen.GetPixel(x, y);
                    histogramaR[pixel.R]++;
                    histogramaG[pixel.G]++;
                    histogramaB[pixel.B]++;
                }
            }

            // Muestra los histogramas en los Picturebox correspondientes
            mostrarHistograma(histogramaR, pcHistogramaRIE, Color.Red);
            mostrarHistograma(histogramaG, pcHistogramaGIE, Color.Green);
            mostrarHistograma(histogramaB, pcHistogramaBIE, Color.Blue);
        }

        private void mostrarHistograma(int[] histograma, PictureBox pictureBox, Color color)
        {
            Bitmap bmpHistograma = new Bitmap(pictureBox.Width, pictureBox.Height);

            using (Graphics g = Graphics.FromImage(bmpHistograma))
            {
                g.Clear(Color.White);

                int maxFrecuencia = histograma.Max();

                for (int i = 0; i < 256; i++)
                {
                    int altura = (int)((double)histograma[i] / maxFrecuencia * pictureBox.Height);
                    g.DrawLine(new Pen(color), i, pictureBox.Height, i, pictureBox.Height - altura);
                }
            }

            pictureBox.Image = bmpHistograma;
        }



        #region Vídeo

        private VideoFileReader videoFileReader;

        private void abrirVídeoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog2.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();

                // Inicializar el lector de archivos de vídeo
                videoFileReader = new VideoFileReader();
                videoFileReader.Open(openFileDialog2.FileName);
            }
        }

        private async void invertirColoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (videoFileReader == null || !videoFileReader.IsOpen)
            {
                MessageBox.Show("Abre un vídeo primero.");
                return;
            }

            int blockWidth = 100;  // Ajusta el ancho del bloque según tus necesidades
            int blockHeight = 100;  // Ajusta la altura del bloque según tus necesidades

            List<Bitmap> invertedFrames = new List<Bitmap>();
            int framesToProcessBeforeCleanup = 1;  // Ajusta según tus necesidades

            try
            {
                string outputVideoPath = "video_editado.mp4";
                using (VideoFileWriter videoFileWriter = new VideoFileWriter())
                {
                    await Task.Run(() =>
                    {
                        int batchSize = 1;  // ajusta el tamaño del lote según tus necesidades

                        for (int i = 0; i < videoFileReader.FrameCount; i += batchSize)
                        {
                            List<Bitmap> batchFrames = GetAllBitmapFramesFromVideo(videoFileReader, i, batchSize);

                            Parallel.ForEach(batchFrames, frame =>
                            {
                                Bitmap invertedFrame = InvertColors(frame, blockWidth, blockHeight);
                                invertedFrames.Add(invertedFrame);

                                frame?.Dispose();
                            });

                            // Escribir los frames invertidos en el archivo de vídeo más frecuentemente
                            if (i % framesToProcessBeforeCleanup == 0)
                            {
                                BeginInvoke(new Action(() =>
                                {
                                    lblFrames.Text = $"Procesando fotogramas {i + 1} al {Math.Min(i + framesToProcessBeforeCleanup, videoFileReader.FrameCount)} de {videoFileReader.FrameCount}";
                                }));

                                // Verificar si hay suficientes elementos en invertedFrames antes de continuar
                                if (invertedFrames.Count >= framesToProcessBeforeCleanup)
                                {
                                    // Abrir el archivo de vídeo si no está abierto
                                    if (!videoFileWriter.IsOpen)
                                    {
                                        videoFileWriter.Open(outputVideoPath, invertedFrames[0].Width, invertedFrames[0].Height, 30, VideoCodec.MPEG4);
                                    }

                                    // Escribir los frames invertidos en el archivo de vídeo
                                    foreach (var invertedFrame in invertedFrames)
                                    {
                                        // Verificar si hay un fotograma antes de mostrarlo en pbFrame
                                        if (invertedFrame != null)
                                        {
                                            // Mostrar el fotograma actual en pbFrame antes de borrarlo
                                            // Clonar la imagen antes de asignarla
                                            Bitmap clonedFrame = (Bitmap)invertedFrame.Clone();

                                            BeginInvoke(new Action(() =>
                                            {
                                                pbFrame.Image = clonedFrame;
                                                pbFrame.Invalidate();
                                            }));

                                            // Escribir el fotograma invertido en el archivo de vídeo
                                            videoFileWriter.WriteVideoFrame(invertedFrame);

                                            clonedFrame?.Dispose();
                                        }
                                    }

                                    // Liberar memoria de los frames invertidos después de escribir
                                    foreach (var invertedFrame in invertedFrames)
                                    {
                                        invertedFrame?.Dispose();
                                    }
                                    invertedFrames.Clear();
                                }
                            }

                            // Liberar memoria de los frames del lote
                            foreach (var frame in batchFrames)
                            {
                                frame?.Dispose();
                            }
                        }
                    });

                    lblFrames.Text = "Proceso completado.";

                    // Escribir los frames restantes en el archivo de vídeo
                    foreach (var invertedFrame in invertedFrames)
                    {
                        videoFileWriter.WriteVideoFrame(invertedFrame);
                    }
                }

                axWindowsMediaPlayer1.URL = outputVideoPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();

                //MessageBox.Show("Proceso completado. El vídeo se ha editado con éxito");
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show("Error: Memoria insuficiente. Intenta con bloques más pequeños o reduce la resolución.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private List<Bitmap> GetAllBitmapFramesFromVideo(VideoFileReader videoReader, int startFrame, int frameCount, bool reducedResolution = false)
        {
            List<Bitmap> frames = new List<Bitmap>();

            for (int frameNumber = startFrame; frameNumber < startFrame + frameCount; frameNumber++)
            {
                var frame = videoReader.ReadVideoFrame();
                if (frame == null)
                {
                    // Fin del archivo, salir del bucle
                    break;
                }

                if (reducedResolution)
                {
                    // Reducir resolución si es necesario
                    frame = ResizeBitmap(frame, new Size(frame.Width / 2, frame.Height / 2));
                }

                frames.Add(frame);
            }

            return frames;
        }

        private Bitmap InvertColors(Bitmap original, int blockWidth, int blockHeight)
        {
            try
            {
                Bitmap invertedFrame = new Bitmap(original.Width, original.Height);
                BitmapData originalData = original.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                BitmapData invertedData = invertedFrame.LockBits(new Rectangle(0, 0, invertedFrame.Width, invertedFrame.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                unsafe
                {
                    byte* originalPtr = (byte*)originalData.Scan0.ToPointer();
                    byte* invertedPtr = (byte*)invertedData.Scan0.ToPointer();

                    for (int y = 0; y < original.Height; y += blockHeight)
                    {
                        for (int x = 0; x < original.Width; x += blockWidth)
                        {
                            // Procesar un bloque
                            for (int blockY = 0; blockY < blockHeight && y + blockY < original.Height; blockY++)
                            {
                                for (int blockX = 0; blockX < blockWidth && x + blockX < original.Width; blockX++)
                                {
                                    int index = (y + blockY) * originalData.Stride + (x + blockX) * 4;

                                    // Invertir los componentes de color
                                    invertedPtr[index] = (byte)(255 - originalPtr[index]); // Blue
                                    invertedPtr[index + 1] = (byte)(255 - originalPtr[index + 1]); // Green
                                    invertedPtr[index + 2] = (byte)(255 - originalPtr[index + 2]); // Red
                                    invertedPtr[index + 3] = originalPtr[index + 3]; // Alpha
                                }
                            }
                        }
                    }
                }

                original.UnlockBits(originalData);
                invertedFrame.UnlockBits(invertedData);

                return invertedFrame;
            }
            catch (System.OutOfMemoryException)
            {
                throw; // Propagar la excepción para manejarla en el nivel superior
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al invertir colores: {ex.Message}");
                return null; // o manejar de otra manera según tus necesidades
            }
        }

        private Bitmap ResizeBitmap(Bitmap original, Size newSize)
        {
            Bitmap resizedBitmap = new Bitmap(newSize.Width, newSize.Height);
            using (Graphics g = Graphics.FromImage(resizedBitmap))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(original, 0, 0, newSize.Width, newSize.Height);
            }
            return resizedBitmap;
        }



        private void revetirCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion


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
