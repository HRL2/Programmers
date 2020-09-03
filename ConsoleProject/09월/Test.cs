using System.Collections.Generic;
using System.Linq;

namespace ConsoleProject
{
    class Test
    {
        public static int solution(string arrangement)
        {
            int answer = 0;

            Stack<bar> tempStack = new Stack<bar>();

            var arrayArg = arrangement.ToArray();

            for (int i = 0; i < arrayArg.Length; i++)
            {
                if (i + 1 < arrayArg.Length)
                {
                    if (arrayArg[i] == '(' && arrayArg[i + 1] == ')')
                        continue;
                }

                if (arrayArg[i] == '(')
                    tempStack.Push(new bar(i, null));
            }

            return answer;
        }

        public static int WordNum(string text, string splitWord)
        {
            int Num;
            var b = text.Count();
            var c = text.Replace(splitWord, "").Count();
            Num = b - c;
            Num = Num / splitWord.Count();

            return Num;

        }
    }

    class bar
    {
        private int _StartIndex;
        public int StartIndex
        {
            get { return _StartIndex; }
            set { _StartIndex = value; }
        }

        private int? _EndIndex;
        public int? EndIndex
        {
            get { return _EndIndex; }
            set { _EndIndex = value; }
        }

        public bar(int startidx, int? endidx)
        {
            StartIndex = startidx;
            EndIndex = endidx;
        }
    }
}
