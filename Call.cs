using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callcenter
{
    public class Call
    {
        public string clientName;
        public int estimatedTime;
        public Call(string clientName, int estimatedTime)
        {
            this.clientName = clientName;
            this.estimatedTime = estimatedTime;
        }
        public override string ToString()
        {
            return clientName;
        }
    }
}
