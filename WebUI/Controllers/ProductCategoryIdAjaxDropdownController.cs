﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Omu.AwesomeMvc;
using dFrontierAppWizard.Core.Model;
using dFrontierAppWizard.Core.Repository;
using dFrontierAppWizard.Resources;

namespace dFrontierAppWizard.WebUI.Controllers
{                
    public class ProductCategoryIdAjaxDropdownController : Controller
    {
        private readonly IRepo<ProductCategory> repo;

        public ProductCategoryIdAjaxDropdownController(IRepo<ProductCategory> repo)
        {
            this.repo = repo;
        }

        public ActionResult GetItems(int? v)
        {
            var list = new List<SelectableItem> { new SelectableItem ("", Mui.not_selected) };


            list.AddRange(repo.GetAll().ToArray().Select(o => new SelectableItem
                                                     {
                                                         Text = string.Format("{0} ",o.Description),
                                                         Value = o.Id.ToString(),
                                                         Selected = o.Id == v
                                                     }));
            return Json(list);
        }
    }
}