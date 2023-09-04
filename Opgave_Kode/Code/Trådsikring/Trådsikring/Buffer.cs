using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;

namespace Thread02
{
    class Buffer
    {
        private Queue<Car> bufferData;
        private int capacity;

        private object bufferLock = new object();

        public Buffer(int capacity)
        {
            this.capacity = capacity;
            bufferData = new Queue<Car>();
        }


        public void Put(Car car)
        {
            Monitor.Enter(bufferLock);
            try
            {
                while (IsFull())
                {
                    Monitor.Wait(bufferLock);
                }
                bufferData.Enqueue(car);
                Monitor.Pulse(bufferLock);
            }
            finally { Monitor.Exit(bufferLock); }
        }

        public Car Get()
        {
            Monitor.Enter(bufferLock);
            try
            {
                Car car;
                while (IsEmpty())
                {
                    Monitor.Wait(bufferLock);
                }
                car = bufferData.Dequeue();
                Monitor.Pulse(bufferLock);
                return car;
            }
            finally { Monitor.Exit(bufferLock); }
        }

        public void ClearQueue()
        {
            bufferData.Clear();
        }

        public bool IsEmpty()
        {
            bool isempty;
            lock (bufferLock)
            {
                isempty = bufferData.Count == 0;
            }
            return isempty;
        }

        public bool IsFull()
        {
            bool isfull;
            lock (bufferLock)
            {
                isfull = bufferData.Count == capacity;
            }
            return isfull;
        }
    }

}

