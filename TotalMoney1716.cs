namespace leetcode
{
    internal class TotalMoney1716
    {
        public int TotalMoney(int n)
        {
            var num = n / 7;
            var many = n % 7;
            var last = 0;
            var begin = num + 1;
            for (var i = 0; i < many; i++)
            {
                last += begin;
                begin++;
            }
            var sub = 0;
            for (var i = 0; i < num; i++)
            {
                sub += i * 7;
            }
            return (1 + 7) * 7 / 2 * num + sub + last;
        }
    }
}
