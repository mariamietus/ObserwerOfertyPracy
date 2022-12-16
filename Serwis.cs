namespace ObserwerOfertyPracy
{
    public class Serwis : Subject
    {
        constructor()
        {
            // o zmianie tego stanu będziemy informować słuchaczy
            this.newJobOffer = { };
            // Subject wie o wszystkich obserwujących go obiektach
            this.observers = [];
        }





        protected override void Notify()
        {
            foreach (IObserver observer in this._observerList)
            {

                observer.Update(this);
            }
        }
    }
}
