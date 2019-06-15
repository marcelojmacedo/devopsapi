using System;
using Xunit;
using DevOpsAPI.Controllers;

namespace DevOpsAPI.Tests
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();

        [Fact]
        public void Test1()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("marcelo", returnValue.Value);
            

        }
    }
}
