using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW5_Threads
{
    public class Subscriber
    {
        private Queue<int> _queue;
        private object _locker = new object();

        public Subscriber(Queue<int> queue)
        {
            _queue = queue;
        }

        public void PrintQueueElement()
        {
            if (_queue.Count == 0)
            {
                return;
            }

            lock (_locker)
                {
                    Console.WriteLine($"Print deqeue {_queue.Dequeue()}");
                }
        }
    }
}
