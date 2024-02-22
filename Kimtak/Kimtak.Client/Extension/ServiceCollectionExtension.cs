using Kimtak.Client.Presenter;
using System.Linq;
using System.Reflection;

namespace Kimtak.Client.Extension
{
    /// <summary>
    /// DIコンテナ登録する処理を拡張する
    /// </summary>
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddPresenters(this IServiceCollection @this)
        {
            var typeList = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(c => c.GetInterfaces().Any(x => x == typeof(IPresenter)))
                .ToList();

            typeList.ForEach(x => @this.AddScoped(x));

            return @this;
        }
    }
}
