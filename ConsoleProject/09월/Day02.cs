using System.Collections.Generic;
using System.Linq;

namespace ConsoleProject
{
    /// <summary>
    /// K번째 수
    /// date : 2020-09-02
    /// </summary>
    class Day02
    {
        public int[] solution(int[] array, int[,] commands)
        {
            if (array.Length == 1) return array;

            List<int> answer = new List<int>();
            List<int> temp = array.ToList();

            for (int i = 0; i < commands.GetLength(0); i++ )
            {
                int startInx = commands[i, 0];
                int count = commands[i, 1] - startInx + 1;
                int number = commands[i, 2] - 1;

                int result = temp.GetRange(startInx - 1, count).OrderBy(p => p).ElementAt(number);

                answer.Add(result);
            }

            return answer.ToArray();
        }
    }
}
