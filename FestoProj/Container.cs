using System;
using System.Collections.Generic;
using System.Linq;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using FestoProj.Hardware;

namespace FestoProj {
    public class Container : WindsorContainer {
        private readonly IDictionary<string, string> deviceNameToTypeMap = new Dictionary<string, string> {
            { "memory", "FestoProj.Hardware.RAM" },
            { "processor", "FestoProj.Hardware.Processor" },
            { "mmotherBoard", "FestoProj.Hardware.MotherBoard" }
        };

        public void Initialize() {
            Func<Type, bool> isInitializationStrategy = x => x.GetGenericTypeDefinition() == typeof(IInitializationStrategy<>);

            var initializationStrategies = AppDomain.CurrentDomain.GetAssemblies()
                                                    .SelectMany(x => x.GetTypes())
                                                    .Where(
                                                        y => y.GetInterfaces().Any(x => x.IsGenericType && isInitializationStrategy(x)))
                                                    .Select(
                                                        type => new {
                                                            ArgumentType = type.GetInterfaces().First(isInitializationStrategy).GetGenericArguments()[0].ToString(), 
                                                            Instance = Activator.CreateInstance(type) as IInitializationStrategy<Device>
                                                        })
                                                    .ToDictionary(k => k.ArgumentType, v => v.Instance);
            Register(Component.For<IComputerConfigurationExtractor>().ImplementedBy<ComputerConfigurationExtractor>());
            Register(Component.For<IComputerFactory>().ImplementedBy<ComputerFactory>().DependsOn(new { initializationStrategies, deviceNameToTypeMap }));
            Register(Component.For<IDeviceTesting>().ImplementedBy<DeviceTesting>().DependsOn(new { initializationStrategies }));
        }
    }
}