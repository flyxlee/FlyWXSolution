﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WXService.Entity.Request.Event
{
    public class ReqEventBase : ReqMsgBase
    {
        public string Event { get; set; }

        public ReqEventBase()
        { }
    }
}
