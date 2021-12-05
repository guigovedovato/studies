using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace M220N.Models.Projections
{
    public class ReportProjection
    {
        public int Count { get; set; }

        [BsonElement("_id")]
        public string Id { get; set; }
    }

    public class TopCommentsProjection
    {
        public TopCommentsProjection(List<ReportProjection> report)
        {
            this.Report = report;
        }

        [BsonElement("report")]
        public List<ReportProjection> Report { get; set; }
    }
}