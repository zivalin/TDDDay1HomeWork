namespace CLHomeWorkDay1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Calculator
    {
        public IEnumerable<int> GroupSum(int groupByCount , List<IProduct> data , Func<IProduct , int> value)
        {  // 這段參考同學寫法
            int count = 0;
            while (count <= data.Count()) {
                yield return data.Skip(count).Take(groupByCount).Sum(value);
                count += groupByCount;
            }
        }
    }
}