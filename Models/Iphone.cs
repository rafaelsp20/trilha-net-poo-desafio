namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"

    public class Iphone : Smartphone
    {

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero) : base(numero)
        {
        }        

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Realizando a instalação de App:.... {nomeApp}");           
            
        }

        public void Teste(string modelo)
        {
            string Modelo = modelo;         

            Console.WriteLine($"Iniciando teste, modelo: {Modelo}");
            Console.WriteLine($"....");
            Console.WriteLine($"...");    

        }
    } 
}