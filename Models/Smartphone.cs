namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string? Modelo;  
        private string? IMEI;
        private int? Memoria;           

        public Smartphone(string numero)
        {
             // TODO: Passar os parâmetros do construtor para as propriedades
            string Numero = numero;
            
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando...{Numero}");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação...");
        }
         public void Teste()
        {
            Console.WriteLine($"Iniciando teste.....");
            Console.WriteLine($"....");
            Console.WriteLine($"...");            
        }

        public abstract void InstalarAplicativo(string nomeApp);
            
    }
}