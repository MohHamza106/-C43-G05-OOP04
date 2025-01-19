using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.overload
{
    internal class Duration
    {
        #region attribute
        private int Hours { get; set; }
        private int Minutes { get; set; }
        private int Seconds { get; set; }
        #endregion
        #region Constructors
        public Duration() { }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int number)
        {

            Minutes = (number / 60) % 60;
            Hours = number / 60 / 60;
            Seconds = number % 60;
        }

        public static Duration operator +(Duration left, Duration right)
        {
            return new Duration()
            {
                Hours = left.Hours + right.Hours,
                Minutes = left.Minutes + right.Minutes,
                Seconds = left.Seconds + right.Seconds
            };

        }
        public static Duration operator -(Duration left, Duration right)
        {
            return new Duration()
            {
                Hours = left.Hours - right.Hours,
                Minutes = left.Minutes - right.Minutes,
                Seconds = left.Seconds - right.Seconds
            };

        }
        public static Duration operator +(int left, Duration right)
        {
            return new Duration()
            {
                Hours = left + right.Hours,
                Minutes = left + right.Minutes,
                Seconds = left + right.Seconds
            };
        }
        public static Duration operator +(Duration left, int right)
        {
            return new Duration()
            {
                Hours = left.Hours + right,
                Minutes = left.Hours + right,
                Seconds = left.Seconds + right
            };
        }


        public static Duration operator ++(Duration duration)
        {
            return new Duration()
            {
                Hours = ++duration.Hours,
                Minutes = ++duration.Minutes,
                Seconds = ++duration.Seconds
            };
        }
        public static Duration operator --(Duration duration)
        {
            return new Duration()
            {
                Hours = --duration.Hours,
                Minutes = --duration.Minutes,
                Seconds = --duration.Seconds
            };
        }

        public static bool operator >(Duration left,Duration right)
        {
            if (left.Hours > right.Hours && left.Minutes>right.Minutes && left.Seconds>right.Seconds)
            {
              return true;
            }
            else 
            {
             return false;
                        
            }
        }
        public static bool operator <(Duration left, Duration right)
        {
            if (left.Hours <= right.Hours && left.Minutes <= right.Minutes && left.Seconds <= right.Seconds)
            {
                return true; 
            }
            else
            {
                return false; 


            }
        }
        public static bool operator <=(Duration left, Duration right)
        {
            if (left.Hours > right.Hours && left.Minutes > right.Minutes && left.Seconds > right.Seconds)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        public static bool operator >=(Duration left, Duration right)
        {
            if (left.Hours > right.Hours && left.Minutes > right.Minutes && left.Seconds > right.Seconds)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        public static explicit operator bool(Duration obj)
        {
            if (obj == null) return true;
            else return false;
        }
        public static explicit operator DateTime(Duration obj)
        {
            return new DateTime();
        
        }
        #endregion
        #region method
        public override string ToString()
        {
            return $"hour={Hours} Minutes={Minutes} Seconds={Seconds}";
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion


    }
}
