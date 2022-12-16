namespace ObserwerOfertyPracy
{
    public class Serwis
    {
        public List<OfertaPracy> jobOfferList { get; set; } = new();
        public List<IObserver> _observerList = new List<IObserver>();

        public void Add(OfertaPracy ofertaPracy)
        {
            jobOfferList.Add(ofertaPracy);
            ofertaPracy.Status = OfertaPracyStatus.New;
        }


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

    }
}
