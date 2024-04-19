using System.Reflection;

namespace Ixm.Nexus.Users.Application.Cores;
public class ApplicationAutoFacModule : Autofac.Module
{
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);

        var unused = builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();
    }
}
