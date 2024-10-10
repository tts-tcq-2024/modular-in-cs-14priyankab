using System;
using System.Diagnostics;
using System.Drawing;
namespace TelCo.ColorCoder
{
    public class ColorPairMapperTests : ColorPairMapperTestsBase
    {
        private readonly ColorPairMapperBase _mapper;

        public ColorPairMapperTests()
        {
            _mapper = new ColorPairMapper();
        }

        public void RunAllTests()
        {
            VerifyColorPairMapping(_mapper, 1, System.Drawing.Color.White, System.Drawing.Color.Blue);
            VerifyColorPairMapping(_mapper, 5, System.Drawing.Color.White, System.Drawing.Color.SlateGray);
            VerifyColorPairMapping(_mapper, 23, System.Drawing.Color.Violet, System.Drawing.Color.Green);
            VerifyNumberMapping(_mapper, System.Drawing.Color.Yellow, System.Drawing.Color.Green, 18);
            VerifyNumberMapping(_mapper, System.Drawing.Color.Red, System.Drawing.Color.Blue, 6);
            VerifyColorPairMapping(_mapper, 4, System.Drawing.Color.White, System.Drawing.Color.Brown);
            VerifyColorPairMapping(_mapper, 25, System.Drawing.Color.Violet, System.Drawing.Color.SlateGray);
            VerifyNumberMapping(_mapper, System.Drawing.Color.White, System.Drawing.Color.Blue, 1);
            VerifyNumberMapping(_mapper, System.Drawing.Color.Violet, System.Drawing.Color.SlateGray, 25);
        }
    }


 public abstract class ColorPairMapperTestsBase
    {
        protected void VerifyColorPairMapping(ColorPairMapperBase mapper, int pairNumber, Color expectedMajor, Color expectedMinor)
        {
            ColorPair testPair = mapper.MapNumberToColorPair(pairNumber);
            Console.WriteLine($"[In] Pair Number: {pairNumber}, [Out] Colors: {testPair}");
            Debug.Assert(testPair.MajorColor == expectedMajor);
            Debug.Assert(testPair.MinorColor == expectedMinor);
        }

        protected void VerifyNumberMapping(ColorPairMapperBase mapper, Color majorColor, Color minorColor, int expectedPairNumber)
        {
            ColorPair testPair = new ColorPair { MajorColor = majorColor, MinorColor = minorColor };
            int pairNumber = mapper.MapColorPairToNumber(testPair);
            Console.WriteLine($"[In] Colors: {testPair}, [Out] PairNumber: {pairNumber}");
            Debug.Assert(pairNumber == expectedPairNumber);
        }
    }
}
