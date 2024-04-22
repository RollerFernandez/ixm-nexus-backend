namespace Ixm.Nexus.Users.Infrastructure.Cores;
public class InfrastructureAutoFacModule : Autofac.Module
{
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);

        builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();
    }
}
