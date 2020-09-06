using System;
using System.Collections.Generic;
using System.Text;
using com.nlf.calendar;
using com.nlf.calendar.util;
using com.nlf.calendar.eightchar;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ����
            Solar solar = new Solar(2020, 5, 26, 23, 42, 0);
            Console.WriteLine(solar);
            Console.WriteLine(solar.toFullString());

            // ����
            Lunar lunar = solar.getLunar();
            Console.WriteLine(lunar);
            Console.WriteLine(lunar.toFullString());

            // ����
            EightChar baZi = lunar.getEightChar();
            Console.WriteLine(baZi.getYear() + " " + baZi.getMonth() + " " + baZi.getDay() + " " + baZi.getTime());

            // ��������
            Console.WriteLine(baZi.getYearNaYin() + " " + baZi.getMonthNaYin() + " " + baZi.getDayNaYin() + " " + baZi.getTimeNaYin());

            // ��������
            Console.WriteLine(baZi.getYearWuXing() + " " + baZi.getMonthWuXing() + " " + baZi.getDayWuXing() + " " + baZi.getTimeWuXing());

            // �������ʮ��
            Console.WriteLine(baZi.getYearShiShenGan() + " " + baZi.getMonthShiShenGan() + " " + baZi.getDayShiShenGan() + " " + baZi.getTimeShiShenGan());

            // ���ֵ�֧ʮ��
            Console.WriteLine(baZi.getYearShiShenZhi()[0] + " " + baZi.getMonthShiShenZhi()[0] + " " + baZi.getDayShiShenZhi()[0] + " " + baZi.getTimeShiShenZhi()[0]);

            // ������֧ʮ��
            foreach (string s in baZi.getYearShiShenZhi())
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            // ������֧ʮ��
            foreach (string s in baZi.getMonthShiShenZhi())
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            // ������֧ʮ��
            foreach (string s in baZi.getDayShiShenZhi())
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            // ����ʱ֧ʮ��
            foreach (string s in baZi.getTimeShiShenZhi())
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            // ����̥Ԫ
            Console.WriteLine(baZi.getTaiYuan());

            // ��������
            Console.WriteLine(baZi.getMingGong());

            // ������
            Console.WriteLine(baZi.getShenGong());

            Console.WriteLine();
            solar = new Solar(1988, 3, 20, 18, 0, 0);
            lunar = solar.getLunar();
            EightChar bazi = lunar.getEightChar();

            // ����
            Yun yun = bazi.getYun(1);
            Console.WriteLine("����" + solar.toYmdHms() + "����");
            Console.WriteLine("����" + yun.getStartYear() + "��" + yun.getStartMonth() + "����" + yun.getStartDay() + "�������");
            Console.WriteLine("����" + yun.getStartSolar().toYmd() + "������");
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
