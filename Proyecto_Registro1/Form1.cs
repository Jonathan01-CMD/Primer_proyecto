using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Registro1.DAL;
using Proyecto_Registro1.BLL;
using Proyecto_Registro1.Entidades;
using Microsoft.EntityFrameworkCore;


namespace Proyecto_Registro1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            IdNumeroUpDown.Value = 1;
            txt_Roll.Text = string.Empty;
            dateTimePicker1.CustomFormat = " ";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Roles LlenaClase()
        {
            Roles role = new Roles();
            role.Descripcion = txt_Roll.Text;
            role.Rolid = Convert.ToInt32(IdNumeroUpDown.Value);
            role.FechaCreacion = dateTimePicker1.Value;
            return role;
        }
        private void LlenarRoll(Roles roles)
        {
            IdNumeroUpDown.Value = roles.Rolid;
            txt_Roll.Text = roles.Descripcion;
            dateTimePicker1.Value = roles.FechaCreacion;
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();

            ErrorProvider.DataSource = contexto.Roles.ToList();
            contexto.Dispose();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
            Roles role = new Roles();
            bool paso = false;

            if (!Validar())
                return;
            role = LlenaClase();

            if (IdNumeroUpDown.Value == 0)
                paso = BLL.RolesBLL.Guardar(role);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("Roll en uso", "Elija otro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Desea guardar los cambios?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {

                    }
                    else if (result == DialogResult.No)
                    {
                        Limpiar();

                        return;
                    }
                }
                paso = BLL.RolesBLL.Modificar(role);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se guardo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool Validar()
        {
            
            bool paso = true;

            if (txt_Roll.Text == string.Empty)
            {
                errorProvider1.SetError(txt_Roll, "El campo nombre no puede estar vacio");
                txt_Roll.Focus();
                paso = false;
            }
            return paso;

        }

        
        private void LlenarCampo(Roles role)
        {
            IdNumeroUpDown.Value = role.Rolid;
            txt_Roll.Text = role.Descripcion;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Roles role = Roles.Buscar((int)IdNumeroUpDown.Value);

            return (role != null);
        }


        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_Roll_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            int id;
            Roles role = new Roles();
            int.TryParse(IdNumeroUpDown.Text, out id);

            Limpiar();

            role = BLL.RolesBLL.Buscar(id);

            if (role != null)
            {
                MessageBox.Show("Roll En Base de datos");
                LlenarCampo(role);
            }
            else
            {
                MessageBox.Show("Roll no Existe");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd / MM / yyyy";
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            int id;
            int.TryParse(IdNumeroUpDown.Text, out id);

            Limpiar();

            if (RolesBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                errorProvider1.SetError(IdNumeroUpDown, "No se puede eliminar una persona que no existe");
        }
    }
    }

