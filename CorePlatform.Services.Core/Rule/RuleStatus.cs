﻿using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePlatform.Services.Core.Rule
{
    public class RuleStatus : SmartEnum<RuleStatus>
    {
        public static readonly RuleStatus DisabledRule = new(nameof(ActiveRule), 0);
        public static readonly RuleStatus ActiveRule = new(nameof(ActiveRule), 1);

        protected RuleStatus(string name, int value) : base(name, value) { }
    }
}
