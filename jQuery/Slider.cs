// Slider.cs
//

using System;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;
using jQueryApi;

[Mixin("$.fn")]
public static class SliderPlugin
{
    public static jQueryObject Slider(SliderOptions customOptions)
    {
        SliderOptions defaultOptions =
            new SliderOptions("myOption", 0
            /* name/value pairs corresponding to default options */);

        SliderOptions options =
            jQuery.ExtendObject<SliderOptions>(new SliderOptions(), defaultOptions, customOptions);

        return jQuery.Current.Each(delegate(int i, Element element)
        {
            // TODO: Consume the matched elements
        });
    }
}

[Imported]
[ScriptName("Object")]
public sealed class SliderOptions
{
    // TODO: Replace with fields corresponding to options for the plugin
    public int myOption;

    public SliderOptions()
    {
    }

    public SliderOptions(params object[] nameValuePairs)
    {
    }
}

#region Script# Support
[Imported]
public sealed class SliderObject : jQueryObject
{
    public jQueryObject Slider()
    {
        return null;
    }

    public jQueryObject Slider(string option)
    {
        return null;
    }

    public jQueryObject Slider(SliderOptions options)
    {
        return null;
    }
}
#endregion
