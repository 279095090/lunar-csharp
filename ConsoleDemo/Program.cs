using System;
using System.Collections.Generic;
using System.Text;
using com.nlf.calendar;
using com.nlf.calendar.util;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ����
            Solar solar = new Solar(2020,5,26,23,42,0);
            Console.WriteLine(solar);
            Console.WriteLine(solar.toFullString());

            // ����
            Lunar lunar = solar.getLunar();
            Console.WriteLine(lunar);
            Console.WriteLine(lunar.toFullString());

            // ����
            foreach(string s in lunar.getBaZi()){
                Console.Write(s+" ");
            }
            Console.WriteLine();

            // ��������
            foreach (string s in lunar.getBaZiNaYin())
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            // �������ʮ��
            foreach (string s in lunar.getBaZiShiShenGan())
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            // ���ֵ�֧ʮ��
            foreach (string s in lunar.getBaZiShiShenZhi())
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            // ������֧ʮ��
            foreach (string s in lunar.getBaZiShiShenYearZhi())
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            // ������֧ʮ��
            foreach (string s in lunar.getBaZiShiShenMonthZhi())
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            // ������֧ʮ��
            foreach (string s in lunar.getBaZiShiShenDayZhi())
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            // ����ʱ֧ʮ��
            foreach (string s in lunar.getBaZiShiShenTimeZhi())
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            // ��������
            foreach (string s in lunar.getBaZiWuXing())
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            // �ڼ���
            List<Holiday> holidays = HolidayUtil.getHolidays(2012);
            foreach (Holiday holiday in holidays)
            {
                Console.WriteLine(holiday);
            }
            Console.WriteLine();

            // ����ת����
            List<Solar> solars = Solar.fromBaZi("����", "����", "��î", "����");
            foreach (Solar d in solars)
            {
                Console.WriteLine(d.toFullString());
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
