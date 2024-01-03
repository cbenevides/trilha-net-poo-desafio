namespace DesafioPOO.Models
{
public class Nokia : Smartphone
    {
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Nokia(string numero, string modelo, string imei, int memoria): base(numero)
        {
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public override void InstalarAplicativo(string nomeApp){
           Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
        }
        
    }
}