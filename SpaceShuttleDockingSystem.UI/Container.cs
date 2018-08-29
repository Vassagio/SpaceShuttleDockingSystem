using Unity;
using Unity.Lifetime;

namespace SpaceShuttleDockingSystem.UI
{
	public static class Container
	{
		private static readonly UnityContainer _container = new UnityContainer();

		public static void RegisterType<I, T>() where T : I => _container.RegisterType<I, T>(new ContainerControlledLifetimeManager());
		public static T Resolve<T>() => _container.Resolve<T>();
	}
}