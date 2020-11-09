using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pet_Care___Login
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Por favor insira valores no Login e Senha", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Dono Dono = new Dono();
                Dono.Login = txtUsername.Text;
                Dono.Password = txtPassword.Text;

                //verifica se o Login já existe
                if (System.IO.File.Exists(@"C:\Users\Public\DataBase\Users\" + Dono.Login + ".txt") == true)
                {
                    MessageBox.Show("Não foi possível cadastrar pois usuário já existe", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    StreamWriter streamWriterUser = new StreamWriter(@"C:\Users\Public\DataBase\Users\" + Dono.Login + ".txt");
                    streamWriterUser.WriteLine(Dono.Password);
                    streamWriterUser.Close();

                    MessageBox.Show("Usuário cadastrado com Sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Dashboard Dashboard = new Dashboard();
                    this.Hide();
                    Dashboard.ShowDialog();
                }
            }
        }
    }
}