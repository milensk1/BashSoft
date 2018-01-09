namespace Executor.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Field)]
    internal class InjectAttribute : Attribute
    {
        public InjectAttribute()
        {
        }
    }
}