﻿using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotMoveCurveAction : ShotMoveBaseAction
{
    [JsonPropertyName("gravityScale_")]
    public float GravityScale { get; set; } = 0.0f;

    [JsonPropertyName("isRotateFall_")]
    public bool IsRotateFall { get; set; } = false;

    [JsonPropertyName("targetDegreeX_")]
    public float TargetDegreeX { get; set; } = 0.0f;

    [JsonPropertyName("targetDegreeY_")]
    public float TargetDegreeY { get; set; } = 0.0f;

    [JsonPropertyName("rotationSecondX_")]
    public float RotationSecondX { get; set; } = 0.0f;

    [JsonPropertyName("rotationSecondY_")]
    public float RotationSecondY { get; set; } = 0.0f;
}