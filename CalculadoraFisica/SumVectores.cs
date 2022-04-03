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
    public partial class SumVectores : Form
    {
        List<Controles> lstControls = new List<Controles>();
        List<Resultados> lstResults = new List<Resultados>();
        Control[] ctrlResultSave = new Control[3];
        public SumVectores()
        {
            InitializeComponent();
            btnCalculaDatos.Enabled = false;
        }

        private void btnCreaControles_Click(object sender, EventArgs e)
        {
            // RC, Genera controles de Vectores
            for (int x = 0; x < nudCantControl.Value; x++)
            {
                Label lbl = new Label();
                lbl.Name = $"Vector{x + 1}";
                lbl.Text = $"Vector {x + 1}";
                lbl.Size = new System.Drawing.Size(50, 20);
                lbl.Location = new System.Drawing.Point(91, 100 + (x * 30));
                panelData.Controls.Add(lbl);

                TextBox txtLong = new TextBox();
                txtLong.Name = $"LongitudVec{x + 1}";
                txtLong.Size = new System.Drawing.Size(62, 20);
                txtLong.Location = new System.Drawing.Point(169, 100 + (x * 30));
                txtLong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
                panelData.Controls.Add(txtLong);

                TextBox txtDire = new TextBox();
                txtDire.Name = $"DireccionVec{x + 1}";
                txtDire.Size = new System.Drawing.Size(39, 20);
                txtDire.Location = new System.Drawing.Point(273, 100 + (x * 30));
                txtDire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
                panelData.Controls.Add(txtDire);

                lstControls.Add(new Controles { orden = x + 1, etiqueta = lbl, longitud = txtLong, direccion = txtDire });
            }

            btnCreaControles.Enabled = false;
            btnCalculaDatos.Enabled = true;
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

        private void btnCalculaDatos_Click(object sender, EventArgs e)
        {
            // Limpia Resultados
            lstResults.Clear();            
            panelResult.Controls.Remove(ctrlResultSave[0]);
            panelResult.Controls.Remove(ctrlResultSave[1]);
            panelResult.Controls.Remove(ctrlResultSave[2]);

            try
            {
                // RC, Calcula las coordenas X y Y de cada Vector 
                double totalx = 0, totaly = 0, totalResult = 0;
                foreach (Controles ctrls in lstControls)
                {
                    Resultados res = new Resultados();
                    double angulo = Convert.ToDouble(((TextBox)ctrls.direccion).Text);
                    double anguloEnRadianes = angulo * Math.PI / 180.0;
                    double coseno = Math.Round(Math.Cos(anguloEnRadianes), 8);
                    double seno = Math.Round(Math.Sin(anguloEnRadianes), 8);
                    res.etiqueta = ctrls.etiqueta.Text;
                    res.valx = Math.Round(coseno * Convert.ToDouble(((TextBox)ctrls.longitud).Text), 2);
                    res.valy = Math.Round(seno * Convert.ToDouble(((TextBox)ctrls.longitud).Text), 2);
                    totalx += res.valx;
                    totaly += res.valy;
                    lstResults.Add(res);
                }

                // RC, Calcula el Vector Resultante
                totalResult = Math.Round(Math.Sqrt(Math.Pow(totalx, 2) + Math.Pow(totaly, 2)), 2);
                double anguloResult = Math.Round((Math.Acos(totalx / totalResult) * 180) / Math.PI, 2);

                // RC, Muestra los resultados
                muestraTablaResultado(totalx, totaly, totalResult, anguloResult);
            }
            catch(Exception)
            {
                MessageBox.Show("Error en los datos proporcionados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                       
        }


        public void muestraTablaResultado(double totalx, double totaly, double totalResult, double anguloResult)
        {
            // Tabla Datos
            TableLayoutPanel tlpanel = new TableLayoutPanel();
            panelResult.Controls.Add(tlpanel);
            tlpanel.ColumnCount = 3;
            tlpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpanel.RowCount = 1;
            tlpanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

            tlpanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlpanel.Location = new System.Drawing.Point(100, 80);
            tlpanel.Size = new System.Drawing.Size(300, (lstResults.Count + 1) * 50);
            tlpanel.Name = "detalle";


            tlpanel.Controls.Add(new Label() { Text = "" }, 0, 0);
            tlpanel.Controls.Add(new Label() { Text = "X", Font = new Font(Font.FontFamily, 10F, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 1, 0);
            tlpanel.Controls.Add(new Label() { Text = "Y", Font = new Font(Font.FontFamily, 10F, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 2, 0);

            foreach (Resultados resul in lstResults)
            {
                tlpanel.RowCount = tlpanel.RowCount + 1;
                tlpanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                tlpanel.Controls.Add(new Label() { Text = resul.etiqueta, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 0, tlpanel.RowCount - 1);
                tlpanel.Controls.Add(new Label() { Text = $"{resul.valx}", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 1, tlpanel.RowCount - 1);
                tlpanel.Controls.Add(new Label() { Text = $"{resul.valy}", TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 2, tlpanel.RowCount - 1);
            }

            // Tabla Totales
            TableLayoutPanel tlpanelTot = new TableLayoutPanel();
            panelResult.Controls.Add(tlpanelTot);
            tlpanelTot.ColumnCount = 3;
            tlpanelTot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlpanelTot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpanelTot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpanelTot.RowCount = 1;
            tlpanelTot.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

            tlpanelTot.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlpanelTot.Location = new System.Drawing.Point(100, 80 + ((lstResults.Count + 1) * 50) + 1);
            tlpanelTot.Size = new System.Drawing.Size(300, 50);
            tlpanelTot.Name = "total";


            tlpanelTot.Controls.Add(new Label() { Text = "TOTAL", Font = new Font(Font.FontFamily, 10F, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 0, 0);
            tlpanelTot.Controls.Add(new Label() { Text = $"{totalx}", Font = new Font(Font.FontFamily, 10F, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 1, 0);
            tlpanelTot.Controls.Add(new Label() { Text = $"{totaly}", Font = new Font(Font.FontFamily, 10F, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.Fill }, 2, 0);

            // Label que muestra Vector Resultante
            Label lblResult = new Label();
            lblResult.Text = $"El Vector Resultante es: {totalResult}, {anguloResult}º {(totaly < 0 ? "por debajo de" : "sobre")} la horizontal";
            lblResult.Name = "lblResult";
            lblResult.Location = new System.Drawing.Point(100, tlpanelTot.Location.Y + 100);
            lblResult.Font = new Font(lblResult.Font.FontFamily, Convert.ToInt16(15));
            lblResult.AutoSize = false;
            lblResult.Size = new Size(300, 100);
            panelResult.Controls.Add(lblResult);

            // Guarda Controles
            ctrlResultSave[0] = tlpanel;
            ctrlResultSave[1] = tlpanelTot;
            ctrlResultSave[2] = lblResult;
        }

        private void btnLimpiaControles_Click(object sender, EventArgs e)
        {
            // Elimina Controles de Vectores
            foreach (Controles ctrl in lstControls)
            {
                panelData.Controls.Remove(ctrl.etiqueta);
                panelData.Controls.Remove(ctrl.longitud);
                panelData.Controls.Remove(ctrl.direccion);
            }

            // Limpia Datos
            lstControls.Clear();
            lstResults.Clear();

            // Elimina Controles de resultados
            panelResult.Controls.Remove(ctrlResultSave[0]);
            panelResult.Controls.Remove(ctrlResultSave[1]);
            panelResult.Controls.Remove(ctrlResultSave[2]);

            // Reinicia botones
            btnCreaControles.Enabled = true;
            btnCalculaDatos.Enabled = false;
        }
    }

    public class Controles
    {
        public int orden { get; set; }
        public Label etiqueta { get; set; }
        public TextBox longitud { get; set; }
        public TextBox direccion { get; set; }
    }

    public class Resultados
    {
        public string etiqueta { get; set; }
        public double valx { get; set;}
        public double valy { get; set; }
    }
}
