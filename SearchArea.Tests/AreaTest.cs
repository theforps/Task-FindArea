namespace SearchArea.Tests
{
    public class AreaTest
    {
        [Fact]
        public void Test1()
        {
            Area area = new Area();

            Assert.Equal(area?.Aria(15), 706.5);
        }

        [Fact]
        public void Test2()
        {
            Area area = new Area();

            Assert.Equal(area?.Aria(3, 4, 5), 6);
        }
    }
}