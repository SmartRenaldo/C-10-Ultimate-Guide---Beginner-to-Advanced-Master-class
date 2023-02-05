using System.Runtime.CompilerServices;

namespace ModuleInitializer
{
    internal class CustomModuleInitializer
    {
        [ModuleInitializer]
        internal static void CustomInitializer()
        {
            new Initializer1().Initialize();
            new Initializer2().Initialize();
        }
    }
}
