# Menu Suspenso para Sistema de Celular 📲
#### Trilha .NET - Programação orientada a objetos
Esse projeto foi elaborado durante o Bootcamp do **Decola Tech 2024** pela DIO, se trata de uma aplicação dos conceitos de POO utilizando C#. Nessa aplicação, a partir de um menu suspenso o usuário escolhe a marca do smartphone, e se deseja fazer uma ligação, receber ligação ou instalar um aplicativo. Com base em cada escolha será exibido uma mensagem.

## Rodando o projeto
Obs.: Para rodar é necessário ter instalado .NET versão 6.0.
```
git clone link
```
Para acessar o Program.cs: 
1º Acesse a pasta Desafio
2º Digite no terminal o comando abaixo
```
dotnet run
```
Para acessar os testes unitários: 
1º Acesse a pasta Tests
2º Digite no terminal o comando abaixo
```
dotnet test
```
## Funcionalidades ☑️
- Escolher marca de celular
- Decidir qual operação fará com a marca escolhida, que pode ser uma das listadas abaixo.
    - Ligar
    - Receber ligação
    - Instalar aplicativo


## Proposta
O sistema foi criado em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. De acordo com o diagrama baixo:

<img src="./Imagens/diagrama.png" width="600">

## Regras e validações seguidas
1. A classe **Smartphone** é abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** são classes filhas de Smartphone.
3. O método **InstalarAplicativo** é sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Ferramentas utilizadas ⛏️
<img src="./Imagens/DotNet.svg" width="48"> <img src="./Imagens/CS.svg" width="48"> 

