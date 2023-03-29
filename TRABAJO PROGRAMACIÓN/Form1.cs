using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABAJO_PROGRAMACIÓN
{
    public partial class Form1 : Form

    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void USUARIO_Click(object sender, EventArgs e)
        {

        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if(txtusuario.Text=="USUARIO")
            { txtusuario.Text = "";
                txtusuario.ForeColor = Color.Black;
               
            }
    }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "USUARIO";
                txtusuario.ForeColor = Color.DarkGray;

            }
        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "CONTRASEÑA")
            {
                txtcontraseña.Text = "";
                txtcontraseña.ForeColor = Color.Black;
                txtcontraseña.UseSystemPasswordChar = true;

            }
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "")
            {
                txtcontraseña.Text = "CONTRASEÑA";
                txtcontraseña.ForeColor = Color.DarkGray;
                txtcontraseña.UseSystemPasswordChar = false;
            }

        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)

        {
            this.Hide();
         MessageBox.Show($"¡Hola {txtusuario.Text }! Haz click en Aceptar para ingresar al menú principal." ,  "INGRESO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk ); 
             var form = new Form2();
            form.Show();
           
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}