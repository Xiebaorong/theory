using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconsitution
{
    /// <summary>
    /// 影片类
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// 电影名称
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// 电影类型
        /// </summary>
        public MovieType MovieType { get; set; }

        public Rental Rental
        {
            get => default(Rental);
            set
            {
            }
        }

        public Movie(string title, MovieType movieType)
        {
            this.Title = title;
            this.MovieType = movieType;
        }
    }
}
