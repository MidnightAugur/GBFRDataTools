﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using YamlDotNet.RepresentationModel;

namespace GBFRDataTools.Core.UI.Types;

public class UIVec3 : UIObjectBase
{
    public Vector3 Vector { get; set; }

    public override YamlNode GetYamlNode()
    {
        return new YamlScalarNode($"{Vector.X}, {Vector.Y}, {Vector.Z}");
    }
}
