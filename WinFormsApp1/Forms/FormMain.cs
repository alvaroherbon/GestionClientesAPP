using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GestionClientesAPP;
using GestionClientesAPP.Forms;

namespace GestionClientesAPP
{
    public partial class FormMain : Form
    {

        private Form formActual;
        Color colorFondo;
        Button selectedButton;

        public FormMain()
        {
            InitializeComponent();
            btnCloseForm.Visible = false;
            colorFondo = Color.FromArgb(205, 194, 190);
        }

        private void openForm(Form form, object sender)
        {
            if (formActual != null)
            {
                formActual.Close();
            }
            formActual = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(form);
            this.panelPrincipal.Tag = form;
            form.BringToFront();
            form.Show();
            labelTitulo.Text = form.Text;
            btnCloseForm.Visible = true;
        }

        private void btnSelected(object sender)
        {
            Button btn = (Button)sender;
            if (selectedButton != null)
            {
                selectedButton.BackColor = colorFondo;
                selectedButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
            selectedButton = btn;
            btn.BackColor = Color.White;
            btn.TextImageRelation = TextImageRelation.TextBeforeImage;
        }


        private void ResetLayout()
        {
            labelTitulo.Text = "Panel Principal";
            btnCloseForm.Visible = false;
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            btnSelected(sender);
            // openForm(new Forms.FormClientes(), sender);
        }

        private void btnArticulos_Click_1(object sender, EventArgs e)
        {
            btnSelected(sender);
            //openForm(new Forms.FormArticulos(), sender);
        }

        private void btnAlbaranes_Click_1(object sender, EventArgs e)
        {
            btnSelected(sender);
            openForm(new FormAlbaranes(), sender);

        }

        private void btnFacturas_Click_1(object sender, EventArgs e)
        {
            btnSelected(sender);
        }

        private void btnNotas_Click_1(object sender, EventArgs e)
        {
            btnSelected(sender);
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            if (formActual != null)
            {
                formActual.Close();
                ResetLayout();
                selectedButton.BackColor = colorFondo;
                selectedButton.TextImageRelation = TextImageRelation.ImageBeforeText;

            }
        }
    }
}