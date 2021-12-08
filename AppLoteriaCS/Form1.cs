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
        private PictureBox[] tablas;
        
        public Form1()
        {
            InitializeComponent();
            //2 arreglo de imagenes
            //tarjetas = new PictureBox[54];
            tablas = new PictureBox[25];
            inicializarTablas();
        }
        // 3 arreglo imagenes declararlo
        private void inicializarTablas()
        {
            int r = 0, c = 0;
            int[] carta = new int[54];
            for (int i = 0; i < carta.Length; i++)
            {
                carta[i] = i + 1;
            }
            Random rnd = new Random();
            int a, aux;
            for (int i = 0; i < carta.Length; i++)
            {
                a = rnd.Next(carta.Length);
                aux = carta[i];
                carta[i] = carta[a];
                carta[a] = aux;
            }

            for (int i = 0; i < tablas.Length; i++)
            {
                tablas[i] = new PictureBox();
                tablas[i].Location = new System.Drawing.Point(100 + (c * 90), 25 + (r * 125));
                tablas[i].Name = "ImagenTabla" + i;
                tablas[i].Size = new System.Drawing.Size(85, 120); //tamaño de la imagen
                tablas[i].TabIndex = 0 + i;
                tablas[i].SizeMode = PictureBoxSizeMode.StretchImage;
                tablas[i].TabStop = false;
                tablas[i].Image = Image.FromFile(@"tarjetas\" + (carta[i+1]) + ".jpg");       
                this.Controls.Add(tablas[i]);
                c++;
                if (c == 5)
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
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Buenas.wav");
            player.Play(); 
        }

       
    }
}
