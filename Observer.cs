using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserwerOfertyPracy
{
    public class Observer:IObserver
    {
        private string _observerName;

        public Observer(string name)
        {
            this._observerName = name;
        }


        public void Update(OfertaPracy oferta)
        {

            Console.WriteLine("-------------");
            Console.WriteLine("Powiadomienie dla użytkownika: {0}", this._observerName);
            Console.WriteLine("Nowa oferta pracy : {0} o następującym szczegółowym opisie", name, description);
        }



    }
}
