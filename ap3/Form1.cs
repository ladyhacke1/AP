using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ap3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //bunifuFormDock1.SubscribeControlToDragEvents(pa);
        }

        //llamados
        Queue<string> ColaName = new Queue<string>();
        Queue<string> ColaName1 = new Queue<string>();
        

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;//minimizamos
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            maximizar.Visible = false;//validamos el boton
            restaurar.Visible = true;

        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            maximizar.Visible = true;
        }

        private void menuside_Click(object sender, EventArgs e)
        {
            if (SideBar.Width == 235)
            {
                SideBar.Visible = false; //para que la animacion funcione el sidebar debe estar oculto y luego llamamos
                SideBar.Width = 68;//cambiar si cambio las medidas
                menu.Width = 90;
                AnimacionSideBar.Show(SideBar);//llamado de la animacion
            }
            else
            {
                SideBar.Visible = false;
                SideBar.Width = 235;
                menu.Width = 254;
                AnimacionSideBarBackoFondo.Show(SideBar);
            }
        }

        private void btnServicioalCliente_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Servicio al cliente");
        }

        private void btnPresentacion_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Presentacion");
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Visualizar");
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Caja");
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Servicio Bancario");
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Ruta de Acceso");
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            int i = 0;
            ColaName.Enqueue(txtName.Text);
            //lbPila.Items.Clear();
            //foreach (var item in PilaName)
            //{
              //  lbPila.Items.Add(item);
                //lbPila.Items.Add("-----");
            //}

            foreach (var item in ColaName)
            {
                
                dgControCaja.Rows.Add();
                dgControCaja.Rows[i].Cells[0].Value = item;
                i++;
            }

            txtName.Clear();
            txtName.Focus();

        }

        private void btnServicioBancario_Click(object sender, EventArgs e)
        {
            int i = 0;
            ColaName1.Enqueue(txtName.Text);

            foreach (var item1 in ColaName1)
            {
                dgMostrarServicioBancario.Rows.Add();
                dgMostrarServicioBancario.Rows[i].Cells[0].Value = item1;

                dgControlServicio.Rows.Add();
                dgControlServicio.Rows[i].Cells[0].Value = item1;
                i++;
            }

            txtName.Clear();
            txtName.Focus();

        }

        private void btnProximoCaja_Click(object sender, EventArgs e)
        {
            int i = 0;

            EnCaja.Items.Clear();
            EnCaja.Items.Add("En caja " + ColaName.Dequeue());//Muestra el que esta en caja

            
            foreach (var item in ColaName)
            {
                dgMostrarCaja.Rows.Add();
                dgMostrarCaja.Rows[i].Cells[0].Value = item;

                dgControCaja1.Rows.Add();
                dgControCaja1.Rows[i].Cells[0].Value = item;
                i++;
            }
        }

        private void btnEnCaja_Click(object sender, EventArgs e)
        {
            
        }
    }
}
