using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dream.CMMI
{
    /// <summary>
    /// 功能模块
    /// </summary>
    public class FuncModule : EntityBase
    {
        /// <summary>
        /// 功能模块名称
        /// </summary>

        public string FuncName { get; set; }

        /// <summary>
        /// 功能模块描述
        /// </summary>

        public string FuncDiscription { get; set; }

        /// <summary>
        /// 功能模块原型设计
        /// </summary>

        public string FuncPrototypeDesign { get; set; }

        /// <summary>
        /// 界面截图
        /// </summary>

        public string FuncInterface { get; set; }

        /// <summary>
        /// 输入数据
        /// </summary>

        public string InputData { get; set; }

        /// <summary>
        /// 输出数据
        /// </summary>

        public string OutputData { get; set; }

        /// <summary>
        /// 从属模块
        /// </summary>

        public int ParentID { get; set; }

        [NotMapped]
        public IEnumerable<FuncModule> children { get; set; }
    }
}
