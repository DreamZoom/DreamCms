using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dream.CMMI
{
    /// <summary>
    /// 项目
    /// </summary>
    public class CmmiProject : EntityBase
    {
        /// <summary>
        /// 项目编码/代号
        /// </summary>
        public string ProjectNo { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// 项目说明
        /// </summary>
        public string ProjectDiscription { get; set; }

        /// <summary>
        /// 项目启动时间
        /// </summary>
        public DateTime StartupTime { get; set; }
    }
}
