﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Maglielle;

public class Em2100SetScaleWearSwordAction : ActionComponent
{
    [JsonPropertyName("swordScale_")]
    public float SwordScale { get; set; } = 1.0f;
}