


namespace VersionAttribute
{
    using System;
[AttributeUsage(AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Enum|AttributeTargets.Interface|AttributeTargets.Method)]
    public class VersionAttribute:Attribute
    {
    public VersionAttribute(string version)
    {
        this.Version = version;
    }
        public string  Version { get; private set; }
    }
}
