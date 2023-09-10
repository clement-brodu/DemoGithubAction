using NUnit.Framework;
using DemoGithubAction;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGithubAction.Tests
{
    [TestFixture()]
    public class Class1Tests
    {
        [Test()]
        public void HellWorldTest()
        {
            var class1 = new Class1();
            Assert.That(class1.HelloWorld(), Is.EqualTo("Hello"));
        }
    }
}