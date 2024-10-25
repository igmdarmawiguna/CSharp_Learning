using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication33
{
    abstract class SoundDriver
    {
        public void vol() {Console.WriteLine("Control volume"); }
        public void mute() { Console.WriteLine("Set vol = 0"); }
    }

    class MusicPlayer : SoundDriver
    {
        public void play()
        {
            base.mute();
            base.vol();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MusicPlayer p = new MusicPlayer();
            p.play();
        }
    }
}
