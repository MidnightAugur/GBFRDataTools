﻿using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::CharaInfo
public class CharaInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new(0x8E1CB3E3, UIFieldType.ObjectRefVector),
        new(0x930C5152, UIFieldType.ObjectRef),
        new(0xF272EF26, UIFieldType.ObjectRef),
        new("Icon", UIFieldType.ObjectRef),
        new("Names", UIFieldType.ObjectRefVector),
        new("UpdateIcon", UIFieldType.ObjectRef),
        new(0x4E129D7C, UIFieldType.ObjectRef),
        new("Attacks", UIFieldType.ObjectRefVector),
        new(0x72816E5A, UIFieldType.ObjectRef),
        new("Levels", UIFieldType.ObjectRefVector),
        new("ComparedAttackObj", UIFieldType.ObjectRef),
        new(0xB6BE3C01, UIFieldType.ObjectRefVector),
        new(0xD5C55338, UIFieldType.ObjectRef),
        new("ComparedAttack", UIFieldType.ObjectRef),
        new("Icons", UIFieldType.ObjectRefVector),
        new(0xE5772903, UIFieldType.ObjectRef),
        new("Level", UIFieldType.ObjectRef),
        new("OnlineNameColorSetter", UIFieldType.ObjectRef),
        new(0x25B6908C, UIFieldType.ObjectRef),
        new("Sets", UIFieldType.ObjectRefVector),
        new("Elements", UIFieldType.ObjectRefVector),
        new(0x0BC8E8E8, UIFieldType.ObjectRefVector),
        new("Hides", UIFieldType.ObjectRefVector),
        new(0x5E626A07, UIFieldType.ObjectRefVector),
        new(0x867A1FA6, UIFieldType.ObjectRef),
        new(0x04118DA0, UIFieldType.ObjectRefVector),
        new(0x9C5D8806, UIFieldType.ObjectRefVector),
        new(0xB00E6317, UIFieldType.ObjectRefVector),
        new(0xC125A813, UIFieldType.ObjectRefVector),
        new(0xE0D72E02, UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
