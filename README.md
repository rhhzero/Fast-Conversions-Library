
============================
About:
============================

This is the No Allocations Conversions Library, or NACL! The primary purpose of this 
library is to allow for type conversions without needless allocations, as many of the 
.NET methods do (ToString() being a popular example). This is pretty important for 
applications and platforms where you must focus heavily on alleviating garbage 
collector pressure, such as in a video game.

While modern garbage collectors are quite excellent, not everyone has the luxury 
of working on a platform or hardware set where these collectors are available. 
Enter NACL!

Avoiding allocations help to avoid garbage collector spikes, but also increase 
the performance of your code in critical sections, since allocations are not 
a free operation. In fact, they can be quite costly and can often be the bottleneck 
in a tight and unoptimized loop which allocates on each iteration. It is for this 
reason that even if you are blessed to be able to develop for a target platform 
which has strong processing power and the latest garbage collectors available, 
you should still aim to avoid needless allocations.

My hope is that you find this library useful for your needs, as I've designed it 
particularly with performance in mind (which is why there are so many variations 
available, even though I could have used generics). In the interest of performance, 
I have assumed that you will use these methods with some idea of what kind of input 
your program will be accepting.  If you do not know, it is extremely trivial to 
add error checks to each of these methods yourself. 

Let me state it again: THERE ARE NO DEFAULT ERROR CHECKS! You should implement them yourself 
in the likely event that you will need them. I feel it is better this way since you can implement 
only what you require.

Have fun! And don't forget to profile any changes!!!

Criticism, improvements, and suggestions are always welcome.

- Roy Hwang
