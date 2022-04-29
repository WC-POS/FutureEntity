﻿using System;
using System.Collections.Generic;

namespace FutureEntity.Entities
{
    public partial class LogConfig
    {
        public Guid LogConfigID { get; set; }
        public short TerminalNumber { get; set; }
        public string Application { get; set; } = null!;
        public byte LogLevel { get; set; }
    }
}
