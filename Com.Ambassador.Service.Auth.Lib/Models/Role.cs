﻿using Com.Ambassador.Service.Auth.Lib.BusinessLogic.Services;
using Com.Moonlay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Com.Ambassador.Service.Auth.Lib.Models
{
    public class Role : StandardEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Permission2> Permissions { get; set; }
        public virtual ICollection<AccountRole> AccountRoles { get; set; }

        public string UId { get; set; }

    }
}
