﻿using System;
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
using Microsoft.VisualBasic;
using System.Reflection;

namespace Chinchi
{
    public partial class HomeForm : MaterialForm
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


        int blockWidth = 100;  // Ajusta el ancho del bloque según tus necesidades
        int blockHeight = 100;  // Ajusta la altura del bloque según tus necesidades
        // Variables para el double buffer y evitar el flicker

        //private int anchoVentana, altoVentana;

        public HomeForm()
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
            //listaImagenes.Add(Properties.Resources.Diapositiva1);
            listaImagenes.Add(Properties.Resources.Diapositiva2);
            listaImagenes.Add(Properties.Resources.Diapositiva3);
            listaImagenes.Add(Properties.Resources.Diapositiva4);
            listaImagenes.Add(Properties.Resources.Diapositiva5);
            listaImagenes.Add(Properties.Resources.Diapositiva6);
            listaImagenes.Add(Properties.Resources.Diapositiva7);
            //listaImagenes.Add(Properties.Resources.Diapositiva8);
            pbManualDeUsuario.Image = Properties.Resources.Diapositiva2;

            // Accede a la versión del ensamblado
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            // Asigna la versión al Text del Label
            lblVersion.Text = $"CHINCHI v{version}";

            // Accede al atributo de derechos de autor del ensamblado
            AssemblyCopyrightAttribute copyAttribute =
                (AssemblyCopyrightAttribute)Attribute.GetCustomAttribute(
                    Assembly.GetExecutingAssembly(),
                    typeof(AssemblyCopyrightAttribute)
                );

            // Accede a la versión del ensamblado
            //AssemblyFileVersionAttribute fileAttribute =
            //    (AssemblyFileVersionAttribute)Attribute.GetCustomAttribute(
            //        Assembly.GetExecutingAssembly(),
            //        typeof(AssemblyFileVersionAttribute)
            //    );
            // Asigna la versión al Text del Label
            lblVersion.Text = $"CHINCHI v{version}";

            // Asigna el valor al Text del Label
            lblCopyRight.Text = copyAttribute?.Copyright ?? string.Empty;
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
            Bitmap resultante = InvertirColores(original, blockWidth, blockHeight);

            // La operación no fue exitosa, cancelar el proceso
            if (resultante == null)
            {
                return;
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
            Bitmap resultante = ColorearRojo(original, blockWidth, blockHeight);

            // La operación no fue exitosa, cancelar el proceso
            if (resultante == null)
            {
                return;
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
            Bitmap resultante = ColorearVerde(original, blockWidth, blockHeight);

            // La operación no fue exitosa, cancelar el proceso
            if (resultante == null)
            {
                return;
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
            Bitmap resultante = ColorearAzul(original, blockWidth, blockHeight);

            // La operación no fue exitosa, cancelar el proceso
            if (resultante == null)
            {
                return;
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
            Bitmap resultante = ColorearAmarillo(original, blockWidth, blockHeight);

            // La operación no fue exitosa, cancelar el proceso
            if (resultante == null)
            {
                return;
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
            Bitmap resultante = ColorearVioleta(original, blockWidth, blockHeight);

            // La operación no fue exitosa, cancelar el proceso
            if (resultante == null)
            {
                return;
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
            Bitmap resultante = ColorearCyan(original, blockWidth, blockHeight);

            // La operación no fue exitosa, cancelar el proceso
            if (resultante == null)
            {
                return;
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

            original = aux;
            pcImagenEditada.Image = aux;
            pcImagenEditada.Invalidate();

            cargarHistogramasIE(original);
        }

        private void aberraciónCromáticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!validacionDeImagenCargada())
            {
                return;
            }

            Bitmap resultante = AberracionCromatica(original, 1);

            // La operación no fue exitosa, cancelar el proceso
            if (resultante == null)
            {
                return;
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
            Bitmap resultante = EscalaDeGrises(original, blockWidth, blockHeight);

            // La operación no fue exitosa, cancelar el proceso
            if (resultante == null)
            {
                return;
            }

            original = resultante;
            pcImagenEditada.Image = resultante;
            pcImagenEditada.Invalidate();

            cargarHistogramasIE(original);
        }
        private void brilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!validacionDeImagenCargada())
            {
                return;
            }

            // Crear una copia de la imagen original con el mismo tamaño y formato
            Bitmap resultante = Brillo(original, blockWidth, blockHeight);

            // La operación no fue exitosa, cancelar el proceso
            if (resultante == null)
            {
                return;
            }

            original = resultante;
            pcImagenEditada.Image = resultante;
            pcImagenEditada.Invalidate();

            cargarHistogramasIE(original);
        }

        private void contrasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!validacionDeImagenCargada())
            {
                return;
            }

            // Crear una copia de la imagen original con el mismo tamaño y formato
            Bitmap resultante = Contraste(original, blockWidth, blockHeight);

            // La operación no fue exitosa, cancelar el proceso
            if (resultante == null)
            {
                return;
            }

            original = resultante;
            pcImagenEditada.Image = resultante;
            pcImagenEditada.Invalidate();

            cargarHistogramasIE(original);
        }

        private void gradienteDeColoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!validacionDeImagenCargada())
            {
                return;
            }

