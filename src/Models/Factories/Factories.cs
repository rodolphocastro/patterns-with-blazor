using System.Collections.Generic;

namespace Models.Factories
{
    /// <summary>
    /// Shortcut para acessar as factories.
    /// </summary>
    public static class Factories
    {
        public const string MethodFactory = "Method";
        public const string ClassFactory = "Class";
        public const string AbstractFactory = "Abstract";
        public static IEnumerable<string> Types = new List<string> { MethodFactory, ClassFactory, MethodFactory };
    }
}
