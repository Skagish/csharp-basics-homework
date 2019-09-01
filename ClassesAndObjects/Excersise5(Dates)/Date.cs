using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise5_Dates_
{
    class Date
    {
        private int _day;
        private int _month;
        private int _year;

        public Date(int day, int month, int year)
        {
            _year = year;
            _month = month;
            _day = day;
        }

        public void SetDay(int day)
        {
            _day = day;
        }
        public int GetDay()
        {
            return _day;
        }
        public void SetMonth(int month)
        {
            _month = month;
        }
        public int GetMonth()
        {
            return _month;
        }
        public void SetYear(int year)
        {
            _year = year;
        }
        public int Getyear()
        {
            return _year;
        }

        public DateTime DisplayDate()
        {
            var time = new DateTime(_year,_month,_day);
            return time;
        }
    }
}
