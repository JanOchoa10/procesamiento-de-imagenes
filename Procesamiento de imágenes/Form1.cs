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


        int blockWidth = 100;  // Ajusta el ancho del bloque según tus necesidades
        int blockHeight = 100;  // Ajusta la altura del bloque según tus necesidades
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
            //listaImagenes.Add(Properties.Resources.Diapositiva1);
            listaImagenes.Add(Properties.Resources.Diapositiva2);
            listaImagenes.Add(Properties.Resources.Diapositiva3);
            listaImagenes.Add(Properties.Resources.Diapositiva4);
            listaImagenes.Add(Properties.Resources.Diapositiva5);
            listaImagenes.Add(Properties.Resources.Diapositiva6);
            listaImagenes.Add(Properties.Resources.Diapositiva7);
            //listaImagenes.Add(Properties.Resources.Diapositiva8);
            pbManualDeUsuario.Image = Properties.Resources.Diapositiva2;
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
            Bitmap resultante = DegradadoColores(original);

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
            Bitmap resultante = Ruido(original, blockWidth, blockHeight, 50);

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
            Bitmap resultante = Pixelar(original, 10);

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
            Bitmap resultante = Warp(original, 10, 3);

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

        private Bitmap DegradadoColores(Bitmap original)
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

                            // Asignar colores en función de la posición vertical
                            byte gradientColor = (byte)(y * 255 / original.Height);

                            // Establecer el color en la nueva imagen
                            gradientPtr[index] = originalPtr[index]; // Blue
                            gradientPtr[index + 1] = gradientColor;   // Green
                            gradientPtr[index + 2] = gradientColor;   // Red
                            gradientPtr[index + 3] = originalPtr[index + 3]; // Alpha
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

        private Bitmap Ruido(Bitmap original, int blockWidth, int blockHeight, double factorRuido)
        {
            try
            {
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
                return null; // O manejar de otra manera según tus necesidades
            }
        }

        private Bitmap Pixelar(Bitmap original, int blockSize)
        {
            try
            {
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

        private Bitmap Warp(Bitmap original, double amplitude, double frequency)
        {
            try
            {
                Bitmap warpedImage = new Bitmap(original.Width, original.Height);
                BitmapData originalData = original.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                BitmapData warpedData = warpedImage.LockBits(new Rectangle(0, 0, warpedImage.Width, warpedImage.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                unsafe
                {
                    byte* originalPtr = (byte*)originalData.Scan0.ToPointer();
                    byte* warpedPtr = (byte*)warpedData.Scan0.ToPointer();

                    for (int y = 0; y < original.Height; y++)
                    {
                        for (int x = 0; x < original.Width; x++)
                        {
                            // Calcular la nueva posición usando una función sinusoidal
                            int newX = (int)(x + amplitude * Math.Sin(2 * Math.PI * frequency * y / original.Height));
                            int newY = (int)(y + amplitude * Math.Sin(2 * Math.PI * frequency * x / original.Width));

                            // Asegurarse de que las nuevas coordenadas estén dentro de los límites de la imagen
                            newX = Math.Max(0, Math.Min(original.Width - 1, newX));
                            newY = Math.Max(0, Math.Min(original.Height - 1, newY));

                            // Copiar el color de la posición original a la nueva posición
                            int originalIndex = y * originalData.Stride + x * 4;
                            int warpedIndex = newY * warpedData.Stride + newX * 4;

                            for (int i = 0; i < 4; i++)
                            {
                                warpedPtr[warpedIndex + i] = originalPtr[originalIndex + i];
                            }
                        }
                    }
                }

                original.UnlockBits(originalData);
                warpedImage.UnlockBits(warpedData);

                return warpedImage;
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
