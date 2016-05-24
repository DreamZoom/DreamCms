using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Webdiyer.WebControls.Mvc;
using Dream.Author;

namespace Dream
{
    [Author]
    public class ManageControllerBase<TService, TEntity> : ControllerBase
        where TEntity : EntityBase
        where TService : EntityServiceBase<TEntity>, new()
    {

        protected TService Service { get; set; }

        protected int PageSize { get { return 20; } }

        public ManageControllerBase()
        {
            Service = new TService();
            ViewData.ModelMetadata = ModelMetadataProviders.Current.GetMetadataForType(null, typeof(TEntity));
        }


        public virtual ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public virtual ActionResult Create(TEntity model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Service.Create(model);
                    return RedirectToAction("List");
                }

            }
            catch (Exception err)
            {
                ModelState.AddModelError("", string.Format("数据创建失败,{0}", err.Message));
            }
            return View(model);
        }

        public virtual ActionResult Edit(int Id)
        {
            var model = Service.Get(Id);
            if (model == null) return Error("数据不存在");
            return View(model);
        }

        [HttpPost]
        public virtual ActionResult Edit(int Id, TEntity model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Service.Update(model);
                    return RedirectToAction("List");
                }

            }
            catch (Exception err)
            {
                ModelState.AddModelError("", string.Format("数据修改失败,{0}", err.Message));
            }
            return View(model);
        }


        public virtual ActionResult Details(int Id)
        {
            var model = Service.Get(Id);
            if (model == null) return Error("数据不存在");
            return View(model);
        }

        public virtual ActionResult Delete(int Id)
        {
            var model = Service.Get(Id);
            if (model == null) return Error("数据不存在");
            return View(model);
        }

        [HttpPost]
        public virtual ActionResult Delete(int Id, TEntity model)
        {
            try
            {
                Service.Delete(model);
                return RedirectToAction("List");
            }
            catch (Exception err)
            {
                ModelState.AddModelError("", string.Format("数据删除失败,{0}", err.Message));
            }
            return View(model);
        }


        public virtual ActionResult List(int pageIndex = 1)
        {
            var list = Service.GetList(ControllerContext.RequestContext).OrderBy(m => m.ID).ToPagedList(pageIndex, PageSize);
            return View(list);
        }


        public virtual ActionResult DeleteList(int[] IdList)
        {
            try
            {
                Service.DeleteList(IdList);
                return RedirectToAction("List");
            }
            catch (Exception err)
            {
                return Error(string.Format("数据删除失败,{0}", err.Message));
            }

        }

        public virtual ActionResult JsonPageList(int page = 1)
        {
            var list = Service.GetList(ControllerContext.RequestContext).OrderBy(m => m.ID).ToPagedList(page, PageSize);
            return JsonP(new { rows = list, total = list.TotalItemCount });
        }


        public virtual ActionResult JsonList(string IdList = "")
        {
            string[] IdListArray = IdList.Split(',');
            var list = Service.GetList().Where(m => IdListArray.Contains(m.ID.ToString())).OrderBy(m => m.ID).ToList();
            return JsonP(list);
        }

    }
}
