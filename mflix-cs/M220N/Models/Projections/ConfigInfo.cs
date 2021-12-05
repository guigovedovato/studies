using MongoDB.Bson;
using MongoDB.Driver;

namespace M220N.Models.Projections
{
    public class AuthInfo
    {
        public BsonArray AuthenticatedUserPrivileges { get; set; }
        public BsonArray AuthenticatedUserRoles { get; set; }
        public BsonArray AuthenticatedUsers { get; set; }
    }

    public class ConfigInfo
    {
        public AuthInfo AuthInfo { get; set; }
        public int Ok { get; set; }
        public MongoClientSettings Settings { get; set; }
    }
}