using NUnit.Framework;

namespace lib.tests.integration {

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, Category("Integration")]    
        public void Test1()
        {
            Assert.Fail();
        }
    }

}
