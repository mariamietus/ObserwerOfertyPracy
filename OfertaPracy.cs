using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserwerOfertyPracy
{
    public class OfertaPracy : Subject
    {
        // nazwa oferty
        private string _name;
        public string Name
        {
            get { return this._name; }
        }
        // opis oferty
        private string _description;
        public string Description
        {
            get { return this._description; }
        }

        // status aukcji (możliwe wartości: nowa aukcja, podbita aukcja, sprzedana)
        private OfertaPracyStatus _status;
        public OfertaPracyStatus Status
        {
            get { return this._status; }
            set
            {
                this._status = value;
                if (this._status == OfertaPracyStatus.New)
                    Notify();
            }
        }
        public Serwis _serwis { get; set; }
        public OfertaPracy(string name, string description, Serwis serwis)
        {
            this._name = name;
            this._description = description;
            _serwis = serwis;
        }


        // powiadamianie obserwatorów o zmianie danych w obserwowanycn podmiocie (Auction)
        protected override void Notify()
        {
            foreach (IObserver observer in _serwis._observerList)
            {
                // Wersja "PULL"
                // Obserwowany podmiot (Book) wywołuje metodę Update() na rzecz każdego obserwatora.
                // Obserwatorzy pobierają samodzielnie interesujące ich dane z obserwowanego podmiotu.
                observer.Update(this);
            }
        }

    }
}
