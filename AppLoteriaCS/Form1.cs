using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace AppLoteriaCS
{
    public partial class Form1 : Form
    {
        Stack<int> cartas = new Stack<int>();
        Random r = new Random();
        int i = 0;
        //int c = 0;
        //int aux;
        //int[,] tabla = new int[5, 5];
        //int[] carta = new int[54];
        //private System.Windows.Forms.PictureBox pictureBox;
        // 1 arreglo de imagene para la tabla
        private PictureBox [] tarjetas;
        private PictureBox[] tablas;
      


        public Form1()
        {
            InitializeComponent();
            //2 arreglo de imagenes
            tarjetas = new PictureBox[54];
            tablas = new PictureBox[25];
            inicializarTabla();
        }

        // 3 arreglo imagenes declararlo
        private void inicializarTabla()
        {
            int r = 0, c = 0; 
            for (int i = 0; i < tablas.Length; i++)
            {
                tablas[i] = new PictureBox();
                tablas[i].Location = new System.Drawing.Point(100 + (c * 90), 25 + (r * 125));
                tablas[i].Name = "ImagenTabla" + i;
                tablas[i].Size = new System.Drawing.Size(85,120); //tamaño de la imagen
                tablas[i].TabIndex = 0 + i;
                tablas[i].SizeMode = PictureBoxSizeMode.StretchImage;
                tablas[i].TabStop = false;
                tablas[i].Image = Image.FromFile(@"tarjetas\" + (i + 1) + ".png");        //aun no funciona
                this.Controls.Add(tablas[i]);
                c++;
                if (c==5)
                {
                    r++;
                    c = 0;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
            this.imageList1.ImageSize = new Size(150,160);
            this.listView1.LargeImageList = this.imageList1;
            //this.pbTabla.ImageLocation = this.imageList1;
            //this.pbTabla.LargeImageList = this.imageList1;
            //this.imageList1.ImageSize = new Size(150, 110);
            //this.pbTabla.ImageLocation = imageList1; //(NO FUNCIONA, FALTA CORROBORAR LO DE LA TABLA Y NO SABEMOS SI EL 
            // ARREGLO DE CARTA PUEDA FUNCIONAR EN ALGO CHTM TE ODIO PROGRAM
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            label1.Text = (54 - cartas.Count()).ToString();
            bool aux = false;
            if (cartas.Count() == 54)
            {
                aux = true;
                MessageBox.Show("Son todas las cartas","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            while (!aux)
            {
                int num = r.Next(1, 54);
                if (!cartas.Contains(num))
                {
                    pbCarta.Image = Image.FromFile(@"C:\Users\Usuario\Pictures\Baraja Loteria\"+num+".png");
                    pbCarta.SizeMode = PictureBoxSizeMode.StretchImage;
                    cartas.Push(num);
                    this.imageList1.Images.Add(Image.FromFile(@"C:\Users\Usuario\Pictures\Baraja Loteria\" + num + ".png"));
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = i;
                    this.listView1.Items.Add(item);
                    aux = true;
                    i++;
                }
            }
        }

        private void btnBarajear_Click(object sender, EventArgs e)
        {
            cartas.Clear();
            imageList1.Images.Clear();
            listView1.Items.Clear();
            pbCarta.Image = null;
            i = 0;
            label1.Text = "";
           
        }
        private void GBCartas_Enter(object sender, EventArgs e)
        {

        }

        private void btnbuenas_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "C:/Users/Usuario/Documents/Sonar.wav";
            //public void Play(string "C:/Users/Usuario/Documents/Sonar.wav");
            //SoundPlayer.Play();

        }

        private void btnTabla_Click(object sender, EventArgs e)
        {

        //    for (int i = 0; i < tabla.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < tabla.GetLength(0); j++)
        //        {
        //            tabla[i, j] = carta[c++];
        //        }
        //    }
        //    //int ar, ac;
        //    //for (int i = 0; i < tabla.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < tabla.GetLength(0); j++)
        //        {
        //            ar = r.Next(5);
        //            ac = r.Next(5);
        //            aux = tabla[i, j];
        //            tabla[i, j] = tabla[ar, ac];
        //            tabla[ar, ac] = aux;
        //        }
        //    }
        }
    }
}
