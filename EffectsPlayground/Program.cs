using System;

namespace EffectsPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                TextEffects.Typewrite("Here's a basic typewriter effect.");

                Console.ReadKey();

                TextEffects.TypewriteSound("\nHi. Now it's got sound! How cool is that? Annoying?");

                Console.ReadKey();

                TextEffects.TypeLikeHuman("\nWell, I'm sorry. It's just... I want you to feel like a human is here. Typing. With attitude.");

                Console.ReadKey();

                TextEffects.TypeLikeHuman("Cash isn’t the only thing I take from my father’s study when I leave home. I take a small, old gold lighter—I like the design and feel of it—and a folding knife with a really sharp blade. Made to skin deer, it has a five-inch blade and a nice heft. Probably something he bought on one of his trips abroad. I also take a sturdy, bright pocket flashlight out of a drawer. Plus sky blue Revo sunglasses to disguise my age.");

            }
            
            
        }
    }
}
