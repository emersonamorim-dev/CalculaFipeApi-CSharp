namespace CalculaFipeApi.Services
{
    public interface ICalculoFipeService
    {
        decimal CalcularJuros(decimal valorBase, int dias, decimal taxaJuros);
        object CalcularJuros(string valorBase, int dias, string taxaJuros);
    }

    public class CalculoFipeService 
    {
        public decimal CalcularJuros(string valorBaseStr, int dias, string taxaJurosStr)
        {
            decimal valorBase = decimal.Parse(valorBaseStr.Replace(" RD", ""));
            decimal taxaJuros = decimal.Parse(taxaJurosStr.Replace(" RD", ""));

            return valorBase * (decimal)Math.Pow((double)(1 + taxaJuros / 100), dias);
        }
    }

}
