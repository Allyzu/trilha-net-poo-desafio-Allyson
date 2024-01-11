namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            // Implementação específica para instalação de aplicativo em um iPhone
            Console.WriteLine($"Instalando aplicativo '{nomeApp}' no Nokia, atraves da Play Store.");
        }
        
    }
}