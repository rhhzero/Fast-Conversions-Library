/* NACL by Roy Hwang * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * 
 * =====================
 * About:
 * =====================
 * 
 * This is the No Allocations Conversions Library, or NACL! The primary purpose of this 
 * library is to allow for type conversions without needless allocations, as many of the 
 * .NET methods do (ToString being a popular example). This is pretty important for 
 * applications and platforms where you must focus heavily on alleviating garbage 
 * collector pressure, such as in a video game.
 * 
 * While modern garbage collectors are quite excellent, not everyone has the luxury 
 * of working on a platform or hardware set where these collectors are available. 
 * Enter NACL!
 * 
 * Avoiding allocations help to avoid garbage collector spikes, but also increase 
 * the performance of your code in critical sections, since allocations are not 
 * a free operation. In fact, they can be quite costly and can often be the bottleneck 
 * in a tight and unoptimized loop which allocates on each iteration.
 * 
 * My hope is that you find this library useful for your needs, as I've designed it 
 * particularly with performance in mind (which is why there are so many variations 
 * available, even though I could have used generics). In the interest of performance, 
 * I have assumed that you will use these methods with some idea of what kind of input 
 * your program will be accepting.  If you do not know, it is extremely trivial to 
 * add error checks to each of these methods yourself.  Have fun!
 * 
 * Criticism and improvements are always welcome.
 * 
 * - Roy Hwang
 * 
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */


namespace NACL
{
    /// <summary>
    /// Convert a string to another type.
    /// </summary>
    public static class StringConvert
    {
        /// <summary>
        /// Converts a string to an integer. This method performs slightly worse than the 
        /// dedicated positive and negative conversion methods. 
        /// <para>Use this when you do not know whether the string representation will be a 
        /// positive or negative number.</para>
        /// </summary>
        public static int StringToInt(string s)
        {
            int min = 0;
            bool isNegative = s[0] == '-';
            if (isNegative) min = 1;

            int len = s.Length;
            int total = 0;
            for (int i = min; i < len; ++i)
            {
                // Convert digit to char
                int digit = (s[i] - '0');

                for (int j = i + 1; j < len; ++j)
                {
                    digit *= 10;
                }
                total += digit;
            }

            if (isNegative) total *= -1;

            return total;
        }

        /// <summary>
        /// Converts a string representing a positive number to an integer.
        /// </summary>
        public static int StringToPositiveInt(string s)
        {
            int total = 0;
            int len = s.Length;
            for (int i = 0; i < len; ++i)
            {
                // Convert digit to char
                int digit = (s[i] - '0');

                for (int j = i + 1; j < len; ++j)
                {
                    digit *= 10;
                }
                total += digit;
            }

            return total;
        }

        /// <summary>
        /// Converts a string representing a negative number to an integer.
        /// </summary>
        public static int StringToNegativeInt(string s)
        {
            int total = 0;
            int len = s.Length;
            for (int i = 1; i < len; ++i)
            {
                // Convert digit to char
                int digit = (s[i] - '0');

                for (int j = i + 1; j < len; ++j)
                {
                    digit *= 10;
                }
                total += digit;
            }

            return total * -1;
        }

        /// <summary>
        /// Converts a string to an unsigned integer.
        /// </summary>
        public static uint StringToUint(string s)
        {
            uint total = 0;
            int len = s.Length;
            for (int i = 0; i < len; ++i)
            {
                // Convert digit to char
                uint digit = (uint)(s[i] - '0');

                for (int j = i + 1; j < len; ++j)
                {
                    digit *= 10;
                }
                total += digit;
            }

            return total;
        }

        /// <summary>
        /// Converts a string to a 64 bit integer. Performs slightly worse than the 
        /// dedicated positive and negative conversion methods.
        /// <para>Use this when you do not know whether the string representation will be a 
        /// positive or negative number.</para>
        /// </summary>
        public static long StringToLong(string s)
        {
            int min = 0;
            bool isNegative = s[0] == '-';
            if (isNegative) min = 1;

            int len = s.Length;
            long total = 0;
            for (int i = min; i < len; ++i)
            {
                // Convert digit to char
                long digit = (s[i] - '0');

                for (int j = i + 1; j < len; ++j)
                {
                    digit *= 10L;
                }
                total += digit;
            }

            if (isNegative) total *= -1L;

            return total;
        }

