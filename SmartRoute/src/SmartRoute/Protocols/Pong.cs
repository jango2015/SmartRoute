﻿using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRoute.Protocols
{
    [ProtoContract]
    public class Pong
    {
        [ProtoMember(1)]
        public int Status { get; set; }
    }
}
