using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test
{
    public class RedAndWhiteBalls
    {
        //[Fact(DisplayName = "Should group red balls")]
        public void Test1()
        {
            var balls = "WWWRWWRWWRWW";
            var handler = new ReadAndWhiteBallsHandler();
            var expected = "WWWRRRWWWWWW";
            Assert.Equal(expected, handler.Handle(balls));
        }
    }
}
