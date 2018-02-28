namespace PersonListe
{
    using System;

    public class Elev : Person
    {
        public Elev(string fornavn, string efternavn, int elevId) : base(fornavn, efternavn)
        {
            this.ElevId = elevId;
        }
        public int ElevId { get; private set; }

        public override void Skriv()
        {
            Console.WriteLine($"Elev: {Fornavn} {Efternavn} - Id: {ElevId}");
        }
        
    }
}
