using GestionClientesAPP.domain;
using GestionClientesAPP.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClientesAPP.Forms
{
    public partial class FormArticulos : Form
    {

        GestionClientesContext context = new GestionClientesContext(); 
        public FormArticulos()
        {
            InitializeComponent();
            CBCliente.DataSource = context.Clientes.Select(g => g.clienteID + " " + g.nombre).ToList();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Cliente cliente = context.Clientes.Find(int.Parse(CBCliente.Text.Split(" ")[0]));
            Articulo articulo = new Articulo(TBnombreArticulo.Text, float.Parse(TBprecio.Text), double.Parse(CBtipoImpuesto.Text), cliente);
            context.Articulos.Add(articulo);
            cliente.addArticulo(articulo);
            Debug.WriteLine(cliente.articulos.Count());
            context.SaveChanges(); 
                
                }
    }
}
