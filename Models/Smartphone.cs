namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {

        //Construtor
        public Smartphone(string numero, string modelo, string imei, int memoria){
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Atributos
        public string Numero {get; set;}
        protected string Modelo {get; set;}
        protected string IMEI {get; set;}
        protected int Memoria {get; set;}


        // Métodos
        public void Ligar(){
            System.Console.WriteLine($"Ligando...");
        }

        public void ReceberLigacao(){
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

    }
}
      