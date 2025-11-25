using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lesson4_Task2
{

    public interface IPlayable {

        void Play();
        void Pause();
        void Stop();
    
    }
    public interface IRecordable {
        void Record();
        void Pause();
        void Stop();
    }

    public class Player : IPlayable, IRecordable
    {
        void IPlayable.Play()
        {
            Console.WriteLine("Начато проигрывание");
            Console.WriteLine();
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Проигрывание приостановлено");
            Console.WriteLine();
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Проигрывание остановлено");
            Console.WriteLine();
        }

        void IRecordable.Record()
        {
            Console.WriteLine("Запись начата");
            Console.WriteLine();
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Запись приостановлена");
            Console.WriteLine();
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Запись остановлена");
            Console.WriteLine();
        }

        public void StartPlay()
        {
            IPlayable playable = this;

            playable.Play();
            Thread.Sleep(2000);
            playable.Pause();
            Thread.Sleep(1000);
            playable.Stop();
            Thread.Sleep(1000);
        }

        public void StartRecord()
        {
            IRecordable recordable = this;

            recordable.Record();
            Thread.Sleep(2000);
            recordable.Pause();
            Thread.Sleep(1000);
            recordable.Stop();
            Thread.Sleep(1000);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.StartRecord();
            player.StartPlay();
        }
    }
}
