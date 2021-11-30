using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo
{
    public class Greeting
    {
        private ITimeProvider timeProvider;
      
        public Greeting()
        {
            this.timeProvider = new CurrentTimeProvider();
        }

        public Greeting(ITimeProvider timeProvider)
        {
            this.timeProvider = timeProvider;
        }
        public string Greet()
        {
            DateTime dateTime = timeProvider.Time();
            if (dateTime.Hour < 9)
                return "Good morning";
            return "";
        }
    }
}
