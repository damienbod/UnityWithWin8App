using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using DataAccessLayer;

namespace UnityTestWin8App
{
    public class UnityHelper
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterTypes(AllClasses.FromApplication(false,false),
                                    WithMappings.FromMatchingInterface,
                                    WithName.Default,
                                    WithLifetime.ContainerControlled
                                );

            // This method checks and for classes from Loaded Assemblies and creates a per request lifetime object for classes with the custom attribute 
            //container.RegisterTypes(AllClasses.FromLoadedAssemblies(),
            //                        UnityHelpers.FromAllInterfacesWith_PerRequestLifetimeAttribute,
            //                        WithName.Default,
            //                        PerRequest
            //                    )
            //         .RegisterType<IUnitOfWorkExample, UnitOfWorkExampleTest>(new TransientLifetimeManager());

        }
    }
}
