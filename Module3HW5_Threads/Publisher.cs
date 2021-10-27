using System.Collections.Generic;

namespace Module3HW5_Threads
{
    public class Publisher
    {
        private Queue<int> _queue;
        private object _locker = new object();

        public Publisher(Queue<int> queue)
        {
            _queue = queue;
        }

        public void Publish(int x)
        {
            if (_queue != null)
            {
                lock (_locker)
                {
                    _queue.Enqueue(x);
                }
            }
        }
    }
}
