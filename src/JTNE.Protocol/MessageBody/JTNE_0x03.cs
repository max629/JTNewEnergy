﻿using JTNE.Protocol.Attributes;
using JTNE.Protocol.Formatters.MessageBodyFormatters;
using System;
using System.Collections.Generic;
using System.Text;

namespace JTNE.Protocol.MessageBody
{
    /// <summary>
    /// 实时信息上报
    /// </summary>
    [JTNEFormatter(typeof(JTNE_0x03_Formatter))]
    public class JTNE_0x03 : JTNEBodies
    {
        public JTNE_0x02 Supplement { get; set; }
    }
}
