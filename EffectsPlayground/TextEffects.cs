using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EffectsPlayground
{
    class TextEffects
    {
        public static void Typewrite(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(60);
            }
        }

        public static void Typewrite(string message, int duration)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(duration);
            }
        }

        public static void TypewriteWithSounds(string message)
        {
            int duration = 30;

            for (int i = 0; i < message.Length; i++)
            {
                MusicPlayer.PlayNote(Note.C5, duration);
                Console.Write(message[i]);
                Thread.Sleep(duration);
            }
        }

        public static void TypewriteHumanized(string message)
        {
            int duration = 15;
            Random rnd = new Random();

            for (int i = 0; i < message.Length; i++)
            {
                if (char.IsWhiteSpace(message[i]))
                {
                    Console.Write(message[i]);
                    Thread.Sleep(duration * 5 + rnd.Next(1, 100));
                }
                else if (message[i].Equals('.'))
                {
                    Console.Write(message[i]);
                    Thread.Sleep(duration * 10 + rnd.Next(400, 1300));
                }
                else if (char.IsPunctuation(message[i]))
                {
                    Console.Write(message[i]);
                    Thread.Sleep(duration * 10 + rnd.Next(10, 600));
                }
                else
                {
                    Console.Write(message[i]);
                    Thread.Sleep(duration + rnd.Next(10, 40));
                }
                
            }
        }
    }
}