            // Crear una copia de la imagen original con el mismo tamaño y formato
            Color colorInicio = Color.Blue;
            Color colorFin = Color.Red;
            float opacidad = 0.5f; // Ajusta este valor según tus necesidades

            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtiene el color seleccionado por el usuario
                colorInicio = colorDialog.Color;
            }

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtiene el color seleccionado por el usuario
                colorFin = colorDialog.Color;
            }
            int minValue = 1;
            int maxValue = 100;
            int defaultValue = 50;
            string tituloSlider = "Cantidad de Opacidad:";
            // Mostrar un formulario que contenga la barra deslizadora
            SliderForm sliderForm = new SliderForm(minValue, maxValue, defaultValue, tituloSlider);

            if (sliderForm.ShowDialog() != DialogResult.OK)
            {
                // El usuario canceló el formulario
                MessageBox.Show("Se canceló el proceso.");
                return;
            }

            opacidad = (float)sliderForm.Valor / 100;


            Bitmap resultante = DegradadoColores(original, colorInicio, colorFin, opacidad);



            // La operación no fue exitosa, cancelar el proceso
            if (resultante == null)
            {
                return;
            }

            original = resultante;
            pcImagenEditada.Image = resultante;
            pcImagenEditada.Invalidate();

            cargarHistogramasIE(original);
        }

        private void ruidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!validacionDeImagenCargada())
            {
                return;
            }

            // Crear una copia de la imagen original con el mismo tamaño y formato
            Bitmap resultante = Ruido(original, blockWidth, blockHeight);

            if (resultante == null)
            {
                // La operación de ruido no fue exitosa, cancelar el proceso
                //MessageBox.Show("La operación de ruido no se realizó correctamente. Se cancelará el proceso.");
                return;
            }

            original = resultante;
            pcImagenEditada.Image = resultante;
            pcImagenEditada.Invalidate();

            cargarHistogramasIE(original);
        }

        private void pixelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!validacionDeImagenCargada())
            {
                return;
            }

            // Crear una copia de la imagen original con el mismo tamaño y formato
            Bitmap resultante = Pixelar(original);

            // La operación no fue exitosa, cancelar el proceso
            if (resultante == null)
            {
                return;
            }

            original = resultante;
            pcImagenEditada.Image = resultante;
            pcImagenEditada.Invalidate();

            cargarHistogramasIE(original);
        }

        private void warpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!validacionDeImagenCargada())
            {
                return;
            }

            // Crear una copia de la imagen original con el mismo tamaño y formato
            Bitmap resultante = Warp(original);

            // La operación no fue exitosa, cancelar el proceso
            if (resultante == null)
            {
                return;
            }

            original = resultante;
            pcImagenEditada.Image = resultante;
            pcImagenEditada.Invalidate();

            cargarHistogramasIE(original);
        }

        private void warpCircularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!validacionDeImagenCargada())
            {
                return;
            }

            // Crear una copia de la imagen original con el mismo tamaño y formato
            Bitmap resultante = CircularWarp(original);

            // La operación no fue exitosa, cancelar el proceso
            if (resultante == null)
            {
                return;
            }

            original = resultante;
            pcImagenEditada.Image = resultante;
            pcImagenEditada.Invalidate();

            cargarHistogramasIE(original);
        }

        private void ojoDePezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!validacionDeImagenCargada())
            {
                return;
            }

            // Crear una copia de la imagen original con el mismo tamaño y formato
            Bitmap resultante = FishEye(original);

            // La operación no fue exitosa, cancelar el proceso
            if (resultante == null)
            {
                return;
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
        private VideoFileWriter videoFileWriter;

        private void abrirVídeoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog2.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();

                // Liberar el lector de archivos de vídeo existente antes de crear uno nuevo
                videoFileReader?.Close();
                videoFileReader = new VideoFileReader();
                videoFileReader.Open(openFileDialog2.FileName);
            }
        }


        private async void invertirColoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            await ProcesarVideo(ProcesoVideo.InvertirColores);
        }

        private async void escalaDeGrisesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            await ProcesarVideo(ProcesoVideo.EscalaDeGrises);
        }

        private enum ProcesoVideo
        {
            InvertirColores,
            EscalaDeGrises
        }

        private async Task ProcesarVideo(ProcesoVideo proceso)
        {
            if (videoFileReader == null || !videoFileReader.IsOpen)
            {
                MessageBox.Show("Abre un vídeo primero.");
                return;
            }

            List<Bitmap> processedFrames = new List<Bitmap>();
            int framesToProcessBeforeCleanup = 1;  // Ajusta según tus necesidades

            string outputVideoPath = "video_editado.mp4";
            try
            {
                menuVideo.Enabled = false;
                // Usar VideoFileWriter como un campo para poder cerrarlo más tarde
                videoFileWriter = new VideoFileWriter();
                videoFileWriter.Open(outputVideoPath, videoFileReader.Width, videoFileReader.Height, videoFileReader.FrameRate, VideoCodec.MPEG4);

                await Task.Run(() =>
                {
                    int batchSize = 1;  // ajusta el tamaño del lote según tus necesidades

                    for (int i = 0; i < videoFileReader.FrameCount; i += batchSize)
                    {
                        List<Bitmap> batchFrames = GetAllBitmapFramesFromVideo(videoFileReader, i, batchSize);

                        Parallel.ForEach(batchFrames, frame =>
                        {
                            Bitmap processedFrame = null;
                            int currentFrameNumber = i + batchFrames.IndexOf(frame) + 1;

                            switch (proceso)
                            {
                                case ProcesoVideo.InvertirColores:
                                    processedFrame = InvertirColores(frame, blockWidth, blockHeight);
                                    break;
                                case ProcesoVideo.EscalaDeGrises:
                                    processedFrame = EscalaDeGrises(frame, blockWidth, blockHeight);
                                    break;
                                    // Agrega otros casos según sea necesario
                            }

                            BeginInvoke(new Action(() =>
                            {
                                lblFrames.Text = $"Procesando fotograma {currentFrameNumber} de {videoFileReader.FrameCount}";
                            }));

                            processedFrames.Add(processedFrame);

                            frame?.Dispose();
                        });

                        // Escribir los frames procesados en el archivo de vídeo más frecuentemente
                        if (i % framesToProcessBeforeCleanup == 0)
                        {
                            // Verificar si hay suficientes elementos en processedFrames antes de continuar
                            if (processedFrames.Count >= framesToProcessBeforeCleanup)
                            {
                                // Abrir el archivo de vídeo si no está abierto
                                if (!videoFileWriter.IsOpen)
                                {
                                    videoFileWriter.Open(outputVideoPath, processedFrames[0].Width, processedFrames[0].Height, 30, VideoCodec.MPEG4);
                                }

                                // Escribir los frames procesados en el archivo de vídeo
                                foreach (var processedFrame in processedFrames)
                                {
                                    // Verificar si hay un fotograma antes de mostrarlo en pbFrame
                                    if (processedFrame != null)
                                    {
                                        // Mostrar el fotograma actual en pbFrame antes de borrarlo
                                        // Clonar la imagen antes de asignarla
                                        Bitmap clonedFrame = (Bitmap)processedFrame.Clone();

                                        BeginInvoke(new Action(() =>
                                        {
                                            try
                                            {
                                                pbFrame.Image = clonedFrame;
                                                pbFrame.Invalidate();
                                            }
                                            catch (Exception ex)
                                            {
                                                //MessageBox.Show($"Error: {ex.Message}. Frame no válido, continuaré con los demás frames");
                                            }
                                        }));

                                        // Escribir el fotograma procesado en el archivo de vídeo
                                        videoFileWriter.WriteVideoFrame(processedFrame);

                                        clonedFrame?.Dispose();
                                    }
                                }

                                // Liberar memoria de los frames procesados después de escribir
                                foreach (var processedFrame in processedFrames)
                                {
                                    processedFrame?.Dispose();
                                }
                                processedFrames.Clear();
                            }
                        }

                        // Liberar memoria de los frames del lote
                        foreach (var frame in batchFrames)
                        {
                            frame?.Dispose();
                        }
                    }

                    // Cerrar VideoFileWriter después de terminar de escribir los frames
                    videoFileWriter.Close();
                });
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show("Error: Memoria insuficiente. Intenta con bloques más pequeños o reduce la resolución.");
            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show($"Error de argumento: {ex.Message}");
                // También puedes agregar código para limpiar y restablecer el estado si es necesario
                // ...
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                // Asegúrate de liberar recursos
                videoFileReader?.Close();
                videoFileWriter?.Close();
                menuVideo.Enabled = true;
            }

            lblFrames.Text = "Proceso completado.";

            // Escribir los frames restantes en el archivo de vídeo
            foreach (var processedFrame in processedFrames)
            {
                videoFileWriter.WriteVideoFrame(processedFrame);
            }

            axWindowsMediaPlayer1.URL = outputVideoPath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
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
                    //frame = ResizeBitmap(frame, new Size(frame.Width / 2, frame.Height / 2));
                }

                frames.Add(frame);
            }

            return frames;
        }

        private Bitmap InvertirColores(Bitmap original, int blockWidth, int blockHeight)
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
            catch (System.ArgumentException ex)
            {
                MessageBox.Show($"Error de argumento: {ex.Message}. Detalles: {ex.StackTrace}");
                return null;
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show($"Error de memoria");
                throw; // Propagar la excepción para manejarla en el nivel superior
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al invertir colores: {ex.Message}");
                return null; // o manejar de otra manera según tus necesidades
            }
        }

        //private Bitmap ResizeBitmap(Bitmap original, Size newSize)
        //{
        //    Bitmap resizedBitmap = new Bitmap(newSize.Width, newSize.Height);
        //    using (Graphics g = Graphics.FromImage(resizedBitmap))
        //    {
        //        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
        //        g.DrawImage(original, 0, 0, newSize.Width, newSize.Height);
        //    }
        //    return resizedBitmap;
        //}

        private Bitmap EscalaDeGrises(Bitmap original, int blockWidth, int blockHeight)
        {
            try
            {
                Bitmap grisesFrame = new Bitmap(original.Width, original.Height);
                BitmapData originalData = original.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                BitmapData grisesData = grisesFrame.LockBits(new Rectangle(0, 0, grisesFrame.Width, grisesFrame.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                unsafe
                {
                    byte* originalPtr = (byte*)originalData.Scan0.ToPointer();
                    byte* grisesPtr = (byte*)grisesData.Scan0.ToPointer();

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

                                    // Convertir a escala de grises utilizando la fórmula
                                    float grayValue = originalPtr[index] * 0.299f + originalPtr[index + 1] * 0.587f + originalPtr[index + 2] * 0.114f;

                                    // Asignar el nuevo valor a cada componente de color
                                    grisesPtr[index] = (byte)grayValue; // Blue
                                    grisesPtr[index + 1] = (byte)grayValue; // Green
                                    grisesPtr[index + 2] = (byte)grayValue; // Red
                                    grisesPtr[index + 3] = originalPtr[index + 3]; // Alpha
                                }
                            }
                        }
                    }
                }

                original.UnlockBits(originalData);
                grisesFrame.UnlockBits(grisesData);

                return grisesFrame;
            }
            catch (System.OutOfMemoryException)
            {
                throw; // Propagar la excepción para manejarla en el nivel superior
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al convertir a escala de grises: {ex.Message}");
                return null; // o manejar de otra manera según tus necesidades
            }
        }

        private Bitmap AberracionCromatica(Bitmap original, double aPercentage)
        {
            try
            {
                int a = (int)(original.Width * (aPercentage / 100.0));

                Bitmap aberratedFrame = new Bitmap(original.Width, original.Height);
                BitmapData originalData = original.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                BitmapData aberratedData = aberratedFrame.LockBits(new Rectangle(0, 0, aberratedFrame.Width, aberratedFrame.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                unsafe
                {
                    byte* originalPtr = (byte*)originalData.Scan0.ToPointer();
                    byte* aberratedPtr = (byte*)aberratedData.Scan0.ToPointer();

                    for (int y = 0; y < original.Height; y++)
                    {
                        for (int x = 0; x < original.Width; x++)
                        {
                            int index = y * originalData.Stride + x * 4;

                            int r = 0;
                            int g = originalPtr[index + 1]; // Canal verde sin cambios
                            int b = 0;

                            // Obtener el rojo
                            if (x + a < original.Width)
                            {
                                r = originalPtr[(y * originalData.Stride) + (x + a) * 4 + 2]; // Canal rojo
                            }

                            // Obtener el azul
                            if (x - a >= 0)
                            {
                                b = originalPtr[(y * originalData.Stride) + (x - a) * 4]; // Canal azul
                            }

                            // Colocar el píxel aberrado
                            aberratedPtr[index] = (byte)b;          // Canal azul
                            aberratedPtr[index + 1] = (byte)g;      // Canal verde
                            aberratedPtr[index + 2] = (byte)r;      // Canal rojo
                            aberratedPtr[index + 3] = originalPtr[index + 3]; // Canal alfa
                        }
                    }
                }

                original.UnlockBits(originalData);
                aberratedFrame.UnlockBits(aberratedData);

                return aberratedFrame;
            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show($"Error de argumento: {ex.Message}. Detalles: {ex.StackTrace}");
                return null;
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show($"Error de memoria");
                throw; // Propagar la excepción para manejarla en el nivel superior
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar aberración cromática: {ex.Message}");
                return null; // O manejar de otra manera según tus necesidades
            }
        }

        private Bitmap ColorearRojo(Bitmap original, int blockWidth, int blockHeight)
        {
            try
            {
                Bitmap redFrame = new Bitmap(original.Width, original.Height);
                BitmapData originalData = original.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                BitmapData redData = redFrame.LockBits(new Rectangle(0, 0, redFrame.Width, redFrame.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                unsafe
                {
                    byte* originalPtr = (byte*)originalData.Scan0.ToPointer();
                    byte* redPtr = (byte*)redData.Scan0.ToPointer();

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

                                    // Mantener solo el componente rojo, establecer los otros a 0
                                    redPtr[index] = 0;                   // Blue a 0
                                    redPtr[index + 1] = 0;                // Green a 0
                                    redPtr[index + 2] = originalPtr[index + 2]; // Red a componente rojo original
                                    redPtr[index + 3] = originalPtr[index + 3]; // Alpha sin cambios
                                }
                            }
                        }
                    }
                }

                original.UnlockBits(originalData);
                redFrame.UnlockBits(redData);

                return redFrame;
            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show($"Error de argumento: {ex.Message}. Detalles: {ex.StackTrace}");
                return null;
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show($"Error de memoria");
                throw; // Propagar la excepción para manejarla en el nivel superior
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al dejar solo el color rojo: {ex.Message}");
                return null; // O manejar de otra manera según tus necesidades
            }
        }

        private Bitmap ColorearVerde(Bitmap original, int blockWidth, int blockHeight)
        {
            try
            {
                Bitmap redFrame = new Bitmap(original.Width, original.Height);
                BitmapData originalData = original.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                BitmapData redData = redFrame.LockBits(new Rectangle(0, 0, redFrame.Width, redFrame.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                unsafe
                {
                    byte* originalPtr = (byte*)originalData.Scan0.ToPointer();
                    byte* redPtr = (byte*)redData.Scan0.ToPointer();

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

                                    // Mantener solo el componente verde, establecer los otros a 0
                                    redPtr[index] = 0;                   // Blue a 0
                                    redPtr[index + 1] = originalPtr[index + 1];                // Green a tope
                                    redPtr[index + 2] = 0; // Red a 0
                                    redPtr[index + 3] = originalPtr[index + 3]; // Alpha sin cambios
                                }
                            }
                        }
                    }
                }

                original.UnlockBits(originalData);
                redFrame.UnlockBits(redData);

                return redFrame;
            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show($"Error de argumento: {ex.Message}. Detalles: {ex.StackTrace}");
                return null;
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show($"Error de memoria");
                throw; // Propagar la excepción para manejarla en el nivel superior
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al dejar solo el color rojo: {ex.Message}");
                return null; // O manejar de otra manera según tus necesidades
            }
        }

        private Bitmap ColorearAzul(Bitmap original, int blockWidth, int blockHeight)
        {
            try
            {
                Bitmap redFrame = new Bitmap(original.Width, original.Height);
                BitmapData originalData = original.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                BitmapData redData = redFrame.LockBits(new Rectangle(0, 0, redFrame.Width, redFrame.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                unsafe
                {
                    byte* originalPtr = (byte*)originalData.Scan0.ToPointer();
                    byte* redPtr = (byte*)redData.Scan0.ToPointer();

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

                                    // Mantener solo el componente rojo, establecer los otros a 0
                                    redPtr[index] = originalPtr[index];                   // Blue a tope
                                    redPtr[index + 1] = 0;                // Green a 0
                                    redPtr[index + 2] = 0; // Red a 0
                                    redPtr[index + 3] = originalPtr[index + 3]; // Alpha sin cambios
                                }
                            }
                        }
                    }
                }

                original.UnlockBits(originalData);
                redFrame.UnlockBits(redData);

                return redFrame;
            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show($"Error de argumento: {ex.Message}. Detalles: {ex.StackTrace}");
                return null;
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show($"Error de memoria");
                throw; // Propagar la excepción para manejarla en el nivel superior
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al dejar solo el color rojo: {ex.Message}");
                return null; // O manejar de otra manera según tus necesidades
            }
        }

        private Bitmap ColorearAmarillo(Bitmap original, int blockWidth, int blockHeight)
        {
            try
            {
                Bitmap redFrame = new Bitmap(original.Width, original.Height);
                BitmapData originalData = original.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                BitmapData redData = redFrame.LockBits(new Rectangle(0, 0, redFrame.Width, redFrame.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                unsafe
                {
                    byte* originalPtr = (byte*)originalData.Scan0.ToPointer();
                    byte* redPtr = (byte*)redData.Scan0.ToPointer();

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

                                    // Mantener solo el componente rojo, establecer los otros a 0
                                    redPtr[index] = 0;                   // Blue a tope
                                    redPtr[index + 1] = originalPtr[index + 1];                // Green a 0
                                    redPtr[index + 2] = originalPtr[index + 2]; // Red a 0
                                    redPtr[index + 3] = originalPtr[index + 3]; // Alpha sin cambios
                                }
                            }
                        }
                    }
                }

                original.UnlockBits(originalData);
                redFrame.UnlockBits(redData);

                return redFrame;
            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show($"Error de argumento: {ex.Message}. Detalles: {ex.StackTrace}");
                return null;
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show($"Error de memoria");
                throw; // Propagar la excepción para manejarla en el nivel superior
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al dejar solo el color rojo: {ex.Message}");
                return null; // O manejar de otra manera según tus necesidades
            }
        }

        private Bitmap ColorearVioleta(Bitmap original, int blockWidth, int blockHeight)
        {
            try
            {
                Bitmap redFrame = new Bitmap(original.Width, original.Height);
                BitmapData originalData = original.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                BitmapData redData = redFrame.LockBits(new Rectangle(0, 0, redFrame.Width, redFrame.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                unsafe
                {
                    byte* originalPtr = (byte*)originalData.Scan0.ToPointer();
                    byte* redPtr = (byte*)redData.Scan0.ToPointer();

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

                                    // Mantener solo el componente rojo, establecer los otros a 0
                                    redPtr[index] = originalPtr[index];                   // Blue a tope
                                    redPtr[index + 1] = 0;                // Green a 0
                                    redPtr[index + 2] = originalPtr[index + 2]; // Red a 0
                                    redPtr[index + 3] = originalPtr[index + 3]; // Alpha sin cambios
                                }
                            }
                        }
                    }
                }

                original.UnlockBits(originalData);
                redFrame.UnlockBits(redData);

                return redFrame;
            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show($"Error de argumento: {ex.Message}. Detalles: {ex.StackTrace}");
                return null;
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show($"Error de memoria");
                throw; // Propagar la excepción para manejarla en el nivel superior
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al dejar solo el color rojo: {ex.Message}");
                return null; // O manejar de otra manera según tus necesidades
            }
        }

        private Bitmap ColorearCyan(Bitmap original, int blockWidth, int blockHeight)
        {
            try
            {
                Bitmap redFrame = new Bitmap(original.Width, original.Height);
                BitmapData originalData = original.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                BitmapData redData = redFrame.LockBits(new Rectangle(0, 0, redFrame.Width, redFrame.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                unsafe
                {
                    byte* originalPtr = (byte*)originalData.Scan0.ToPointer();
                    byte* redPtr = (byte*)redData.Scan0.ToPointer();

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

                                    // Mantener solo el componente rojo, establecer los otros a 0
                                    redPtr[index] = originalPtr[index];                   // Blue a tope
                                    redPtr[index + 1] = originalPtr[index + 1];                // Green a 0
                                    redPtr[index + 2] = 0; // Red a 0
                                    redPtr[index + 3] = originalPtr[index + 3]; // Alpha sin cambios
                                }
                            }
                        }
                    }
                }

                original.UnlockBits(originalData);
                redFrame.UnlockBits(redData);

                return redFrame;
            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show($"Error de argumento: {ex.Message}. Detalles: {ex.StackTrace}");
                return null;
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show($"Error de memoria");
                throw; // Propagar la excepción para manejarla en el nivel superior
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al dejar solo el color rojo: {ex.Message}");
                return null; // O manejar de otra manera según tus necesidades
            }
        }

        private Bitmap DegradadoColores(Bitmap original, Color colorInicio, Color colorFin, float intensidad)
        {
            try
            {
                Bitmap gradientImage = new Bitmap(original.Width, original.Height);
                BitmapData originalData = original.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                BitmapData gradientData = gradientImage.LockBits(new Rectangle(0, 0, gradientImage.Width, gradientImage.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                unsafe
                {
                    byte* originalPtr = (byte*)originalData.Scan0.ToPointer();
                    byte* gradientPtr = (byte*)gradientData.Scan0.ToPointer();

                    for (int y = 0; y < original.Height; y++)
                    {
                        for (int x = 0; x < original.Width; x++)
                        {
                            int index = y * originalData.Stride + x * 4;

                            // Calcular el valor de interpolación para la posición vertical
                            float t = (float)y / original.Height;

                            // Interpolar entre los dos colores
                            Color interpolatedColor = Color.FromArgb(
                                (int)(colorInicio.A + (colorFin.A - colorInicio.A) * t),
                                (int)(colorInicio.R + (colorFin.R - colorInicio.R) * t),
                                (int)(colorInicio.G + (colorFin.G - colorInicio.G) * t),
                                (int)(colorInicio.B + (colorFin.B - colorInicio.B) * t)
                            );

                            // Mezclar con el color original
                            Color originalColor = Color.FromArgb(originalPtr[index + 3], originalPtr[index + 2], originalPtr[index + 1], originalPtr[index]);
                            Color finalColor = Color.FromArgb(
                                (int)(originalColor.A + (interpolatedColor.A - originalColor.A) * intensidad),
                                (int)(originalColor.R + (interpolatedColor.R - originalColor.R) * intensidad),
                                (int)(originalColor.G + (interpolatedColor.G - originalColor.G) * intensidad),
                                (int)(originalColor.B + (interpolatedColor.B - originalColor.B) * intensidad)
                            );

                            // Establecer el color en la nueva imagen
                            gradientPtr[index] = (byte)finalColor.B; // Blue
                            gradientPtr[index + 1] = (byte)finalColor.G; // Green
                            gradientPtr[index + 2] = (byte)finalColor.R; // Red
                            gradientPtr[index + 3] = (byte)finalColor.A; // Alpha
                        }
                    }
                }

                original.UnlockBits(originalData);
                gradientImage.UnlockBits(gradientData);

                return gradientImage;
            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show($"Error de argumento: {ex.Message}. Detalles: {ex.StackTrace}");
                return null;
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show($"Error de memoria");
                throw; // Propagar la excepción para manejarla en el nivel superior
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar el degradado de colores: {ex.Message}");
                return null; // O manejar de otra manera según tus necesidades
            }
        }

        private Bitmap Brillo(Bitmap original, int blockWidth, int blockHeight)
        {
            try
            {
                Bitmap brightenedImage = new Bitmap(original.Width, original.Height);
                BitmapData originalData = original.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                BitmapData brightenedData = brightenedImage.LockBits(new Rectangle(0, 0, brightenedImage.Width, brightenedImage.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                unsafe
                {
                    byte* originalPtr = (byte*)originalData.Scan0.ToPointer();
                    byte* brightenedPtr = (byte*)brightenedData.Scan0.ToPointer();

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

                                    // Incrementar el brillo en un 10% para los componentes R, G, y B
                                    for (int i = 0; i < 3; i++)
                                    {
                                        int newValue = (int)(originalPtr[index + i] * 1.1); // Aumentar en un 10%
                                        brightenedPtr[index + i] = (byte)Math.Min(255, newValue);
                                    }

                                    // Mantener el componente alpha sin cambios
                                    brightenedPtr[index + 3] = originalPtr[index + 3];
                                }
                            }
                        }
                    }
                }

                original.UnlockBits(originalData);
                brightenedImage.UnlockBits(brightenedData);

                return brightenedImage;
            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show($"Error de argumento: {ex.Message}. Detalles: {ex.StackTrace}");
                return null;
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show($"Error de memoria");
                throw; // Propagar la excepción para manejarla en el nivel superior
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aumentar el brillo: {ex.Message}");
                return null; // O manejar de otra manera según tus necesidades
            }
        }

        private Bitmap Contraste(Bitmap original, int blockWidth, int blockHeight)
        {
            try
            {
                Bitmap highContrastImage = new Bitmap(original.Width, original.Height);
                BitmapData originalData = original.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                BitmapData highContrastData = highContrastImage.LockBits(new Rectangle(0, 0, highContrastImage.Width, highContrastImage.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                unsafe
                {
                    byte* originalPtr = (byte*)originalData.Scan0.ToPointer();
                    byte* highContrastPtr = (byte*)highContrastData.Scan0.ToPointer();

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

                                    // Aumentar el contraste aplicando una fórmula
                                    for (int i = 0; i < 3; i++)
                                    {
                                        double newValue = ((originalPtr[index + i] / 255.0) - 0.5) * 2.0; // Normalizar y ajustar al rango [-1, 1]
                                        newValue = newValue * 1.5; // Ajustar el factor de contraste según sea necesario
                                        newValue = (newValue / 2.0) + 0.5; // Desnormalizar al rango [0, 1]
                                        newValue *= 255; // Escalar de nuevo al rango [0, 255]
                                        highContrastPtr[index + i] = (byte)Math.Max(0, Math.Min(255, newValue));
                                    }

                                    // Mantener el componente alpha sin cambios
                                    highContrastPtr[index + 3] = originalPtr[index + 3];
                                }
                            }
                        }
                    }
                }

                original.UnlockBits(originalData);
                highContrastImage.UnlockBits(highContrastData);

                return highContrastImage;
            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show($"Error de argumento: {ex.Message}. Detalles: {ex.StackTrace}");
                return null;
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show($"Error de memoria");
                throw; // Propagar la excepción para manejarla en el nivel superior
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aumentar el contraste: {ex.Message}");
                return null; // O manejar de otra manera según tus necesidades
            }
        }

        private Bitmap Ruido(Bitmap original, int blockWidth, int blockHeight)
        {
            try
            {
                int minValue = 1;
                int maxValue = 100;
                int defaultValue = 50;
                string tituloSlider = "Cantidad de Ruido:";
                // Mostrar un formulario que contenga la barra deslizadora
                using (SliderForm sliderForm = new SliderForm(minValue, maxValue, defaultValue, tituloSlider))
                {
                    if (sliderForm.ShowDialog() != DialogResult.OK)
                    {
                        // El usuario canceló el formulario
                        MessageBox.Show("Se canceló el proceso.");
                        return null;
                    }

                    double factorRuido = sliderForm.Valor;

                    Random random = new Random();
                    Bitmap noisyImage = new Bitmap(original.Width, original.Height);
                    BitmapData originalData = original.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                    BitmapData noisyData = noisyImage.LockBits(new Rectangle(0, 0, noisyImage.Width, noisyImage.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                    unsafe
                    {
                        byte* originalPtr = (byte*)originalData.Scan0.ToPointer();
                        byte* noisyPtr = (byte*)noisyData.Scan0.ToPointer();

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

                                        // Añadir ruido a cada componente de color
                                        for (int i = 0; i < 3; i++)
                                        {
                                            double noise = (random.NextDouble() * 2 - 1) * factorRuido;
                                            int newValue = (int)Math.Min(255, Math.Max(0, originalPtr[index + i] + noise));
                                            noisyPtr[index + i] = (byte)newValue;
                                        }

                                        // Mantener el componente alpha sin cambios
                                        noisyPtr[index + 3] = originalPtr[index + 3];
                                    }
                                }
                            }
                        }
                    }

                    original.UnlockBits(originalData);
                    noisyImage.UnlockBits(noisyData);

                    return noisyImage;
                }
            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show($"Error de argumento: {ex.Message}. Detalles: {ex.StackTrace}");
                return null;
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show($"Error de memoria");
                throw; // Propagar la excepción para manejarla en el nivel superior
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al añadir ruido: {ex.Message}");
                return null;
            }
        }

        private Bitmap Pixelar(Bitmap original)
        {
            try
            {
                int minValue = 1;
                int maxValue = ((original.Width > original.Height) ? original.Width : original.Height) / 5;
                int defaultValue = (((original.Width > original.Height) ? original.Width : original.Height) / 5) / 2; // Valor por defecto
                string tituloSlider = "Cantidad de Pixelado:";

                // Mostrar un formulario que contenga la barra deslizadora para la cantidad de pixelado
                using (SliderForm sliderForm = new SliderForm(minValue, maxValue, defaultValue, tituloSlider))
                {
                    if (sliderForm.ShowDialog() != DialogResult.OK)
                    {
                        // El usuario canceló el formulario
                        MessageBox.Show("Se canceló el proceso.");
                        return null;
                    }

                    int blockSize = sliderForm.Valor;

                    Bitmap pixelatedImage = new Bitmap(original.Width, original.Height);
                    BitmapData originalData = original.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                    BitmapData pixelatedData = pixelatedImage.LockBits(new Rectangle(0, 0, pixelatedImage.Width, pixelatedImage.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                    unsafe
                    {
                        byte* originalPtr = (byte*)originalData.Scan0.ToPointer();
                        byte* pixelatedPtr = (byte*)pixelatedData.Scan0.ToPointer();

                        for (int y = 0; y < original.Height; y += blockSize)
                        {
                            for (int x = 0; x < original.Width; x += blockSize)
                            {
                                // Procesar un bloque
                                int sumR = 0, sumG = 0, sumB = 0, sumA = 0;
                                int pixelCount = 0;

                                for (int blockY = 0; blockY < blockSize && y + blockY < original.Height; blockY++)
                                {
                                    for (int blockX = 0; blockX < blockSize && x + blockX < original.Width; blockX++)
                                    {
                                        int index = (y + blockY) * originalData.Stride + (x + blockX) * 4;

                                        // Sumar los componentes de color del bloque
                                        sumR += originalPtr[index];
                                        sumG += originalPtr[index + 1];
                                        sumB += originalPtr[index + 2];
                                        sumA += originalPtr[index + 3];
                                        pixelCount++;
                                    }
                                }

                                // Calcular el promedio de color para el bloque
                                int avgR = sumR / pixelCount;
                                int avgG = sumG / pixelCount;
                                int avgB = sumB / pixelCount;
                                int avgA = sumA / pixelCount;

                                // Establecer el mismo color promedio para todos los píxeles en el bloque
                                for (int blockY = 0; blockY < blockSize && y + blockY < original.Height; blockY++)
                                {
                                    for (int blockX = 0; blockX < blockSize && x + blockX < original.Width; blockX++)
                                    {
                                        int index = (y + blockY) * originalData.Stride + (x + blockX) * 4;

                                        pixelatedPtr[index] = (byte)avgR;
                                        pixelatedPtr[index + 1] = (byte)avgG;
                                        pixelatedPtr[index + 2] = (byte)avgB;
                                        pixelatedPtr[index + 3] = (byte)avgA;
                                    }
                                }
                            }
                        }
                    }

                    original.UnlockBits(originalData);
                    pixelatedImage.UnlockBits(pixelatedData);

                    return pixelatedImage;
                }
            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show($"Error de argumento: {ex.Message}. Detalles: {ex.StackTrace}");
                return null;
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show($"Error de memoria");
                throw; // Propagar la excepción para manejarla en el nivel superior
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al pixelar la imagen: {ex.Message}");
                return null; // O manejar de otra manera según tus necesidades
            }
        }

        private Bitmap Warp(Bitmap original)
        {
            try
            {
                // Preguntar al usuario por los valores de xWarp e yWarp
                int xWarp, yWarp;

                // Preguntar por xWarp
                using (var xWarpForm = new SliderForm(0, original.Width, original.Width / 2, "Ingrese el valor de X (max: " + original.Width + "):"))
                {
                    if (xWarpForm.ShowDialog() == DialogResult.OK)
                    {
                        xWarp = xWarpForm.Valor;
                    }
                    else
                    {
                        MessageBox.Show("Proceso cancelado.");
                        return null;
                    }
                }

                // Preguntar por yWarp
                using (var yWarpForm = new SliderForm(0, original.Height, original.Height / 2, "Ingrese el valor de Y (max: " + original.Height + "):"))
                {
                    if (yWarpForm.ShowDialog() == DialogResult.OK)
                    {
                        yWarp = yWarpForm.Valor;
                    }
                    else
                    {
                        MessageBox.Show("Proceso cancelado.");
                        return null;
                    }
                }

                // Restricción para evitar valores fuera del rango de la imagen original
                xWarp = Math.Min(xWarp, original.Width);
                yWarp = Math.Min(yWarp, original.Height);

                // Preguntar al usuario si desea usar interpolación bilineal
                bool bilineal = false; // valor predeterminado
                var result = MessageBox.Show("¿Desea utilizar interpolación bilineal?", "Interpolación Bilineal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bilineal = true;
                }

                // Crear una copia de la imagen original con el mismo tamaño y formato
                Bitmap resultante = new Bitmap(original.Width, original.Height);


                // Punto medio de la imagen
                int medioX = original.Width / 2;
                int medioY = original.Height / 2;

                // Cuarto superior izquierdo
                // Coordenadas de los puntos del poliedro
                int x1 = 0;
                int x2 = medioX;
                int x3 = xWarp;
                int x4 = 0;
                int y1 = 0;
                int y2 = 0;
                int y3 = yWarp;
                int y4 = medioY;

                // Offset para el cuadrante
                int offsetX = 0;
                int offsetY = 0;


                if (bilineal)
                    warpBilineal(x1, y1, x2, y2, x3, y3, x4, y4, offsetX, offsetY, resultante);
                else
                    warpNormal(x1, y1, x2, y2, x3, y3, x4, y4, offsetX, offsetY, resultante);

                // Cuarto superior derecho
                x1 = medioX;
                x2 = original.Width - 1;
                x3 = original.Width - 1;
                x4 = xWarp;
                y1 = 0;
                y2 = 0;
                y3 = medioY;
                y4 = yWarp;

                offsetX = medioX;
                offsetY = 0;

                if (bilineal)
                    warpBilineal(x1, y1, x2, y2, x3, y3, x4, y4, offsetX, offsetY, resultante);
                else
                    warpNormal(x1, y1, x2, y2, x3, y3, x4, y4, offsetX, offsetY, resultante);

                // Cuarto inferior derecho
                x1 = xWarp;
                x2 = original.Width - 1;
                x3 = original.Width - 1;
                x4 = medioX;
                y1 = yWarp;
                y2 = medioY;
                y3 = original.Height - 1;
                y4 = original.Height - 1;

                offsetX = medioX;
                offsetY = medioY;

                if (bilineal)
                    warpBilineal(x1, y1, x2, y2, x3, y3, x4, y4, offsetX, offsetY, resultante);
                else
                    warpNormal(x1, y1, x2, y2, x3, y3, x4, y4, offsetX, offsetY, resultante);

                // Cuarto inferior derecho
                x1 = 0;
                x2 = xWarp;
                x3 = medioX;
                x4 = 0;
                y1 = medioY;
                y2 = yWarp;
                y3 = original.Height - 1;
                y4 = original.Height - 1;

                offsetX = 0;
                offsetY = medioY;

                if (bilineal)
                    warpBilineal(x1, y1, x2, y2, x3, y3, x4, y4, offsetX, offsetY, resultante);
                else
                    warpNormal(x1, y1, x2, y2, x3, y3, x4, y4, offsetX, offsetY, resultante);

                this.Invalidate();
                return resultante;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la transformación warp: {ex.Message}");
                return null;
            }
        }

        private void warpNormal(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, int extraX, int extraY, Bitmap resultante)
        {
            int alto = original.Height;
            int ancho = original.Width;

            int relleno = 128;
            Color miColor;
            int medioX = ancho / 2;
            int medioY = alto / 2;
            int denominador = medioX * medioY;

            // Colocamos los terminos par ala transformacion espacial
            int xa = x2 - x1;
            int xb = x4 - x1;
            int xab = x1 - x2 + x3 - x4;

            int ya = y2 - y1;
            int yb = y4 - y1;
            int yab = y1 - y2 + y3 - y4;

            // Recorremos el cuadrante y hacemos la transformación espacial
            int y = 0;
            int x = 0;

            // Coordenadas para encontrar el color en la imagen
            int xImagen = 0;
            int yImagen = 0;

            for (y = 0; y < medioY; y++)
            {
                for (x = 0; x < medioX; x++)
                {
                    xImagen = x1 + (xa * x) / medioX + (xb * y) / medioY + (xab * y * x) / denominador;
                    yImagen = y1 + (ya * x) / medioX + (yb * y) / medioY + (yab * y * x) / denominador;

                    // Si estamos fuera de la imagen ponemos el color de relleno
                    if (xImagen < 0 || xImagen >= ancho || yImagen < 0 || yImagen >= alto)
                        resultante.SetPixel(x + extraX, y + extraY, Color.FromArgb(relleno, relleno, relleno));
                    else
                    {
                        // Encontramos el color segun las coordenadas
                        miColor = original.GetPixel(xImagen, yImagen);
                        // Ponemos el color
                        resultante.SetPixel(x + extraX, y + extraY, miColor);
                    }
                }
            }
        }

        private void warpBilineal(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, int extraX, int extraY, Bitmap resultante)
        {
            int alto = original.Height;
            int ancho = original.Width;

            Color miColor;
            double medioX = ancho / 2;
            double medioY = alto / 2;
            double denominador = medioX * medioY;

            // Colocamos los terminos para la transformacion espacial
            double xa = x2 - x1;
            double xb = x4 - x1;
            double xab = x1 - x2 + x3 - x4;

            double ya = y2 - y1;
            double yb = y4 - y1;
            double yab = y1 - y2 + y3 - y4;

            // Recorremos el cuadrante y hacemos la transformación espacial
            int y = 0;
            int x = 0;

            // Para usar las cordenadas como doubles
            double dy = 0;
            double dx = 0;
            double xImagen = 0;
            double yImagen = 0;

            for (y = 0; y < medioY; y++)
            {
                for (x = 0; x < medioX; x++)
                {
                    dy = y;
                    dx = x;
                    xImagen = x1 + (xa * dx) / medioX + (xb * dy) / medioY + (xab * dy * dx) / denominador;
                    yImagen = y1 + (ya * dx) / medioX + (yb * dy) / medioY + (yab * dy * dx) / denominador;

                    miColor = interpolacionBilineal(xImagen, yImagen);


                    resultante.SetPixel(x + extraX, y + extraY, miColor);
                }
            }
        }

        private Color interpolacionBilineal(double x, double y)
        {
            Color resultado = Color.Black;
            Color Color1;
            Color Color2;

            double fraccionX = 0;
            double fraccionY = 0;
            double unoMenosX = 0;
            double unoMenosY = 0;

            int techoX = 0;
            int techoY = 0;
            int pisoX = 0;
            int pisoY = 0;

            int rp1 = 0;
            int rp2 = 0;
            int rp3 = 0;

            int gp1 = 0;
            int gp2 = 0;
            int gp3 = 0;

            int bp1 = 0;
            int bp2 = 0;
            int bp3 = 0;
            int relleno = 128;

            // Si esta fuera de rango regreasmos el relleno
            if (x < 0 || x >= original.Width - 1 || y < 0 || y >= original.Height - 1)
            {
                return Color.FromArgb(relleno, relleno, relleno);
            }

            pisoX = (int)Math.Floor(x);
            pisoY = (int)Math.Floor(y);
            techoX = (int)Math.Ceiling(x);
            techoY = (int)Math.Ceiling(y);

            fraccionX = x - pisoX;
            fraccionY = y - pisoY;

            unoMenosX = 1.0 - fraccionX;
            unoMenosY = 1.0 - fraccionY;

            Color1 = original.GetPixel(pisoX, pisoY);
            Color2 = original.GetPixel(techoX, techoY);

            rp1 = (int)(unoMenosX * Color1.R + fraccionX * Color2.R);
            gp1 = (int)(unoMenosX * Color1.G + fraccionX * Color2.G);
            bp1 = (int)(unoMenosX * Color1.B + fraccionX * Color2.B);

            Color1 = original.GetPixel(pisoX, techoY);
            Color2 = original.GetPixel(techoX, techoY);

            rp2 = (int)(unoMenosX * Color1.R + fraccionX * Color2.R);
            gp2 = (int)(unoMenosX * Color1.G + fraccionX * Color2.G);
            bp2 = (int)(unoMenosX * Color1.B + fraccionX * Color2.B);

            rp3 = (int)(unoMenosY * rp1 + fraccionY * rp2);
            gp3 = (int)(unoMenosY * gp1 + fraccionY * gp2);
            bp3 = (int)(unoMenosY * bp1 + fraccionY * bp2);

            resultado = Color.FromArgb(rp3, gp3, bp3);

            return resultado;
        }

        private Bitmap FishEye(Bitmap original)
        {
            try
            {
                int minValue = 1;
                int maxValue = 100;
                int defaultValue = 50;
                string tituloAmplitud = "Cantidad de Amplitud:";

                // Mostrar un formulario que contenga la barra deslizadora para la amplitud
                using (SliderForm amplitudForm = new SliderForm(minValue, maxValue, defaultValue, tituloAmplitud))
                {
                    if (amplitudForm.ShowDialog() != DialogResult.OK)
                    {
                        // El usuario canceló el formulario
                        MessageBox.Show("Se canceló el proceso.");
                        return null;
                    }

                    float maxAmplitude = (float)amplitudForm.Valor / 100;

                    Bitmap warpedImage = new Bitmap(original.Width, original.Height);
                    BitmapData originalData = original.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                    BitmapData warpedData = warpedImage.LockBits(new Rectangle(0, 0, warpedImage.Width, warpedImage.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                    int centerX = original.Width / 2;
                    int centerY = original.Height / 2;

                    float maxRadius = Math.Min(centerX, centerY);

                    unsafe
                    {
                        byte* originalPtr = (byte*)originalData.Scan0.ToPointer();
                        byte* warpedPtr = (byte*)warpedData.Scan0.ToPointer();

                        for (int y = 0; y < original.Height; y++)
                        {
                            for (int x = 0; x < original.Width; x++)
                            {
                                // Calcular la distancia al centro
                                double distanceToCenter = Math.Sqrt(Math.Pow(x - centerX, 2) + Math.Pow(y - centerY, 2));

                                // Si la distancia está dentro de un rango específico
                                if (distanceToCenter < maxRadius)
                                {
                                    // Calcular las coordenadas polares
                                    double angle = Math.Atan2(y - centerY, x - centerX);

                                    // Modificar la amplitud en función de la distancia desde el centro
                                    float amplitude = maxAmplitude * (float)(1 - distanceToCenter / maxRadius);

                                    // Aplicar la expansión circular
                                    double newRadius = distanceToCenter + amplitude * Math.Pow(distanceToCenter, 2) / maxRadius;

                                    // Convertir de coordenadas polares a cartesianas
                                    int newX = (int)(centerX + newRadius * Math.Cos(angle));
                                    int newY = (int)(centerY + newRadius * Math.Sin(angle));

                                    // Asegurarse de que las nuevas coordenadas estén dentro de los límites de la imagen
                                    newX = Math.Max(0, Math.Min(original.Width - 1, newX));
                                    newY = Math.Max(0, Math.Min(original.Height - 1, newY));

                                    // Bilineal Interpolation
                                    double u = (double)newX - Math.Floor((double)newX);
                                    double v = (double)newY - Math.Floor((double)newY);

                                    int x0 = (int)Math.Floor((double)newX);
                                    int y0 = (int)Math.Floor((double)newY);
                                    int x1 = Math.Min(x0 + 1, original.Width - 1);
                                    int y1 = Math.Min(y0 + 1, original.Height - 1);

                                    int color00 = GetPixel(originalPtr, originalData.Stride, original.Width, original.Height, x0, y0);
                                    int color01 = GetPixel(originalPtr, originalData.Stride, original.Width, original.Height, x0, y1);
                                    int color10 = GetPixel(originalPtr, originalData.Stride, original.Width, original.Height, x1, y0);
                                    int color11 = GetPixel(originalPtr, originalData.Stride, original.Width, original.Height, x1, y1);

                                    int interpolatedColor = BilinearInterpolation(color00, color01, color10, color11, u, v);

                                    // Copiar el color interpolado a la nueva posición
                                    int warpedIndex = y * warpedData.Stride + x * 4;

                                    SetPixel(warpedPtr, warpedIndex, interpolatedColor);
                                }
                                else
                                {
                                    // Si la distancia está fuera del rango, simplemente copiar el píxel original
                                    int originalIndex = y * originalData.Stride + x * 4;
                                    int originalColor = BitConverter.ToInt32(new byte[] { originalPtr[originalIndex], originalPtr[originalIndex + 1], originalPtr[originalIndex + 2], originalPtr[originalIndex + 3] }, 0);
                                    SetPixel(warpedPtr, y * warpedData.Stride + x * 4, originalColor);
                                }
                            }
                        }
                    }

                    original.UnlockBits(originalData);
                    warpedImage.UnlockBits(warpedData);

                    return warpedImage;
                }
            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show($"Error de argumento: {ex.Message}. Detalles: {ex.StackTrace}");
                return null;
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show($"Error de memoria");
                throw; // Propagar la excepción para manejarla en el nivel superior
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar el filtro warp: {ex.Message}");
                return null; // O manejar de otra manera según tus necesidades
            }
        }

        private Bitmap CircularWarp(Bitmap original)
        {
            try
            {
                int minValue = 1;
                int maxValue = 100;
                int defaultValue = 50;
                string tituloAmplitud = "Cantidad de Amplitud:";

                // Mostrar un formulario que contenga la barra deslizadora para la amplitud
                using (SliderForm amplitudForm = new SliderForm(minValue, maxValue, defaultValue, tituloAmplitud))
                {
                    if (amplitudForm.ShowDialog() != DialogResult.OK)
                    {
                        // El usuario canceló el formulario
                        MessageBox.Show("Se canceló el proceso.");
                        return null;
                    }

                    float maxAmplitude = (float)amplitudForm.Valor / 100;

                    Bitmap warpedImage = new Bitmap(original.Width, original.Height);
                    BitmapData originalData = original.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                    BitmapData warpedData = warpedImage.LockBits(new Rectangle(0, 0, warpedImage.Width, warpedImage.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                    int centerX = original.Width / 2;
                    int centerY = original.Height / 2;

                    unsafe
                    {
                        byte* originalPtr = (byte*)originalData.Scan0.ToPointer();
                        byte* warpedPtr = (byte*)warpedData.Scan0.ToPointer();

                        for (int y = 0; y < original.Height; y++)
                        {
                            for (int x = 0; x < original.Width; x++)
                            {
                                // Calcular las coordenadas polares
                                double angle = Math.Atan2(y - centerY, x - centerX);
                                double radius = Math.Sqrt(Math.Pow(x - centerX, 2) + Math.Pow(y - centerY, 2));

                                // Modificar la amplitud en función de la distancia desde el centro con un degradado
                                float gradient = 1 - (float)radius / Math.Max(centerX, centerY); // Puedes ajustar el degradado según tus preferencias
                                float amplitude = maxAmplitude * gradient;

                                // Aplicar la expansión circular
                                double newRadius = radius + amplitude * Math.Pow(radius, 2) / Math.Max(centerX, centerY);

                                // Restringir la amplitud para asegurar que no sea negativa
                                amplitude = Math.Max(0, amplitude);

                                // Convertir de coordenadas polares a cartesianas
                                int newX = (int)(centerX + newRadius * Math.Cos(angle));
                                int newY = (int)(centerY + newRadius * Math.Sin(angle));

                                // Asegurarse de que las nuevas coordenadas estén dentro de los límites de la imagen
                                newX = Math.Max(0, Math.Min(original.Width - 1, newX));
                                newY = Math.Max(0, Math.Min(original.Height - 1, newY));

                                // Bilineal Interpolation
                                double u = (double)newX - Math.Floor((double)newX);
                                double v = (double)newY - Math.Floor((double)newY);

                                int x0 = (int)Math.Floor((double)newX);
                                int y0 = (int)Math.Floor((double)newY);
                                int x1 = Math.Min(x0 + 1, original.Width - 1);
                                int y1 = Math.Min(y0 + 1, original.Height - 1);

                                int color00 = GetPixel(originalPtr, originalData.Stride, original.Width, original.Height, x0, y0);
                                int color01 = GetPixel(originalPtr, originalData.Stride, original.Width, original.Height, x0, y1);
                                int color10 = GetPixel(originalPtr, originalData.Stride, original.Width, original.Height, x1, y0);
                                int color11 = GetPixel(originalPtr, originalData.Stride, original.Width, original.Height, x1, y1);

                                int interpolatedColor = BilinearInterpolation(color00, color01, color10, color11, u, v);

                                // Copiar el color interpolado a la nueva posición
                                int warpedIndex = y * warpedData.Stride + x * 4;

                                SetPixel(warpedPtr, warpedIndex, interpolatedColor);
                            }
                        }
                    }

                    original.UnlockBits(originalData);
                    warpedImage.UnlockBits(warpedData);

                    return warpedImage;
                }
            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show($"Error de argumento: {ex.Message}. Detalles: {ex.StackTrace}");
                return null;
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show($"Error de memoria");
                throw; // Propagar la excepción para manejarla en el nivel superior
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al aplicar el filtro warp: {ex.Message}");
                return null; // O manejar de otra manera según tus necesidades
            }
        }

        private unsafe int GetPixel(byte* data, int stride, int width, int height, int x, int y)
        {
            if (x < 0 || x >= width || y < 0 || y >= height)
            {
                // Coordenadas fuera de límites
                return 0; // o el valor que tenga sentido en tu caso
            }

            int index = y * stride + x * 4;

            if (data == null || index < 0 || index + 3 >= stride * height)
            {
                // Puntero o datos no válidos
                return 0; // o el valor que tenga sentido en tu caso
            }

            return BitConverter.ToInt32(new byte[] { data[index], data[index + 1], data[index + 2], data[index + 3] }, 0);
        }

        private unsafe void SetPixel(byte* data, int index, int color)
        {
            data[index] = (byte)(color & 0xFF);
            data[index + 1] = (byte)((color >> 8) & 0xFF);
            data[index + 2] = (byte)((color >> 16) & 0xFF);
            data[index + 3] = (byte)((color >> 24) & 0xFF);
        }

        private int BilinearInterpolation(int color00, int color01, int color10, int color11, double u, double v)
        {
            double top = (1 - u) * color00 + u * color10;
            double bottom = (1 - u) * color01 + u * color11;
            return (int)((1 - v) * top + v * bottom);
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


        #region ManualDeUsuario

        private int indiceActual = 0;
        List<Image> listaImagenes = new List<Image>();
        // Agrega tus imágenes a la lista

        private void btnFlechaIzquierda_Click(object sender, EventArgs e)
        {

            if (indiceActual > 0)
            {
                indiceActual--;
            }
            else
            {
                // Si estamos en la primera imagen, ir a la última
                indiceActual = listaImagenes.Count - 1;
            }

            pbManualDeUsuario.Image = listaImagenes[indiceActual];
        }

        private void btnFlechaDerecha_Click(object sender, EventArgs e)
        {
            if (indiceActual < listaImagenes.Count - 1)
            {
                indiceActual++;
            }
            else
            {
                // Si estamos en la última imagen, ir a la primera
                indiceActual = 0;
            }

            pbManualDeUsuario.Image = listaImagenes[indiceActual];
        }









        #endregion
    }

}
