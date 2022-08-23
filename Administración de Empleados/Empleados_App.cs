using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administración_de_Empleados
{
    public partial class frmadminempleados : Form
    {
        public frmadminempleados()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            EmpleadosConexion conexion = new EmpleadosConexion();
            dgvempleados.DataSource = conexion.ListarEmpleados();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Nuevo_Empleado agregarempleado = new Nuevo_Empleado();
            agregarempleado.ShowDialog();
            Cargar();
        }

        private void frmadminempleados_Load(object sender, EventArgs e)
        {
            Cargar();
            dgvempleados.Columns[0].Visible = false;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Empleados empleado;
            empleado = (Empleados)dgvempleados.CurrentRow.DataBoundItem;
            Nuevo_Empleado modificar = new Nuevo_Empleado(empleado);
            modificar.Text = "Modificar Empleado";
            modificar.ShowDialog();
            Cargar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que quiere eliminarlo de forma definitiva?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            EmpleadosConexion conexion = new EmpleadosConexion();
            Empleados empleado = (Empleados)dgvempleados.CurrentRow.DataBoundItem;
            conexion.eliminar(empleado.Id);
            MessageBox.Show("Eliminado correctamente");
            Cargar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            EmpleadosConexion conn = new EmpleadosConexion();
            dgvempleados.DataSource = conn.ListarEmpleados(txtfiltro.Text);
            if (dgvempleados.RowCount == 0)
            {
                MessageBox.Show("No hay Empleados a listar con el filtro indicado", "Filtro",MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargar();
                txtfiltro.Clear();
            }
        }
    }
}
