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

namespace GBFRDataTools.FSM.Components.Actions.Enemy.DroitaSentinel;

public class Em1301ElectricFiledAttackSignAction : ActionComponent
{
    [JsonPropertyName("size_")]
    public float Size { get; set; } = 1.0f;

    [JsonPropertyName("dispSec_")]
    public float DispSec { get; set; } = 1.0f;

    [JsonPropertyName("posOffset_")]
    public /* cVec4 */ Vector4 PosOffset { get; set; } = Vector4.UnitW;
}
