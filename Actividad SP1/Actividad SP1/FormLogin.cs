using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_SP1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
        int intentos=0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "adm" && txtContrasena.Text == "@1a") && (comboBox1.Text == "ADM" ||
                comboBox1.Text == "VTA" ||
                comboBox1.Text == "COM"))
            {
                this.Hide();
                FrmInicio f = new FrmInicio();
                f.Text = txtUsuario.Text;
                f.ShowDialog();
            }else if(txtUsuario.Text=="jhon"&&txtContrasena.Text=="*2b"&&comboBox1.Text=="SIST"){
                this.Hide();
                FrmInicio f = new FrmInicio();
                f.Text = txtUsuario.Text;
                f.ShowDialog();
            }else if ((txtUsuario.Text=="ceci"&& txtContrasena.Text == "*@3C")&& (comboBox1.Text == "ADM" ||
                comboBox1.Text == "VTA"))
            {
                this.Hide();
                FrmInicio f = new FrmInicio();
                f.Text = txtUsuario.Text;
                f.ShowDialog();
            }else if((txtUsuario.Text=="god" && txtContrasena.Text == "*@#4d")&&(comboBox1.Text == "ADM" ||
                comboBox1.Text == "VTA" ||
                comboBox1.Text == "SIST" ||
                comboBox1.Text == "COM"))
            {
                this.Hide();
                FrmInicio f = new FrmInicio();
                f.Text = txtUsuario.Text;
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("DATOS INCORRECTOS");
                intentos++;
                if(intentos==2){
                    this.Close();
                }
            }
            {

            }
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
