using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
     
    public class Queue
    {
        public List<string> queueObj = new List<string>();       

        public List<string> enqueue(string obj)
        {
            if(obj != null){
                queueObj.Add(obj);
            }

            return queueObj;
        }

        public List<string> dequeue()
        {
            if (queueObj.Count > 0 )
            queueObj.RemoveAt(0);
            return queueObj;
        }

        public List<string> GetAll() {
            return queueObj;
        }
    }
}
