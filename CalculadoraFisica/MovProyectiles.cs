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
    public partial class MovProyectiles : Form
    {
        List<Variables> lstVariables = new List<Variables>();
        List<Formulas> lstFormulas = new List<Formulas>();
        List<int> ordenFormulas = new List<int>();
        Control tablaFormulas;
        int tipo = 0;

        public MovProyectiles()
        {
            InitializeComponent();
            rbtnTHorizontal.CheckedChanged += new System.EventHandler(this.radioChange);
            rbtnTParabolico.CheckedChanged += new System.EventHandler(this.radioChange);
            rbtnTParabolico.Checked = true;
            cargarFormulas();
        }

        // RC, Proceso de calculo
        private void button1_Click(object sender, EventArgs e)
        {
            reiniciaValores(true);
            cargarVariables();

            bool calculoValor = false;
            do
            {
                calculoValor = false;
                foreach (Variables itemVar in lstVariables)
                {
                    if (!itemVar.contieneValor)
                    {
                        switch (itemVar.variable)
                        {
                            case "Ago": if (calcAgo()) calculoValor = true; break;
                            case "Vo": if (calcVo()) calculoValor = true; break;
                            case "Vox": if(calcVox()) calculoValor = true; break;
                            case "Voy": if (calcVoy()) calculoValor = true; break;
                            case "Vf": if (calcVf()) calculoValor = true; break;
                            case "Vfx": if (calcVfx()) calculoValor = true; break;
                            case "Vfy": if (calcVfy()) calculoValor = true; break;
                            case "X": if (calcX()) calculoValor = true; break;
                            case "Y": if (calcY()) calculoValor = true; break;
                            case "H": if (calcH()) calculoValor = true; break;
                            case "T": if (calcT()) calculoValor = true; break;
                            case "Agf": if (calcAgf()) calculoValor = true; break;
                        }
                    }
                }
            } while (calculoValor == true);

            muestraFormulario();
        }

        // RC, En esta seccion estan los metodos para el calculo de cada una de las variables
        #region Calculo de Variables
        public bool calcVox()
        {
            bool calculo = false;
            double varCalc = 0;
            if (buscaVariables(new List<string> { "Vfx" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("Vox"));
                varCalc = Math.Round(var("Vfx"),2);
                vClass.valor = var("Vfx");
                vClass.contieneValor = true;
                ordenFormulas.Add(26);
                calculo = true;
            }
            else if (buscaVariables(new List<string> { "Ago", "Vo" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("Vox"));
                varCalc = Math.Round(Math.Cos(var("Ago") * (Math.PI / 180)) * var("Vo"), 3);
                vClass.valor = Math.Cos(var("Ago") * (Math.PI / 180)) * var("Vo");
                vClass.contieneValor = true;
                ordenFormulas.Add(1);
                calculo = true;
            }
            else if (buscaVariables(new List<string> { "X", "T" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("Vox"));
                varCalc = Math.Round(var("X") / var("T"), 3);
                vClass.valor = var("X") / var("T");
                vClass.contieneValor = true;
                ordenFormulas.Add(2);
                calculo = true;
            }

            if (calculo)
            {
                txtVox.Text = $"{varCalc}";
            }
            return calculo;
        }

        public bool calcVoy()
        {
            bool calculo = false;
            double varCalc = 0;
            if (buscaVariables(new List<string> { "Ago", "Vo" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("Voy"));
                varCalc = Math.Round(Math.Sin(var("Ago") * (Math.PI / 180)) * var("Vo"), 3);
                vClass.valor = Math.Sin(var("Ago") * (Math.PI / 180)) * var("Vo");
                vClass.contieneValor = true;
                ordenFormulas.Add(3);
                calculo = true;
            }
            else if(buscaVariables(new List<string> { "Vfy", "G", "T" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("Voy"));
                varCalc = Math.Round(var("Vfy") - (var("G") * var("T")), 3);
                vClass.valor = var("Vfy") - (var("G") * var("T"));
                vClass.contieneValor = true;
                ordenFormulas.Add(4);
                calculo = true;
            }
            else if (buscaVariables(new List<string> { "Vfy", "G", "Y" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("Voy"));
                varCalc = Math.Round(Math.Sqrt(Math.Abs(Math.Pow(var("Vfy"), 2) - (2 * var("G") * var("Y")))), 3);
                vClass.valor = Math.Sqrt(Math.Abs(Math.Pow(var("Vfy"), 2) - (2 * var("G") * var("Y"))));
                vClass.contieneValor = true;
                ordenFormulas.Add(5);
                calculo = true;
            }

            if (calculo)
            {
                txtVoy.Text = $"{varCalc}";
            }
            return calculo;
        }

        public bool calcVo()
        {
            bool calculo = false;
            double varCalc = 0;
            if (buscaVariables(new List<string> { "Vox", "Voy" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("Vo"));
                varCalc = Math.Round(Math.Sqrt(Math.Pow(var("Vox"), 2) + Math.Pow(var("Voy"), 2)), 2);
                vClass.valor = Math.Sqrt(Math.Pow(var("Vox"), 2) + Math.Pow(var("Voy"), 2));
                vClass.contieneValor = true;
                ordenFormulas.Add(23);
                calculo = true;
            }

            if (calculo)
            {
                txtVo.Text = $"{varCalc}";
            }
            return calculo;
        }

        public bool calcAgo()
        {
            bool calculo = false;
            double varCalc = 0;
            if (buscaVariables(new List<string> { "Vox", "Voy", "Vo" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("Ago"));
                varCalc = Math.Round((Math.Acos(var("Vox") / var("Vo")) * 180) / Math.PI, 2);
                if (var("Voy") < 0)
                {
                    varCalc = 360 - varCalc;
                    ordenFormulas.Add(21);
                }
                else
                {
                    ordenFormulas.Add(22);
                }
                vClass.valor = varCalc;
                vClass.contieneValor = true;                
                calculo = true;
            }

            if (calculo)
            {
                txtAgo.Text = $"{varCalc}";
            }
            return calculo;
        }

        public bool calcVf()
        {
            bool calculo = false;
            double varCalc = 0;
            if (buscaVariables(new List<string> { "Vfx", "Vfy" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("Vf"));
                varCalc = Math.Round(Math.Sqrt(Math.Pow(var("Vfx"), 2) + Math.Pow(var("Vfy"), 2)), 2);
                vClass.valor = Math.Sqrt(Math.Pow(var("Vfx"), 2) + Math.Pow(var("Vfy"), 2));
                vClass.contieneValor = true;
                ordenFormulas.Add(6);
                calculo = true;
            }

            if (calculo)
            {
                txtVf.Text = $"{varCalc}";
            }
            return calculo;
        }

        public bool calcVfx()
        {
            bool calculo = false;
            double varCalc = 0;
            if (buscaVariables(new List<string> { "Vox" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("Vfx"));
                varCalc = Math.Round(var("Vox"),3);
                vClass.valor = var("Vox");
                vClass.contieneValor = true;
                ordenFormulas.Add(7);
                calculo = true;
            }
            else if (buscaVariables(new List<string> { "Agf", "Vf" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("Vfx"));
                varCalc = Math.Round(Math.Cos(var("Agf") * (Math.PI / 180)) * var("Vf"), 3);
                vClass.valor = Math.Cos(var("Agf") * (Math.PI / 180)) * var("Vf");
                vClass.contieneValor = true;
                ordenFormulas.Add(24);
                calculo = true;
            }

            if (calculo)
            {
                txtVfx.Text = $"{varCalc}";
            }
            return calculo;
        }

        public bool calcVfy()
        {
            bool calculo = false;
            double varCalc = 0;
            if (buscaVariables(new List<string> { "Agf", "Vf" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("Vfy"));
                varCalc = Math.Round(Math.Sin(var("Agf") * (Math.PI / 180)) * var("Vf"), 3);
                vClass.valor = Math.Sin(var("Agf") * (Math.PI / 180)) * var("Vf");
                vClass.contieneValor = true;
                ordenFormulas.Add(25);
                calculo = true;
            }
            else if (buscaVariables(new List<string> { "Voy", "G", "T" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("Vfy"));
                varCalc = Math.Round(var("Voy") + (var("G") * var("T")),3);
                vClass.valor = var("Voy") + (var("G") * var("T"));
                vClass.contieneValor = true;
                ordenFormulas.Add(8);
                calculo = true;
            }
            else if (buscaVariables(new List<string> { "Voy", "G", "Y" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("Vfy"));
                double v1 = Math.Pow(var("Voy"), 2);
                double v2 = 2 * (var("G")) * (var("Y"));
                varCalc = Math.Sqrt(Math.Abs(v2 + v1));
                if (tipo == 1 || var("Y") < 0)
                    varCalc = varCalc * -1;
                else
                {
                    DialogResult opt = MessageBox.Show("¿El objeto está cayendo?", "Mas información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(opt == DialogResult.Yes)
                    {
                        varCalc = varCalc * -1;
                    }
                }
                vClass.valor = varCalc;
                varCalc = Math.Round(varCalc, 3);
                vClass.contieneValor = true;
                ordenFormulas.Add(9);
                calculo = true;
            }

            if (calculo)
            {
                txtVfy.Text = $"{varCalc}";
            }
            return calculo;
        }

        public bool calcX()
        {
            bool calculo = false;
            double varCalc = 0;
            if (buscaVariables(new List<string> { "Vox", "T" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("X"));
                varCalc = Math.Round(var("Vox") * var("T"), 2);
                vClass.valor = var("Vox") * var("T");
                vClass.contieneValor = true;
                ordenFormulas.Add(10);
                calculo = true;
            }
            else if (buscaVariables(new List<string> { "Vfx", "T" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("X"));
                varCalc = Math.Round(var("Vfx") * var("T"), 2);
                vClass.valor = var("Vfx") * var("T");
                vClass.contieneValor = true;
                ordenFormulas.Add(11);
                calculo = true;
            }

            if (calculo)
            {
                txtX.Text = $"{varCalc}";
            }
            return calculo;
        }

        public bool calcY()
        {
            bool calculo = false;
            double varCalc = 0;
            if (buscaVariables(new List<string> { "Voy", "T", "G" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("Y"));
                varCalc = Math.Round((var("Voy") * var("T")) + ((0.5) * (var("G")) * Math.Pow(var("T"), 2)), 2);
                vClass.valor = (var("Voy") * var("T")) + ((0.5) * (var("G")) * Math.Pow(var("T"), 2));
                vClass.contieneValor = true;
                ordenFormulas.Add(12);
                calculo = true;
            }
            else if (buscaVariables(new List<string> { "Vfy", "T", "G" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("Y"));
                varCalc = Math.Round((var("Vfy") * var("T")) - ((0.5) * (var("G")) * Math.Pow(var("T"), 2)), 2);
                vClass.valor = (var("Vfy") * var("T")) - ((0.5) * (var("G")) * Math.Pow(var("T"), 2));
                vClass.contieneValor = true;
                ordenFormulas.Add(13);
                calculo = true;
            }
            else if (buscaVariables(new List<string> { "Voy", "Vfy", "G" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("Y"));
                varCalc = Math.Round((Math.Pow(var("Vfy"), 2) - Math.Pow(var("Voy"), 2)) / (2 * var("G")), 2);
                vClass.valor = (Math.Pow(var("Vfy"), 2) - Math.Pow(var("Voy"), 2)) / (2 * var("G"));
                vClass.contieneValor = true;
                ordenFormulas.Add(14);
                calculo = true;
            }

            if (calculo)
            {
                txtY.Text = $"{varCalc}";
            }
            return calculo;
        }

        public bool calcT()
        {
            bool calculo = false;
            double varCalc = 0;
            if (buscaVariables(new List<string> { "Voy", "Vfy", "G" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("T"));
                varCalc = Math.Abs(Math.Round((var("Vfy") - var("Voy")) / var("G"), 2));
                vClass.valor = varCalc;
                vClass.contieneValor = true;
                ordenFormulas.Add(15);
                calculo = true;
            }
            else if (buscaVariables(new List<string> { "Vox", "X" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("T"));
                varCalc = Math.Abs(Math.Round((var("X") / var("Vox")), 2));
                vClass.valor = varCalc;
                vClass.contieneValor = true;
                ordenFormulas.Add(16);
                calculo = true;
            }
            else if (buscaVariables(new List<string> { "Vfx", "X" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("T"));
                varCalc = Math.Abs(Math.Round((var("X") / var("Vfx")), 2));
                vClass.valor = varCalc;
                vClass.contieneValor = true;
                ordenFormulas.Add(17);
                calculo = true;
            }

            if (calculo)
            {
                txtT.Text = $"{varCalc}";
            }
            return calculo;
        }

        public bool calcH()
        {
            bool calculo = false;
            double varCalc = 0;
            if (buscaVariables(new List<string> { "Voy", "G" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("H"));
                varCalc = Math.Round((0-Math.Pow(var("Voy"), 2)) / (2 * var("G")), 2);
                vClass.valor = varCalc;
                vClass.contieneValor = true;
                ordenFormulas.Add(18);
                calculo = true;
            }            

            if (calculo)
            {
                txtH.Text = $"{varCalc}";
            }
            return calculo;
        }

        public bool calcAgf()
        {
            bool calculo = false;
            double varCalc = 0;
            if (buscaVariables(new List<string> { "Vfx", "Vfy", "Vf" }))
            {
                Variables vClass = lstVariables.Find(x => x.variable.Equals("Agf"));
                varCalc = Math.Round((Math.Acos(var("Vfx") / var("Vf")) * 180) / Math.PI, 2);
                if (var("Vfy") < 0)
                {
                    varCalc = 360 - varCalc;
                    ordenFormulas.Add(19);
                }
                else
                {
                    ordenFormulas.Add(20);
                }
                vClass.valor = varCalc;
                vClass.contieneValor = true;               
                calculo = true;
            }

            if (calculo)
            {
                txtAgf.Text = $"{varCalc}";
            }
            return calculo;
        }
        #endregion

        // RC, Busca las variables necesarias segun formula a utilizar
        public bool buscaVariables(List<string> varBusqueda)
        {
            bool ret = true;

            foreach (string variable in varBusqueda)
            {
                if (!lstVariables.Find(x => x.variable.Equals(variable)).contieneValor)
                    ret = false;
            }

            return ret;
        }

        // RC, Devuelve el valor de la variable
        public double var(string variable)
        {
            return lstVariables.Find(x => x.variable.Equals(variable)).valor;
        }

        // RC, Cambio de tipo tiro
        private void radioChange(object sender, EventArgs e)
        {
            RadioButton rdbUnidad = (RadioButton)sender;

            if (rdbUnidad.Checked)
            {
                switch (rdbUnidad.Name)
                {
                    case "rbtnTHorizontal": tipo = 1; break;
                    case "rbtnTParabolico": tipo = 2; break;
                }
            }
            configurarForm();
        }

        // RC, Configura formulario
        public void configurarForm()
        {
            reiniciaValores();

            switch (tipo)
            {
                case 1:
                    txtAgo.Text = "0";
                    txtAgo.ReadOnly = true;
                    txtAgo.BackColor = SystemColors.Control;
                    break;
                case 2:
                    txtAgo.ReadOnly = false;
                    break;
            }
        }

        // RC, Proceso Limpia datos
        public void reiniciaValores(bool soloCalculados = false)
        {
            if (!soloCalculados)
            {
                if (tipo != 1)
                {
                    txtAgo.Text = String.Empty;
                    txtAgo.BackColor = Color.LightSteelBlue;
                }
                txtVo.Text = String.Empty;
                txtVo.BackColor = Color.LightSteelBlue;
                txtVox.Text = String.Empty;
                txtVox.BackColor = Color.LightSteelBlue;
                txtVoy.Text = String.Empty;
                txtVoy.BackColor = Color.LightSteelBlue;
                txtVf.Text = String.Empty;
                txtVf.BackColor = Color.LightSteelBlue;
                txtVfx.Text = String.Empty;
                txtVfx.BackColor = Color.LightSteelBlue;
                txtVfy.Text = String.Empty;
                txtVfy.BackColor = Color.LightSteelBlue;
                txtX.Text = String.Empty;
                txtX.BackColor = Color.LightSteelBlue;
                txtY.Text = String.Empty;
                txtY.BackColor = Color.LightSteelBlue;
                txtT.Text = String.Empty;
                txtT.BackColor = Color.LightSteelBlue;
                txtAgf.Text = String.Empty;
                txtAgf.BackColor = Color.LightSteelBlue;
                txtH.Text = String.Empty;
            }
            else
            {
                if(tipo != 1)
                    txtAgo.Text = (txtAgo.BackColor == Color.LightSteelBlue ? String.Empty : txtAgo.Text);
                txtVo.Text = (txtVo.BackColor == Color.LightSteelBlue ? String.Empty : txtVo.Text);
                txtVox.Text = (txtVox.BackColor == Color.LightSteelBlue ? String.Empty : txtVox.Text);
                txtVoy.Text = (txtVoy.BackColor == Color.LightSteelBlue ? String.Empty : txtVoy.Text);
                txtVf.Text = (txtVf.BackColor == Color.LightSteelBlue ? String.Empty : txtVf.Text);
                txtVfx.Text = (txtVfx.BackColor == Color.LightSteelBlue ? String.Empty : txtVfx.Text);
                txtVfy.Text = (txtVfy.BackColor == Color.LightSteelBlue ? String.Empty : txtVfy.Text);
                txtX.Text = (txtX.BackColor == Color.LightSteelBlue ? String.Empty : txtX.Text);
                txtY.Text = (txtY.BackColor == Color.LightSteelBlue ? String.Empty : txtY.Text);
                txtT.Text = (txtT.BackColor == Color.LightSteelBlue ? String.Empty : txtT.Text);
                txtAgf.Text = (txtAgf.BackColor == Color.LightSteelBlue ? String.Empty : txtAgf.Text);
                txtH.Text = String.Empty;
            }

            lstVariables.Clear();
            ordenFormulas.Clear();
            panelFormulas.Controls.Remove(tablaFormulas);
        }

        // RC, Validaciones al salir del control
        private void txtData_Leave(object sender, EventArgs e)
        {            
            if (((TextBox)sender).Text != String.Empty)
            {
                try
                {
                    Convert.ToDouble(((TextBox)sender).Text);
                    ((TextBox)sender).BackColor = SystemColors.Window;

                    if (((TextBox)sender).Name == "txtY" && tipo == 1)
                    {
                        ((TextBox)sender).Text = Convert.ToString(Math.Abs(Convert.ToDouble(((TextBox)sender).Text)) * -1);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Los valores ingresados tienen formato incorrecto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ((TextBox)sender).Text = String.Empty;
                }
            }
            else
            {
                ((TextBox)sender).BackColor = Color.LightSteelBlue;
            }
        }

        // RC, Boton Limpia datos
        private void button2_Click(object sender, EventArgs e)
        {
            reiniciaValores();
        }

        // RC, Muestra tabla de formulas
        public void muestraFormulario()
        {
            if (ordenFormulas.Count == 0)
            {
                MessageBox.Show("Datos insuficientes para realizar calculos!!", "Falta Datos", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                // Tabla Datos
                TableLayoutPanel tlpanel = new TableLayoutPanel();
                panelFormulas.Controls.Add(tlpanel);
                tlpanel.ColumnCount = 2;
                tlpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
                tlpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
                tlpanel.RowCount = 1;
                tlpanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

                tlpanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                tlpanel.Location = new System.Drawing.Point(100, 15);
                tlpanel.Size = new System.Drawing.Size(300, (ordenFormulas.Count + 1) * 50 + 10);
                tlpanel.Name = "detalle";


                tlpanel.Controls.Add(new Label() { Text = "Orden", Font = new Font(Font.FontFamily, 10F, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 0, 0);
                tlpanel.Controls.Add(new Label() { Text = "Fórmula", Font = new Font(Font.FontFamily, 10F, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 1, 0);

                foreach (int resul in ordenFormulas)
                {
                    tlpanel.RowCount = tlpanel.RowCount + 1;
                    tlpanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                    tlpanel.Controls.Add(new Label() { Text = $"{tlpanel.RowCount - 1}", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 0, tlpanel.RowCount - 1);
                    tlpanel.Controls.Add(new PictureBox() { Image = lstFormulas.Find(x => x.formula.Equals(resul)).img, Size = new Size(160, 50), SizeMode = PictureBoxSizeMode.StretchImage, Dock = DockStyle.Fill }, 1, tlpanel.RowCount - 1);
                }

                tablaFormulas = tlpanel;

                if(ordenFormulas.Count <= 3)
                    MessageBox.Show("No se lograron calcular todos los datos con la información proporcionada!!", "Cálculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // RC, Carga las variables en el listado
        public void cargarVariables()
        {
            lstVariables.Add(new Variables { variable = "Ago", valor = (txtAgo.Text != String.Empty ? Convert.ToDouble(txtAgo.Text) : 0), contieneValor = (txtAgo.Text != String.Empty ? true : false) });
            lstVariables.Add(new Variables { variable = "Vo", valor = (txtVo.Text != String.Empty ? Convert.ToDouble(txtVo.Text) : 0), contieneValor = (txtVo.Text != String.Empty ? true : false) });
            lstVariables.Add(new Variables { variable = "Vox", valor = (txtVox.Text != String.Empty ? Convert.ToDouble(txtVox.Text) : 0), contieneValor = (txtVox.Text != String.Empty ? true : false) });
            lstVariables.Add(new Variables { variable = "Voy", valor = (txtVoy.Text != String.Empty ? Convert.ToDouble(txtVoy.Text) : 0), contieneValor = (txtVoy.Text != String.Empty ? true : false) });
            lstVariables.Add(new Variables { variable = "Vf", valor = (txtVf.Text != String.Empty ? Convert.ToDouble(txtVf.Text) : 0), contieneValor = (txtVf.Text != String.Empty ? true : false) });
            lstVariables.Add(new Variables { variable = "Vfx", valor = (txtVfx.Text != String.Empty ? Convert.ToDouble(txtVfx.Text) : 0), contieneValor = (txtVfx.Text != String.Empty ? true : false) });
            lstVariables.Add(new Variables { variable = "Vfy", valor = (txtVfy.Text != String.Empty ? Convert.ToDouble(txtVfy.Text) : 0), contieneValor = (txtVfy.Text != String.Empty ? true : false) });
            lstVariables.Add(new Variables { variable = "X", valor = (txtX.Text != String.Empty ? Convert.ToDouble(txtX.Text) : 0), contieneValor = (txtX.Text != String.Empty ? true : false) });
            lstVariables.Add(new Variables { variable = "Y", valor = (txtY.Text != String.Empty ? Convert.ToDouble(txtY.Text) : 0), contieneValor = (txtY.Text != String.Empty ? true : false) });
            lstVariables.Add(new Variables { variable = "H", valor = (txtH.Text != String.Empty ? Convert.ToDouble(txtH.Text) : 0), contieneValor = (txtH.Text != String.Empty ? true : false) });
            lstVariables.Add(new Variables { variable = "T", valor = (txtT.Text != String.Empty ? Convert.ToDouble(txtT.Text) : 0), contieneValor = (txtT.Text != String.Empty ? true : false) });
            lstVariables.Add(new Variables { variable = "G", valor = (txtG.Text != String.Empty ? Convert.ToDouble(txtG.Text) : 0), contieneValor = (txtG.Text != String.Empty ? true : false) });
            lstVariables.Add(new Variables { variable = "Agf", valor = (txtAgf.Text != String.Empty ? Convert.ToDouble(txtAgf.Text) : 0), contieneValor = (txtAgf.Text != String.Empty ? true : false) });
        }

        // RC, Carga las imagenes en el listado
        public void cargarFormulas()
        {
            lstFormulas.Add(new Formulas { formula = 1, img = global::CalculadoraFisica.Properties.Resources.img1 });
            lstFormulas.Add(new Formulas { formula = 2, img = global::CalculadoraFisica.Properties.Resources.img2 });
            lstFormulas.Add(new Formulas { formula = 3, img = global::CalculadoraFisica.Properties.Resources.img3 });
            lstFormulas.Add(new Formulas { formula = 4, img = global::CalculadoraFisica.Properties.Resources.img4 });
            lstFormulas.Add(new Formulas { formula = 5, img = global::CalculadoraFisica.Properties.Resources.img5 });
            lstFormulas.Add(new Formulas { formula = 6, img = global::CalculadoraFisica.Properties.Resources.img6 });
            lstFormulas.Add(new Formulas { formula = 7, img = global::CalculadoraFisica.Properties.Resources.img7 });
            lstFormulas.Add(new Formulas { formula = 8, img = global::CalculadoraFisica.Properties.Resources.img8 });
            lstFormulas.Add(new Formulas { formula = 9, img = global::CalculadoraFisica.Properties.Resources.img9 });
            lstFormulas.Add(new Formulas { formula = 10, img = global::CalculadoraFisica.Properties.Resources.img10 });
            lstFormulas.Add(new Formulas { formula = 11, img = global::CalculadoraFisica.Properties.Resources.img11 });
            lstFormulas.Add(new Formulas { formula = 12, img = global::CalculadoraFisica.Properties.Resources.img12 });
            lstFormulas.Add(new Formulas { formula = 13, img = global::CalculadoraFisica.Properties.Resources.img13 });
            lstFormulas.Add(new Formulas { formula = 14, img = global::CalculadoraFisica.Properties.Resources.img14 });
            lstFormulas.Add(new Formulas { formula = 15, img = global::CalculadoraFisica.Properties.Resources.img15 });
            lstFormulas.Add(new Formulas { formula = 16, img = global::CalculadoraFisica.Properties.Resources.img16 });
            lstFormulas.Add(new Formulas { formula = 17, img = global::CalculadoraFisica.Properties.Resources.img17 });
            lstFormulas.Add(new Formulas { formula = 18, img = global::CalculadoraFisica.Properties.Resources.img18 });
            lstFormulas.Add(new Formulas { formula = 19, img = global::CalculadoraFisica.Properties.Resources.img19 });
            lstFormulas.Add(new Formulas { formula = 20, img = global::CalculadoraFisica.Properties.Resources.img20 });
            lstFormulas.Add(new Formulas { formula = 21, img = global::CalculadoraFisica.Properties.Resources.img21 });
            lstFormulas.Add(new Formulas { formula = 22, img = global::CalculadoraFisica.Properties.Resources.img22 });
            lstFormulas.Add(new Formulas { formula = 23, img = global::CalculadoraFisica.Properties.Resources.img23 });
            lstFormulas.Add(new Formulas { formula = 24, img = global::CalculadoraFisica.Properties.Resources.img24 });
            lstFormulas.Add(new Formulas { formula = 25, img = global::CalculadoraFisica.Properties.Resources.img25 });
            lstFormulas.Add(new Formulas { formula = 26, img = global::CalculadoraFisica.Properties.Resources.img26 });
        }
    }

    public class Formulas
    {
        public int formula { get; set; }
        public Image img { get; set; } 
    }

    public class Variables
    {
        public string variable { get; set; }
        public double valor { get; set; }
        public bool contieneValor { get; set; }
        public int formula { get; set; }
    }
}
