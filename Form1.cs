using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = textBox1.Text;
            String apellido = textBox2.Text;
            String telefono = textBox3.Text;
            String edad = textBox4.Text;
            String estatura = textBox5.Text;
            String genero = " ";
            if (radioButton1.Checked)
            {
                genero = "Hombre";
            }
            else if (radioButton2.Checked)
            {
                genero = "Mujer";
            }

            string datos = $"nombres: {nombre}\r\nApellido: {apellido}\r\nTelefono: {telefono}\r\nEdad: {edad}\r\nEstatura {estatura}\r\nGenero: {genero}\r\n";
            string archivo = "C:\\Users\\User\\Desktop\\pro\\datitos.txt";
            using (StreamWriter writer = new StreamWriter(archivo, true))
            {
                writer.WriteLine(datos);
            }
            MessageBox.Show("datos guardados con exito:\n\n" + datos, "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
