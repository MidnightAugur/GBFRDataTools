﻿using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class AlphaAction : ActionComponent
{
    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; } = new();

    [JsonPropertyName("alphaStart_")]
    public float AlphaStart { get; set; } = 1.0f;

    [JsonPropertyName("alphaEnd_")]
    public float AlphaEnd { get; set; } = 1.0f;

    [JsonPropertyName("changeSecMax_")]
    public float ChangeSecMax { get; set; } = 0.0f;

    [JsonPropertyName("applyToChildRecursively_")]
    public bool ApplyToChildRecursively { get; set; } = false;
}