using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrelloLista;

namespace e_commerce_carrello_lista
{
    public partial class Form1 : Form
    {
        private double ptot = 0;
        Carrello c;
        int conta = 0;
        public Form1()
        {
            InitializeComponent();
            c = new Carrello("c1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aggiungi_Click(object sender, EventArgs e)
        {
            //non aggiunge prodotti "invisibili"
            if (textBox1.Text == "")
                return;

            // Recupera l'ID dal TextBox
            string prodottoId = textBox1.Text;
            Prodotto p = null;

            // Recupera il tipo di prodotto selezionato dalla ComboBox
            string tipoProdotto = comboBox1.SelectedItem.ToString();

            // Crea il prodotto in base al tipo selezionato
            if (tipoProdotto == "Elettronico")
            {
                p = new ProdottoElettronico(prodottoId, "ModelloElettronico", "MarcaElettronico", 100);
            }
            else if (tipoProdotto == "Alimentare")
            {
                p = new ProdottoAlimentare(prodottoId, "ModelloAlimentare", "MarcaAlimentare", 100);
            }

            // Se il prodotto è stato creato
            if (p != null)
            {
                // Calcola lo sconto applicato
                double sconto = p.CalcolaSconto();
                double prezzoFinale = p.Prezzo - sconto;
                ptot += prezzoFinale;

                // Aggiunge il prodotto al carrello
                c.aggiungiProdotto(p);
                ListaCarrello.Items.Add(p.Id);
                textBox1.Text = "";
                aggiornaPrezzoProdotti();
                aggiornaNumeroProdotti();
            }

            conta++;
        }

        private void rimuovi_Click(object sender, EventArgs e)
        {
            // Rimuovi in base al testo nella TextBox
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Prodotto p = new Prodotto(textBox1.Text, "modello", "marca", 2);
                c.rimuoviProdotto(p);
                ListaCarrello.Items.Remove(textBox1.Text);
                textBox1.Text = "";
            }

            // Rimuovi elemento selezionato nella ListBox
            else if (ListaCarrello.SelectedItem != null)
            {
                string selezionato = ListaCarrello.SelectedItem.ToString();
                Prodotto p = new Prodotto(selezionato, "modello", "marca", 2);
                aggiornaPrezzoProdotti();
                c.rimuoviProdotto(p);
                ListaCarrello.Items.Remove(selezionato);
            }

            // Verifica se il carrello è vuoto
            if (ListaCarrello.Items.Count == 0)
            {
                MessageBox.Show("Il carrello è vuoto.");
            }

            aggiornaNumeroProdotti();
        }

        private void svuota_Click(object sender, EventArgs e)
        {
            c.svuotaProdotti();

            conta = 0;
            if (ListaCarrello.Items.Count == 0)
            {
                MessageBox.Show("lista gia' vuota.");
            }
            else
            {
                ListaCarrello.Items.Clear();
                MessageBox.Show("E' stato svuotato il carrello.");
            }

            ptot = 0;
            aggiornaPrezzoProdotti();
            aggiornaNumeroProdotti();
        }
        private void aggiornaNumeroProdotti()
        {
            n_prodotti.Text = $"Hai {ListaCarrello.Items.Count} prodotti nel carrello.";
        }

        private void aggiornaPrezzoProdotti()
        {
            PrezzoP.Text = $"{ptot}$";
        }
    }
}
