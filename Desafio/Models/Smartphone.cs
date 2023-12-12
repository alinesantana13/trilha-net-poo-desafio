namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public string Ligar()
        {
            return "Ligando...";
        }

        public string ReceberLigacao()
        {
            return "Recebendo ligação...";
        }

        public abstract string InstalarAplicativo(string nomeApp);
    }
}