// Resource.cs
//

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AngularApi
{
    [Imported, IgnoreNamespace, ScriptName("Object")]
    public interface Resource
    {
        ResourceItem get(Object parameters, Delegate success, Delegate error);

        [AlternateSignature]
        ResourceItem get(Object parameters, Delegate success);

        [AlternateSignature]
        ResourceItem get(Object parameters);

        [AlternateSignature]
        ResourceItem get();

        void save(Object postData, Delegate success, Delegate error);

        [AlternateSignature]
        void save(Object postData, Delegate success);

        void save(Array postData, Delegate success, Delegate error);

        [AlternateSignature]
        void save(Array postData, Delegate success);

        void save(Object parameters, Object postData, Delegate success, Delegate error);

        [AlternateSignature]
        void save(Object parameters, Object postData, Delegate success);

        [AlternateSignature]
        void save(Object parameters, Object postData);

        [AlternateSignature]
        void save(Object parameters);

        void save(Object parameters, Array postData, Delegate success, Delegate error);

        [AlternateSignature]
        void save(Object parameters, Array postData, Delegate success);

        [AlternateSignature]
        void save(Object parameters, Array postData);

        ResourceItem[] query(Object parameters, Delegate success, Delegate error);

        [AlternateSignature]
        ResourceItem[] query(Object parameters, Delegate success);

        [AlternateSignature]
        ResourceItem[] query(Object parameters);

        [AlternateSignature]
        ResourceItem[] query();

        void remove(Object postData, Delegate success, Delegate error);

        [AlternateSignature]
        void remove(Object postData, Delegate success);

        [AlternateSignature]
        void remove(Object postData);

        void remove(Array postData, Delegate success, Delegate error);

        [AlternateSignature]
        void remove(Array postData, Delegate success);

        [AlternateSignature]
        void remove(Array postData);

        void remove(Object parameters, Object postData, Delegate success, Delegate error);

        [AlternateSignature]
        void remove(Object parameters, Object postData, Delegate success);

        [AlternateSignature]
        void remove(Object parameters, Object postData);

        void remove(Object parameters, Array postData, Delegate success, Delegate error);

        [AlternateSignature]
        void remove(Object parameters, Array postData, Delegate success);

        [AlternateSignature]
        void remove(Object parameters, Array postData);

        void delete(Object postData, Delegate success, Delegate error);

        [AlternateSignature]
        void delete(Object postData, Delegate success);

        [AlternateSignature]
        void delete(Object postData);

        void delete(Array postData, Delegate success, Delegate error);

        [AlternateSignature]
        void delete(Array postData, Delegate success);

        [AlternateSignature]
        void delete(Array postData);

        void delete(Object parameters, Object postData, Delegate success, Delegate error);

        [AlternateSignature]
        void delete(Object parameters, Object postData, Delegate success);

        [AlternateSignature]
        void delete(Object parameters, Object postData);

        void delete(Object parameters, Array postData, Delegate success, Delegate error);

        [AlternateSignature]
        void delete(Object parameters, Array postData, Delegate success);

        [AlternateSignature]
        void delete(Object parameters, Array postData);
    }
}
