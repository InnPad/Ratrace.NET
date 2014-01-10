// AngularModel.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AngularApi
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public class AngularModel
    {
        [ScriptName("$dirty")]
        public bool dirty;

        [ScriptName("$error")]
        public object error;

        [ScriptName("$formatters")]
        public Array formatters;

        [ScriptName("$invalid")]
        public bool invalid;

        [ScriptName("$modelValue")]
        public object modelValue;

        [ScriptName("$name")]
        public string name;

        [ScriptName("$parsers")]
        public Array parsers;

        [ScriptName("$pristine")]
        public bool pristine;

        [ScriptName("$render")]
        public void render() { }

        [ScriptName("$setValidity")]
        public void setValidity(bool validity) { }

        [ScriptName("$setViewValue")]
        public void setViewValue(object value) { }

        [ScriptName("$valid")]
        public bool valid;

        [ScriptName("$viewChangeListeners")]
        public Array viewChangeListeners;

        [ScriptName("$viewValue")]
        public object viewValue;
    }
}
