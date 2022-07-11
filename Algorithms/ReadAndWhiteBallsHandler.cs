using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class ReadAndWhiteBallsHandler
    {
        public string Handle(string balls)
        {
            var array = balls.ToCharArray();

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == 'R' && array[i + 1] != 'R')
                {

                }
            }

            return "";
        }
    }
}
