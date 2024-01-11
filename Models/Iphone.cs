namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Implementação específica do construtor do Iphone, se necessário
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            // Implementação específica para instalação de aplicativo em um iPhone
            Console.WriteLine($"Instalando aplicativo '{nomeApp}' no iPhone, atraves da Apple Store.");
        }

    }
}