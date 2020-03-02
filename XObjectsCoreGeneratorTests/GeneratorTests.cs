using System;
using NUnit.Framework;
using W3C.XSD;

namespace Xml.Schema.Code.Tests
{
    public class GeneratorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var schema = new schema() { targetNamespace = new Uri("https://github.com/Kinnara/ModernWpf/wiki/FlipView") };
            var d = ExampleA.A(schema);
        }
    }
}