        /// <summary>
        /// Converts a string representing a positive number to a 64 bit integer.
        /// </summary>
        public static long StringToPositiveLong(string s)
        {
            int len = s.Length;
            long total = 0;
            for (int i = 0; i < len; ++i)
            {
                // Convert digit to char
                long digit = (s[i] - '0');

                for (int j = i + 1; j < len; ++j)
                {
                    digit *= 10L;
                }
                total += digit;
            }
            return total;
        }

        /// <summary>
        /// Converts a string representing a negative number to a 64 bit integer.
        /// </summary>
        public static long StringToNegativeLong(string s)
        {
            int len = s.Length;
            long total = 0;
            for (int i = 1; i < len; ++i)
            {
                // Convert digit to char
                long digit = (s[i] - '0');

                for (int j = i + 1; j < len; ++j)
                {
                    digit *= 10L;
                }
                total += digit;
            }
            return total * -1L;
        }

        /// <summary>
        /// Converts a string to an unsigned 64 bit integer.
        /// </summary>
        public static ulong StringToUlong(string s)
        {
            ulong total = 0;
            int len = s.Length;
            for (int i = 0; i < len; ++i)
            {
                // Convert digit to char
                ulong digit = (ulong)(s[i] - '0');

                for (int j = i + 1; j < len; ++j)
                {
                    digit *= 10UL;
                }
                total += digit;
            }
            return total;
        }

        /// <summary>
        /// Converts a string to a double. Performs slightly worse than the dedicated 
        /// positive and negative conversion methods.
        /// <para>Use this when you do not know whether the string representation will be a 
        /// positive or negative number.</para>
        /// </summary>
        public static double StringToDouble(string s)
        {
            int min = 0;
            bool isNegative = s[0] == '-';
            if (isNegative) min = 1;

            int len = s.Length;

            // Find the index of the decimal point
            int decimalPosition = min;
            for (; decimalPosition < len; ++decimalPosition)
            {
                if (s[decimalPosition] == '.') break;
            }

            double total = 0.0;

            // Convert all digits to the left of the decimal point
            for (int i = min; i < decimalPosition; ++i)
            {
                char c = s[i];
                double digit = (c - '0');
                for (int j = i + 1; j < decimalPosition; ++j)
                {
                    digit *= 10.0;
                }
                total += digit;
            }


            // Convert all digits to the right of the decimal point
            for (int i = len - 1; i >= decimalPosition; --i)
            {
                char c = s[i];
                double digit = (c - '0');
                for (int j = decimalPosition; j < i; ++j)
                {
                    digit *= 0.1;
                }
                total += digit;
            }

            if (isNegative) total *= -1.0;

            return total;
        }

        /// <summary>
        /// Converts a string representation of a positive number to a double.
        /// </summary>
        public static double StringToPositiveDouble(string s)
        {

            int len = s.Length;

            // Find the index of the decimal point
            int decimalPosition = 0;
            for (; decimalPosition < len; ++decimalPosition)
            {
                if (s[decimalPosition] == '.') break;
            }

            double total = 0.0;

            // Convert all digits to the left of the decimal point
            for (int i = 0; i < decimalPosition; ++i)
            {
                char c = s[i];
                double digit = (c - '0');
                for (int j = i + 1; j < decimalPosition; ++j)
                {
                    digit *= 10.0;
                }
                total += digit;
            }


            // Convert all digits to the right of the decimal point
            for (int i = len - 1; i >= decimalPosition; --i)
            {
                char c = s[i];
                double digit = (c - '0');
                for (int j = decimalPosition; j < i; ++j)
                {
                    digit *= 0.1;
                }
                total += digit;
            }

            return total;
        }

