using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Task1
{
    public class ClassRoom
    {
        private Pupil[] pupils = new Pupil[4];
        public ClassRoom(params Pupil[] knownpupils)
        {
            for (int i = 0; i < knownpupils.Length && i < 4; i++)
            {
                this.pupils[i] = knownpupils[i];
            }

            for (int i = knownpupils.Length; i < this.pupils.Length; i++)
            {
                this.pupils[i] = new Pupil();
            }
        }
        public void showInfo()
        {
            foreach (var p in this.pupils)
            {
                p.Study();
                p.Read();
                p.Write();
                p.Relax();
                Console.WriteLine();
            }
        }
    }

    public class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Обычный ученик учится но так себе");
        }
        public virtual void Read() 
        {
            Console.WriteLine("Обычный ученик читает но отвлекается на игры");
        }
        public virtual void Write()
        { 
           Console.WriteLine("Обычный ученик пишет но допускает ошибки"); 
        }
        public virtual void Relax()
        {
            Console.WriteLine("Обычный ученик проводит время за телевизором");
        }
    }

    public class ExcelentPupil : Pupil 
    {
        public override void Study()
        {
            Console.WriteLine("Отличник учится сразу пяти вещам одновременно");
        }
        public override void Read()
        {
            Console.WriteLine("Отличник во время чтения сразу переводит текст на испанский");
        }
        public override void Write()
        {
            Console.WriteLine("Отличник пишет безошибочно и каллиграфическим почерком");
        }
        public override void Relax()
        {
            Console.WriteLine("Во время отдыха отличник ставит эксперименты по физике и химии");
        }
    }
    public class GoodPupil : Pupil {
        public override void Study()
        {
            Console.WriteLine("Прилежный ученик учится не отвлекаясь");
        }
        public override void Read()
        {
            Console.WriteLine("Прилежный ученик читает выразительно и сосредоточенно");
        }
        public override void Write()
        {
            Console.WriteLine("Прилежный ученик пишет безошибочно");
        }
        public override void Relax()
        {
            Console.WriteLine("Прилежный ученик отдыхает на прогулке");
        }
    }
    public class BadPupil : Pupil {
        public override void Study()
        {
            Console.WriteLine("Вместо учебы двоечник играет в компьютер");
        }
        public override void Read()
        {
            Console.WriteLine("Двоечник во время чтения отпускает неуместные шуточки");
        }
        public override void Write()
        {
            Console.WriteLine("Вместо письма двоечник рисует в тетради всякие непотребства");
        }
        public override void Relax()
        {
            Console.WriteLine("Двоечник отдыхает почти весь день не оставляя время учебе");
        }
    }





    internal class Program
    {
        static void Main(string[] args)
        {
            GoodPupil good = new GoodPupil();
            BadPupil bad = new BadPupil();
            ExcelentPupil excelent = new ExcelentPupil();
            ClassRoom room = new ClassRoom(good, bad, excelent);
            room.showInfo();
        }
    }
}
