using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserwerOfertyPracy
{
    public interface IObserver
    {
        void Update(OfertaPracy oferta);
    }
}
