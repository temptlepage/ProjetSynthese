﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stagio.Web.Services
{
    public interface INotificationService
    {
        bool SendNotificationTo(int destinationId, String title, String message);

    }
}