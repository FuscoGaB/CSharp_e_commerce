﻿namespace e_commerce_carrello_lista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            n_prodotti = new Label();
            label4 = new Label();
            PrezzoP = new Label();
            aggiungi = new Button();
            rimuovi = new Button();
            svuota = new Button();
            ListaCarrello = new ListBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Elettronico", "Alimentare" });
            comboBox1.Location = new Point(347, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 28);
            comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(347, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 42);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 2;
            label1.Text = "Prodotto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 282);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 3;
            label2.Text = "N. prodotti:";
            // 
            // n_prodotti
            // 
            n_prodotti.AutoSize = true;
            n_prodotti.Location = new Point(445, 282);
            n_prodotti.Name = "n_prodotti";
            n_prodotti.Size = new Size(0, 20);
            n_prodotti.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 324);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 5;
            label4.Text = "Prezzo:";
            // 
            // PrezzoP
            // 
            PrezzoP.AutoSize = true;
            PrezzoP.Location = new Point(409, 324);
            PrezzoP.Name = "PrezzoP";
            PrezzoP.Size = new Size(0, 20);
            PrezzoP.TabIndex = 6;
            // 
            // aggiungi
            // 
            aggiungi.Location = new Point(348, 165);
            aggiungi.Name = "aggiungi";
            aggiungi.Size = new Size(185, 29);
            aggiungi.TabIndex = 7;
            aggiungi.Text = "aggiungi";
            aggiungi.UseVisualStyleBackColor = true;
            aggiungi.Click += aggiungi_Click;
            // 
            // rimuovi
            // 
            rimuovi.Location = new Point(350, 200);
            rimuovi.Name = "rimuovi";
            rimuovi.Size = new Size(182, 29);
            rimuovi.TabIndex = 8;
            rimuovi.Text = "rimuovi";
            rimuovi.UseVisualStyleBackColor = true;
            rimuovi.Click += rimuovi_Click;
            // 
            // svuota
            // 
            svuota.Location = new Point(350, 235);
            svuota.Name = "svuota";
            svuota.Size = new Size(182, 29);
            svuota.TabIndex = 9;
            svuota.Text = "svuota";
            svuota.UseVisualStyleBackColor = true;
            svuota.Click += svuota_Click;
            // 
            // ListaCarrello
            // 
            ListaCarrello.FormattingEnabled = true;
            ListaCarrello.Location = new Point(638, 14);
            ListaCarrello.Name = "ListaCarrello";
            ListaCarrello.Size = new Size(150, 424);
            ListaCarrello.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListaCarrello);
            Controls.Add(svuota);
            Controls.Add(rimuovi);
            Controls.Add(aggiungi);
            Controls.Add(PrezzoP);
            Controls.Add(label4);
            Controls.Add(n_prodotti);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label n_prodotti;
        private Label label4;
        private Label PrezzoP;
        private Button aggiungi;
        private Button rimuovi;
        private Button svuota;
        private ListBox ListaCarrello;
    }
}