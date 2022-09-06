using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.IO;

namespace DemoLibrary.Tests
{
    public class ExamplesTests
    {
        [Fact]
        public void ExamplesLoadTextFile_ValidNameShouldWork()
        {
            string actual = Examples.ExampleLoadTextFile("This is a valid file name.");

            Assert.True(actual.Length > 0);
        }

        [Fact]
        public void ExamplesLoadTextFile_InvalidNameShoudlFail()
        {
            Assert.Throws<ArgumentException>("file", () => Examples.ExampleLoadTextFile(""));
        }
    }
}
