using Npgsql;
using SD.LLBLGen.Pro.DQE.PostgreSql;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.Tools.OrmProfiler.Interceptor;
using System.Diagnostics;

namespace TestApi.Common
{
    public static class ConfigLLBLRuntime
    {
        public static void ConfigLLBLRuntimeConfiguration()
        {
            RuntimeConfiguration.ConfigureDQE<PostgreSqlDQEConfiguration>(
                c => c.AddDbProviderFactory(typeof(NpgsqlFactory))
                .AddDbProviderFactory(InterceptorCore.Initialize("TestApi", typeof(NpgsqlFactory)))
                       .SetTraceLevel(TraceLevel.Verbose));


            RuntimeConfiguration.Tracing
                     .SetTraceLevel("ORMPersistenceExecution", TraceLevel.Verbose)
                     .SetTraceLevel("ORMPlainSQLQueryExecution", TraceLevel.Verbose);

        }
    }
}
