using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jil;

namespace SerializersCompare.Serializers
{
    public class JILJson<T> : SerializerBase<T>
    {
        public JILJson()
        {
            IsBinarySerializer = false;
            SerName = "JIL";
        }

        public override dynamic Serialize(object thisObj)
        {
            SerString = JSON.Serialize(thisObj);
            return SerString;
        }

        public override T Deserialize(dynamic json)
        {
            return JSON.Deserialize<T>((string)json);
        }
    }
}
