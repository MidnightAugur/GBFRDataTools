﻿using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions;

public class TypeCondition : ConditionComponent
{
    [JsonPropertyName("value_")]
    public int Value { get; set; } = 0;
}
