using RabbitMQ.Client;
using System;
using System.Text;

namespace TesteRabbitMQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost"
            };
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare
                    (
                    queue: "queue02",
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null
                    );

                    string message = "Teste RabbitMQ";

                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish
                    (
                    exchange: "",
                    routingKey: "queue01",
                    basicProperties: null,
                    body: body
                    );
                    Console.WriteLine($"Mensagem enviada: {message}");
                }
            }
            
        }
    }
}
