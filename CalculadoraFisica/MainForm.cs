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
    public partial class MainForm : Form
    {

        private Form activeForm = null;

        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelConfigSubmenu.Visible = false;
        }


        private void hideSubMenu()
        {
            panelConfigSubmenu.Visible = (panelConfigSubmenu.Visible ? false : false);
        }

        private void showSubMenu(Panel _subMenu)
        {
            if (!_subMenu.Visible)
            {
                hideSubMenu();
                _subMenu.Visible = true;
            }
            else
            {
                _subMenu.Visible = false;
            }
        }

        private void openChildForm(Form _childForm, Button _btnClick)
        {
            if (activeForm != null)
            {
                closeAllChildForm();
            }
            _btnClick.BackColor = System.Drawing.Color.FromArgb(254, 187, 103);
            activeForm = _childForm;
            _childForm.TopLevel = false;
            _childForm.FormBorderStyle = FormBorderStyle.None;
            _childForm.Dock = DockStyle.Fill;
            panelChildFormContent.Controls.Add(_childForm);
            panelChildFormContent.Tag = _childForm;
            _childForm.BringToFront();
            _childForm.Show();
        }

        public void openSubChildForm(Form _childForm)
        {
            _childForm.TopLevel = false;
            _childForm.FormBorderStyle = FormBorderStyle.None;
            _childForm.Dock = DockStyle.Fill;
            panelChildFormContent.Controls.Add(_childForm);
            panelChildFormContent.Tag = _childForm;
            _childForm.BringToFront();
            _childForm.Show();
        }

        private void closeAllChildForm()
        {

            while (panelChildFormContent.Controls.Count > 0)
            {
                ((Form)panelChildFormContent.Controls[0]).Close();
            }

            btnConversor.BackColor = Color.RoyalBlue;
            btnSolucionProblemas.BackColor = Color.RoyalBlue;
            btnVectores.BackColor = Color.LightSteelBlue;
            btnProyectiles.BackColor = Color.LightSteelBlue;
            btnInfo.BackColor = Color.RoyalBlue;
        }



        #region Botones de Menu

        #region Calculadora

        private void btnConversor_Click(object sender, EventArgs e)
        {
            openChildForm(new CalcConversion(), (Button)sender);

        }

        #endregion


        #region Problemas

        private void btnSolucionProblemas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelConfigSubmenu);
        }

        private void btnVectores_Click(object sender, EventArgs e)
        {
            openChildForm(new SumVectores(), (Button)sender);
        }

        private void btnProyectiles_Click(object sender, EventArgs e)
        {
            openChildForm(new MovProyectiles(), (Button)sender);
        }

        #endregion


        #region Informacion

        private void btnInfo_Click(object sender, EventArgs e)
        {
            openChildForm(new InfoSistema(), (Button)sender);

        }

        #endregion


        private void btnLogoutMenu_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                closeAllChildForm();
            }

            this.Close();
        }


        #endregion
    }
}
