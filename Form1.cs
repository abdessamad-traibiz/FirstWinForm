using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listVille_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valueselected = listVille.GetItemText(listVille.SelectedItem);
            textAdresse.Text = valueselected;
            //MessageBox.Show(valueselected);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textNom.Text;
            string prenom = textPrenom.Text;
            string adresse = textAdresse.Text;
            MessageBox.Show("InfosUser : \n\n" + "  Nom :" + name + "\n  Prénom : " + prenom + "\n  Adresse : " + adresse);
            groupBox1.Text = "UserInfos";
        }
        }
    }

