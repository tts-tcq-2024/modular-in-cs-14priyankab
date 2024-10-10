using System;
namespace TelCo.ColorCoder
{
    public class ColorPairMapper : ColorPairMapperBase
    {
        public override ColorPair MapNumberToColorPair(int pairNumber)
        {
            EnsureValidPairNumber(pairNumber);
            int minorIndex = (pairNumber - 1) % ColorMapping.MinorColors.Length;
            int majorIndex = (pairNumber - 1) / ColorMapping.MinorColors.Length;
            return new ColorPair 
            { 
                MajorColor = ColorMapping.MajorColors[majorIndex], 
                MinorColor = ColorMapping.MinorColors[minorIndex] 
            };
        }

        public override int MapColorPairToNumber(ColorPair pair)
        {
            int majorIndex = ColorMapping.GetColorIndex(pair.MajorColor, ColorMapping.MajorColors);
            int minorIndex = ColorMapping.GetColorIndex(pair.MinorColor, ColorMapping.MinorColors);
            return (majorIndex * ColorMapping.MinorColors.Length) + (minorIndex + 1);
        }
    }
	
	
	    public abstract class ColorPairMapperBase
    {
        public abstract ColorPair MapNumberToColorPair(int pairNumber);
        public abstract int MapColorPairToNumber(ColorPair pair);

        protected void EnsureValidPairNumber(int pairNumber)
        {
            int maxPairNumber = ColorMapping.MajorColors.Length * ColorMapping.MinorColors.Length;
            if (pairNumber < 1 || pairNumber > maxPairNumber)
            {
                throw new ArgumentOutOfRangeException($"PairNumber: {pairNumber} is outside the allowed range of 1 to {maxPairNumber}");
            }
        }
    }
}
