using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_POP
{
    public class ThreadInfo
    {
        int id;
        int time;
        volatile bool canStop;

        public ThreadInfo(int id, int time)
        {
            this.Id = id;
            this.Time = time;
        }

        public int Id { get => id; set => id = value; }
        public int Time { get => time; set => time = value; }
        public bool CanStop { get => canStop; set => canStop = value; }
    }

}
