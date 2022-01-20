using System;
using System.Collections.Generic;
using System.Text;
using com.nlf.calendar.util;

namespace com.nlf.calendar
{
    class ExactDate
    {
        public static DateTime fromYmdHms(int year, int month, int day, int hour, int minute, int second)
        {
            if (year < 1)
            {
                throw new ArgumentOutOfRangeException("solar year must bigger than 0");
            }
            return new DateTime(year, month, day, hour, minute, second, 0, DateTimeKind.Utc);
        }

        public static DateTime fromYmd(int year, int month, int day)
        {
            return fromYmdHms(year, month, day, 0, 0, 0);
        }

        public static DateTime fromDate(DateTime date)
        {
            return fromYmdHms(date.Year, date.Month, date.Day, date.Hour, date.Minute,date.Second);
        }

        /// <summary>
        /// ��ȡ��������֮�������������������a������bС������Ϊ�����������a������b������Ϊ����
        /// </summary>
        /// <param name="ay">��a</param>
        /// <param name="am">��a</param>
        /// <param name="ad">��a</param>
        /// <param name="by">��b</param>
        /// <param name="bm">��b</param>
        /// <param name="bd">��b</param>
        /// <returns></returns>
        public static int getDaysBetween(int ay, int am, int ad, int by, int bm, int bd)
        {
            int n;
            int days;
            int i;
            if (ay == by)
            {
                n = SolarUtil.getDaysInYear(by, bm, bd) - SolarUtil.getDaysInYear(ay, am, ad);
            }
            else if (ay > by)
            {
                days = SolarUtil.getDaysOfYear(by) - SolarUtil.getDaysInYear(by, bm, bd);
                for (i = by + 1; i < ay; i++)
                {
                    days += SolarUtil.getDaysOfYear(i);
                }
                days += SolarUtil.getDaysInYear(ay, am, ad);
                n = -days;
            }
            else
            {
                days = SolarUtil.getDaysOfYear(ay) - SolarUtil.getDaysInYear(ay, am, ad);
                for (i = ay + 1; i < by; i++)
                {
                    days += SolarUtil.getDaysOfYear(i);
                }
                days += SolarUtil.getDaysInYear(by, bm, bd);
                n = days;
            }
            return n;
        }

        /// <summary>
        /// ��ȡ��������֮�������������������a������bС������Ϊ�����������a������b������Ϊ����
        /// </summary>
        /// <param name="date0">����a</param>
        /// <param name="date1">����b</param>
        /// <returns>����</returns>
        public static int getDaysBetween(DateTime date0, DateTime date1)
        {
            return getDaysBetween(date0.Year, date0.Month, date0.Day, date1.Year, date1.Month, date1.Day);
        }
    }
}
