using ForPI;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Program.Fact(1) == 1);
        }

        [Fact]
        public void Test5()
        {
            Assert.True(Program.Fact(5) == 120);
        }

        [Fact]
        public void Test0()
        {
            Assert.True(Program.Fact(0) == 1);
        }

        [Fact]
        public void Main()
        {
            Test0();
            Test1();
            Test5();
        }
    }
}