using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleProject
{
    class Day03
    {
        /// <summary>
        /// 가운데 글자 가져오기
        /// date : 2020-09-03
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string solution(string s)
        {
            string answer = "";

            answer = s.Length % 2 == 0 ? s.Substring(s.Length / 2 - 1, 2) : s.Substring(s.Length / 2, 1);

            return answer;
        }

        /// <summary>
        /// 두 정수 사이의 합
        /// dae : 2020-09-03
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public long solution(int a, int b)
        {
            long min, max;
            List<long> list = new List<long>();

            if(a > b) { min = b; max = a; }
            else { min = a; max = b; }

            for (long i = min; i <= max; i++ )
            {
                list.Add(i);
            }

            return list.Sum();
        }

        /// <summary>
        /// 서울에서 김서방 찾기
        /// date : 2020-09-03
        /// </summary>
        /// <param name="seoul"></param>
        /// <returns></returns>
        public string solution(string[] seoul)
        {
            string answer = "";

            var index = seoul.ToList().IndexOf("Kim");
            //var index = Array.FindIndex(seoul, i => i == "Kim");

            answer = string.Format("김서방은 {0}에 있다");

            return answer;
        }

        /// <summary>
        /// 수박수박수박수박수..
        /// date : 2020-09-03
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string solution(int n)
        {
            StringBuilder sb = new StringBuilder();

            int i = 0;
            while(i < n)
            {
                sb.Append(n % 2 == 0 ? "수" : "박");
                i++;
            }

            return sb.ToString();
        }

        /// <summary>
        /// 문자열 내림차순으로 배치하기
        /// date : 2020-09-03
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string solution2(string s)
        {
            var lower = s.Where(char.IsLower).OrderByDescending(p => p).ToList();
            var upper = s.Where(char.IsUpper).OrderByDescending(p => p).ToList();

            lower.AddRange(upper);

            return string.Join("", lower);
        }
    }
}
