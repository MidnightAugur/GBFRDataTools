﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class AreaEffectSoundSoftCall : ActionComponent
{
    [JsonPropertyName("softCallType_")]
    public int SoftCallType { get; set; } = 0;

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 1;

    [JsonPropertyName("beginPos_")]
    public /* cVec4 */ Vector4 BeginPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("endPos_")]
    public /* cVec4 */ Vector4 EndPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("defineName_")]
    public string DefineName { get; set; } = string.Empty;

    [JsonPropertyName("isCall_")]
    public bool IsCall { get; set; } = false;

    [JsonPropertyName("isFirst_")]
    public bool IsFirst { get; set; } = false;

    [JsonPropertyName("softCallWorkIndex_")]
    public int SoftCallWorkIndex { get; set; } = 0;
}