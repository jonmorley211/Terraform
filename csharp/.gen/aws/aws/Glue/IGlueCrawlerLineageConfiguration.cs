using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IGlueCrawlerLineageConfiguration), fullyQualifiedName: "aws.glue.GlueCrawlerLineageConfiguration")]
    public interface IGlueCrawlerLineageConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#crawler_lineage_settings GlueCrawler#crawler_lineage_settings}.</summary>
        [JsiiProperty(name: "crawlerLineageSettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CrawlerLineageSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCrawlerLineageConfiguration), fullyQualifiedName: "aws.glue.GlueCrawlerLineageConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueCrawlerLineageConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler#crawler_lineage_settings GlueCrawler#crawler_lineage_settings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "crawlerLineageSettings", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CrawlerLineageSettings
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
