using Reconsitution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconsitution_Test3
{
    public interface ICalculating
    {
        /// <summary>
        /// 电影类型
        /// </summary>
        MovieType MovieType { get; }

        /// <summary>
        /// 计算积分
        /// </summary>
        double CalculatingIntegral(double day);

        /// <summary>
        /// 计算金额
        /// </summary>
        double CalculatingMoney(double day);
    }
}
