﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Enemy;

public class Em2000ActionTypeCondition : ConditionComponent
{
    [JsonPropertyName("isLongRange_")]
    public bool IsLongRange { get; set; } = false;

    [JsonPropertyName("value_")]
    public int Value { get; set; } = 0;

}