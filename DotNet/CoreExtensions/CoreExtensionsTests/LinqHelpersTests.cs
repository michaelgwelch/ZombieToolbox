using System;
using NUnit.Framework;
using System.Linq;
using ZombieToolbox.System;

namespace CoreExtensionsTests
{
    [TestFixture()]
    public class LinqHelpersTests
    {
        [Test()]
        public void Covert_5_To_Enumerable()
        {
            var x = 5.Enumerable();

            Assert.AreEqual(x.Single(), 5);
        }

        [Test()]
        public void Covert_Null_To_Enumerable()
        {
            object src = null;
            var x = src.Enumerable();

            Assert.AreEqual(x.Count(), 0);
        }
    }
}

