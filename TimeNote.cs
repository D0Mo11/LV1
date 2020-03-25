using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON
{
    class TimeNote : Note
    {
        public DateTime time = new DateTime();
        public TimeNote() : base() { this.time = DateTime.Now; }
        public TimeNote(String author, String text, int importance, DateTime time) : base(author, text, importance)
        {
            time = DateTime.Now;
            this.time = time;
        }
        public DateTime getTime()
        {
            return this.time;
        }
        public void setTime(DateTime time)
        {
            time = DateTime.Now;
            this.time = time;
        }
        public override string ToString()
        {
            return base.ToString() + "\n" + this.time;
        }
    }
}
