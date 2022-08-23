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
    public partial class Nuevo_Empleado : Form
    {
        private Empleados empleado = null;
        public Nuevo_Empleado()
        {
            InitializeComponent();
            empleado = new Empleados();
        } 
        public Nuevo_Empleado(Empleados e)
        {
            InitializeComponent();
            empleado = e;
        }

        private void Limpiar()
        {
            txtnombre.Clear();
            txtdni.Clear();
            txtedad.Clear();
            cmbcasado.ResetText();
            txtsalario.Clear();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {

            try
            {

                //Empleados empleado = new Empleados();
                EmpleadosConexion conn = new EmpleadosConexion();
                if (cmbcasado.SelectedItem.ToString() == "Sí")
                {
                    empleado.Casado = true;
                }
                else
                {
                    empleado.Casado = false;
                }
                empleado.DNI = txtdni.Text;
                empleado.Edad = int.Parse(txtedad.Text);
                empleado.NombreCompleto = txtnombre.Text;
                empleado.Salario = decimal.Parse(txtsalario.Text);
                if (empleado.Id == 0)
                {
                    conn.agregar(empleado);
                    MessageBox.Show("Agregado exitosamente","Nuevo");
                }
                else
                {
                    conn.modificar(empleado);
                    MessageBox.Show("Modificado exitosamente","Modificando");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Revise los campos numericos, solo adminiten números.","Error");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Uno o más campos no tienen datos cargados", "Error");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Hubo un error; contactese con su administrador:  " + ex.ToString());
            }
            finally
            {
                Limpiar();
            }
        }

        private void Nuevo_Empleado_Load(object sender, EventArgs e)
        {
            if (empleado.Id != 0)
            {
                //MessageBox.Show(cmbcasado.Items[1].ToString());
                if (empleado.Casado == true)
                {
                    cmbcasado.SelectedIndex = 0;
                }
                else
                {
                    cmbcasado.SelectedIndex = 1;
                }
                txtdni.Text = empleado.DNI;
                txtedad.Text = empleado.Edad.ToString();
                txtnombre.Text = empleado.NombreCompleto;
                txtsalario.Text = empleado.Salario.ToString();
            }
        }
    }
}
