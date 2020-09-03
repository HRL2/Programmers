using System.Collections.Generic;
using System.Linq;

namespace ConsoleProject
{
    /// <summary>
    /// 수포자 모의고사 문제
    /// date : 2020-09-01
    /// </summary>
    class Day01
    {
        public int[] Solution(int[] answers)
        {
            int[] answer = { };

            Dictionary<int, int[]> a = new Dictionary<int, int[]>();
            a.Add(1, new int[] { 1, 2, 3, 4, 5 });
            a.Add(2, new int[] { 2, 1, 2, 3, 2, 4, 2, 5 });
            a.Add(3, new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 });

            var counts = CalcCount(answers, a);

            return GetResultAnswer(counts);
        }

        private int[] GetResultAnswer(Dictionary<int, int> resultCount)
        {
            List<int> result = new List<int>();

            var max = resultCount.Max(p => p.Value);

            var checkList = resultCount.Where(p => p.Value == max);

            foreach(var item in checkList)
            {
                result.Add(item.Key);
            }

            return result.OrderBy(p => p).ToArray();
        }

        private static Dictionary<int, int> CalcCount(int[] answers, Dictionary<int, int[]> a)
        {
            var resultCount = new Dictionary<int, int>();
            resultCount.Add(1, 0);
            resultCount.Add(2, 0);
            resultCount.Add(3, 0);

            int index1 = 0, index2 = 0, index3 = 0;

            foreach (var ans in answers)
            {
                if (ans == (int)a[1].GetValue(index1))
                {
                    resultCount[1]++;
                }

                if (ans == (int)a[2].GetValue(index2))
                {
                    resultCount[2]++;
                }

                if (ans == (int)a[3].GetValue(index3))
                {
                    resultCount[3]++;
                }

                index1 = index1 == a[1].Length -1 ? 0 : index1 + 1;
                index2 = index2 == a[2].Length -1 ? 0 : index2 + 1;
                index3 = index3 == a[3].Length -1 ? 0 : index3 + 1;
            }

            return resultCount;
        }
    }
}
