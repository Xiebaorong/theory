using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reconsitution;

namespace Reconsitution_Test3
{
    /// <summary>
    /// 儿童电影计算积分和金额
    /// </summary>
    public class ChildrenCalculating : ICalculating
    {
        public MovieType MovieType => MovieType.Children;

        public ICalculating ICalculating
        {
            get => default(ICalculating);
            set
            {
            }
        }

        public double CalculatingIntegral(double day)
        {
            double integral = 1;
            if (day > 5)
                integral += (day - 5) * 1.5;
            return integral;
        }

        public double CalculatingMoney(double day)
        {
            return 5 + day * 1;
        }
    }
}
