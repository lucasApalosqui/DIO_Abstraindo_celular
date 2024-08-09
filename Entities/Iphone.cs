namespace DIO_Abstraindo_Celular.Entities
{
    public class Iphone : Smartphone
    {
        public Iphone(string modelo, string imei, int memoria) : base(modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string aplicativo)
        {
            Console.WriteLine($"Verificando IOS\n Instalando aplicativo {aplicativo}");
        }
    }
}
