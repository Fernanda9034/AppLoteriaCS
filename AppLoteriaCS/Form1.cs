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
        PictureBox[,] imagenes = new PictureBox[5, 5];
        PictureBox[,] imagenes2 = new PictureBox[5, 5];
        PictureBox[,] imagenes3 = new PictureBox[5, 5];
        PictureBox[,] imagenes4 = new PictureBox[5, 5];
        PictureBox[,] imagusuario = new PictureBox[5, 5];
        PictureBox[,] imagen = new PictureBox[5, 5];
        PictureBox[,] imagen2 = new PictureBox[6, 9];
        PictureBox[] picBox = new PictureBox[54];
        PictureBox pil;
        Image[] att = new Image[54];
        Image[] lo = new Image[54];
        Image[] wii = new Image[54];
        Image[] wiii = new Image[5];
        Label ganador = new Label();
        int[] numeros = new int[54];
        int x, f, k, m;
        int[] tr = new int[4];

        public Form1()
        {
            pil = new PictureBox();
            InitializeComponent();
            x = 0;
            f = 0;
            ganador.Location = new System.Drawing.Point(8, 58);
            ganador.Size = new System.Drawing.Size(408, 25);
            ganador.Text = "Aparecer";
            //2 arreglo de imagenes
            //tarjetas = new PictureBox[54];
            tablas = new PictureBox[25];
            //inicializarTablas();
        }
        private void imagePictureBox_Click(object sender, System.EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (pic.BackColor == Color.Green)
            {
                pic.BackColor = Color.Transparent;
                x -= 1;
            }
            else
            {
                pic.BackColor = Color.Green;
                x += 1;
            }
        }


        // 3 arreglo imagenes declararlo
        //private void inicializarTablas()
        //{
        //    int r = 0, c = 0;
        //    int[] carta = new int[54];
        //    for (int i = 0; i < carta.Length; i++)
        //    {
        //        carta[i] = i + 1;
        //    }
        //    Random rnd = new Random();
        //    int a, aux;
        //    for (int i = 0; i < carta.Length; i++)
        //    {
        //        a = rnd.Next(carta.Length);
        //        aux = carta[i];
        //        carta[i] = carta[a];
        //        carta[a] = aux;
        //    }

        //    for (int i = 0; i < tablas.Length; i++)
        //    {
        //        tablas[i] = new PictureBox();
        //        tablas[i].Location = new System.Drawing.Point(100 + (c * 90), 25 + (r * 125));
        //        tablas[i].Name = "ImagenTabla" + i;
        //        tablas[i].Size = new System.Drawing.Size(85, 120); //tamaño de la imagen
        //        tablas[i].TabIndex = 0 + i;
        //        tablas[i].SizeMode = PictureBoxSizeMode.StretchImage;
        //        tablas[i].TabStop = false;
        //        tablas[i].Image = Image.FromFile(@"tarjetas\" + (carta[i+1]) + ".jpg");       
        //        this.Controls.Add(tablas[i]);
        //        c++;
        //        if (c == 5)
        //        {
        //            r++;
        //            c = 0;
        //        }
        //    }
        //}
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked == false) && (checkBox2.Checked == false) && (checkBox3.Checked == false) && (checkBox4.Checked == false) && (checkBox5.Checked == false))
            {
                MessageBox.Show("Marca Una Casilla");
            }
            else
            {
                //Zero Tablas NPC´s
                if (nUDTablas.Value == 0)
                {
                    Tablas(imagusuario);
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            imagusuario[i, j].Image = lo[numeros[((i * 5) + j)]];
                            imagusuario[i, j].Click += new System.EventHandler(this.imagePictureBox_Click);
                        }
                    }
                }
                //Una Tabla NPC
                if (nUDTablas.Value == 1)
                {
                    Tablas(imagenes);
                    Tablas(imagusuario);
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            imagenes[i, j].Location = new Point(5 + (i * 55), 125 + (j * 85));
                            imagenes[i, j].Size = new Size(50, 80);
                            imagenes[i, j].Image = lo[numeros[((i * 5) + j)]];
                            //Tabla Usuario
                            imagusuario[i, j].Location = new Point(20 + ((i + 5) * 55), 125 + (j * 85));
                            imagusuario[i, j].Size = new Size(50, 80);
                            imagusuario[i, j].Image = lo[numeros[((i * 5) + j) + 25]];
                            imagusuario[i, j].Click += new System.EventHandler(this.imagePictureBox_Click);
                        }
                    }
                    NumDoblesxT(imagenes);
                    NumDoblesxT(imagusuario);
                }
                //Dos Tablas NPC´s
                if (nUDTablas.Value == 2)
                {
                    Tablas(imagenes);
                    Tablas(imagenes2);
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            imagenes[i, j].Location = new Point(5 + (i * 42), 5 + (j * 65));
                            imagenes[i, j].Size = new Size(37, 60);
                            imagenes[i, j].Image = lo[numeros[((i * 5) + j)]];
                            imagenes2[i, j].Location = new Point(5 + ((i) * 42), 20 + ((j + 5) * 65));
                            imagenes2[i, j].Size = new Size(37, 60);
                            imagenes2[i, j].Image = lo[numeros[((i * 5) + j) + 25]];
                        }
                    }
                    Revolver();
                    Tablas(imagusuario);
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            imagusuario[i, j].Location = new Point(240 + ((i) * 55), 125 + (j * 85));
                            imagusuario[i, j].Size = new Size(50, 80);
                            imagusuario[i, j].Image = lo[numeros[((i * 5) + j)]];
                            imagusuario[i, j].Click += new System.EventHandler(this.imagePictureBox_Click);
                        }
                    }
                    NumDoblesxT(imagenes);
                    NumDoblesxT(imagenes2);
                    NumDoblesxT(imagusuario);
                }

                //Tres Tablas NPC´s
                if (nUDTablas.Value == 3)
                {
                    Tablas(imagenes);
                    Tablas(imagenes2);
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            imagenes[i, j].Location = new Point(5 + (i * 42), 5 + (j * 65));
                            imagenes[i, j].Size = new Size(37, 60);
                            imagenes[i, j].Image = lo[numeros[((i * 5) + j)]];
                            imagenes2[i, j].Location = new Point(20 + ((i + 5) * 42), 170 + ((j) * 65));
                            imagenes2[i, j].Size = new Size(37, 60);
                            imagenes2[i, j].Image = lo[numeros[((i * 5) + j) + 25]];
                        }
                    }
                    Revolver();
                    Tablas(imagenes3);
                    Tablas(imagusuario);
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            imagenes3[i, j].Location = new Point(5 + ((i) * 42), 20 + ((j + 5) * 65));
                            imagenes3[i, j].Size = new Size(37, 60);
                            imagenes3[i, j].Image = lo[numeros[((i * 5) + j)]];
                            //Tabla Usuario
                            imagusuario[i, j].Location = new Point(180 + ((i + 5) * 55), 125 + (j * 85));
                            imagusuario[i, j].Size = new Size(50, 80);
                            imagusuario[i, j].Image = lo[numeros[((i * 5) + j) + 25]];
                            imagusuario[i, j].Click += new System.EventHandler(this.imagePictureBox_Click);
                        }
                    }
                    NumDoblesxT(imagenes);
                    NumDoblesxT(imagenes2);
                    NumDoblesxT(imagenes3);
                    NumDoblesxT(imagusuario);
                }

                //Cuatro Tablas NPC´s
                if (nUDTablas.Value == 4)
                {
                    Tablas(imagenes);
                    Tablas(imagenes2);
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            imagenes[i, j].Location = new Point(5 + (i * 42), 5 + (j * 65));
                            imagenes[i, j].Size = new Size(37, 60);
                            imagenes[i, j].Image = lo[numeros[((i * 5) + j)]];
                            imagenes2[i, j].Location = new Point(20 + ((i + 5) * 42), 5 + ((j) * 65));
                            imagenes2[i, j].Size = new Size(37, 60);
                            imagenes2[i, j].Image = lo[numeros[((i * 5) + j) + 25]];
                        }
                    }
                    Revolver();
                    Tablas(imagenes3);
                    Tablas(imagenes4);
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            imagenes3[i, j].Location = new Point(5 + ((i) * 42), 20 + ((j + 5) * 65));
                            imagenes3[i, j].Size = new Size(37, 60);
                            imagenes3[i, j].Image = lo[numeros[((i * 5) + j)]];
                            imagenes4[i, j].Location = new Point(20 + ((i + 5) * 42), 20 + ((j + 5) * 65));
                            imagenes4[i, j].Size = new Size(37, 60);
                            imagenes4[i, j].Image = lo[numeros[((i * 5) + j) + 25]];
                        }
                    }
                    Revolver();
                    Tablas(imagusuario);
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            imagusuario[i, j].Location = new Point(180 + ((i + 5) * 55), 125 + (j * 85));
                            imagusuario[i, j].Size = new Size(50, 80);
                            imagusuario[i, j].Image = lo[numeros[((i * 5) + j)]];
                            imagusuario[i, j].Click += new System.EventHandler(this.imagePictureBox_Click);
                        }
                    }
                    NumDoblesxT(imagenes);
                    NumDoblesxT(imagenes2);
                    NumDoblesxT(imagenes3);
                    NumDoblesxT(imagenes4);
                    NumDoblesxT(imagusuario);
                }
                label1.Visible = false;
                btnCrear.Visible = false;
                nUDTablas.Visible = false;
                numericUpDown1.Visible = false;
            }

        }
        private void Form1_Load1(object sender, EventArgs e)
        {
            Revolver();
            for (int i = 1; i < 55; i++)
                lo[i - 1] = new System.Drawing.Bitmap(Application.StartupPath + @"\png\" + (i) + ".jpg");
        }
        private void Revolver()
        {
            for (int i = 0; i < 54; i++)
            {
                numeros[i] = (i);
            }

            for (int i = 0; i < 54; i++)
            {
                k = aleat.Next(0, 53);
                m = numeros[k];
                numeros[k] = numeros[i];
                numeros[i] = m;
            }

            for (int i = 0; i < 4; i++)
            {
                tr[i] = i;
            }

            for (int i = 0; i < 4; i++)
            {
                k = aleat.Next(0, 3);
                m = tr[k];
                tr[k] = tr[i];
                tr[i] = m;
            }

        }
        private void DoblesxTabla(PictureBox[,] Dobles)
        {
            if (f < 4)
            {
                Dobles[tr[f], tr[f] + 1].Image = Dobles[tr[f] + 1, tr[f]].Image;
            }
            else
            {
                f = 1;
                Dobles[tr[f], tr[f] + 1].Image = Dobles[tr[f] + 1, tr[f]].Image;
            }

            f += 1;
        }
        private void Doble(PictureBox[,] Dobles2)
        {
            if (f < 4)
            {
                Dobles2[tr[f] + 1, tr[f]].Image = Dobles2[tr[f], tr[f] + 1].Image;
            }
            else
            {
                f = 1;
                Dobles2[tr[f] + 1, tr[f]].Image = Dobles2[tr[f], tr[f] + 1].Image;
            }
            f += 1;
        }

        private void NumDoblesxT(PictureBox[,] arreglo)
        {
            if (numericUpDown1.Value == 1)
            {
                DoblesxTabla(arreglo);
            }
            if (numericUpDown1.Value == 2)
            {
                DoblesxTabla(arreglo);
                Doble(arreglo);
            }
            if (numericUpDown1.Value == 3)
            {
                DoblesxTabla(arreglo);
                Doble(arreglo);
                DoblesxTabla(arreglo);
            }
        }
    }
}
