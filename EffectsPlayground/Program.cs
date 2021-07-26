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

                Console.WriteLine("WARNING: quick chirpy sounds coming up after you press any key. Prepare your volume.");

                Console.ReadKey();

                TextEffects.TypewriteWithSounds("\nHi. Now it's got sound! How cool is that? Annoying?");

                Console.ReadKey();

                TextEffects.TypewriteHumanized("\nHow about a humanized typewriter effect? It's just... I want you to feel like a human is here. Typing. Slowly with attitude. :)");

                Console.ReadKey();

                TextEffects.Typewrite("An old familiar song starts to play...");
                TextEffects.Typewrite("Press CTRL + C to quit or, ya know, just click the X");

                MusicPlayer.PlaySuperMarioThemeSong();
            }
            
            
        }
    }
}
