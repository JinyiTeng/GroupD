using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class MovieModel
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
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
