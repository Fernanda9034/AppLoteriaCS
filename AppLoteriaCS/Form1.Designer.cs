
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
            this.btnTabla = new System.Windows.Forms.Button();
            this.GBCartas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarta)).BeginInit();
            this.GBHistorial.SuspendLayout();
            this.GBCRestantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBCartas
            // 
            this.GBCartas.Controls.Add(this.pbCarta);
            this.GBCartas.Location = new System.Drawing.Point(12, 12);
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
            this.GBHistorial.Location = new System.Drawing.Point(759, 12);
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
            this.GBCRestantes.Location = new System.Drawing.Point(184, 12);
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
            this.label1.Size = new System.Drawing.Size(96, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(61, 207);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente Carta";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnBarajear
            // 
            this.btnBarajear.Location = new System.Drawing.Point(792, 234);
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
            this.btnbuenas.Location = new System.Drawing.Point(389, 430);
            this.btnbuenas.Name = "btnbuenas";
            this.btnbuenas.Size = new System.Drawing.Size(212, 44);
            this.btnbuenas.TabIndex = 6;
            this.btnbuenas.Text = "BUENAS";
            this.btnbuenas.UseVisualStyleBackColor = true;
            this.btnbuenas.Click += new System.EventHandler(this.btnbuenas_Click);
            // 
            // btnTabla
            // 
            this.btnTabla.Location = new System.Drawing.Point(12, 263);
            this.btnTabla.Name = "btnTabla";
            this.btnTabla.Size = new System.Drawing.Size(163, 27);
            this.btnTabla.TabIndex = 7;
            this.btnTabla.Text = "Generar tabla";
            this.btnTabla.UseVisualStyleBackColor = true;
            this.btnTabla.Click += new System.EventHandler(this.btnTabla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 507);
            this.Controls.Add(this.btnTabla);
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnTabla;
    }
}

