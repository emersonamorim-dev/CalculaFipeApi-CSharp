namespace CalculaFipeApi.Model
{
    public class CalculoFipeRequest
    {
        public string ValorBase { get; set; }
        public int Dias { get; set; }
        public string TaxaJuros { get; set; } 
    }

    public class CalculoFipeResponse
    {
        public string ValorFinal { get; set; } 
    }

}
