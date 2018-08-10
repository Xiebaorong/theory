using Reconsitution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconsitution_Test3
{
    /// <summary>
    /// 儿童电影计算积分和金额
    /// </summary>
    public class NewCalculating : ICalculating
    {
        public MovieType MovieType => MovieType.New;

        public ICalculating ICalculating
        {
            get => default(ICalculating);
            set
            {
            }
        }

        public double CalculatingIntegral(double day)
        {
            return day * 3;
        }

        public double CalculatingMoney(double day)
        {
            return 20 + day * 3;
        }
    }
}
