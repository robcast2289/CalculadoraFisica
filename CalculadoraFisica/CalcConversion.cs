using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraFisica
{
    public partial class CalcConversion : Form
    {
        List<Valores> Longitud = new List<Valores>();
        List<Valores> Masa = new List<Valores>();
        List<Valores> Tiempo = new List<Valores>();
        int tipo = 0;

        public CalcConversion()
        {
            InitializeComponent();
            cargarLongitud();
            cargarMasa();
            cargarTiempo();

            rbtn1.CheckedChanged += new System.EventHandler(this.radioChange);
            rbtn2.CheckedChanged += new System.EventHandler(this.radioChange);
            rbtn3.CheckedChanged += new System.EventHandler(this.radioChange);
            rbtn1.Checked = true;
        }

        // RC, Reinicia valores del formulario segun el tipo de conversion
        public void configurarForm()
        {
            List<Valores> TipoConversion1 = new List<Valores>();
            List<Valores> TipoConversion2 = new List<Valores>();
            switch (tipo)
            {
                case 1: TipoConversion1 = new List<Valores>(Longitud); TipoConversion2 = new List<Valores>(Longitud); break;
                case 2: TipoConversion1 = new List<Valores>(Masa); TipoConversion2 = new List<Valores>(Masa); break;
                case 3: TipoConversion1 = new List<Valores>(Tiempo); TipoConversion2 = new List<Valores>(Tiempo); break;
            }
            comboBox1.DataSource = TipoConversion1;
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "medidaOriginal";

            comboBox2.DataSource = TipoConversion2;
            comboBox2.DisplayMember = "nombre";
            comboBox2.ValueMember = "medidaOriginal";

            valor1.Text = String.Empty;
            valor2.Text = String.Empty;
        }

        // RC, Se configuran las conversiones de cada tipo a la unidad mas pequeña
        #region Carga de datos
        public void cargarLongitud()
        {
            Longitud.Add(new Valores() { nombre = "Milímetros", medidaOriginal = "mm", medidaMasPequea = 0.1 });
            Longitud.Add(new Valores() { nombre = "Centímetros", medidaOriginal = "cm", medidaMasPequea = 1 });
            Longitud.Add(new Valores() { nombre = "Pulgadas", medidaOriginal = "plg", medidaMasPequea = 2.54 });
            Longitud.Add(new Valores() { nombre = "Pies", medidaOriginal = "pie", medidaMasPequea = 30.48 });
            Longitud.Add(new Valores() { nombre = "Metros", medidaOriginal = "mtr", medidaMasPequea = 100 });
            Longitud.Add(new Valores() { nombre = "Kilómetros", medidaOriginal = "km", medidaMasPequea = 100000 });
            Longitud.Add(new Valores() { nombre = "Millas", medidaOriginal = "mll", medidaMasPequea = 160934 });
        }

        public void cargarMasa()
        {
            Masa.Add(new Valores() { nombre = "Gramos", medidaOriginal = "gr", medidaMasPequea = 1 });
            Masa.Add(new Valores() { nombre = "Onzas", medidaOriginal = "oz", medidaMasPequea = 28.3495 });
            Masa.Add(new Valores() { nombre = "Libras", medidaOriginal = "lb", medidaMasPequea = 453.595 });
            Masa.Add(new Valores() { nombre = "Kilogramos", medidaOriginal = "kg", medidaMasPequea = 1000 });
        }

        public void cargarTiempo()
        {
            Tiempo.Add(new Valores() { nombre = "Segundos", medidaOriginal = "seg", medidaMasPequea = 1 });
            Tiempo.Add(new Valores() { nombre = "Minutos", medidaOriginal = "min", medidaMasPequea = 60 });
            Tiempo.Add(new Valores() { nombre = "Horas", medidaOriginal = "hra", medidaMasPequea = 3600 });
            Tiempo.Add(new Valores() { nombre = "Días", medidaOriginal = "dia", medidaMasPequea = 86400 });
            Tiempo.Add(new Valores() { nombre = "Años", medidaOriginal = "anio", medidaMasPequea = 31536000 });
        }
        #endregion

        // RC, Cambio de tipo de conversion
        private void radioChange(object sender, EventArgs e)
        {
            RadioButton rdbUnidad = (RadioButton)sender;

            if (rdbUnidad.Checked)
            {
                switch (rdbUnidad.Name)
                {
                    case "rbtn1": tipo = 1; break;
                    case "rbtn2": tipo = 2; break;
                    case "rbtn3": tipo = 3; break;
                }
            }
            configurarForm();
        }

        // RC, Valida que solo ingrese datos numericos
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        // RC, Accion al cambiar valores en los textbox
        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                TextBox txtCalc = (TextBox)sender;
                double resultado = 0;
                if (txtCalc.Name == "valor1")
                {
                    if (valor1.Text != String.Empty)
                    {
                        resultado = calculo(comboBox1.SelectedValue.ToString(), Convert.ToDouble(valor1.Text), comboBox2.SelectedValue.ToString());
                        valor2.Text = $"{resultado}";
                    }
                }
                if (txtCalc.Name == "valor2")
                {
                    if (valor2.Text != String.Empty)
                    {
                        resultado = calculo(comboBox2.SelectedValue.ToString(), Convert.ToDouble(valor2.Text), comboBox1.SelectedValue.ToString());
                        valor1.Text = $"{resultado}";
                    }
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // RC, Accion al cambiar los valores de los ComboBox
        private void cbxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox txtCalc = (ComboBox)sender;
                double resultado = 0;
                if (valor1.Text != String.Empty)
                {
                    resultado = calculo(comboBox1.SelectedValue.ToString(), Convert.ToDouble(valor1.Text), comboBox2.SelectedValue.ToString());
                    valor2.Text = $"{resultado}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // RC, Proceso de calculo de conversion
        public double calculo(string _de, double _valorDe, string _a)
        {
            List<Valores> TipoConversion = new List<Valores>();
            switch (tipo)
            {
                case 1: TipoConversion = new List<Valores>(Longitud); break;
                case 2: TipoConversion = new List<Valores>(Masa); break;
                case 3: TipoConversion = new List<Valores>(Tiempo); break;
            }
            Valores Busqueda1 = TipoConversion.Find(x => x.medidaOriginal.Contains(_de));
            Valores Busqueda2 = TipoConversion.Find(x => x.medidaOriginal.Contains(_a));

            double resultado = 0;

            resultado = (_valorDe * Busqueda1.medidaMasPequea) / Busqueda2.medidaMasPequea;
            resultado = Math.Round(resultado, 4, MidpointRounding.ToEven);
            return resultado;
        }
    }

    public class Valores
    {
        public string nombre { get; set; }
        public string medidaOriginal { get; set; }
        public double medidaMasPequea { get; set; }
    }
}
