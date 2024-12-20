﻿using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.WinCut;

// ui::component::ControllerWinCutChoice
public class ControllerWinCutChoice // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Menu", UIFieldType.ObjectRef),
        new("Elements", UIFieldType.ObjectRefVector),
        new("OpenControlDelay", UIFieldType.F32),
        new("FixCallbackDelay", UIFieldType.F32),
        new("Root", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
