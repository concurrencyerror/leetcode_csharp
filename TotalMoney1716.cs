namespace leetcode
{
    internal class TotalMoney1716
    {
        public int TotalMoney(int n)
        {
            int num = n / 7;
            int many = n % 7;
            int last = 0;
            int begin = num + 1;
            for (int i = 0; i < many; i++)
            {
                last += begin;
                begin++;
            }
            int sub = 0;
            for (int i = 0; i < num; i++)
            {
                sub += i * 7;
            }
            return (1 + 7) * 7 / 2 * num + sub + last;
        }
    }
}
