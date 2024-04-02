using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callcenter
{
    public class CallCenter
    {
        public Queue<Call> callQueue;
        public CallCenter()
        {
            callQueue = new Queue<Call>();
        }
        public void processQueue()
        {
            while (!callQueue.IsEmpty())
            {
                Call topCall = callQueue.getOnTop();
                
                int timeSleep = topCall.estimatedTime;
                Console.WriteLine($"O Atendente vai atender o Cliente {topCall.clientName} em aproximadamente {timeSleep * 1000} segundos");
                Task.Delay(timeSleep).Wait();
                callQueue.Dequeue();
            }
        }

       

    }
}
