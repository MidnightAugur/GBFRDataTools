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

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class AIMovePassAction : ActionComponent
{
    [JsonPropertyName("params_")]
    public BindingList<PassParam> Params { get; set; } = [];

    [JsonPropertyName("speedRate_")]
    public float SpeedRate { get; set; } = 1.0f;

    public class PassParam // BT::AIMovePassAction::PassParam
    {
        [JsonPropertyName("pos_")]
        public /* cVec4 */ Vector4 Pos { get; set; } = Vector4.UnitW;

        [JsonPropertyName("pointNum_")]
        public int PointNum { get; set; } = 5;

        [JsonPropertyName("useNavMesh_")]
        public bool UseNavMesh { get; set; } = false;

        [JsonPropertyName("useDash_")]
        public bool UseDash { get; set; } = false;
    }
}
