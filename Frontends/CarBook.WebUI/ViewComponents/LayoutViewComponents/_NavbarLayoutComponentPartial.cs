﻿using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.LayoutViewComponents
{
    public class _NavbarLayoutComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
