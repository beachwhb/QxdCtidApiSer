﻿using Abp.Application.Navigation;

namespace QxdCtidApiSer.Web.Models.Layout
{
    public class SideBarNavViewModel
    {
        public UserMenu MainMenu { get; set; }

        public string ActiveMenuItemName { get; set; }
    }
}