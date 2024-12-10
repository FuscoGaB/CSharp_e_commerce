using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrelloLista
{
    internal class Carrello
    {
        // Creazione list lista di tipo prodotto
        private List<Prodotto> lista = new List<Prodotto>();
        public List<Prodotto> Lista
        {
            get { return lista; }
        }

        private String id;
        public String Id
        {
            get { return id; }
        }

        public Carrello(String id)
        {
            this.id = id;
            lista = new List<Prodotto>();
        }

        public void aggiungiProdotto(Prodotto p)
        {
            if (p == null) return;
            lista.Add(p);
        }

        public void rimuoviProdotto(Prodotto p)
        {
            /*Prodotto prodottoDaRimuovere = null;
            foreach (Prodotto p in lista)
            {
                if (p.Id == prodotto.Id)
                {
                    prodottoDaRimuovere = p;
                    break;
                }
            }

            if (prodottoDaRimuovere != null)
                lista.Remove(prodottoDaRimuovere);
            */
            int trovato;
            trovato = lista.IndexOf(p);
            if (trovato != -1) lista.RemoveAt(trovato);
        }

        public void svuotaProdotti()
        {
            lista.Clear();
        }
    }
}