namespace Projekt
{
    internal class FilterByteOperations
    {
        public static byte Addition(byte pixelVal, int strength)
        {
            return (byte)CheckThreshold((int)pixelVal + strength);
        }
        public static byte Multiply(byte pixelVal, int strength)
        {
            return CheckThreshold(pixelVal * strength);
        }
        public static byte Divide(byte pixelVal, int strength)
        {
            return CheckThreshold(pixelVal / strength);
        }

        private static byte CheckThreshold(int val)
        {
            return (byte)Math.Min(255, Math.Max(0, val));
        }

        public static byte ComputeGamma(byte pixelValue, int gamma)
        {
            double exp = 1 - (gamma / (double)100);
            return (byte)(255 * Math.Pow(pixelValue / 255f, exp));
        }
    }
}
