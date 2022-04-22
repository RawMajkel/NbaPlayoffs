using System.Data;

namespace PlayoffsApi.Application.Configuration.Data;

public interface ISqlConnectionFactory
{
    IDbConnection GetOpenConnection();
}