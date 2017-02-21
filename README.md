
Fast Conversions Library (FCL)

By: Roy Hwang

Target Framework: .NET 4.6

- Must have "allow unsafe code" enabled

===================================
About:
===================================

This is the Fast Conversions Library, or FCL! The primary purpose of this 
library is to allow for type conversions without needless allocations, and providing 
faster functions for doing so. This is pretty important for 
applications and platforms where you must focus heavily on alleviating garbage 
collector pressure, and maintain a high baseline performance level, such as a video game.

While modern garbage collectors are quite excellent, not everyone has the luxury 
of working on a platform or hardware set where these collectors are available. 
Enter FCL!

This library can help to avoid garbage collector spikes by being smart with allocations, 
and also by increasing the performance of your code in critical sections. The C# .NET 
standard library is generally excellent at avoiding needless allocations, but also 
can be quite a bit slower than a hand-rolled implementation of your own.

My hope is that you find this library useful for your needs, as I've designed it 
particularly with performance in mind (which is why there are so many variations 
available, even though I could have used generics). In the interest of performance, 
I have assumed that you will use these methods with some idea of what kind of input 
your program will be accepting.  If you do not know, it is extremely trivial to 
add error checks to each of these methods yourself.

Let me state it again: THERE ARE NO DEFAULT ERROR CHECKS! You should implement them yourself 
in the event that you need them. I feel it is better this way since you can implement 
only what you require.

Also, you'll find that some of the methods make use of the "[MethodImpl(MethodImplOptions.AggressiveInlining)]" hint. 
If you are targeting a framework in your own project which does not support this, you can simply remove the 
attribute, and either leave the method as is or manually inline it yourself (you should consider the ramifications 
of forcing an inlined method before implementing it).

Have fun! And don't forget to profile any changes!!! Not all substitutions will be faster for every machine!

Criticism, improvements, and suggestions are always welcome.
