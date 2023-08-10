
using test.Dal.DatabaseSpecific;
using test.Dal.EntityClasses;
using test.Dal.Linq;
using TestApi.Common;

namespace TestApi.Manager
{
    public class TestManager
    {
        public async Task<ApiResponse<List<TestEntity>>> SelectAll()
        {
            try
            {
                using (DataAccessAdapter adapter = new DataAccessAdapterFactory().CreateAdapter())
                {
                    var metaData = new LinqMetaData(adapter);
                    return metaData.Test.ToList();
                }
            } catch (Exception ex)
            {
                return ApiResponse<List<TestEntity>>.Generate(GeneralCode.Error, ex.Message);
            }
        }
    }
}
