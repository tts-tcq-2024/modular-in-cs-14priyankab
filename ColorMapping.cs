using System.Drawing;

namespace TelCo.ColorCoder
{
    public class ColorMapping
    {
        public static readonly Color[] MajorColors = 
            { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
        public static readonly Color[] MinorColors = 
            { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };

        public static int GetColorIndex(Color color, Color[] colorArray)
        {
            for (int i = 0; i < colorArray.Length; i++)
            {
                if (colorArray[i] == color) return i;
            }
            return -1;
        }
    }
}
