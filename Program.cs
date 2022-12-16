using ObserwerOfertyPracy;

// symulacja dzialania wzorca Obserwator
Serwis serwis = new Serwis();

Observer jan = new Observer("Jan");
Observer kasia = new Observer("Kasia");
serwis.Attach(jan);
serwis.Attach(kasia);

OfertaPracy offer1 = new OfertaPracy("Planner Engineer", "lanie wody", serwis);
OfertaPracy offer2 = new OfertaPracy("Programista", "kreowanie świata", serwis);

serwis.Add(offer1);
serwis.Add(offer2);








