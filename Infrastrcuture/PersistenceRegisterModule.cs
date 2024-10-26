using Autofac;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;



namespace Infrastrcuture
{
    public class PersistenceRegisterModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterAssemblyTypes(this.GetType().Assembly)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            builder.RegisterType<AppDbContext>()
                .As<DbContext>()
                .InstancePerLifetimeScope();
        }
    }
}
