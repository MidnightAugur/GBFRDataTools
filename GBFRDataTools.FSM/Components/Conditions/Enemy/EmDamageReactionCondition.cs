﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Enemy;

public class EmDamageReactionCondition : ConditionComponent
{
    [JsonPropertyName("damageReactionStrHash_")]
    public uint DamageReactionStrHash { get; set; }
}