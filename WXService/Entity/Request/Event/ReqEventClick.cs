using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WXService.Entity.Request.Event
{
    public class ReqEventClick : ReqEventBase
    {
        public string EventKey { get; set; }

        public ReqEventClick() { }
    }
}
