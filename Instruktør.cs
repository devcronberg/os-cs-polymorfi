namespace PersonListe
{
    using System;

    public class Instruktør : Person
    {
        public Instruktør(string fornavn, string efternavn, int afdelingId) : base(fornavn, efternavn)
        {
            this.AfdelingId = afdelingId;
        }
        public int AfdelingId { get; private set; }


        public override void Skriv()
        {
            Console.WriteLine($"Instruktør: {Fornavn} {Efternavn} - Afdeling: {AfdelingId}");
        }
    }
}
