﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions;

public class ManualPlayerStatusCondition : ConditionComponent
{
    [JsonPropertyName("checkFlag_")]
    public int CheckFlag { get; set; } = 0;
}