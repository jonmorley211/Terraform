using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiByValue(fqn: "aws.glue.GlueCrawlerLineageConfiguration")]
    public class GlueCrawlerLineageConfiguration : aws.Glue.IGlueCrawlerLineageConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#crawler_lineage_settings GlueCrawler#crawler_lineage_settings}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "crawlerLineageSettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CrawlerLineageSettings
        {
            get;
            set;
        }
    }
}
