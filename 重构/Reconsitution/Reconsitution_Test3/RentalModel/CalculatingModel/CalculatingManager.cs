using Reconsitution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconsitution_Test3
{
    public class CalculatingManager
    {
        private static CalculatingManager instance;

        private static object CalculatingManagerLock = new object();

        /// <summary>
        /// 具有线程安全的单例
        /// </summary>
        public static CalculatingManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (CalculatingManagerLock)
                    {
                        if (instance == null)
                            instance = new CalculatingManager();
                    }
                }
                return instance;
            }
        }

        /// <summary>
        /// 所以计算类
        /// </summary>
        private Dictionary<MovieType, ICalculating> calculatingModels;

        private CalculatingManager()
        {
            InitICalculatings();
        }

        /// <summary>
        /// 加载所有计算类
        /// </summary>
        private void InitICalculatings()
        {
            calculatingModels = new Dictionary<MovieType, ICalculating>();
            ICalculating newCalculating = new NewCalculating();
            ICalculating childrenCalculating = new ChildrenCalculating();
            ICalculating ordinaryCalculating = new OrdinaryCalculating();
            calculatingModels.Add(newCalculating.MovieType, newCalculating);
            calculatingModels.Add(childrenCalculating.MovieType, childrenCalculating);
            calculatingModels.Add(ordinaryCalculating.MovieType, ordinaryCalculating);
        }

        /// <summary>
        /// 根据类型获取计算类
        /// </summary>
        /// <param name="movieType"></param>
        public ICalculating GetCalculating(MovieType movieType)
        {
            if (calculatingModels.ContainsKey(movieType))
                return calculatingModels[movieType];
            return null;
        }
    }
}
