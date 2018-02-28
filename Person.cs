namespace PersonListe
{
    using System;

    public abstract class Person
    {

        public Person(string fornavn, string efternavn)
        {
            this.Fornavn = fornavn;
            this.Efternavn = efternavn;
        }

        public string Fornavn { get; private set; }
        public string Efternavn { get; private set; }

        public virtual void Skriv()
        {
            Console.WriteLine($"{Fornavn} {Efternavn}");
        }
    }
}
