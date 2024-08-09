namespace DIO_Abstraindo_Celular.Entities
{
    public abstract class Smartphone
    {
        public Smartphone(string modelo, string imei, int memoria)
        {
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public string Numero { get; private set; }
        private string Modelo;
        private string Imei;
        private int Memoria;

        public void Ligar()
        {
            Console.WriteLine("Realizando ligação...");
        }

        public void ReceberLigação()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public virtual void InstalarAplicativo(string aplicativo)
        {
            
        }

        public void InformacoesAparelho()
        {
            Console.WriteLine($"Modelo: {Modelo} | IMEI: {Imei} | Memória: {Memoria}");
        }

        public void AdicionarNumero(string numero)
        {
            if (Numero == null)
            {
                Numero = numero;
                Console.WriteLine($"Numero {numero}, adicionado com sucesso!");
            }
            else
            {
                AlterarNumero(numero);
            }

        }

        public void AlterarNumero(string numero)
        {
            if(Numero != null)
            {
                Numero = numero;
                Console.WriteLine($"Numero {numero}, alterado com sucesso!");
            }
            else
            {
                AdicionarNumero(numero);
            }

        }
    }
}
