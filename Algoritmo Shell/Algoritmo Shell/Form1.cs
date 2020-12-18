using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmo_Shell
{
    public partial class Form1 : Form
    {
        Random aleatorio;
        Shell arrayshell;
        int[] v; // Declaracion del arreglo

        DateTime inicio;
        DateTime final;
        TimeSpan duracion;

        public Form1()
        {
            InitializeComponent();

            arrayshell = new Shell();
            aleatorio = new Random();

            lblTiempo.Visible = false;
            label4.Visible = false;
            txtLista.Visible = false;
            btnLista.Visible = false;

            btnRandom.Visible = false;
            txtMayor.Visible = false;
            txtMenor.Visible = false;
            lbMayorR.Visible = false;
            lbMenorR.Visible = false;

            label2.Visible = false;
            ltbDesordenados.Visible = false;
            label1.Visible = false;
            ltbOrdenados.Visible = false;

            btnLimpiar.Visible = false;
            btnShell.Visible = false;
            lbl5.Visible = false;

        }

        int valor, i = 0;

        private void btnRandom_Click(object sender, EventArgs e)
        {
            ltbDesordenados.Items.Clear();//Limpia el ListBox

            aleatorio = new Random();
            int menor;
            int mayor;

            if (txtMenor.Text == "" || txtMayor.Text=="")
            {
                MessageBox.Show("Introduce el valor menor o mayor de los numeros a generar", "Aviso");
                return;
            }
            menor = int.Parse(txtMenor.Text);
            mayor = int.Parse(txtMayor.Text);

            //ciclo utilizado para proporcionar los numeros aleatoriamente al arreglo
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = aleatorio.Next(menor, mayor);
                ltbDesordenados.Items.Add(v[i]);
            }

            txtMayor.Visible = false;
            txtMenor.Visible = false;
            lbMayorR.Visible = false;
            lbMenorR.Visible = false;

            label4.Visible = false;
            txtLista.Visible = false;
            btnLista.Visible = false;
            btnRandom.Visible = false;

            label2.Visible = true;
            ltbDesordenados.Visible = true;
            label1.Visible = true;
            ltbOrdenados.Visible = true;

            btnLimpiar.Visible = true;
            btnShell.Visible = true;
            lbl5.Visible = true;

            txtMenor.Clear();
            txtMayor.Clear();
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            inicio = DateTime.Now;
            arrayshell.MetodoShell(v);
            final = DateTime.Now;
            duracion = final - inicio;
            lblTiempo.Text = "Tiempo Transcurrido: " + duracion;
            lbl5.Text = "Iteraciones: " + arrayshell.MetodoShell(v);

            //agrega los valores ya ordenados a nuestro vector
            for (int i = 0; i < v.Length; i++)
            {
                ltbOrdenados.Items.Add(v[i]);

            }
            lblTiempo.Visible = true;
            btnShell.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Introducir el tamaño del Arreglo","Aviso");
                return;
            }
            
            v = new int[int.Parse(textBox1.Text)]; //Tamaño del arreglo
            ltbDesordenados.Items.Clear();

            txtMayor.Visible = true;
            txtMenor.Visible = true;
            lbMayorR.Visible = true;
            lbMenorR.Visible = true;

            label3.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;

            label4.Visible = true;
            txtLista.Visible = true;
            btnLista.Visible = true;

            btnRandom.Visible = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ltbDesordenados.Items.Clear();
            ltbOrdenados.Items.Clear();
            lbl5.Visible = false;
            textBox1.Clear();

            lblTiempo.Visible = false;
            label4.Visible = false;
            txtLista.Visible = false;
            btnLista.Visible = false;

            btnRandom.Visible = false;

            label2.Visible = false;
            ltbDesordenados.Visible = false;
            label1.Visible = false;
            ltbOrdenados.Visible = false;

            btnLimpiar.Visible = false;
            btnShell.Visible = false;

            label3.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            if (txtLista.Text == "")
            {
                MessageBox.Show("Ingrese los Valores");
                return;
            }
            valor = int.Parse(txtLista.Text);
            v[i++] = valor;
            ltbDesordenados.Items.Add(v[i - 1]);
            txtLista.Clear();
            txtLista.Focus();

            btnRandom.Visible = false;

            label2.Visible = true;
            ltbDesordenados.Visible = true;
            label1.Visible = true;
            ltbOrdenados.Visible = true;

            btnLimpiar.Visible = true;
            btnShell.Visible = true;
        }
    }
}
