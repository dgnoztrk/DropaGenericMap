using Mapper.Abstract;
using Mapper.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace Mapper.Ext
{
	public static class ServiceCollectionExtensions
	{
		public static void AddGenericMap<T>(this IServiceCollection services) where T : class
		{
			services.AddSingleton<IGenericMapExtensions<T>, GenericMapExtensions<T>>();
		}
	}
}