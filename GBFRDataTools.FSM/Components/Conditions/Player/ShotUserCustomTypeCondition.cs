﻿using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Player;

public class ShotUserCustomTypeCondition : ConditionComponent
{
    [JsonPropertyName("checkValue_")]
    public int CheckValue { get; set; } = 0;

    [JsonPropertyName("operatorType_")]
    public OperatorType OperatorType { get; set; } = OperatorType.Equal;

    [JsonPropertyName("bbIntName_")]
    public string BbIntName { get; set; } = string.Empty;

    [JsonPropertyName("bbHashValue_")]
    public uint BbHashValue { get; set; } = 0;
}