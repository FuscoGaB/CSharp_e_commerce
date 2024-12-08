using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrelloLista
{
    internal class ProdottoAlimentare : Prodotto
    {
        public ProdottoAlimentare(string id, string modello, string marca, double prezzo)
        : base(id, modello, marca, prezzo) { }

        //sovrascrizione del metodo della classe padre
        public override double CalcolaSconto()
        {
            return Prezzo * 0.10;
        }

    }
}