using Unity;
using AutoService.Repositories.Interfaces;
using AutoService.Repositories.Stubs;

namespace AutoService
{
    public static class ContainerConfig
    {
        public static IUnityContainer Configure()
        {
            var container = new UnityContainer();

            container.RegisterSingleton<IClientRepository, ClientRepositoryStub>();
            container.RegisterSingleton<IMechanicRepository, MechanicRepositoryStub>();
            container.RegisterSingleton<ICarRepository, CarRepositoryStub>();
            container.RegisterSingleton<IWorkTypeRepository, WorkTypeRepositoryStub>();
            container.RegisterSingleton<ICarPartRepository, CarPartRepositoryStub>();
            container.RegisterSingleton<IAppointmentRepository, AppointmentRepositoryStub>();
            container.RegisterSingleton<IPerformedWorkRepository, PerformedWorkRepositoryStub>();
            container.RegisterSingleton<IUsedPartRepository, UsedPartRepositoryStub>();

            return container;
        }
    }
}