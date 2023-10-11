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
    public partial class SliderForm : MaterialForm
    {
        public int Valor { get { return slider.Value; } }

        public SliderForm(int minValue, int maxValue, int defaultValue, string tituloSlider)
        {
            InitializeComponent();

            // Configurar la barra deslizadora con los valores proporcionados
            slider.RangeMin = minValue;
            slider.RangeMax = maxValue;
            slider.Value = defaultValue;
            slider.Text = tituloSlider;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

}
