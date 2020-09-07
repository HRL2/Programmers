using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleProject
{
    class Day05
    {
        /// <summary>
        /// 2016년 월,일 의 요일 구하기
        /// date : 2020-09-08
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string solution(int a, int b)
        {
            string answer = "";

            DateTime date = new DateTime(2016, a, b);

            switch(date.DayOfWeek)
            {
                case DayOfWeek.Monday: answer = "MON"; break;
                case DayOfWeek.Tuesday: answer = "TUE"; break;
                case DayOfWeek.Wednesday: answer = "WEN"; break;
                case DayOfWeek.Thursday: answer = "THU"; break;
                case DayOfWeek.Friday: answer = "FRI"; break;
                case DayOfWeek.Saturday: answer = "SAT"; break;
                case DayOfWeek.Sunday: answer = "SUN"; break;
            }

            return answer;
        }

        /// <summary>
        /// 나누어 떨어지는 숫자 배열
        /// date : 2020-09-08
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public int[] solution(int[] arr, int divisor)
        {
            var temp = new List<int>();
            Array.Sort(arr);

            foreach (var item in arr)
            {
                if (item % divisor == 0)
                    temp.Add(item);
            }

            return temp.Count == 0 ? new int[] { -1 } : temp.ToArray();
        }

        /// <summary>
        /// 문자열 다루기 기본
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool solution(string s)
        {
            int i = 0;

            if(s.Length == 4 || s.Length == 6)
            {
                return Int32.TryParse(s, out i);
            }

            return false;
        }

        /// <summary>
        /// 문자열 내 마음대로 정렬하기
        /// date : 2020-09-08
        /// </summary>
        /// <param name="strings"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public string[] solution(string[] strings, int n)
        {
            string[] answer = new string[strings.Length];

            var charList = strings.Select(p => p.ElementAt(n)).Distinct().OrderBy(p => p);

            int index = 0;

            foreach(var ch in charList)
            {
                var temp = strings.Where(p => p.ElementAt(n) == ch).OrderBy(p => p);
                
                foreach(var item in temp)
                {
                    answer[index] = item;
                    index++;
                }
            }

            return answer;
        }

        /// <summary>
        /// 문자열을 정수로 만들기
        /// date : 2020-09-08
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int solution2(string s)
        {
            if(s.StartsWith("-"))
            {
                return Int32.Parse(s.Substring(1, s.Length - 2)) * -1;
            }
            else
            {
                return Int32.Parse(s);
            }
        }
    }
}
