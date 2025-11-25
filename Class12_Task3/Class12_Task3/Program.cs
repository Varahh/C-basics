using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class12_Task3
{
    internal class Program
    {
        public class Date
        {
            private int year, month, day;
            private DateTime _date;

            public Date(int year, int month, int day)
            {
                this.year = year;
                this.month = month;
                this.day = day;

                _date = new DateTime(year, month, day);
            }
            public static int operator -(Date a, Date b)
            {
                return Math.Abs((a._date - b._date).Days);
            }

            public static Date operator +(Date a, int days)
            {
                DateTime newDate = a._date.AddDays(days);
                return new Date(newDate.Year, newDate.Month, newDate.Day);
            }

            public override string ToString() {
                return $"{this.year} - {this.month} - {this.day}";
            }
            static void Main(string[] args)
            {
                Date date1 = new Date(2000, 11, 29);
                Date date2 = new Date(1999, 11, 29);
                Console.WriteLine(date1 - date2 + " дней");
                Date date2add = date2 + 310;
                Console.WriteLine(date2add.ToString());
            }
        }
    }
}
