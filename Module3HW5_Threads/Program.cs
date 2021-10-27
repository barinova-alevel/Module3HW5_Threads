using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Module3HW5_Threads
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new Queue<int>();
            var publisher1 = new Publisher(numbers);
            var publisher2 = new Publisher(numbers);
            var subscriber = new Subscriber(numbers);

            Task.Run(() =>
            {
                for (int i = 10; i < 20; i++)
                {
                   publisher1.Publish(i);
                   Thread.Sleep(600);
                }
            });

            Task.Run(() =>
            {
                for (int i = 20; i < 30; i++)
                {
                    publisher2.Publish(i);
                    Thread.Sleep(1000);
                }
            });

            Task.Run(() =>
            {
                while (true)
                {
                    subscriber.PrintQueueElement();
                    Thread.Sleep(500);
                }
            });

            Console.ReadKey();
        }
    }
}
