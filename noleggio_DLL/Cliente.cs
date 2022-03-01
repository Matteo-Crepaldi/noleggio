namespace noleggio_DLL
{
    public class Cliente
    {
        public string Nome { get; }
        public string Cognome { get; }
        public string CodiceFiscale { get; }

        public Cliente(string nome, string cognome, string codiceFiscale)
        {
            Nome = nome;
            Cognome = cognome;
            CodiceFiscale = codiceFiscale;
        }

        public string GetInfo()
        {
            return $"{Nome};{Cognome};{CodiceFiscale}";
        }
    }
}
