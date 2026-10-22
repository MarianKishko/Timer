using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public struct Timers
    {
        private int _hour = 0, _minute = 0, _second = 0;
        private string _title;

        public int Hour => _hour;
        public int Minute => _minute;
        public int Second => _second;
        public string Title => _title;

        public Timers(int hour, int minute, int second)
        {
            _hour = hour;
            _minute = minute;
            _second = second;

            //if (_hour != 0 && _minute != 0 && _second != 0) 
            _title = SetTitle(_hour, _minute, _second);
        }

        private string SetTitle(int hour, int min, int sec)
        {
            string fututeTitle = "";

            if (hour != 0)
            {
                if (hour > 1)
                    fututeTitle += hour + " hours ";
                else
                    fututeTitle += hour + " hour ";
            }
            if (min != 0)
                fututeTitle += min + " min ";
            if (sec != 0)
                fututeTitle += sec + " sec ";

            return fututeTitle;
        }

        public override string ToString()
        {
            return _title;
        }
    }
}
