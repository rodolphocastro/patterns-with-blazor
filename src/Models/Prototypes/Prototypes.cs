using System.Collections.Generic;

namespace Models.Prototypes
{
    public class Prototypes
    {
        public const string None = "None";
        public const string Instances = "Static Instances";
        public const string CopyCtor = "Copy Constructor";
        public const string Cloneable = "ICloneable";
        public const string DeepCopyable = "DeepCopyable";
        public const string ShallowCopyable = "ShallowCopyable";
        public const string Serializable = "Serializable";
        public static IEnumerable<string> PrototypeTypes = new List<string>
        {
            None,
            Instances,
            CopyCtor,
            Cloneable,
            DeepCopyable,
            ShallowCopyable,
            Serializable
        };
    }
}
