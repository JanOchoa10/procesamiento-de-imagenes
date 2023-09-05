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

namespace Procesamiento_de_imágenes
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        private Bitmap original;
        private Bitmap resultante;
        private Bitmap aux;
        private PictureBox org;
        private int[] histograma = new int[256];
        private int[,] conv3x3 = new int[3, 3];
        private int factor;
        private int offset;

        // Variables para el double buffer y evitar el flicker

        private int anchoVentana, altoVentana;

        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);


            // Creamos el bitmap resultante del cuadro
            resultante = new Bitmap(800, 600);

            // Colocamos los valores para el dibujo con scrolls
            anchoVentana = 800;
            altoVentana = 600;
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerramos la aplicación
            this.Close();
        }

        private void abrirImagenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                original = (Bitmap)(Bitmap.FromFile(openFileDialog1.FileName));
                anchoVentana = original.Width;
                altoVentana = original.Height;

                // Mantén una copia de la imagen original en 'aux'
                aux = new Bitmap(original);

                resultante = original;
                
                org = new PictureBox();
                org.Image = resultante; // Carga la imagen original en el PictureBox org
                pictureBox4.Image = resultante;
                this.Invalidate();
            }

            //OpenFileDialog od = new OpenFileDialog();
            //if(od.ShowDialog() == DialogResult.OK)
            //{
            //    org = new PictureBox();
            //    org.Load(od.FileName);
            //    pictureBox4.Load(od.FileName);
            //}

            materialSlider1.Value = 9;
        }

        private void guardarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                resultante.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        // Función para realizar el dibujo que se puede reutilizar
        private void DibujarImagenEnGraphics(Graphics g)
        {
            // Verificamos que se tenga un bitmap instanciado
            if (resultante != null)
            {
                // Calculamos el scroll
                // AutoScrollMinSize = new Size(anchoVentana, altoVentana);

                // Copiamos del bitmap a la ventana
                //g.DrawImage(resultante, new Rectangle(this.AutoScrollPosition.X, this.AutoScrollPosition.Y + 30, anchoVentana, altoVentana));
            }
        }

        //private void Filtros_Paint(object sender, PaintEventArgs e)
        //{
        //    // Obtenemos el objeto graphics
        //    Graphics g = e.Graphics;

        //    // Llamar a la función de dibujo
        //    DibujarImagenEnGraphics(g);
        //}

        //private void pictureBox3_Paint(object sender, PaintEventArgs e)
        //{
        //    // Obtenemos el objeto graphics
        //    Graphics g = e.Graphics;

        //    // Llamar a la función de dibujo
        //    DibujarImagenEnGraphics(g);
        //}

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            // Obtenemos el objeto graphics
            Graphics g = e.Graphics;

            // Llamar a la función de dibujo
            DibujarImagenEnGraphics(g);
        }


        Image ZoomPicture(Image img, SizeF size)
        {
            int newWidth = (int)(img.Width * size.Width);
            int newHeight = (int)(img.Height * size.Height);

            Bitmap bm = new Bitmap(newWidth, newHeight);
            Graphics gpu = Graphics.FromImage(bm);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            gpu.DrawImage(img, new Rectangle(0, 0, newWidth, newHeight));
            return bm;
        }



        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {
            //materialSlider1.Minimum = -6; // Establece el valor mínimo en negativo
            //materialSlider1.Maximum = 6; // Establece el valor máximo en positivo
            //materialSlider1.SmallChange = 1;
            //materialSlider1.LargeChange = 1;
            //trackBar1.UseWaitCursor = false;



            //    materialSlider1.MinimumSize = 1;
            //    materialSlider1.MaximumSize = 6;
            //    materialSlider1.UseWaitCursor = false;

        }

        //private void trackBar1_Scroll(object sender, EventArgs e)
        //{
        //    // El valor del TrackBar representa la escala del zoom.
        //    float scaleFactor = 1.0f + (float)trackBar1.Value / 10.0f; // 10 es un factor de ajuste

        //    // Aplica el zoom utilizando la función ZoomPicture.
        //    pictureBox4.Image = ZoomPicture(org.Image, new SizeF(scaleFactor, scaleFactor));
        //}

        private void materialSlider1_onValueChanged(object sender, int newValue)
        {
            int sliderValue = materialSlider1.Value;

            sliderValue += 1;

            int sliderRange = 10;
            int sliderZoom = 100 / sliderRange;

            // Ajusta el valor para considerar 5 como 0
            if (sliderValue > sliderRange)
            {
                sliderValue -= sliderRange; // Valores mayores a 5 se vuelven positivos
            }
            else if (sliderValue < sliderRange)
            {
                sliderValue -= sliderRange; // Valores menores a 5 se vuelven negativos
            }
            else
            {
                sliderValue = 0; // 5 se considera como 0
            }

            // Verifica si org.Image y pictureBox4.Image son diferentes de null antes de aplicar el zoom
            if (org != null && org.Image != null && pictureBox4.Image != null)
            {
                if (sliderValue > -sliderRange)
                {
                    // Escala el valor para el zoom
                    float scaleFactor = 1.0f + (float)sliderValue / 10.0f; // 10 es un factor de ajuste

                    // Aplica el zoom utilizando la función ZoomPicture.
                    pictureBox4.Image = ZoomPicture(org.Image, new SizeF(scaleFactor, scaleFactor));
                }
            }
            // Actualiza el texto del label
            materialSlider1.Text = $"Zoom {sliderValue * sliderZoom}%";
        }

        private void materialCard3_Paint(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            org = new PictureBox();
            org.Image = pictureBox4.Image;
        }


        //private void testToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    int x = 0;
        //    int y = 0;

        //    resultante = new Bitmap(original.Width, original.Height);

        //    for (x = 0; x < original.Width; x++)
        //    {
        //        for (y = 0; y < original.Height; y++)
        //        {
        //            resultante.SetPixel(x, y, Color.FromArgb(32, 68, 100));
        //        }
        //    }

        //    this.Invalidate();
        //}

        //private void invertirColoresToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    // Invertimos la imagen, saca su negativo
        //    int x = 0;
        //    int y = 0;
        //    resultante = new Bitmap(original.Width, original.Height);
        //    Color rColor = new Color();
        //    Color oColor = new Color();

        //    for (x = 0; x < original.Width; x++)
        //    {
        //        for (y = 0; y < original.Height; y++)
        //        {
        //            // Obtenemos el color del pixel
        //            oColor = original.GetPixel(x, y);

        //            // Procesamos y obtenemos el nuevo color
        //            rColor = Color.FromArgb(255 - oColor.R, 255 - oColor.G, 255 - oColor.B);

        //            // Colocamos el color en resultante
        //            resultante.SetPixel(x, y, rColor);
        //        }
        //    }

        //    org = new PictureBox();
        //    org.Image = resultante; // Carga la imagen original en el PictureBox org
        //    pictureBox4.Image = resultante;

        //    this.Invalidate();

        //}

        private void invertirColoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Invertimos los colores
            // Crear una copia de la imagen original
            Bitmap originalCopy = new Bitmap(original.Width, original.Height, original.PixelFormat);

            // Invertir la imagen original y guardarla en resultante
            for (int x = 0; x < originalCopy.Width; x++)
            {
                for (int y = 0; y < originalCopy.Height; y++)
                {
                    Color oColor = original.GetPixel(x, y);
                    Color rColor = Color.FromArgb(oColor.A, 255 - oColor.R, 255 - oColor.G, 255 - oColor.B);
                    resultante.SetPixel(x, y, rColor);
                }
            }

            // Asignar resultante a pictureBox4 manteniendo el mismo tamaño

            pictureBox4.Image = resultante;

            // Refrescar el PictureBox
            pictureBox4.Refresh();

            // Limpiar la imagen original copiada
            originalCopy.Dispose();


            materialSlider1_onValueChanged(sender, 0);
        }


        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Filtro de color, solo presenta los pixeles de un componente y elimina los otros dos
            int x = 0;
            int y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    // Obtenemos el color del pixel
                    oColor = original.GetPixel(x, y);

                    // Procesamos y obtenemos el nuevo color
                    rColor = Color.FromArgb(oColor.R, 0, 0);

                    // Colocamos el color en resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }
            this.Invalidate();
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Filtro de color, solo presenta los pixeles de un componente y elimina los otros dos
            int x = 0;
            int y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    // Obtenemos el color del pixel
                    oColor = original.GetPixel(x, y);

                    // Procesamos y obtenemos el nuevo color
                    rColor = Color.FromArgb(0, oColor.G, 0);

                    // Colocamos el color en resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }
            this.Invalidate();
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Filtro de color, solo presenta los pixeles de un componente y elimina los otros dos
            int x = 0;
            int y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    // Obtenemos el color del pixel
                    oColor = original.GetPixel(x, y);

                    // Procesamos y obtenemos el nuevo color
                    rColor = Color.FromArgb(0, 0, oColor.B);

                    // Colocamos el color en resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }
            this.Invalidate();
        }

        private void amarilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Filtro de color, solo presenta los pixeles de un componente y elimina los otros dos
            int x = 0;
            int y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    // Obtenemos el color del pixel
                    oColor = original.GetPixel(x, y);

                    // Procesamos y obtenemos el nuevo color
                    rColor = Color.FromArgb(oColor.R, oColor.G, 0);

                    // Colocamos el color en resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }
            this.Invalidate();
        }

        private void violetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Filtro de color, solo presenta los pixeles de un componente y elimina los otros dos
            int x = 0;
            int y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    // Obtenemos el color del pixel
                    oColor = original.GetPixel(x, y);

                    // Procesamos y obtenemos el nuevo color
                    rColor = Color.FromArgb(oColor.R, 0, oColor.B);

                    // Colocamos el color en resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }
            this.Invalidate();
        }

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Filtro de color, solo presenta los pixeles de un componente y elimina los otros dos
            int x = 0;
            int y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    // Obtenemos el color del pixel
                    oColor = original.GetPixel(x, y);

                    // Procesamos y obtenemos el nuevo color
                    rColor = Color.FromArgb(0, oColor.G, oColor.B);

                    // Colocamos el color en resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }
            this.Invalidate();
        }

        private void revertirCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Filtro de color, solo presenta los pixeles de un componente y elimina los otros dos
            // Crear una copia de la imagen original
            Bitmap originalCopy = new Bitmap(aux.Width, aux.Height, aux.PixelFormat);

            for (int x = 0; x < originalCopy.Width; x++)
            {
                for (int y = 0; y < originalCopy.Height; y++)
                {
                    // Obtenemos el color del pixel
                    Color oColor = aux.GetPixel(x, y);

                    // Procesamos y obtenemos el nuevo color
                    Color rColor = Color.FromArgb(oColor.A, oColor.R, oColor.G, oColor.B);

                    // Colocamos el color en resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }
            // Asignar resultante a pictureBox4 manteniendo el mismo tamaño

            pictureBox4.Image = resultante;

            // Refrescar el PictureBox
            pictureBox4.Refresh();

            // Limpiar la imagen original copiada
            originalCopy.Dispose();


            materialSlider1_onValueChanged(sender, 0);
        }

        private void aberraciónCromáticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            int a = 5; // Tamaño de la aberración

            int r = 0;
            int g = 0;
            int b = 0;

            resultante = new Bitmap(original.Width, original.Height);

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    // Obtenemos el verde
                    g = original.GetPixel(x, y).G;

                    // Obtenemos el rojo
                    if (x + a < original.Width)
                    {
                        r = original.GetPixel(x + a, y).R;
                    }
                    else
                    {
                        r = 0;
                    }

                    // Obtenemos el azul
                    if (x - a >= 0)
                    {
                        b = original.GetPixel(x - a, y).B;
                    }
                    else
                    {
                        b = 0;
                    }

                    // Colocamos el pixel
                    resultante.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            this.Invalidate();

        }

        private void escalaDeGrisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una copia de la imagen original con el mismo tamaño y formato
            Bitmap originalCopy = new Bitmap(original.Width, original.Height, original.PixelFormat);

            float g = 0;

            for (int x = 0; x < originalCopy.Width; x++)
            {
                for (int y = 0; y < originalCopy.Height; y++)
                {
                    // Obtenemos el color del pixel
                    Color oColor = original.GetPixel(x, y);

                    // Procesamos y obtenemos el nuevo color
                    g = oColor.R * 0.299f + oColor.G * 0.587f + oColor.B * 0.114f;

                    // Conservamos el canal alfa original
                    Color rColor = Color.FromArgb(oColor.A, (int)g, (int)g, (int)g);

                    // Colocamos el color resultante en la copia
                    resultante.SetPixel(x, y, rColor);
                }
            }

            // Asignar la copia al pictureBox4
            org.Image = resultante;
            pictureBox4.Image = resultante;

            // Refrescar el PictureBox
            pictureBox4.Refresh();

            // No es necesario liberar la memoria de la copia aquí, ya que no es necesario.
            originalCopy.Dispose();


            materialSlider1_onValueChanged(sender, 0);
        }


    }
}
