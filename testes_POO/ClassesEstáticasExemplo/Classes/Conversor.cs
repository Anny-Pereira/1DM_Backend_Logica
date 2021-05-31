namespace ClassesEstáticasExemplo.Classes
{
    public static class Conversor
    {
        private static float CotacaoDolar = 5.22f;

        public static float RealPDolar(float ValorRS)
        {
            return ValorRS / CotacaoDolar;
        }

        public static float DolarPReal (float ValorUS)
        {
            return ValorUS * CotacaoDolar;
        }
    }
}