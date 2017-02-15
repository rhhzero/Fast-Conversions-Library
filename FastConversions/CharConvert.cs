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

using System.Runtime.CompilerServices;

namespace NACL
{
    /// <summary>
    /// Convert a char to another type.
    /// </summary>
    public static class CharConvert
    {
        /// <summary>
        /// Converts a char to an integer. There is NO input validation! Be aware!
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CharToInt(char c)
        {
            return c - '0';
        }

        /// <summary>
        /// Converts a char to an unsigned integer. There is NO input validation! Be aware!
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint CharToUint(char c)
        {
            return (uint)(c - '0');
        }

        /// <summary>
        /// Converts a char to a 64 bit integer. There is NO input validation! Be aware!
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long CharToLong(char c)
        {
            return c - '0';
        }

        /// <summary>
        /// Converts a char to an unsigned 64 bit integer. There is NO input validation! Be aware!
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong CharToUlong(char c)
        {
            return (ulong)(c - '0');
        }

        /// <summary>
        /// Converts a char array to an integer. Beware there is NO input validation! Use CharArrayToIntTerminated 
        /// for char arrays which are terminated with '\0' character.
        /// </summary>
        public static int CharArrayToInt(char[] charArray)
        {
            int len = charArray.Length;
            int multiplier = len - 1;
            int total = 0;
            for (int i = 0; i < len; ++i)
            {
                int digit = charArray[i] - '0';
                for (int j = 0; j < multiplier; ++j)
                {
                    digit *= 10;
                }
                total += digit;
                --multiplier;
            }
            return total;
        }

        /// <summary>
        /// Converts a char array to an integer. Beware there is NO input validation! Use CharArrayToIntTerminated 
        /// for char arrays which are terminated with '\0' character.
        /// </summary>
        public static uint CharArrayToUint(char[] charArray)
        {
            int len = charArray.Length;
            int multiplier = len - 1;
            uint total = 0;
            for (int i = 0; i < len; ++i)
            {
                uint digit = (uint)(charArray[i] - '0');
                for (int j = 0; j < multiplier; ++j)
                {
                    digit *= 10U;
                }
                total += digit;
                --multiplier;
            }
            return total;
        }

        /// <summary>
        /// Converts a char array to an integer. Beware there is NO input validation! Use CharArrayToIntTerminated 
        /// for char arrays which are terminated with '\0' character.
        /// </summary>
        public static long CharArrayToLong(char[] charArray)
        {
            int len = charArray.Length;
            int multiplier = len - 1;
            long total = 0;
            for (int i = 0; i < len; ++i)
            {
                long digit = charArray[i] - '0';
                for (int j = 0; j < multiplier; ++j)
                {
                    digit *= 10L;
                }
                total += digit;
                --multiplier;
            }
            return total;
        }

        /// <summary>
        /// Converts a char array to an integer. Beware there is NO input validation! Use CharArrayToIntTerminated 
        /// for char arrays which are terminated with '\0' character.
        /// </summary>
        public static ulong CharArrayToUlong(char[] charArray)
        {
            int len = charArray.Length;
            int multiplier = len - 1;
            ulong total = 0;
            for (int i = 0; i < len; ++i)
            {
                ulong digit = (ulong)(charArray[i] - '0');
                for (int j = 0; j < multiplier; ++j)
                {
                    digit *= 10UL;
                }
                total += digit;
                --multiplier;
            }
            return total;
        }
    }
}
