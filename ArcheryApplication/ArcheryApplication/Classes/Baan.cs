namespace ArcheryApplication.Classes
{
    public class Baan
    {
        public int Id { get; private set; }
        public string BaanId { get; private set; }
        public int Baannummer { get; private set; }
        public string Letter { get; private set; }
        public Schutter Schutter { get; private set; }
        public int Afstand { get; private set; }

        public Baan(int baanNummer, string letter, int afstand)
        {
            Baannummer = baanNummer;
            Letter = letter;
            Afstand = afstand;
            BaanId = Baannummer.ToString() + Letter;
        }
        public Baan(int id, int baannummer, string letter, int afstand)
        {
            Id = id;
            Baannummer = baannummer;
            Letter = letter;
            Afstand = afstand;
            BaanId = Baannummer.ToString() + Letter;
        }
        public void VoegSchutterToe(Schutter schutter)
        {
            if (Schutter == null)
            {
                Schutter = schutter;
            }
        }
        public void VerwijderSchutter(Schutter schutter)
        {
            //ToDo
        }
        public override string ToString()
        {
            if (Schutter != null)
            {
                return $"{ BaanId }: { Schutter.ToString() }";
            }
            return $"{ BaanId }: Geen schutter";

        }
    }
}