        /// <summary>
        /// Converts a string representation of a negative number to a double.
        /// </summary>
        public static double StringToNegativeDouble(string s)
        {

            int len = s.Length;

            // Find the index of the decimal point
            int decimalPosition = 1;
            for (; decimalPosition < len; ++decimalPosition)
            {
                if (s[decimalPosition] == '.') break;
            }

            double total = 0.0;

            // Convert all digits to the left of the decimal point
            for (int i = 1; i < decimalPosition; ++i)
            {
                char c = s[i];
                double digit = (c - '0');
                for (int j = i + 1; j < decimalPosition; ++j)
                {
                    digit *= 10.0;
                }
                total += digit;
            }


            // Convert all digits to the right of the decimal point
            for (int i = len - 1; i >= decimalPosition; --i)
            {
                char c = s[i];
                double digit = (c - '0');
                for (int j = decimalPosition; j < i; ++j)
                {
                    digit *= 0.1;
                }
                total += digit;
            }

            return total * -1.0;
        }

        /// <summary>
        /// Converts a string to a float. Performs slightly worse than the dedicated 
        /// positive and negative conversion methods.
        /// <para>Use this when you do not know whether the string representation will be a 
        /// positive or negative number.</para>
        /// </summary>
        public static float StringToFloat(string s)
        {
            int min = 0;
            bool isNegative = s[0] == '-';
            if (isNegative) min = 1;

            int len = s.Length;

            // Find the index of the decimal point
            int decimalPosition = min;
            for (; decimalPosition < len; ++decimalPosition)
            {
                if (s[decimalPosition] == '.') break;
            }

            float total = 0f;

            // Convert all digits to the left of the decimal point
            for (int i = min; i < decimalPosition; ++i)
            {
                char c = s[i];
                float digit = (c - '0');
                for (int j = i + 1; j < decimalPosition; ++j)
                {
                    digit *= 10f;
                }
                total += digit;
            }


            // Convert all digits to the right of the decimal point
            for (int i = len - 1; i >= decimalPosition; --i)
            {
                char c = s[i];
                float digit = (c - '0');
                for (int j = decimalPosition; j < i; ++j)
                {
                    digit *= 0.1f;
                }
                total += digit;
            }

            if (isNegative) total *= -1f;

            return total;
        }

        /// <summary>
        /// Converts a string representation of a positive number to a float.
        /// </summary>
        public static float StringToPositiveFloat(string s)
        {
            int len = s.Length;

            // Find the index of the decimal point
            int decimalPosition = 0;
            for (; decimalPosition < len; ++decimalPosition)
            {
                if (s[decimalPosition] == '.') break;
            }

            float total = 0f;

            // Convert all digits to the left of the decimal point
            for (int i = 0; i < decimalPosition; ++i)
            {
                char c = s[i];
                float digit = (c - '0');
                for (int j = i + 1; j < decimalPosition; ++j)
                {
                    digit *= 10f;
                }
                total += digit;
            }


            // Convert all digits to the right of the decimal point
            for (int i = len - 1; i >= decimalPosition; --i)
            {
                char c = s[i];
                float digit = (c - '0');
                for (int j = decimalPosition; j < i; ++j)
                {
                    digit *= 0.1f;
                }
                total += digit;
            }

            return total;
        }

        /// <summary>
        /// Converts a string representation of a negative number to a float.
        /// </summary>
        public static float StringToNegativeFloat(string s)
        {
            int len = s.Length;

            // Find the index of the decimal point
            int decimalPosition = 1;
            for (; decimalPosition < len; ++decimalPosition)
            {
                if (s[decimalPosition] == '.') break;
            }

            float total = 0f;

            // Convert all digits to the left of the decimal point
            for (int i = 1; i < decimalPosition; ++i)
            {
                char c = s[i];
                float digit = (c - '0');
                for (int j = i + 1; j < decimalPosition; ++j)
                {
                    digit *= 10f;
                }
                total += digit;
            }


            // Convert all digits to the right of the decimal point
            for (int i = len - 1; i >= decimalPosition; --i)
            {
                char c = s[i];
                float digit = (c - '0');
                for (int j = decimalPosition; j < i; ++j)
                {
                    digit *= 0.1f;
                }
                total += digit;
            }

            return total * -1f;
        }
    }
}
