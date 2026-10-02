using ERPProductionAPI.ERPProduction;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        

        app.Run(async (context) =>
        {
            

            var response = context.Response;
            var request = context.Request;
            var path = request.Path;

            var getRequestSql = await new request_database().GetRequestSql();

            if (path == "/api/erp_sql" && request.Method == "GET")
            {
                await response.WriteAsync(getRequestSql);
            }

            if (path == "/api/users" && request.Method == "GET")
            {                
                await response.WriteAsync(getRequestSql);
            }
        });

        app.Run();
    }
}