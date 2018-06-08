namespace StringFilter
{
    public struct Filter
    {
        public string FindFirstUniqChar(string str)
        {
            var counter = new int[26];
            var firstPosition = new int[26];

            var offset = 97;
            for (var i = 0; i < str.Length; i++)
            {
                counter[(int)str[i] - offset]++;
                if(firstPosition[(int)str[i] - offset] < 1)
                {
                    firstPosition[(int)str[i] - offset] = i + 1;
                }
            };

            var min = str.Length+1;
            char ch = '[';
            for (var j = 0; j < firstPosition.Length; j++)
            {
                if(counter[j]==1 && firstPosition[j] < min)
                {
                    min = firstPosition[j];
                    ch = str[min-1];
                }
            }
            return ch.ToString();
        }
    }
}