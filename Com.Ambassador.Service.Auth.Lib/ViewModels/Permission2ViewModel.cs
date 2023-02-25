﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Ambassador.Service.Auth.Lib.ViewModels
{
    public class Permission2ViewModel
    {
        public DateTime _createdDate { get; set; }
        public string _createdBy { get; set; }
        public string _createAgent { get; set; }
        //public MenuViewModel menu { get; set; }
        public string Code { get; set; }
        public string Menu { get; set; }
        public string SubMenu { get; set; }
        public string MenuName { get; set; }
        public int? permission { get; set; }
        public int roleId { get; set; }
    }
}
