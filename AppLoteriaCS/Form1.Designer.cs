
namespace AppLoteriaCS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GBCartas = new System.Windows.Forms.GroupBox();
            this.pbCarta = new System.Windows.Forms.PictureBox();
            this.GBHistorial = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.GBCRestantes = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnBarajear = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnbuenas = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.nUDTablas = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.GBCartas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarta)).BeginInit();
            this.GBHistorial.SuspendLayout();
            this.GBCRestantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTablas)).BeginInit();
            this.SuspendLayout();
            // 
            // GBCartas
            // 
            this.GBCartas.Controls.Add(this.pbCarta);
            this.GBCartas.Location = new System.Drawing.Point(674, 165);
            this.GBCartas.Name = "GBCartas";
            this.GBCartas.Size = new System.Drawing.Size(163, 189);
            this.GBCartas.TabIndex = 0;
            this.GBCartas.TabStop = false;
            this.GBCartas.Text = "Cartas";
            this.GBCartas.Enter += new System.EventHandler(this.GBCartas_Enter);
            // 
            // pbCarta
            // 
            this.pbCarta.Location = new System.Drawing.Point(7, 17);
            this.pbCarta.Name = "pbCarta";
            this.pbCarta.Size = new System.Drawing.Size(150, 163);
            this.pbCarta.TabIndex = 0;
            this.pbCarta.TabStop = false;
            // 
            // GBHistorial
            // 
            this.GBHistorial.Controls.Add(this.listView1);
            this.GBHistorial.Location = new System.Drawing.Point(872, 99);
            this.GBHistorial.Name = "GBHistorial";
            this.GBHistorial.Size = new System.Drawing.Size(143, 216);
            this.GBHistorial.TabIndex = 1;
            this.GBHistorial.TabStop = false;
            this.GBHistorial.Text = "Historial";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(131, 191);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // GBCRestantes
            // 
            this.GBCRestantes.Controls.Add(this.label1);
            this.GBCRestantes.Location = new System.Drawing.Point(706, 99);
            this.GBCRestantes.Name = "GBCRestantes";
            this.GBCRestantes.Size = new System.Drawing.Size(108, 54);
            this.GBCRestantes.TabIndex = 2;
            this.GBCRestantes.TabStop = false;
            this.GBCRestantes.Text = "Cartas Restantes";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(674, 372);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(157, 23);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente Carta";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnBarajear
            // 
            this.btnBarajear.Location = new System.Drawing.Point(954, 331);
            this.btnBarajear.Name = "btnBarajear";
            this.btnBarajear.Size = new System.Drawing.Size(75, 23);
            this.btnBarajear.TabIndex = 4;
            this.btnBarajear.Text = "Barajear";
            this.btnBarajear.UseVisualStyleBackColor = true;
            this.btnBarajear.Click += new System.EventHandler(this.btnBarajear_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnbuenas
            // 
            this.btnbuenas.Location = new System.Drawing.Point(817, 428);
            this.btnbuenas.Name = "btnbuenas";
            this.btnbuenas.Size = new System.Drawing.Size(212, 44);
            this.btnbuenas.TabIndex = 6;
            this.btnbuenas.Text = "BUENAS";
            this.btnbuenas.UseVisualStyleBackColor = true;
            this.btnbuenas.Click += new System.EventHandler(this.btnbuenas_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(973, 39);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // nUDTablas
            // 
            this.nUDTablas.Location = new System.Drawing.Point(911, 39);
            this.nUDTablas.Name = "nUDTablas";
            this.nUDTablas.Size = new System.Drawing.Size(42, 20);
            this.nUDTablas.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(908, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Numero de NCP´s";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(648, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Acostado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(648, 67);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Parado";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(734, 39);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(68, 17);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Diagonal";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(734, 67);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(78, 17);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "Polla chica";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(817, 39);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(85, 17);
            this.checkBox5.TabIndex = 14;
            this.checkBox5.Text = "Polla grande";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Elige la Jugada:";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(831, 65);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(112, 23);
            this.btnCrear.TabIndex = 16;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 507);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nUDTablas);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnbuenas);
            this.Controls.Add(this.btnBarajear);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.GBCRestantes);
            this.Controls.Add(this.GBHistorial);
            this.Controls.Add(this.GBCartas);
            this.Name = "Form1";
            this.Text = "Loteria Mexicana";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GBCartas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCarta)).EndInit();
            this.GBHistorial.ResumeLayout(false);
            this.GBCRestantes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBCartas;
        private System.Windows.Forms.GroupBox GBHistorial;
        private System.Windows.Forms.GroupBox GBCRestantes;
        private System.Windows.Forms.PictureBox pbCarta;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnBarajear;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnbuenas;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown nUDTablas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCrear;
    }
}

