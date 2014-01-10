// RangeSlider.cs
//

using System;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;
using jQueryApi;

[Mixin("$.fn")]
public static class RangeSliderPlugin
{
    public static jQueryObject RangeSlider(RangeSliderOptions customOptions)
    {
        RangeSliderOptions defaultOptions =
            new RangeSliderOptions("myOption", 0
            /* name/value pairs corresponding to default options */);

        RangeSliderOptions options =
            jQuery.ExtendObject<RangeSliderOptions>(new RangeSliderOptions(), defaultOptions, customOptions);

        return jQuery.Current.Each(delegate(int i, Element element)
        {
            // TODO: Consume the matched elements
        });
    }
}

[Imported]
[ScriptName("Object")]
public sealed class RangeSliderOptions
{
    /// <summary>
    /// Current high range value. low 'equal or less than' high 'equal or less than' max< high
    /// </summary>
    public Number high;

    /// <summary>
    /// Current low range value. min 'equal or less than' low 'equal or less than' high< high
    /// </summary>
    public Number low;

    /// <summary>
    /// Higher range limit. high 'equal or less than' max< high
    /// </summary>
    public Number max;

    /// <summary>
    /// Lower range limit. min 'equal or less than' low< high
    /// </summary>
    public Number min;

    public RangeSliderOptions()
    {
    }

    public RangeSliderOptions(params object[] nameValuePairs)
    {
    }
}

#region Script# Support
[Imported]
public sealed class RangeSliderObject : jQueryObject
{
    public jQueryObject RangeSlider()
    {
        return null;
    }

    public jQueryObject RangeSlider(RangeSliderOptions options)
    {
        return null;
    }
}
#endregion
