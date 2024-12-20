﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class AddTransformAction : ActionComponent
{
    [JsonPropertyName("addPosition_")]
    public /* cVec4 */ Vector4 AddPosition { get; set; } = Vector4.Zero;

    [JsonPropertyName("addRotation_")]
    public /* cVec4 */ Vector4 AddRotation { get; set; } = Vector4.Zero;

    [JsonPropertyName("slowRatePosition_")]
    public bool SlowRatePosition { get; set; } = false;
}
