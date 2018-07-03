using System;

namespace FeatureFolderWebApplication.Features.FeatureFolders
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class FeatureAttribute : Attribute
    {
        public FeatureAttribute(string name) => Name = name;

        public string Name { get; }
    }
}
