using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procesamiento_de_imágenes
{
    public partial class Form1 : Form
    {
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
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
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
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                resultante.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Verificamos que se tenga un bitmap instanciado
            if(resultante != null)
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

            for(x=0; x<original.Width; x++)
            {
                for(y=0; y<original.Height; y++)
                {
                    resultante.SetPixel(x, y, Color.FromArgb(32, 68, 100));
                }
            }

            this.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
