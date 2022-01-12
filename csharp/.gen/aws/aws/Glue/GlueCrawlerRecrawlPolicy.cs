using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiByValue(fqn: "aws.glue.GlueCrawlerRecrawlPolicy")]
    public class GlueCrawlerRecrawlPolicy : aws.Glue.IGlueCrawlerRecrawlPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#recrawl_behavior GlueCrawler#recrawl_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recrawlBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? RecrawlBehavior
        {
            get;
            set;
        }
    }
}
