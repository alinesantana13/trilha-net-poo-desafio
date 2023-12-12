using DesafioPOO.Models;

namespace Tests;
public class UnitTestIphone
{
    private Iphone iphone = new Iphone(numero: "123456", modelo: "Modelo 1", imei: "1111111", memoria: 128);

    [Fact]
    public void LigandoIphone()
    {
        // Given
        string resultadoEsperado = "Ligando...";

        // When
        string resultado = iphone.Ligar();

        // Then
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void ReceberLigacaoIphone()
    {
        // Given
        string resultadoEsperado = "Recebendo ligação...";

        // When
        string resultado = iphone.ReceberLigacao();

        // Then
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void VerificarSeORetornoDoIphoneSaiComONomeWhatsApp()
    {
        // Given
        string app = "Telegram";
        string resultadoEsperado = "Instalando o aplicativo \"Telegram\" no iPhone";

        // When
        string resultado = iphone.InstalarAplicativo(app);

        // Then
        Assert.Equal(resultadoEsperado, resultado);
    }

}
