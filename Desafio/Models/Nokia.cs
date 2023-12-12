namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {

        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override string InstalarAplicativo(string nomeApp)
        {
            return $"Instalando o aplicativo \"{nomeApp}\" no Nokia";
        }
    }
}