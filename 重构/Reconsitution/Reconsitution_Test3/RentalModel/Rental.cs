using Reconsitution_Test3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconsitution
{
    /// <summary>
    /// 租赁类
    /// 表示客户租赁了一部电影和租赁的时长
    /// </summary>
    public class Rental
    {
        /// <summary>
        /// 电影
        /// </summary>
        public Movie Movie { get; private set; }

        /// <summary>
        /// 租赁时长
        /// </summary>
        public int Days { get; private set; }

        public Rental(Movie movie, int days)
        {
            this.Movie = movie;
            this.Days = days;
        }

        /// <summary>
        /// 计算积分
        /// </summary>
        public double CalculatingIntegral()
        {
            return CalculatingManager.Instance.GetCalculating(this.Movie.MovieType).CalculatingIntegral(this.Days);
        }

        /// <summary>
        /// 计算金额
        /// </summary>
        public double CalculatingMoney()
        {
            return CalculatingManager.Instance.GetCalculating(this.Movie.MovieType).CalculatingMoney(this.Days);
        }
    }
}
