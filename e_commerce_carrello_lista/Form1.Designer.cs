namespace e_commerce_carrello_lista
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
            label3 = new Label();
            prezzo_tot = new Label();
            label5 = new Label();
            prezzoPSingolo = new Label();
            prezzoPScontato = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tipo = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Elettronico", "Alimentare" });
            comboBox1.Location = new Point(105, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 71);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 2;
            label1.Text = "Prodotto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 100);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 3;
            label2.Text = "N. prodotti:";
            // 
            // n_prodotti
            // 
            n_prodotti.AutoSize = true;
            n_prodotti.Location = new Point(393, 100);
            n_prodotti.Name = "n_prodotti";
            n_prodotti.Size = new Size(131, 20);
            n_prodotti.TabIndex = 4;
            n_prodotti.Text = "Il carrello e' vuoto.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(312, 166);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 5;
            label4.Text = "Prezzo scontato:";
            // 
            // PrezzoP
            // 
            PrezzoP.AutoSize = true;
            PrezzoP.Location = new Point(434, 166);
            PrezzoP.Name = "PrezzoP";
            PrezzoP.Size = new Size(25, 20);
            PrezzoP.TabIndex = 6;
            PrezzoP.Text = "0$";
            // 
            // aggiungi
            // 
            aggiungi.Location = new Point(105, 175);
            aggiungi.Name = "aggiungi";
            aggiungi.Size = new Size(185, 40);
            aggiungi.TabIndex = 7;
            aggiungi.Text = "aggiungi";
            aggiungi.UseVisualStyleBackColor = true;
            aggiungi.Click += aggiungi_Click;
            // 
            // rimuovi
            // 
            rimuovi.Location = new Point(105, 220);
            rimuovi.Name = "rimuovi";
            rimuovi.Size = new Size(185, 40);
            rimuovi.TabIndex = 8;
            rimuovi.Text = "rimuovi";
            rimuovi.UseVisualStyleBackColor = true;
            rimuovi.Click += rimuovi_Click;
            // 
            // svuota
            // 
            svuota.Location = new Point(105, 265);
            svuota.Name = "svuota";
            svuota.Size = new Size(185, 40);
            svuota.TabIndex = 9;
            svuota.Text = "svuota";
            svuota.UseVisualStyleBackColor = true;
            svuota.Click += svuota_Click;
            // 
            // ListaCarrello
            // 
            ListaCarrello.FormattingEnabled = true;
            ListaCarrello.Location = new Point(585, 66);
            ListaCarrello.Name = "ListaCarrello";
            ListaCarrello.Size = new Size(203, 264);
            ListaCarrello.TabIndex = 10;
            ListaCarrello.SelectedIndexChanged += ListaCarrello_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 134);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 11;
            label3.Text = "Prezzo totale:";
            // 
            // prezzo_tot
            // 
            prezzo_tot.AutoSize = true;
            prezzo_tot.Location = new Point(417, 134);
            prezzo_tot.Name = "prezzo_tot";
            prezzo_tot.Size = new Size(25, 20);
            prezzo_tot.TabIndex = 12;
            prezzo_tot.Text = "0$";
            prezzo_tot.Click += prezzo_tot_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(585, 43);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 13;
            label5.Text = "Lista prodotti:";
            // 
            // prezzoPSingolo
            // 
            prezzoPSingolo.AutoSize = true;
            prezzoPSingolo.Location = new Point(424, 195);
            prezzoPSingolo.Name = "prezzoPSingolo";
            prezzoPSingolo.Size = new Size(25, 20);
            prezzoPSingolo.TabIndex = 14;
            prezzoPSingolo.Text = "0$";
            // 
            // prezzoPScontato
            // 
            prezzoPScontato.AutoSize = true;
            prezzoPScontato.Location = new Point(485, 223);
            prezzoPScontato.Name = "prezzoPScontato";
            prezzoPScontato.Size = new Size(25, 20);
            prezzoPScontato.TabIndex = 15;
            prezzoPScontato.Text = "0$";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(312, 195);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 16;
            label6.Text = "Prezzo singolo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(312, 223);
            label7.Name = "label7";
            label7.Size = new Size(170, 20);
            label7.TabIndex = 17;
            label7.Text = "Prezzo singolo scontato:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(312, 252);
            label8.Name = "label8";
            label8.Size = new Size(140, 20);
            label8.TabIndex = 18;
            label8.Text = "Tipologia prodotto:";
            // 
            // tipo
            // 
            tipo.AutoSize = true;
            tipo.Location = new Point(447, 252);
            tipo.Name = "tipo";
            tipo.Size = new Size(74, 20);
            tipo.TabIndex = 19;
            tipo.Text = "non selez.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(tipo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(prezzoPScontato);
            Controls.Add(prezzoPSingolo);
            Controls.Add(label5);
            Controls.Add(prezzo_tot);
            Controls.Add(label3);
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
        private Label label3;
        private Label prezzo_tot;
        private Label label5;
        private Label prezzoPSingolo;
        private Label prezzoPScontato;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label tipo;
    }
}
