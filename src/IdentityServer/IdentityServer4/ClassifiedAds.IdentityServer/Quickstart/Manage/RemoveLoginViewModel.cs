﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassifiedAds.IdentityServer.Manage.Models;

public class RemoveLoginViewModel
{
    public string LoginProvider { get; set; }
    public string ProviderKey { get; set; }
}
