using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IGlueCrawlerRecrawlPolicy), fullyQualifiedName: "aws.glue.GlueCrawlerRecrawlPolicy")]
    public interface IGlueCrawlerRecrawlPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#recrawl_behavior GlueCrawler#recrawl_behavior}.</summary>
        [JsiiProperty(name: "recrawlBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecrawlBehavior
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCrawlerRecrawlPolicy), fullyQualifiedName: "aws.glue.GlueCrawlerRecrawlPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueCrawlerRecrawlPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#recrawl_behavior GlueCrawler#recrawl_behavior}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recrawlBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecrawlBehavior
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
