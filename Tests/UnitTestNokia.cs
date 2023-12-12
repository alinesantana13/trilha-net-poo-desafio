using DesafioPOO.Models;

namespace Tests;

public class UnitTestNokia
{
    private Nokia nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111111", memoria: 64);

    [Fact]
    public void LigandoNokia()
    {
        // Given
        string resultadoEsperado = "Ligando...";

        // When
        string resultado = nokia.Ligar();

        // Then
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void ReceberLigacaoNokia()
    {
        // Given
        string resultadoEsperado = "Recebendo ligação...";

        // When
        string resultado = nokia.ReceberLigacao();

        // Then
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void VerificarSeORetornoDoNokiaSaiComONomeWhatsApp()
    {
        string app = "WhatsApp";
        string resultadoEsperado = "Instalando o aplicativo \"WhatsApp\" no Nokia";

        string resultado = nokia.InstalarAplicativo(app);

        Assert.Equal(resultadoEsperado, resultado);
    }
}