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

public class BehaviorKnockBackAction : ActionComponent
{
    [JsonPropertyName("sourcePosition_")]
    public /* cVec4 */ Vector4 SourcePosition { get; set; } = Vector4.UnitW;

    [JsonPropertyName("moveDist_")]
    public float MoveDist { get; set; } = 0.0f;

    [JsonPropertyName("moveSecond_")]
    public float MoveSecond { get; set; } = 0.0f;
}