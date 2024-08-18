using System.ComponentModel;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" // NO TODO
    public class Nokia : Smartphone
    {        


        public Nokia(string numero) : base(numero)
        {
             string Numero = numero;              
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
