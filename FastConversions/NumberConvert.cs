/* FCL by Roy Hwang * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * 
 * =====================
 * About:
 * =====================
 * 
 * This is the Fast Conversions Library, or FCL! The primary purpose of this 
 * library is to allow for type conversions without needless allocations, and providing 
 * faster functions for doing so. This is pretty important for 
 * applications and platforms where you must focus heavily on alleviating garbage 
 * collector pressure, and maintain a high baseline performance level, such as a video game.
 * 
 * While modern garbage collectors are quite excellent, not everyone has the luxury 
 * of working on a platform or hardware set where these collectors are available. 
 * Enter FCL!
 * 
 * This library can help to avoid garbage collector spikes by being smart with allocations, 
 * and also by increasing the performance of your code in critical sections. The C# .NET 
 * standard library is generally excellent at avoiding needless allocations, but also 
 * can be quite a bit slower than a hand-rolled implementation of your own.
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

using System.Text;
using System.Runtime.CompilerServices;

namespace FCL
{
    /// <summary>
    /// Convert a number to another type.
    /// </summary>
    public class NumberConvert
    {

        /// <summary>
        /// <para>Converts a positive digit to a char. Note: A negative digit requires a char array conversion method. 
        /// Use this method if you are only interested in converting a single digit from a number.</para>
        /// <para>DOMAIN: [0 to int.MaxValue]</para>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char PositiveDigitToChar(int i)
        {
            return (char)(i + 48);
        }

        /// <summary>
        /// Converts an unsigned 64 bit integer to populate a StringBuilder.
        /// </summary>
        public static void UlongToStringBuilder(StringBuilder builder, ulong number)
        {
            // Listed in the comments is the digit's place
            if (number >= 10000000000000000000UL)
            {
                // 20.
                builder.Append((char)((number / 10000000000000000000UL) + 48UL));
                number %= 10000000000000000000UL;
            }
            if (number >= 1000000000000000000UL)
            {
                // 19.
                builder.Append((char)((number / 1000000000000000000UL) + 48UL));
                number %= 1000000000000000000UL;
            }
            if (number >= 100000000000000000UL)
            {
                // 18.
                builder.Append((char)((number / 100000000000000000UL) + 48UL));
                number %= 100000000000000000UL;
            }
            if (number >= 10000000000000000UL)
            {
                // 17.
                builder.Append((char)((number / 10000000000000000UL) + 48UL));
                number %= 10000000000000000UL;
            }
            if (number >= 1000000000000000UL)
            {
                // 16.
                builder.Append((char)((number / 1000000000000000UL) + 48UL));
                number %= 1000000000000000UL;
            }
            if (number >= 100000000000000UL)
            {
                // 15.
                builder.Append((char)((number / 100000000000000UL) + 48UL));
                number %= 100000000000000UL;
            }
            if (number >= 10000000000000UL)
            {
                // 14.
                builder.Append((char)((number / 10000000000000UL) + 48UL));
                number %= 10000000000000UL;
            }
            if (number >= 1000000000000UL)
            {
                // 13.
                builder.Append((char)((number / 1000000000000UL) + 48UL));
                number %= 1000000000000UL;
            }
            if (number >= 100000000000UL)
            {
                // 12.
                builder.Append((char)((number / 100000000000UL) + 48UL));
                number %= 100000000000UL;
            }
            if (number >= 10000000000UL)
            {
                // 11.
                builder.Append((char)((number / 10000000000UL) + 48UL));
                number %= 10000000000UL;
            }
            if (number >= 1000000000UL)
            {
                // 10.
                builder.Append((char)((number / 1000000000UL) + 48UL));
                number %= 1000000000UL;
            }
            if (number >= 100000000UL)
            {
                // 9.
                builder.Append((char)((number / 100000000UL) + 48UL));
                number %= 100000000UL;
            }
            if (number >= 10000000UL)
            {
                // 8.
                builder.Append((char)((number / 10000000UL) + 48UL));
                number %= 10000000UL;
            }
            if (number >= 1000000UL)
            {
                // 7.
                builder.Append((char)((number / 1000000UL) + 48UL));
                number %= 1000000UL;
            }
            if (number >= 100000UL)
            {
                // 6.
                builder.Append((char)((number / 100000UL) + 48UL));
                number %= 100000UL;
            }
            if (number >= 10000UL)
            {
                // 5.
                builder.Append((char)((number / 10000UL) + 48UL));
                number %= 10000UL;
            }
            if (number >= 1000UL)
            {
                // 4.
                builder.Append((char)((number / 1000UL) + 48UL));
                number %= 1000UL;
            }
            if (number >= 100UL)
            {
                // 3.
                builder.Append((char)((number / 100UL) + 48UL));
                number %= 100UL;
            }
            if (number >= 10UL)
            {
                // 2.
                builder.Append((char)((number / 10UL) + 48UL));
                number %= 10UL;
            }
            if (number >= 0UL)
            {
                // 1.
                builder.Append((char)(number + 48UL));
            }
        }

        /// <summary>
        /// Converts a 64 bit integer to populate a StringBuilder.
        /// </summary>
        public static void LongToStringBuilder(StringBuilder builder, long number)
        {
            // Account for negative range
            if (number < 0)
            {
                builder.Append('-');
                number *= -1L;
            }

            // Listed in the comments is the digit's place
            if (number >= 1000000000000000000L)
            {
                // 19.
                builder.Append((char)((number / 1000000000000000000L) + 48L));
                number %= 1000000000000000000L;
            }
            if (number >= 100000000000000000L)
            {
                // 18.
                builder.Append((char)((number / 100000000000000000L) + 48L));
                number %= 100000000000000000L;
            }
            if (number >= 10000000000000000L)
            {
                // 17.
                builder.Append((char)((number / 10000000000000000L) + 48L));
                number %= 10000000000000000L;
            }
            if (number >= 1000000000000000L)
            {
                // 16.
                builder.Append((char)((number / 1000000000000000L) + 48L));
                number %= 1000000000000000L;
            }
            if (number >= 100000000000000L)
            {
                // 15.
                builder.Append((char)((number / 100000000000000L) + 48L));
                number %= 100000000000000L;
            }
            if (number >= 10000000000000L)
            {
                // 14.
                builder.Append((char)((number / 10000000000000L) + 48L));
                number %= 10000000000000L;
            }
            if (number >= 1000000000000L)
            {
                // 13.
                builder.Append((char)((number / 1000000000000L) + 48L));
                number %= 1000000000000L;
            }
            if (number >= 100000000000L)
            {
                // 12.
                builder.Append((char)((number / 100000000000L) + 48L));
                number %= 100000000000L;
            }
            if (number >= 10000000000L)
            {
                // 11.
                builder.Append((char)((number / 10000000000L) + 48L));
                number %= 10000000000L;
            }
            if (number >= 1000000000L)
            {
                // 10.
                builder.Append((char)((number / 1000000000L) + 48L));
                number %= 1000000000L;
            }
            if (number >= 100000000L)
            {
                // 9.
                builder.Append((char)((number / 100000000L) + 48L));
                number %= 100000000L;
            }
            if (number >= 10000000L)
            {
                // 8.
                builder.Append((char)((number / 10000000L) + 48L));
                number %= 10000000L;
            }
            if (number >= 1000000L)
            {
                // 7.
                builder.Append((char)((number / 1000000L) + 48L));
                number %= 1000000L;
            }
            if (number >= 100000L)
            {
                // 6.
                builder.Append((char)((number / 100000L) + 48L));
                number %= 100000L;
            }
            if (number >= 10000L)
            {
                // 5.
                builder.Append((char)((number / 10000L) + 48L));
                number %= 10000L;
            }
            if (number >= 1000L)
            {
                // 4.
                builder.Append((char)((number / 1000L) + 48L));
                number %= 1000L;
            }
            if (number >= 100L)
            {
                // 3.
                builder.Append((char)((number / 100L) + 48L));
                number %= 100L;
            }
            if (number >= 10L)
            {
                // 2.
                builder.Append((char)((number / 10L) + 48L));
                number %= 10L;
            }
            if (number >= 0L)
            {
                // 1.
                builder.Append((char)(number + 48L));
            }
        }

        /// <summary>
        /// Converts an integer to populate a StringBuilder.
        /// </summary>
        public static void IntToStringBuilder(StringBuilder builder, int number)
        {
            // Account for negative range
            if (number < 0)
            {
                builder.Append('-');
                number *= -1;
            }

            // Listed in the comments is the digit's place
            if (number >= 1000000000)
            {
                // 10.
                builder.Append((char)((number / 1000000000) + 48));
                number %= 1000000000;
            }
            if (number >= 100000000)
            {
                // 9.
                builder.Append((char)((number / 100000000) + 48));
                number %= 100000000;
            }
            if (number >= 10000000)
            {
                // 8.
                builder.Append((char)((number / 10000000) + 48));
                number %= 10000000;
            }
            if (number >= 1000000)
            {
                // 7.
                builder.Append((char)((number / 1000000) + 48));
                number %= 1000000;
            }
            if (number >= 100000)
            {
                // 6.
                builder.Append((char)((number / 100000) + 48));
                number %= 100000;
            }
            if (number >= 10000)
            {
                // 5.
                builder.Append((char)((number / 10000) + 48));
                number %= 10000;
            }
            if (number >= 1000)
            {
                // 4.
                builder.Append((char)((number / 1000) + 48));
                number %= 1000;
            }
            if (number >= 100)
            {
                // 3.
                builder.Append((char)((number / 100) + 48));
                number %= 100;
            }
            if (number >= 10)
            {
                // 2.
                builder.Append((char)((number / 10) + 48));
                number %= 10;
            }
            if (number >= 0)
            {
                // 1.
                builder.Append((char)(number + 48));
            }
        }

        /// <summary>
        /// Converts an unsigned integer to populate a StringBuilder.
        /// </summary>
        public static void UintToStringBuilder(StringBuilder builder, uint number)
        {
            // Listed in the comments is the digit's place
            if (number >= 1000000000U)
            {
                // 10.
                builder.Append((char)((number / 1000000000U) + 48U));
                number %= 1000000000U;
            }
            if (number >= 100000000U)
            {
                // 9.
                builder.Append((char)((number / 100000000U) + 48U));
                number %= 100000000U;
            }
            if (number >= 10000000U)
            {
                // 8.
                builder.Append((char)((number / 10000000U) + 48U));
                number %= 10000000U;
            }
            if (number >= 1000000U)
            {
                // 7.
                builder.Append((char)((number / 1000000U) + 48U));
                number %= 1000000U;
            }
            if (number >= 100000U)
            {
                // 6.
                builder.Append((char)((number / 100000U) + 48U));
                number %= 100000U;
            }
            if (number >= 10000U)
            {
                // 5.
                builder.Append((char)((number / 10000U) + 48U));
                number %= 10000U;
            }
            if (number >= 1000U)
            {
                // 4.
                builder.Append((char)((number / 1000U) + 48U));
                number %= 1000U;
            }
            if (number >= 100U)
            {
                // 3.
                builder.Append((char)((number / 100U) + 48U));
                number %= 100U;
            }
            if (number >= 10U)
            {
                // 2.
                builder.Append((char)((number / 10U) + 48U));
                number %= 10U;
            }
            if (number >= 0U)
            {
                // 1.
                builder.Append((char)(number + 48U));
            }
        }

        /// <summary>
        /// <para>Converts an unsigned 64 bit integer to populate a char array.</para>
        /// <para>WARNING: For the sake of performance, no error checks are implemented. If you have no guarantee that the 
        /// char array supplied can fit the number of digits + 1 (for terminator), add your own error check!</para>
        /// </summary>
        public static void UlongToCharArray(char[] charArray, ulong number)
        {
            int index = 0;

            // Listed in the comments is the digit's place
            if (number >= 10000000000000000000UL)
            {
                // 20.
                charArray[index] = (char)((number / 10000000000000000000UL) + 48UL);
                number %= 10000000000000000000UL;
                ++index;
            }
            if (number >= 1000000000000000000UL)
            {
                // 19.
                charArray[index] = (char)((number / 1000000000000000000UL) + 48UL);
                number %= 1000000000000000000UL;
                ++index;
            }
            if (number >= 100000000000000000UL)
            {
                // 18.
                charArray[index] = (char)((number / 100000000000000000UL) + 48UL);
                number %= 100000000000000000UL;
                ++index;
            }
            if (number >= 10000000000000000UL)
            {
                // 17.
                charArray[index] = (char)((number / 10000000000000000UL) + 48UL);
                number %= 10000000000000000UL;
                ++index;
            }
            if (number >= 1000000000000000UL)
            {
                // 16.
                charArray[index] = (char)((number / 1000000000000000UL) + 48UL);
                number %= 1000000000000000UL;
                ++index;
            }
            if (number >= 100000000000000UL)
            {
                // 15.
                charArray[index] = (char)((number / 100000000000000UL) + 48UL);
                number %= 100000000000000UL;
                ++index;
            }
            if (number >= 10000000000000UL)
            {
                // 14.
                charArray[index] = (char)((number / 10000000000000UL) + 48UL);
                number %= 10000000000000UL;
                ++index;
            }
            if (number >= 1000000000000UL)
            {
                // 13.
                charArray[index] = (char)((number / 1000000000000UL) + 48UL);
                number %= 1000000000000UL;
                ++index;
            }
            if (number >= 100000000000UL)
            {
                // 12.
                charArray[index] = (char)((number / 100000000000UL) + 48UL);
                number %= 100000000000UL;
                ++index;
            }
            if (number >= 10000000000UL)
            {
                // 11.
                charArray[index] = (char)((number / 10000000000UL) + 48UL);
                number %= 10000000000UL;
                ++index;
            }
            if (number >= 1000000000UL)
            {
                // 10.
                charArray[index] = (char)((number / 1000000000UL) + 48UL);
                number %= 1000000000UL;
                ++index;
            }
            if (number >= 100000000UL)
            {
                // 9.
                charArray[index] = (char)((number / 100000000UL) + 48UL);
                number %= 100000000UL;
                ++index;
            }
            if (number >= 10000000UL)
            {
                // 8.
                charArray[index] = (char)((number / 10000000UL) + 48UL);
                number %= 10000000UL;
                ++index;
            }
            if (number >= 1000000UL)
            {
                // 7.
                charArray[index] = (char)((number / 1000000UL) + 48UL);
                number %= 1000000UL;
                ++index;
            }
            if (number >= 100000UL)
            {
                // 6.
                charArray[index] = (char)((number / 100000UL) + 48UL);
                number %= 100000UL;
                ++index;
            }
            if (number >= 10000UL)
            {
                // 5.
                charArray[index] = (char)((number / 10000UL) + 48UL);
                number %= 10000UL;
                ++index;
            }
            if (number >= 1000UL)
            {
                // 4.
                charArray[index] = (char)((number / 1000UL) + 48UL);
                number %= 1000UL;
                ++index;
            }
            if (number >= 100UL)
            {
                // 3.
                charArray[index] = (char)((number / 100UL) + 48UL);
                number %= 100UL;
                ++index;
            }
            if (number >= 10UL)
            {
                // 2.
                charArray[index] = (char)((number / 10UL) + 48UL);
                number %= 10UL;
                ++index;
            }
            if (number >= 0UL)
            {
                // 1.
                charArray[index] = (char)(number + 48UL);
                ++index;
            }
            charArray[index] = '\0';
        }

        /// <summary>
        /// <para>Converts a 64 bit integer to populate a char array.</para>
        /// <para>WARNING: For the sake of performance, no error checks are implemented. If you have no guarantee that the 
        /// char array supplied can fit the number of digits + 1 (for terminator), add your own error check!</para>
        /// </summary>
        public static void LongToCharArray(char[] charArray, long number)
        {
            int index = 0;

            // Account for negative range
            if (number < 0)
            {
                charArray[0] = '-';
                ++index;
                number *= -1L;
            }

            // Listed in the comments is the digit's place
            if (number >= 1000000000000000000L)
            {
                // 19.
                charArray[index] = (char)((number / 1000000000000000000L) + 48L);
                number %= 1000000000000000000L;
                ++index;
            }
            if (number >= 100000000000000000L)
            {
                // 18.
                charArray[index] = (char)((number / 100000000000000000L) + 48L);
                number %= 100000000000000000L;
                ++index;
            }
            if (number >= 10000000000000000L)
            {
                // 17.
                charArray[index] = (char)((number / 10000000000000000L) + 48L);
                number %= 10000000000000000L;
                ++index;
            }
            if (number >= 1000000000000000L)
            {
                // 16.
                charArray[index] = (char)((number / 1000000000000000L) + 48L);
                number %= 1000000000000000L;
                ++index;
            }
            if (number >= 100000000000000L)
            {
                // 15.
                charArray[index] = (char)((number / 100000000000000L) + 48L);
                number %= 100000000000000L;
                ++index;
            }
            if (number >= 10000000000000L)
            {
                // 14.
                charArray[index] = (char)((number / 10000000000000L) + 48L);
                number %= 10000000000000L;
                ++index;
            }
            if (number >= 1000000000000L)
            {
                // 13.
                charArray[index] = (char)((number / 1000000000000L) + 48L);
                number %= 1000000000000L;
                ++index;
            }
            if (number >= 100000000000L)
            {
                // 12.
                charArray[index] = (char)((number / 100000000000L) + 48L);
                number %= 100000000000L;
                ++index;
            }
            if (number >= 10000000000L)
            {
                // 11.
                charArray[index] = (char)((number / 10000000000L) + 48L);
                number %= 10000000000L;
                ++index;
            }
            if (number >= 1000000000L)
            {
                // 10.
                charArray[index] = (char)((number / 1000000000L) + 48L);
                number %= 1000000000L;
                ++index;
            }
            if (number >= 100000000L)
            {
                // 9.
                charArray[index] = (char)((number / 100000000L) + 48L);
                number %= 100000000L;
                ++index;
            }
            if (number >= 10000000L)
            {
                // 8.
                charArray[index] = (char)((number / 10000000L) + 48L);
                number %= 10000000L;
                ++index;
            }
            if (number >= 1000000L)
            {
                // 7.
                charArray[index] = (char)((number / 1000000L) + 48L);
                number %= 1000000L;
                ++index;
            }
            if (number >= 100000L)
            {
                // 6.
                charArray[index] = (char)((number / 100000L) + 48L);
                number %= 100000L;
                ++index;
            }
            if (number >= 10000L)
            {
                // 5.
                charArray[index] = (char)((number / 10000L) + 48L);
                number %= 10000L;
                ++index;
            }
            if (number >= 1000L)
            {
                // 4.
                charArray[index] = (char)((number / 1000L) + 48L);
                number %= 1000L;
                ++index;
            }
            if (number >= 100L)
            {
                // 3.
                charArray[index] = (char)((number / 100L) + 48L);
                number %= 100L;
                ++index;
            }
            if (number >= 10L)
            {
                // 2.
                charArray[index] = (char)((number / 10L) + 48L);
                number %= 10L;
                ++index;
            }
            if (number >= 0L)
            {
                // 1.
                charArray[index] = (char)(number + 48L);
                ++index;
            }
            charArray[index] = '\0';
        }

        /// <summary>
        /// <para>Converts an unsigned integer to populate a char array.</para>
        /// <para>WARNING: For the sake of performance, no error checks are implemented. If you have no guarantee that the 
        /// char array supplied can fit the number of digits + 1 (for terminator), add your own error check!</para>
        /// </summary>
        public static void UintToCharArray(char[] charArray, uint number)
        {
            int index = 0;

            // Listed in the comments is the digit's place
            if (number >= 1000000000U)
            {
                // 10.
                charArray[index] = (char)((number / 1000000000U) + 48U);
                number %= 1000000000U;
                ++index;
            }
            if (number >= 100000000U)
            {
                // 9.
                charArray[index] = (char)((number / 100000000U) + 48U);
                number %= 100000000U;
                ++index;
            }
            if (number >= 10000000U)
            {
                // 8.
                charArray[index] = (char)((number / 10000000U) + 48U);
                number %= 10000000U;
                ++index;
            }
            if (number >= 1000000U)
            {
                // 7.
                charArray[index] = (char)((number / 1000000U) + 48U);
                number %= 1000000U;
                ++index;
            }
            if (number >= 100000U)
            {
                // 6.
                charArray[index] = (char)((number / 100000U) + 48U);
                number %= 100000U;
                ++index;
            }
            if (number >= 10000U)
            {
                // 5.
                charArray[index] = (char)((number / 10000U) + 48U);
                number %= 10000U;
                ++index;
            }
            if (number >= 1000U)
            {
                // 4.
                charArray[index] = (char)((number / 1000U) + 48U);
                number %= 1000U;
                ++index;
            }
            if (number >= 100U)
            {
                // 3.
                charArray[index] = (char)((number / 100U) + 48U);
                number %= 100U;
                ++index;
            }
            if (number >= 10U)
            {
                // 2.
                charArray[index] = (char)((number / 10U) + 48U);
                number %= 10U;
                ++index;
            }
            if (number >= 0U)
            {
                // 1.
                charArray[index] = (char)(number + 48U);
                ++index;
            }
            charArray[index] = '\0';
        }

        /// <summary>
        /// <para>Converts an integer to populate a char array.</para>
        /// <para>WARNING: For the sake of performance, no error checks are implemented. If you have no guarantee that the 
        /// char array supplied can fit the number of digits + 1 (for terminator), add your own error check!</para>
        /// </summary>
        public static void IntToCharArray(char[] charArray, int number)
        {
            int index = 0;

            // Account for negative range
            if (number < 0)
            {
                charArray[0] = '-';
                ++index;
                number *= -1;
            }

            // Listed in the comments is the digit's place
            if (number >= 1000000000)
            {
                // 10.
                charArray[index] = (char)((number / 1000000000) + 48);
                number %= 1000000000;
                ++index;
            }
            if (number >= 100000000)
            {
                // 9.
                charArray[index] = (char)((number / 100000000) + 48);
                number %= 100000000;
                ++index;
            }
            if (number >= 10000000)
            {
                // 8.
                charArray[index] = (char)((number / 10000000) + 48);
                number %= 10000000;
                ++index;
            }
            if (number >= 1000000)
            {
                // 7.
                charArray[index] = (char)((number / 1000000) + 48);
                number %= 1000000;
                ++index;
            }
            if (number >= 100000)
            {
                // 6.
                charArray[index] = (char)((number / 100000) + 48);
                number %= 100000;
                ++index;
            }
            if (number >= 10000)
            {
                // 5.
                charArray[index] = (char)((number / 10000) + 48);
                number %= 10000;
                ++index;
            }
            if (number >= 1000)
            {
                // 4.
                charArray[index] = (char)((number / 1000) + 48);
                number %= 1000;
                ++index;
            }
            if (number >= 100)
            {
                // 3.
                charArray[index] = (char)((number / 100) + 48);
                number %= 100;
                ++index;
            }
            if (number >= 10)
            {
                // 2.
                charArray[index] = (char)((number / 10) + 48);
                number %= 10;
                ++index;
            }
            if (number >= 0)
            {
                // 1.
                charArray[index] = (char)(number + 48);
                ++index;
            }
            charArray[index] = '\0';
        }

        /// <summary>
        /// <para>Manipulates an existing string to convert an integer, while avoiding expensive memory allocations.</para>
        /// <para>WARNING: For the sake of performance, no error checks are implemented. If you have no guarantee that the 
        /// supplied string can fit the number of digits + 1 (for terminator), add your own error check!</para>
        /// </summary>
        public static unsafe void IntToStringNoAlloc(ref string mutable, int number) {
            fixed (char* cPointer = mutable)
            {
                char* p = cPointer;

                // Account for negative range
                if (number < 0)
                {
                    *p = '-';
                    ++p;
                    number *= -1;
                }

                // Listed in the comments is the digit's place
                if (number >= 1000000000)
                {
                    // 10.
                    *p = (char)((number / 1000000000) + 48);
                    number %= 1000000000;
                    ++p;
                }
                if (number >= 100000000)
                {
                    // 9.
                    *p = (char)((number / 100000000) + 48);
                    number %= 100000000;
                    ++p;
                }
                if (number >= 10000000)
                {
                    // 8.
                    *p = (char)((number / 10000000) + 48);
                    number %= 10000000;
                    ++p;
                }
                if (number >= 1000000)
                {
                    // 7.
                    *p = (char)((number / 1000000) + 48);
                    number %= 1000000;
                    ++p;
                }
                if (number >= 100000)
                {
                    // 6.
                    *p = (char)((number / 100000) + 48);
                    number %= 100000;
                    ++p;
                }
                if (number >= 10000)
                {
                    // 5.
                    *p = (char)((number / 10000) + 48);
                    number %= 10000;
                    ++p;
                }
                if (number >= 1000)
                {
                    // 4.
                    *p = (char)((number / 1000) + 48);
                    number %= 1000;
                    ++p;
                }
                if (number >= 100)
                {
                    // 3.
                    *p = (char)((number / 100) + 48);
                    number %= 100;
                    ++p;
                }
                if (number >= 10)
                {
                    // 2.
                    *p = (char)((number / 10) + 48);
                    number %= 10;
                    ++p;
                }
                if (number >= 0)
                {
                    // 1.
                    *p = (char)(number + 48);
                    ++p;
                }
                *p = '\0';
            }
        }

        /// <summary>
        /// <para>Manipulates an existing string to convert an unsigned integer, while avoiding expensive memory allocations.</para>
        /// <para>WARNING: For the sake of performance, no error checks are implemented. If you have no guarantee that the 
        /// supplied string can fit the number of digits + 1 (for terminator), add your own error check!</para>
        /// </summary>
        public static unsafe void UintToStringNoAlloc(ref string mutable, uint number)
        {
            fixed (char* cPointer = mutable)
            {
                char* p = cPointer;

                // Listed in the comments is the digit's place
                if (number >= 1000000000U)
                {
                    // 10.
                    *p = (char)((number / 1000000000U) + 48U);
                    number %= 1000000000U;
                    ++p;
                }
                if (number >= 100000000U)
                {
                    // 9.
                    *p = (char)((number / 100000000U) + 48U);
                    number %= 100000000U;
                    ++p;
                }
                if (number >= 10000000U)
                {
                    // 8.
                    *p = (char)((number / 10000000U) + 48U);
                    number %= 10000000U;
                    ++p;
                }
                if (number >= 1000000U)
                {
                    // 7.
                    *p = (char)((number / 1000000U) + 48U);
                    number %= 1000000U;
                    ++p;
                }
                if (number >= 100000U)
                {
                    // 6.
                    *p = (char)((number / 100000U) + 48U);
                    number %= 100000U;
                    ++p;
                }
                if (number >= 10000U)
                {
                    // 5.
                    *p = (char)((number / 10000U) + 48U);
                    number %= 10000U;
                    ++p;
                }
                if (number >= 1000U)
                {
                    // 4.
                    *p = (char)((number / 1000U) + 48U);
                    number %= 1000U;
                    ++p;
                }
                if (number >= 100U)
                {
                    // 3.
                    *p = (char)((number / 100U) + 48U);
                    number %= 100U;
                    ++p;
                }
                if (number >= 10U)
                {
                    // 2.
                    *p = (char)((number / 10U) + 48U);
                    number %= 10U;
                    ++p;
                }
                if (number >= 0U)
                {
                    // 1.
                    *p = (char)(number + 48U);
                    ++p;
                }
                *p = '\0';
            }
        }

        /// <summary>
        /// <para>Manipulates an existing string to convert a 64-bit integer, while avoiding expensive memory allocations.</para>
        /// <para>WARNING: For the sake of performance, no error checks are implemented. If you have no guarantee that the 
        /// supplied string can fit the number of digits + 1 (for terminator), add your own error check!</para>
        /// </summary>
        public static unsafe void LongToStringNoAlloc(ref string mutable, long number)
        {
            fixed (char* cPointer = mutable)
            {
                char* p = cPointer;

                // Account for negative range
                if (number < 0)
                {
                    *p = '-';
                    ++p;
                    number *= -1L;
                }

                // Listed in the comments is the digit's place
                if (number >= 1000000000000000000L)
                {
                    // 19.
                    *p = (char)((number / 1000000000000000000L) + 48L);
                    number %= 1000000000000000000L;
                    ++p;
                }
                if (number >= 100000000000000000L)
                {
                    // 18.
                    *p = (char)((number / 100000000000000000L) + 48L);
                    number %= 100000000000000000L;
                    ++p;
                }
                if (number >= 10000000000000000L)
                {
                    // 17.
                    *p = (char)((number / 10000000000000000L) + 48L);
                    number %= 10000000000000000L;
                    ++p;
                }
                if (number >= 1000000000000000L)
                {
                    // 16.
                    *p = (char)((number / 1000000000000000L) + 48L);
                    number %= 1000000000000000L;
                    ++p;
                }
                if (number >= 100000000000000L)
                {
                    // 15.
                    *p = (char)((number / 100000000000000L) + 48L);
                    number %= 100000000000000L;
                    ++p;
                }
                if (number >= 10000000000000L)
                {
                    // 14.
                    *p = (char)((number / 10000000000000L) + 48L);
                    number %= 10000000000000L;
                    ++p;
                }
                if (number >= 1000000000000L)
                {
                    // 13.
                    *p = (char)((number / 1000000000000L) + 48L);
                    number %= 1000000000000L;
                    ++p;
                }
                if (number >= 100000000000L)
                {
                    // 12.
                    *p = (char)((number / 100000000000L) + 48L);
                    number %= 100000000000L;
                    ++p;
                }
                if (number >= 10000000000L)
                {
                    // 11.
                    *p = (char)((number / 10000000000L) + 48L);
                    number %= 10000000000L;
                    ++p;
                }
                if (number >= 1000000000L)
                {
                    // 10.
                    *p = (char)((number / 1000000000L) + 48L);
                    number %= 1000000000L;
                    ++p;
                }
                if (number >= 100000000L)
                {
                    // 9.
                    *p = (char)((number / 100000000L) + 48L);
                    number %= 100000000L;
                    ++p;
                }
                if (number >= 10000000L)
                {
                    // 8.
                    *p = (char)((number / 10000000L) + 48L);
                    number %= 10000000L;
                    ++p;
                }
                if (number >= 1000000L)
                {
                    // 7.
                    *p = (char)((number / 1000000L) + 48L);
                    number %= 1000000L;
                    ++p;
                }
                if (number >= 100000L)
                {
                    // 6.
                    *p = (char)((number / 100000L) + 48L);
                    number %= 100000L;
                    ++p;
                }
                if (number >= 10000L)
                {
                    // 5.
                    *p = (char)((number / 10000L) + 48L);
                    number %= 10000L;
                    ++p;
                }
                if (number >= 1000L)
                {
                    // 4.
                    *p = (char)((number / 1000L) + 48L);
                    number %= 1000L;
                    ++p;
                }
                if (number >= 100L)
                {
                    // 3.
                    *p = (char)((number / 100L) + 48L);
                    number %= 100L;
                    ++p;
                }
                if (number >= 10L)
                {
                    // 2.
                    *p = (char)((number / 10L) + 48L);
                    number %= 10L;
                    ++p;
                }
                if (number >= 0L)
                {
                    // 1.
                    *p = (char)(number + 48L);
                    ++p;
                }
                *p = '\0';
            }
        }

        /// <summary>
        /// <para>Manipulates an existing string to convert a 64-bit integer, while avoiding expensive memory allocations.</para>
        /// <para>WARNING: For the sake of performance, no error checks are implemented. If you have no guarantee that the 
        /// supplied string can fit the number of digits + 1 (for terminator), add your own error check!</para>
        /// </summary>
        public static unsafe void UlongToStringNoAlloc(ref string mutable, ulong number)
        {
            fixed (char* cPointer = mutable)
            {
                char* p = cPointer;

                // Listed in the comments is the digit's place
                if (number >= 10000000000000000000UL)
                {
                    // 20.
                    *p = (char)((number / 10000000000000000000UL) + 48UL);
                    number %= 10000000000000000000UL;
                    ++p;
                }
                if (number >= 1000000000000000000L)
                {
                    // 19.
                    *p = (char)((number / 1000000000000000000L) + 48L);
                    number %= 1000000000000000000L;
                    ++p;
                }
                if (number >= 100000000000000000L)
                {
                    // 18.
                    *p = (char)((number / 100000000000000000L) + 48L);
                    number %= 100000000000000000L;
                    ++p;
                }
                if (number >= 10000000000000000L)
                {
                    // 17.
                    *p = (char)((number / 10000000000000000L) + 48L);
                    number %= 10000000000000000L;
                    ++p;
                }
                if (number >= 1000000000000000L)
                {
                    // 16.
                    *p = (char)((number / 1000000000000000L) + 48L);
                    number %= 1000000000000000L;
                    ++p;
                }
                if (number >= 100000000000000L)
                {
                    // 15.
                    *p = (char)((number / 100000000000000L) + 48L);
                    number %= 100000000000000L;
                    ++p;
                }
                if (number >= 10000000000000L)
                {
                    // 14.
                    *p = (char)((number / 10000000000000L) + 48L);
                    number %= 10000000000000L;
                    ++p;
                }
                if (number >= 1000000000000L)
                {
                    // 13.
                    *p = (char)((number / 1000000000000L) + 48L);
                    number %= 1000000000000L;
                    ++p;
                }
                if (number >= 100000000000L)
                {
                    // 12.
                    *p = (char)((number / 100000000000L) + 48L);
                    number %= 100000000000L;
                    ++p;
                }
                if (number >= 10000000000L)
                {
                    // 11.
                    *p = (char)((number / 10000000000L) + 48L);
                    number %= 10000000000L;
                    ++p;
                }
                if (number >= 1000000000L)
                {
                    // 10.
                    *p = (char)((number / 1000000000L) + 48L);
                    number %= 1000000000L;
                    ++p;
                }
                if (number >= 100000000L)
                {
                    // 9.
                    *p = (char)((number / 100000000L) + 48L);
                    number %= 100000000L;
                    ++p;
                }
                if (number >= 10000000L)
                {
                    // 8.
                    *p = (char)((number / 10000000L) + 48L);
                    number %= 10000000L;
                    ++p;
                }
                if (number >= 1000000L)
                {
                    // 7.
                    *p = (char)((number / 1000000L) + 48L);
                    number %= 1000000L;
                    ++p;
                }
                if (number >= 100000L)
                {
                    // 6.
                    *p = (char)((number / 100000L) + 48L);
                    number %= 100000L;
                    ++p;
                }
                if (number >= 10000L)
                {
                    // 5.
                    *p = (char)((number / 10000L) + 48L);
                    number %= 10000L;
                    ++p;
                }
                if (number >= 1000L)
                {
                    // 4.
                    *p = (char)((number / 1000L) + 48L);
                    number %= 1000L;
                    ++p;
                }
                if (number >= 100L)
                {
                    // 3.
                    *p = (char)((number / 100L) + 48L);
                    number %= 100L;
                    ++p;
                }
                if (number >= 10L)
                {
                    // 2.
                    *p = (char)((number / 10L) + 48L);
                    number %= 10L;
                    ++p;
                }
                if (number >= 0L)
                {
                    // 1.
                    *p = (char)(number + 48L);
                    ++p;
                }
                *p = '\0';
            }
        }

        /// <summary>
        /// <para>Creates a new string object representation of a provided integer.</para>
        /// <para>WARNING: For the sake of performance, no error checks are implemented. Add your own error check to 
        /// validate input if you cannot guarantee that 'number' will be an integer input.</para>
        /// </summary>
        public static unsafe string IntToString(int number)
        {
            char* stringBuild = stackalloc char[12];
            char* p = stringBuild;

            // Account for negative range
            if (number < 0)
            {
                *p = '-';
                ++p;
                number *= -1;
            }

            // Listed in the comments is the digit's place
            if (number >= 1000000000)
            {
                // 10.
                *p = (char)((number / 1000000000) + 48);
                number %= 1000000000;
                ++p;
            }
            if (number >= 100000000)
            {
                // 9.
                *p = (char)((number / 100000000) + 48);
                number %= 100000000;
                ++p;
            }
            if (number >= 10000000)
            {
                // 8.
                *p = (char)((number / 10000000) + 48);
                number %= 10000000;
                ++p;
            }
            if (number >= 1000000)
            {
                // 7.
                *p = (char)((number / 1000000) + 48);
                number %= 1000000;
                ++p;
            }
            if (number >= 100000)
            {
                // 6.
                *p = (char)((number / 100000) + 48);
                number %= 100000;
                ++p;
            }
            if (number >= 10000)
            {
                // 5.
                *p = (char)((number / 10000) + 48);
                number %= 10000;
                ++p;
            }
            if (number >= 1000)
            {
                // 4.
                *p = (char)((number / 1000) + 48);
                number %= 1000;
                ++p;
            }
            if (number >= 100)
            {
                // 3.
                *p = (char)((number / 100) + 48);
                number %= 100;
                ++p;
            }
            if (number >= 10)
            {
                // 2.
                *p = (char)((number / 10) + 48);
                number %= 10;
                ++p;
            }
            if (number >= 0)
            {
                // 1.
                *p = (char)(number + 48);
                ++p;
            }
            *p = '\0';

            return new string(p);
        }

        /// <summary>
        /// <para>Creates a new string object representation of a provided unsigned integer.</para>
        /// <para>WARNING: For the sake of performance, no error checks are implemented. Add your own error check to 
        /// validate input if you cannot guarantee that 'number' will be an unsigned integer input.</para>
        /// </summary>
        public static unsafe string UintToString(uint number)
        {
            char* stringBuild = stackalloc char[11];
            char* p = stringBuild;

            // Listed in the comments is the digit's place
            if (number >= 1000000000U)
            {
                // 10.
                *p = (char)((number / 1000000000U) + 48U);
                number %= 1000000000U;
                ++p;
            }
            if (number >= 100000000U)
            {
                // 9.
                *p = (char)((number / 100000000U) + 48U);
                number %= 100000000U;
                ++p;
            }
            if (number >= 10000000U)
            {
                // 8.
                *p = (char)((number / 10000000U) + 48U);
                number %= 10000000U;
                ++p;
            }
            if (number >= 1000000U)
            {
                // 7.
                *p = (char)((number / 1000000U) + 48U);
                number %= 1000000U;
                ++p;
            }
            if (number >= 100000U)
            {
                // 6.
                *p = (char)((number / 100000U) + 48U);
                number %= 100000U;
                ++p;
            }
            if (number >= 10000U)
            {
                // 5.
                *p = (char)((number / 10000U) + 48U);
                number %= 10000U;
                ++p;
            }
            if (number >= 1000U)
            {
                // 4.
                *p = (char)((number / 1000U) + 48U);
                number %= 1000U;
                ++p;
            }
            if (number >= 100U)
            {
                // 3.
                *p = (char)((number / 100U) + 48U);
                number %= 100U;
                ++p;
            }
            if (number >= 10U)
            {
                // 2.
                *p = (char)((number / 10U) + 48U);
                number %= 10U;
                ++p;
            }
            if (number >= 0U)
            {
                // 1.
                *p = (char)(number + 48U);
                ++p;
            }
            *p = '\0';

            return new string(p);
        }

        /// <summary>
        /// <para>Creates a new string object representation of a provided 64-bit integer.</para>
        /// <para>WARNING: For the sake of performance, no error checks are implemented. Add your own error check to 
        /// validate input if you cannot guarantee that 'number' will be a 64-bit integer input.</para>
        /// </summary>
        public static unsafe string LongToString(long number)
        {
            char* stringBuild = stackalloc char[21];
            char* p = stringBuild;

            // Account for negative range
            if (number < 0)
            {
                *p = '-';
                ++p;
                number *= -1L;
            }

            // Listed in the comments is the digit's place
            if (number >= 1000000000000000000L)
            {
                // 19.
                *p = (char)((number / 1000000000000000000L) + 48L);
                number %= 1000000000000000000L;
                ++p;
            }
            if (number >= 100000000000000000L)
            {
                // 18.
                *p = (char)((number / 100000000000000000L) + 48L);
                number %= 100000000000000000L;
                ++p;
            }
            if (number >= 10000000000000000L)
            {
                // 17.
                *p = (char)((number / 10000000000000000L) + 48L);
                number %= 10000000000000000L;
                ++p;
            }
            if (number >= 1000000000000000L)
            {
                // 16.
                *p = (char)((number / 1000000000000000L) + 48L);
                number %= 1000000000000000L;
                ++p;
            }
            if (number >= 100000000000000L)
            {
                // 15.
                *p = (char)((number / 100000000000000L) + 48L);
                number %= 100000000000000L;
                ++p;
            }
            if (number >= 10000000000000L)
            {
                // 14.
                *p = (char)((number / 10000000000000L) + 48L);
                number %= 10000000000000L;
                ++p;
            }
            if (number >= 1000000000000L)
            {
                // 13.
                *p = (char)((number / 1000000000000L) + 48L);
                number %= 1000000000000L;
                ++p;
            }
            if (number >= 100000000000L)
            {
                // 12.
                *p = (char)((number / 100000000000L) + 48L);
                number %= 100000000000L;
                ++p;
            }
            if (number >= 10000000000L)
            {
                // 11.
                *p = (char)((number / 10000000000L) + 48L);
                number %= 10000000000L;
                ++p;
            }
            if (number >= 1000000000L)
            {
                // 10.
                *p = (char)((number / 1000000000L) + 48L);
                number %= 1000000000L;
                ++p;
            }
            if (number >= 100000000L)
            {
                // 9.
                *p = (char)((number / 100000000L) + 48L);
                number %= 100000000L;
                ++p;
            }
            if (number >= 10000000L)
            {
                // 8.
                *p = (char)((number / 10000000L) + 48L);
                number %= 10000000L;
                ++p;
            }
            if (number >= 1000000L)
            {
                // 7.
                *p = (char)((number / 1000000L) + 48L);
                number %= 1000000L;
                ++p;
            }
            if (number >= 100000L)
            {
                // 6.
                *p = (char)((number / 100000L) + 48L);
                number %= 100000L;
                ++p;
            }
            if (number >= 10000L)
            {
                // 5.
                *p = (char)((number / 10000L) + 48L);
                number %= 10000L;
                ++p;
            }
            if (number >= 1000L)
            {
                // 4.
                *p = (char)((number / 1000L) + 48L);
                number %= 1000L;
                ++p;
            }
            if (number >= 100L)
            {
                // 3.
                *p = (char)((number / 100L) + 48L);
                number %= 100L;
                ++p;
            }
            if (number >= 10L)
            {
                // 2.
                *p = (char)((number / 10L) + 48L);
                number %= 10L;
                ++p;
            }
            if (number >= 0L)
            {
                // 1.
                *p = (char)(number + 48L);
                ++p;
            }
            *p = '\0';

            return new string(p);
        }

        /// <summary>
        /// <para>Creates a new string object representation of a provided unsigned 64-bit integer.</para>
        /// <para>WARNING: For the sake of performance, no error checks are implemented. Add your own error check to 
        /// validate input if you cannot guarantee that 'number' will be an unsigned 64-bit integer input.</para>
        /// </summary>
        public static unsafe string UlongToString(ulong number)
        {
            char* stringBuild = stackalloc char[21];
            char* p = stringBuild;

            // Listed in the comments is the digit's place
            if (number >= 10000000000000000000UL)
            {
                // 20.
                *p = (char)((number / 10000000000000000000UL) + 48UL);
                number %= 10000000000000000000UL;
                ++p;
            }
            if (number >= 1000000000000000000L)
            {
                // 19.
                *p = (char)((number / 1000000000000000000L) + 48L);
                number %= 1000000000000000000L;
                ++p;
            }
            if (number >= 100000000000000000L)
            {
                // 18.
                *p = (char)((number / 100000000000000000L) + 48L);
                number %= 100000000000000000L;
                ++p;
            }
            if (number >= 10000000000000000L)
            {
                // 17.
                *p = (char)((number / 10000000000000000L) + 48L);
                number %= 10000000000000000L;
                ++p;
            }
            if (number >= 1000000000000000L)
            {
                // 16.
                *p = (char)((number / 1000000000000000L) + 48L);
                number %= 1000000000000000L;
                ++p;
            }
            if (number >= 100000000000000L)
            {
                // 15.
                *p = (char)((number / 100000000000000L) + 48L);
                number %= 100000000000000L;
                ++p;
            }
            if (number >= 10000000000000L)
            {
                // 14.
                *p = (char)((number / 10000000000000L) + 48L);
                number %= 10000000000000L;
                ++p;
            }
            if (number >= 1000000000000L)
            {
                // 13.
                *p = (char)((number / 1000000000000L) + 48L);
                number %= 1000000000000L;
                ++p;
            }
            if (number >= 100000000000L)
            {
                // 12.
                *p = (char)((number / 100000000000L) + 48L);
                number %= 100000000000L;
                ++p;
            }
            if (number >= 10000000000L)
            {
                // 11.
                *p = (char)((number / 10000000000L) + 48L);
                number %= 10000000000L;
                ++p;
            }
            if (number >= 1000000000L)
            {
                // 10.
                *p = (char)((number / 1000000000L) + 48L);
                number %= 1000000000L;
                ++p;
            }
            if (number >= 100000000L)
            {
                // 9.
                *p = (char)((number / 100000000L) + 48L);
                number %= 100000000L;
                ++p;
            }
            if (number >= 10000000L)
            {
                // 8.
                *p = (char)((number / 10000000L) + 48L);
                number %= 10000000L;
                ++p;
            }
            if (number >= 1000000L)
            {
                // 7.
                *p = (char)((number / 1000000L) + 48L);
                number %= 1000000L;
                ++p;
            }
            if (number >= 100000L)
            {
                // 6.
                *p = (char)((number / 100000L) + 48L);
                number %= 100000L;
                ++p;
            }
            if (number >= 10000L)
            {
                // 5.
                *p = (char)((number / 10000L) + 48L);
                number %= 10000L;
                ++p;
            }
            if (number >= 1000L)
            {
                // 4.
                *p = (char)((number / 1000L) + 48L);
                number %= 1000L;
                ++p;
            }
            if (number >= 100L)
            {
                // 3.
                *p = (char)((number / 100L) + 48L);
                number %= 100L;
                ++p;
            }
            if (number >= 10L)
            {
                // 2.
                *p = (char)((number / 10L) + 48L);
                number %= 10L;
                ++p;
            }
            if (number >= 0L)
            {
                // 1.
                *p = (char)(number + 48L);
                ++p;
            }
            *p = '\0';

            return new string(p);
        }

    }
}
