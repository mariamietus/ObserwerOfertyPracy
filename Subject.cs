﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserwerOfertyPracy
{
    public abstract class Subject
    {
        public List<IObserver> _observerList = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            if (!this._observerList.Contains(observer))
                this._observerList.Add(observer);
        }
        public void Detach(IObserver observer)
        {
            if (this._observerList.Contains(observer))
                this._observerList.Remove(observer);
        }

        abstract protected void Notify();
    }
}
