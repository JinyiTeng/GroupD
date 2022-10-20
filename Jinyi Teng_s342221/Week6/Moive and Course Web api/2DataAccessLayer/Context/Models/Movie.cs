using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class Movie
    {
        public int MovieId { get; set; } // int
        /// <summary>
        /// 电影名称
        /// </summary>
        public string MovieName { get; set; } // nvarchar(400)
        /// <summary>
        /// 导演
        /// </summary>
        public string Director { set; get; }
        /// <summary>
        /// 上映日期
        /// </summary>
        public DateTime ReleaseDate { set; get; }

        /// <summary>
        /// 简介
        /// </summary>
        public string Brief { set; get; }
    }
}
