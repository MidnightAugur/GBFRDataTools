﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.SoundMix;

public class SoundMixBalanceCameraCondition : ConditionComponent
{
    [JsonPropertyName("condition_")]
    public int Condition { get; set; } = 0;
}