using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrelloLista
{
    internal class Prodotto : IEquatable<Prodotto>
    {
        private String id;
        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        private String modello;
        public String Modello
        {
            get { return modello; }
        }
        private String marca;
        public String Marca
        {
            get { return marca; }
        }

        private double prezzo;
        public double Prezzo
        {
            get { return prezzo; }
            set { prezzo = value; }
        }

        public Prodotto(string id, string modello, string marca, double prezzo)
        {
            this.id = id;
            this.modello = modello;
            this.marca = marca;
            this.prezzo = prezzo;
        }

        public bool Equals(Prodotto other)
        {
            if (other == null)
                return false;

            if (this == other)
                return true;

            return Id.Equals(other.Id);
        }

        // metodo virtuale che può essere sovrascritto,
        // utilizzato per usare Prodotto p in generale per opazioni di classi figlie
        public virtual double CalcolaSconto()
        {
            return 0;
        }
    }
}