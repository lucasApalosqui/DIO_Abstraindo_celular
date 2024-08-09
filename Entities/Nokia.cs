namespace DIO_Abstraindo_Celular.Entities
{
    public class Nokia : Smartphone
    {
        public Nokia(string modelo, string imei, int memoria) : base(modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string aplicativo)
        {
            Console.WriteLine($"Verificando Android\n Instalando aplicativo {aplicativo}");
        }
    }
}
