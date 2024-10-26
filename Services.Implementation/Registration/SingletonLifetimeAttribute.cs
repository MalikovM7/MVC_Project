using Microsoft.Extensions.DependencyInjection;

namespace Services.Implementation.Registration
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
        class SingletonLifeTimeAttribute : Attribute
        {
        }

        [AttributeUsage(AttributeTargets.Class)]
        class LifeTimeAttribute : Attribute
        {
            public ServiceLifetime LifetimeMode { get; set; }
        }
}
