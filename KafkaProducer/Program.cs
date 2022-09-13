using Confluent.Kafka;
using System;
using System.Net;

namespace KafkaProducer 
{
    public class Program
    {
        static void Main(string[] args)
        {
            var config = new ProducerConfig()
            {
                BootstrapServers = "localhost:9092",
                ClientId = Dns.GetHostName()
            };

            Console.WriteLine("************");
            Console.WriteLine("**Producer**");
            Console.WriteLine("************");

            using (var producer = new ProducerBuilder<Null,string>(config).Build())
            {
                while (true)
                {
                    var input = Console.ReadLine();
                    producer.Produce("sensor", new Message<Null, string>() { Value = input });
                }
            }
        }
    }
}