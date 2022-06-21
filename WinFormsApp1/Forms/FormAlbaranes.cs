using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using GestionClientesAPP.domain;
using System.Drawing.Printing;
using Microsoft.Reporting.WinForms;
using System.IO;
using GestionClientesAPP.Persistence;
using System.Linq;

namespace GestionClientesAPP.Forms
{
    public partial class FormAlbaranes : Form
    {
        GestionClientesContext context = new GestionClientesContext(); 
        Bitmap bmp; 
        public FormAlbaranes()
        {
            InitializeComponent();
            CBCliente.DataSource = context.Clientes.Select(g => g.clienteID + " " + g.nombre).ToList();
            CBCliente.SelectedItem = CBCliente.Items[0];


        }

        private void btnGuardarLinea_Click(object sender, EventArgs e)
        {
            int n = DGlineas.Rows.Add();
            DGlineas.Rows[n].Cells[0].Value = CBarticulo.SelectedItem;
            DGlineas.Rows[n].Cells[1].Value = TBdescripcion.Text;
            DGlineas.Rows[n].Cells[2].Value = TBunidad.Text;
            DGlineas.Rows[n].Cells[3].Value = TBancho.Text;
            DGlineas.Rows[n].Cells[4].Value = TBalto.Text;
            ResetearLayout(); 

        }

        private void ResetearLayout()
        {
            TBdescripcion.Text = "";
            TBunidad.Text = "";
            TBancho.Text = "";
            TBalto.Text = ""; 
        }

        private void btnEliminarLinea_Click(object sender, EventArgs e) 
        {

                if (DGlineas.SelectedRows.Count >= 1)
                {
                    foreach (DataGridViewRow rows in DGlineas.SelectedRows)
                    {
                        try
                        {
                            DGlineas.Rows.Remove(rows);
                        }
                        catch (System.InvalidOperationException exception)
                        {
                            Debug.WriteLine(exception);
                        }
                    }
                }
                else if (DGlineas.SelectedRows.Count == 0 && DGlineas.Rows.Count > 0)
                {
                try
                {
                    DataGridViewRow lastRow = DGlineas.Rows[(DGlineas.Rows.Count)-1];
                    DGlineas.Rows.Remove(lastRow);
                }
                catch (System.InvalidOperationException exception)
                {
                    Debug.WriteLine(exception);
                }
            }
            
            
            
        }

        private void btnDeshacerLinea_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarLinea_Click(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)CBCliente.SelectedItem;
            String ciudadProvinciaCP = cliente.poblacion + cliente.provincia + cliente.CP;
            List<LineaAlbaran> lineas = new List<LineaAlbaran>();
            foreach (DataGridViewRow row in DGlineas.Rows)
            {
                LineaAlbaran linea = new LineaAlbaran(row.Cells[1].Value.ToString(), int.Parse(row.Cells[2].Value.ToString()), Double.Parse(row.Cells[2].Value.ToString()), Double.Parse(row.Cells[3].Value.ToString()), float.Parse(TBprecio.Text));
                lineas.Add(linea);
            }
            Albaran albaran = new Albaran(DTPfecha.Value, TBalbaran.Text, cliente, TBdireccion.Text, ciudadProvinciaCP, lineas, RTBobservaciones.Text);
            context.Albaranes.Add(albaran);
            context.SaveChanges(); 
                
                



        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

           
        }

        private void btnImpRapida_Click(object sender, EventArgs e)
        {
            String fecha = DTPfecha.Text;
            String cliente = CBarticulo.SelectedItem.ToString();
            String nºalbaran = TBalbaran.Text;
            String direccion = TBdireccion.Text;
            String ciudadProvinciaCP = "xativa";
            String observaciones = RTBobservaciones.Text;
            List<LineaAlbaran> lineas = new List<LineaAlbaran>();
            foreach (DataGridViewRow row in DGlineas.Rows)
            {
                LineaAlbaran linea = new LineaAlbaran(row.Cells[1].Value.ToString(), int.Parse(row.Cells[2].Value.ToString()), Double.Parse(row.Cells[2].Value.ToString()), Double.Parse(row.Cells[3].Value.ToString()), float.Parse(TBprecio.Text));
                lineas.Add(linea);
            }
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
            new Microsoft.Reporting.WinForms.ReportParameter("Cliente", cliente),
            new Microsoft.Reporting.WinForms.ReportParameter("Fecha", fecha),
            new Microsoft.Reporting.WinForms.ReportParameter("NumAlbaran", nºalbaran),
            new Microsoft.Reporting.WinForms.ReportParameter("Dirección", direccion),
            new Microsoft.Reporting.WinForms.ReportParameter("CiudadProvinciaCP", ciudadProvinciaCP),
            new Microsoft.Reporting.WinForms.ReportParameter("Observaciones", observaciones)


        };
            

            PrintDialog printdialog = new PrintDialog(); 
            if (printdialog.ShowDialog() == DialogResult.OK)
            {
                PageSettings settings = new PageSettings(); 
                LocalReport report = new LocalReport();
                using var fs = new FileStream("Reports/albaran.rdlc", FileMode.Open);
                report.LoadReportDefinition(fs);
                ReportDataSource source = new ReportDataSource("lineas", lineas);
                report.DataSources.Add(source);
                report.SetParameters(p);
                settings.PrinterSettings.PrinterName = printdialog.PrinterSettings.PrinterName;
                settings.PrinterSettings.Copies = printdialog.PrinterSettings.Copies;
                settings.PrinterSettings.PrinterName = printdialog.PrinterSettings.PrinterName; 
                report.PrintToPrinter();
            }

        }

        private void btnGenFactura_Click(object sender, EventArgs e)
        {
            //String fecha = DTPfecha.Text;
            //String nºalbaran = TBalbaran.Text;
            //String cliente = CBarticulo.SelectedItem.ToString(); 
            //String direccion = TBdireccion.Text;
            //String ciudadProvinciaCP = "xativa";
            //List<LineaAlbaran> lineas = new List<LineaAlbaran>();  
            //foreach (DataGridViewRow row in DGlineas.Rows)
            //{
            //    LineaAlbaran linea = new LineaAlbaran(row.Cells[1].Value.ToString(), int.Parse(row.Cells[2].Value.ToString()), Double.Parse(row.Cells[2].Value.ToString()), Double.Parse(row.Cells[3].Value.ToString()), float.Parse(TBprecio.Text));
            //    lineas.Add(linea);
            //}
            //String observaciones = RTBobservaciones.Text; 
            //AlbaranTemplate albaran = new AlbaranTemplate();
            //albaran.SetValues(fecha, nºalbaran, cliente, direccion, ciudadProvinciaCP, lineas, observaciones);
            //albaran.Show(); 
        }

        private void CBCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBarticulo.DataSource = null; 
            Cliente cliente = context.Clientes.Find(int.Parse(CBCliente.Text.Split(" ")[0]));
            CBarticulo.DataSource = cliente.articulos.Select(g => g.ArticuloId + " " + g.descripcion).ToList(); 
        }

        private void CBarticulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TBdescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBunidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBancho_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBalto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBprecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBdescuento1_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, -200, 100);
                
        }

       
    }
}
