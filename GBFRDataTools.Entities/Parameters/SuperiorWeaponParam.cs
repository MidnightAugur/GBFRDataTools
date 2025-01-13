﻿using System.ComponentModel;
using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters;

public class SuperiorWeaponParam : EnemyParameterInfo
{
    [JsonPropertyName("moveAroundParam_")]
    public MoveAroundParam MoveAroundParam_ { get; set; }

    [JsonPropertyName("actionInfoList_")]
    public BindingList<ActionInfo> ActionInfoList { get; set; } = [];

    [JsonPropertyName("actionStates_")]
    public BindingList<int> ActionStates { get; set; } = [];

    public SuperiorWeaponParam()
    {
    }

    public class MoveAroundParam
    {
        [JsonPropertyName("moveSpeedRate_")]
        public float[] MoveSpeedRate { get; set; } = new float[4]; // std::array<float,4> // Offset 0x8

        [JsonPropertyName("jumpHeightY_")]
        public float JumpHeightY { get; set; } // Offset 0x18

        [JsonPropertyName("isMoveSec_")]
        public bool IsMoveSec { get; set; } // Offset 0x1C

        [JsonPropertyName("moveSpeed_")]
        public float MoveSpeed { get; set; } // Offset 0x20

        [JsonPropertyName("addAngleY_")]
        public float AddAngleY { get; set; } // Offset 0x24

        [JsonPropertyName("randomRangeY_")]
        public float RandomRangeY { get; set; } // Offset 0x28

        [JsonPropertyName("ownerDist_")]
        public float OwnerDist { get; set; } // Offset 0x2C

        [JsonPropertyName("isTargetPlayer_")]
        public bool IsTargetPlayer { get; set; } // Offset 0x30

        public MoveAroundParam()
        {
        }
    }

    public class ActionInfo
    {
        [JsonPropertyName("actions_")]
        public BindingList<int> Actions { get; set; } = []; // Offset 0x8

        public ActionInfo()
        {
        }
    }
}
