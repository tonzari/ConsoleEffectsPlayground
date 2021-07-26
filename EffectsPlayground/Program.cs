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

                TextEffects.TypewriteWithSounds("\nHi. Now it's got sound! How cool is that? Annoying?");

                Console.ReadKey();

                TextEffects.TypewriteHumanized("\nHow about a humanized typewriter effect? It's just... I want you to feel like a human is here. Typing. Slowly with attitude. :)");

                Console.ReadKey();

                TextEffects.TypewriteHumanized("An old familiar song starts to play...");
                TextEffects.TypewriteHumanized("Press CTRL + C to quit or, ya know, just click the X");

                MusicPlayer.PlaySuperMarioThemeSong();
            }
            
            
        }
    }
}
