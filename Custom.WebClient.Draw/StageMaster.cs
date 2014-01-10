// StageMaster.cs
//

using System;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;
using jQueryApi;
using Kinetic;

namespace Custom
{
    public class StageMaster
    {
        public static Stage FromElement(Element element, StageOptions options)
        {
            jQueryObject el = jQuery.FromElement(element);
            Stage stage = (Stage)el.GetDataValue("Custom.Stage");

            if (stage == null)
            {
                stage = new Stage(new StageConfig(
                    "container", element/*,
                    "width", Math.Max(400, element.ClientWidth),
                    "height", Math.Max(400, element.ClientHeight)*/));

                el.Data("Custom.Stage", stage);
            }

            return stage;
        }
    }

    [Imported, IgnoreNamespace, ScriptName("Object")]
    public sealed class StageOptions
    {
        public StageOptions()
        {
        }

        public StageOptions(params object[] nameValuePairs)
        {
        }
    }
}
