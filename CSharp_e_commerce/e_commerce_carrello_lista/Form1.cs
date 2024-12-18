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
        private double pFinale = 0;
        private double pScontato = 0;
        Carrello c;
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

        public void aggiungi_Click(object sender, EventArgs e)
        {
            //non aggiunge prodotti "invisibili"
            if (textBox1.Text == "")
            {
                MessageBox.Show("inserisci nome prodotto.");
                return;
            }

            string prodottoId = textBox1.Text;
            Prodotto p = null;

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("seleziona un tipo di prodotto.");
                return;
            }

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

            if (p != null)
            {
                double sconto = p.CalcolaSconto();
                double prezzoSconto = p.Prezzo - sconto;
                pScontato += prezzoSconto;
                pFinale += p.Prezzo;

                bool prodottoEsistente = false;
                foreach (Prodotto prodotto in c.Lista)
                {
                    if (prodotto.Id == p.Id)
                    {
                        prodottoEsistente = true;
                        break;
                    }
                }

                if (prodottoEsistente)
                {
                    MessageBox.Show($"Il prodotto con nome '{p.Id}' è già nel carrello.");
                }
                else
                {
                    c.aggiungiProdotto(p);
                    if (tipoProdotto == "Elettronico")
                    {
                        ListaCarrello.Items.Add(p.Id + " -E");
                    }
                    else if (tipoProdotto == "Alimentare")
                    {
                        ListaCarrello.Items.Add(p.Id + " -A");
                    }
                    //ListaCarrello.Items.Add(p.Id);
                    textBox1.Text = "";
                    aggiornaPrezzoProdotti();
                    aggiornaNumeroProdotti();
                }
            }
        }

        private void rimuovi_Click(object sender, EventArgs e)
        {
            Prodotto prodottoDaRimuovere = null;

            // Rimuove in base al testo nella TextBox
            if (textBox1.Text != null && textBox1.Text != "")
            {
                foreach (Prodotto p in c.Lista)
                {
                    if (p.Id == textBox1.Text)
                    {
                        prodottoDaRimuovere = p;
                        break;
                    }
                }

                if (prodottoDaRimuovere != null)
                {
                    c.rimuoviProdotto(prodottoDaRimuovere);
                    ListaCarrello.Items.Remove(textBox1.Text);
                    textBox1.Text = "";
                }
            }

            // Rimuove elemento selezionato nella ListBox
            else if (ListaCarrello.SelectedItem != null)
            {
                string selezionato = ListaCarrello.SelectedItem.ToString();
                foreach (Prodotto p in c.Lista)
                {
                    if (p.Id == selezionato)
                    {
                        prodottoDaRimuovere = p;// Lo assegno quindi fanno riferimanto allo stesso oggetto
                        break;
                    }
                }

                if (prodottoDaRimuovere != null)
                {
                    c.rimuoviProdotto(prodottoDaRimuovere);
                    ListaCarrello.Items.Remove(selezionato);
                }
            }

            // Aggiorna i prezzi del carrello
            if (prodottoDaRimuovere != null)
            {
                double sconto = prodottoDaRimuovere.CalcolaSconto();
                double prezzoSconto = prodottoDaRimuovere.Prezzo - sconto;

                pScontato -= prezzoSconto;
                pFinale -= prodottoDaRimuovere.Prezzo;
            }

            if (ListaCarrello.Items.Count == 0)
            {
                MessageBox.Show("Il carrello è vuoto.");
            }

            aggiornaPrezzoProdotti();
            aggiornaNumeroProdotti();
        }

        private void svuota_Click(object sender, EventArgs e)
        {
            c.svuotaProdotti();

            if (ListaCarrello.Items.Count == 0)
            {
                MessageBox.Show("carrello gia' vuoto.");
            }
            else
            {
                ListaCarrello.Items.Clear();
                MessageBox.Show("È stato svuotato il carrello.");
            }

            pScontato = 0;
            pFinale = 0;
            aggiornaPrezzoProdotti();
            aggiornaNumeroProdotti();
        }
        private void aggiornaNumeroProdotti()
        {
            if (ListaCarrello.Items.Count == 1)
            {
                n_prodotti.Text = $"Hai {ListaCarrello.Items.Count} prodotto nel carrello.";
            }
            else if (ListaCarrello.Items.Count > 1)
            {
                n_prodotti.Text = $"Hai {ListaCarrello.Items.Count} prodotti nel carrello.";
            }
            else
            {
                n_prodotti.Text = "Il carrello e' vuoto.";
            }
        }


        private void aggiornaPrezzoProdotti()
        {
            PrezzoP.Text = $"{pScontato}$";
            prezzo_tot.Text = $"{pFinale}$";
            prezzosingolo();
        }
        private void prezzosingolo()
        {
            if (ListaCarrello.SelectedItem == null)
            {
                prezzoPScontato.Text = "non acc.";
                prezzoPSingolo.Text = "non acc.";
                return;
            }

            string selezionato = ListaCarrello.SelectedItem.ToString();

            if (selezionato != null)
            { 
                foreach (Prodotto p in c.Lista)
                {
                    if (p.Id == selezionato) 
                    {
                        double sconto = p.CalcolaSconto();
                        double prezzoScontato = p.Prezzo - sconto;

                        prezzoPScontato.Text = $"{prezzoScontato}";
                        prezzoPSingolo.Text = $"{p.Prezzo}";
                        return;
                    }
                }
            }
            
        }
        private void prezzo_tot_Click(object sender, EventArgs e)
        {

        }

        private void ListaCarrello_SelectedIndexChanged(object sender, EventArgs e)
        {
            prezzosingolo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
   