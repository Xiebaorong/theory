using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reconsitution;

namespace Reconsitution_Test3
{
    /// <summary>
    /// 普通电影计算积分和金额
    /// </summary>
    public class OrdinaryCalculating : ICalculating
    {
        public MovieType MovieType => MovieType.Ordinary;

        public ICalculating ICalculating
        {
            get => default(ICalculating);
            set
            {
            }
        }

        public double CalculatingIntegral(double day)
        {
            double integral = 2;
            if (day > 3)
                integral += (day - 3) * 1.5;
            return integral;
        }

        public double CalculatingMoney(double day)
        {
            return 10 + day * 2;
        }
    }
}
