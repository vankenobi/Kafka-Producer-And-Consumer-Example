using Confluent.Kafka;
using System;
using System.Text;
using System.Threading;

namespace KafkaConsumer // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            var config = new ConsumerConfig()
            {
                BootstrapServers = "localhost:9092",
                GroupId = "messageConsumer",
                EnableAutoCommit = false,
            };

            using (var consumer = new ConsumerBuilder<string, string>(config).Build())
            {
                consumer.Subscribe("sensor");
                CancellationTokenSource cancelationToken = new();
                
                while(true)
                {
                    var consumeResult = consumer.Consume();
                    Console.WriteLine(consumeResult.Value);
                    consumer.Commit();
                }

                consumer.Commit();
                consumer.Close();
            }
        }
    }
}