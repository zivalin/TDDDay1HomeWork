namespace CLHomeWorkDay1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Calculator
    {
        public IEnumerable<int> GroupSum(int groupByCount , List<IProduct> data , Func<IProduct , int> value)
        {
            var count = 0;
            while (count <= data.Count()) {
                yield return data.Skip(count).Take(groupByCount).Sum(value);
                count += groupByCount;
            }
        }
    }
}