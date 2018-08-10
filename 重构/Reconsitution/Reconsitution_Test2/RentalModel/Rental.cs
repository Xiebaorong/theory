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
            double integral = 0;
            switch (this.Movie.MovieType)
            {
                case MovieType.Ordinary:
                    integral = CalculatingIntegral_Ordinary();
                    break;
                case MovieType.Children:
                    integral = CalculatingIntegral_Children();
                    break;
                case MovieType.New:
                    integral = CalculatingIntegral_New();
                    break;
                default:
                    break;
            }
            return integral;
        }

        /// <summary>
        /// 计算金额
        /// </summary>
        public double CalculatingMoney()
        {
            double price = 0;
            switch (this.Movie.MovieType)
            {
                case MovieType.Ordinary:
                    price += 10 + this.Days * 2;
                    break;
                case MovieType.Children:
                    price += 5 + this.Days * 1;
                    break;
                case MovieType.New:
                    price += 20 + this.Days * 3;
                    break;
                default:
                    break;
            }
            return price;
        }

        /// <summary>
        /// 普通电影积分计算
        /// </summary>
        private double CalculatingIntegral_Ordinary()
        {
            double integral = 2;
            if (this.Days > 3)
                integral += (this.Days - 3) * 1.5;
            return integral;
        }

        /// <summary>
        /// 儿童电影积分计算
        /// </summary>
        private double CalculatingIntegral_Children()
        {
            double integral = 1;
            if (this.Days > 5)
                integral += (this.Days - 5) * 1.5;
            return integral;
        }

        /// <summary>
        /// 新电影积分计算
        /// </summary>
        private double CalculatingIntegral_New()
        {
            return this.Days * 3;
        }
    }
}
