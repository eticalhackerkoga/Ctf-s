using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

class Program
{
    static void Main()
    {
        string targetIpAddress = "10.10.11.234"; // Substitua pelo endereço IP do servidor de destino
        int targetPort = 1337; // Substitua pela porta desejada

        try
        {
            TcpClient client = new TcpClient(targetIpAddress, targetPort);
            Stream stream = client.GetStream();
            StreamReader reader = new StreamReader(stream);
            StreamWriter writer = new StreamWriter(stream);

            // Inicializa um stream para leitura/escrita de dados do servidor
            // Você pode usar 'reader' para ler dados do servidor e 'writer' para enviar dados ao servidor

            // Exemplo de envio de uma mensagem ao servidor:
            writer.WriteLine("Olá, servidor!");
            writer.Flush();

            // Exemplo de leitura de resposta do servidor:
            string respostaDoServidor = reader.ReadLine();
            Console.WriteLine("Resposta do servidor: " + respostaDoServidor);

            // Coloque seu código aqui para interagir com o servidor como necessário

            // Feche a conexão quando terminar
            client.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }
}
