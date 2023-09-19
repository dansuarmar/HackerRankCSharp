using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ViaticosRequisicionesAPI_Test
{
    public class ByeBye
    {
        [Fact]
        private void StringTest()
        {
            var t = "Hello World";
            ChangeString(t);
            Assert.Equal("Hello World", t);
        }

        public void ChangeString(String str)
        {
            str = "Bye, World";
        }

        [Fact]
        private void ObjectTest()
        {
            var byeObj = new Bye() { str = "Hellow World" };
            ChangeObject(byeObj);
            Assert.Equal("Bye World", byeObj.str);
        }

        public void ChangeObject(Bye inObj)
        {
            inObj.str = "Bye World";
        }
    }

    public class Bye
    {
        public string str { get; set; }
    }
}
