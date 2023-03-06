using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TBdatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\image1.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btn_Escribir_Click(object sender, EventArgs e)
        {
            TextWriter Escribe = new StreamWriter("Test.txt");
            Escribe.WriteLine("HOLA A TODOS DE PARTE DE PACO");
            Escribe.Close();

            StreamWriter agregar = File.AppendText("test.txt");
            agregar.WriteLine("Nueva Linea agregar");
            agregar.Close();

            MessageBox.Show("Listo");

        }

        private void btn_Leer_Click(object sender, EventArgs e)
        {
            TextReader Leer = new StreamReader("Test.txt");
            MessageBox.Show(Leer.ReadToEnd());
            Leer.Close();

        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Busca tu archivo";
                openFileDialog1.ShowDialog();
                string Texto = openFileDialog1.FileName;

                if (File.Exists(openFileDialog1.FileName))
                {

                    TextReader Leer = new StreamReader(Texto);
                    rtxt_Contenido.Text = Leer.ReadToEnd();
                    Leer.Close();

                }
                txt_Direccion.Text = Texto;
            }
            catch (Exception) 
            {
                MessageBox.Show("Error al abrir");

            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if(File.Exists(saveFileDialog1.FileName))
                    {
                        string txt = saveFileDialog1.FileName;
                        StreamWriter textoaguardar = File.CreateText(txt);
                        textoaguardar.Write(rtxt_Contenido.Text);
                        textoaguardar.Flush();
                        textoaguardar.Close();
                        txt_Direccion.Text = txt;
                    }
                    else
                    {
                        string txt = saveFileDialog1.FileName;
                        StreamWriter textoaguardar = File.CreateText(txt);
                        textoaguardar.Write(rtxt_Contenido.Text);
                        textoaguardar.Flush();
                        textoaguardar.Close();
                        txt_Direccion.Text = txt;
                    }

                }

            }
            catch (Exception)
            {

                MessageBox.Show("error al guardar");
            }
        }
    }
}                                                  
