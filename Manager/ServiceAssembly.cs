using System.Reflection;

namespace TestApi.Manager
{
    public class ServiceAssembly
    {
        public static Assembly Assembly => typeof(ServiceAssembly).Assembly;
    }
}
