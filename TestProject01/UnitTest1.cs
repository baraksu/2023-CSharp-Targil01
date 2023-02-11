using Targil01;

namespace TestProject01
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Weight weight = new Weight();

            Console.Out.WriteLine(weight.Gram);
            Console.Out.WriteLine(weight.Kilo);
             
        }
    }
}