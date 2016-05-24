using Dream.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Dream.Cms
{
    public class Article : EntityBase
    {
        /// <summary>
        /// 标题
        /// </summary>
        [Sort(1)]
        [Display(Name = "标题")]
        public string Name { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        [Display(Name = "摘要")]
        [DataType(DataType.MultilineText)]
        [Sort(2)]
        public string Summary { get; set; }

        /// <summary>
        /// 封面图
        /// </summary>
        [Display(Name = "封面图")]
        [Sort(3)]
        [Image]
        public string Surface { get; set; }

        /// <summary>
        /// 访问次数
        /// </summary>
        [Display(Name = "访问次数")]
        [Sort(11)]
        [ShowMode(CreateMode = ShowMode.Remove)]
        public int Visits { get; set; }

        [Display(Name = "频道编号")]
        [Select(Name = "ChannelName", NameTitle = "频道名称", Title = "选择频道", ControllerName = "Channel", SelectMode = 1)]
        [Sort(2)]
        public int ChannelID { get; set; }

        [Display(Name = "频道")]
        [ForeignKey("ChannelID")]
        public virtual Channel Channel { get; set; }
        /// <summary>
        /// 文章内容
        /// </summary>
        [Display(Name = "文章内容")]
        [RichText]
        [Sort(3)]
        public string ContentBody { get; set; }
    }
}
