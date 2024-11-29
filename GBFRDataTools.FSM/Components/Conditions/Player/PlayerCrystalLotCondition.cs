﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Player;

public class PlayerCrystalLotCondition : ConditionComponent
{
    [JsonPropertyName("isSSR_")]
    public bool IsSSR { get; set; } = false;

    [JsonPropertyName("isSR_")]
    public bool IsSR { get; set; } = false;

    [JsonPropertyName("isR_")]
    public bool IsR { get; set; } = false;
}
