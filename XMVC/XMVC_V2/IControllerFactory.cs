﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMVC_V2
{
    public interface IControllerFactory
    {
        IController CreateController(string controllerName);
        void ReleaseController(IController controller);
    }
}
