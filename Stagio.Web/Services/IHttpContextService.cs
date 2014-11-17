﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using Stagio.Domain.Application;

namespace Stagio.Web.Services
{
    public interface IHttpContextService
    {
        int GetUserId();
        void AuthenticationSignIn(ClaimsIdentity identity);
        void AuthenticationSignOut();

        String[] GetUserRole();
    }
}