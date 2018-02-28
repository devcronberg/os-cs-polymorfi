namespace PersonListe
{
    using System.Collections.Generic;
    public class Program
    {
        private static void Main(string[] args)
        {
            List<Person> personer = new List<Person>();
            personer.Add(new Instruktør("A", "A", 1));
            for (int i = 0; i < 8; i++)
            {
                // 66 = B, 67 = c, 68 = .....
                string bogstav = ((char)(66 + i)).ToString();
                personer.Add(new Elev(bogstav, bogstav, i + 101));
            }
            personer.ForEach(_ => _.Skriv());
        }
    }
}
