namespace TelCo.ColorCoder
{
    public static class TestRunner
    {
        public static void ExecuteAllTests()
        {
            var tests = new ColorPairMapperTests();
            tests.RunAllTests();
        }
    }
}
