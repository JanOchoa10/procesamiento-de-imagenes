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

namespace Procesamiento_de_imágenes
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        private Bitmap original;
        private Bitmap resultante;
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerramos la aplicación
            this.Close();
        }

        private void abrirImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                original = (Bitmap)(Bitmap.FromFile(openFileDialog1.FileName));
                anchoVentana = original.Width;
                altoVentana = original.Height;

                resultante = original;

                this.Invalidate();
            }
        }

        private void guardarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                resultante.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Verificamos que se tenga un bitmap instanciado
            if (resultante != null)
            {
                // Obtenemos el objeto graphics
                Graphics g = e.Graphics;

                // Calculamos el scroll
                AutoScrollMinSize = new Size(anchoVentana, altoVentana);

                // Copiamos del bitmap a la ventana
                g.DrawImage(resultante, new Rectangle(this.AutoScrollPosition.X, this.AutoScrollPosition.Y + 30, anchoVentana, altoVentana));

                // Liberamos el recurso
                g.Dispose();
            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;

            resultante = new Bitmap(original.Width, original.Height);

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    resultante.SetPixel(x, y, Color.FromArgb(32, 68, 100));
                }
            }

            this.Invalidate();
        }

        private void invertirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Invertimos la imagen, saca su negativo
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
                    rColor = Color.FromArgb(255 - oColor.R, 255 - oColor.G, 255 - oColor.B);

                    // Colocamos el color en resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }

            this.Invalidate();
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


        private void violetaToolStripMenuItem_Click_1(object sender, EventArgs e)
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
                    rColor = Color.FromArgb(oColor.R, oColor.G, oColor.B);

                    // Colocamos el color en resultante
                    resultante.SetPixel(x, y, rColor);
                }
            }
            this.Invalidate();
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
            // Convertimos la imagen a escala de grises
            int x = 0;
            int y = 0;
            resultante = new Bitmap(original.Width, original.Height);
            Color rColor = new Color();
            Color oColor = new Color();

            float g = 0;

            for (x = 0; x < original.Width; x++)
            {
                for (y = 0; y < original.Height; y++)
                {
                    // Obtenemos el color del pixel
                    oColor = original.GetPixel(x, y);

                    // Procesamos y obtenemos el nuevo color
                    // 0.2126, 0.7152, 0.0722 // Colorimetrica, basada en percepción humana
                    // 0.299,  0.587,  0.114  // Luma, basado en brillo
                    // 0.267,  0.678,  0.0593 // Promedio de los 3 colores

                    g = oColor.R * 0.299f + oColor.G * 0.587f + oColor.B * 0.114f;

                    rColor = Color.FromArgb((int)g, (int)g, (int)g);

                    // Colocamos el color resultante
                    resultante.SetPixel(x, y, rColor);

                }
            }

            this.Invalidate();
        }

    }
}
