using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace UnityTestWin8App
{

    public class Locator : IServiceLocator
    {
        private readonly IUnityContainer _container = UnityHelper.GetConfiguredContainer();

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }

    public interface IServiceLocator
    {
        T Resolve<T>();
    }
}
