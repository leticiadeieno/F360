using SimpleInjector;
using Klingon.Domain.Core.Contracts;
using Klingon.Domain.Core.Services;

namespace Klingon.Domain.Core.IoC
{
    public static class Resolver
    {
        public static void Register(Container container)
        {
            container.Register<IKlingonService, KlingonService>();
        }
    }
}
