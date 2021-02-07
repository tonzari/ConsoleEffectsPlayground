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

            }
            
            
        }
    }
}
