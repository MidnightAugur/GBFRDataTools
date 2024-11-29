﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class PlayerRevival : QuestActionComponent
{
    [JsonPropertyName("playerIndex_")]
    public int PlayerIndex { get; set; } = 0;

    [JsonPropertyName("full_")]
    public bool Full { get; set; } = false;

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
