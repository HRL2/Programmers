using System.Linq;

namespace ConsoleProject
{
    class Day04
    {
        /// <summary>
        /// 체육복
        /// date : 2020-09-04
        /// </summary>
        /// <param name="n"></param>
        /// <param name="lost"></param>
        /// <param name="reserve"></param>
        /// <returns></returns>
        public int solution(int n, int[] lost, int[] reserve)
        {
            int answer = n - lost.Count();
            var lostClone = (int[])lost.Clone();
            
            foreach(var item in reserve.Intersect(lost))
            {
                answer++;
                lost[lost.ToList().IndexOf(item)] = -1;
            }

            foreach (var item in reserve.Except(lostClone))
            {
                var temp = lost.FirstOrDefault(p => p == item + 1 || p == item - 1);

                if (temp != 0)
                {
                    answer++;
                    lost[lost.ToList().IndexOf(temp)] = -1;
                }
            }

            return answer;
        }
    }
}
