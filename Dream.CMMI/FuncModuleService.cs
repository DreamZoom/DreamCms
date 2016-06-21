using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dream.CMMI
{
    public class FuncModuleService : EntityServiceBase<FuncModule>
    {
        public IEnumerable<FuncModule> GetTreeList()
        {
            var list = this.GetList().ToList();
            return ComboxTree(list, 0);
        }

        private IEnumerable<FuncModule> ComboxTree(IEnumerable<FuncModule> list, int pid)
        {
            var listtemp = list.Where(m => m.ParentID == pid);
            foreach (var item in listtemp)
            {
                item.children = ComboxTree(list, item.ID);
            }
            return listtemp;
        }
    }
}
