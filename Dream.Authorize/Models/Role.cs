using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dream.Authorize
{
    public class Role  : EntityBase
    {
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// 角色的权限
        /// </summary>
        public virtual ICollection<Authority> Authoritys { get; set; }
    }
}
