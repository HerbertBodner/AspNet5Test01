using AspNet5Test01.Bl.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AspNet5Test01.UnitTests.Bl.Services
{
    public class MyStupidCalculatorServiceTests
    {
        public MyStupidCalculatorService GetService()
        {
            return new MyStupidCalculatorService();
        }

        [Fact]
        public void Add_2And3_Returns5()
        {
            var service = GetService();
            Assert.Equal(5, service.Add(2, 3));
        }

        [Fact]
        public void Subtract_3from2_Returns1()
        {
            var service = GetService();
            Assert.Equal(1, service.Subtract(3, 2));
        }
    }
}
