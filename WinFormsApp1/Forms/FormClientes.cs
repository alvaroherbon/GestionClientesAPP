using GestionClientesAPP.domain;
using GestionClientesAPP.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClientesAPP.Forms
{
    public partial class FormClientes : Form
    {
        GestionClientesContext context = new GestionClientesContext(); 
        public FormClientes()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(TBnombre.Text, TBrazonSocial.Text, TBtelef1.Text, null, TBnif.Text, TBdir1.Text, TBCP1.Text, TBpoblacion1.Text
                , TBprovincia1.Text, TBpais1.Text, null, null, DTPfecha.Value);
            context.Clientes.Add(cliente);
            context.SaveChanges(); 
         }
    }
}
