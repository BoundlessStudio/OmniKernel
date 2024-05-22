using Boundless.OmniAdapter.Kernel;
using Microsoft.Extensions.DependencyInjection;

namespace Boundless.OmniAdapter;

public static class ServiceCollectionExtensions
{

  public static void AddKernel(this IServiceCollection services, Action<IServiceProvider, KernelBuilder> fn)
  {
    services.AddSingleton<IKernel>(sp =>
    {
      var builder = new KernelBuilder();
      fn(sp, builder);
      return builder.Build();
    });
  }

  public static void AddKernel(this IServiceCollection services, string key, Action<IServiceProvider, KernelBuilder> fn)
  {
    services.AddKeyedSingleton<IKernel>(key, (sp, _) =>
    {
      var builder = new KernelBuilder();
      fn(sp, builder);
      return builder.Build();
    });
  }
}
