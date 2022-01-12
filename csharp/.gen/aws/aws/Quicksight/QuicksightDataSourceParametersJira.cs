using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksight.QuicksightDataSourceParametersJira")]
    public class QuicksightDataSourceParametersJira : aws.Quicksight.IQuicksightDataSourceParametersJira
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#site_base_url QuicksightDataSource#site_base_url}.</summary>
        [JsiiProperty(name: "siteBaseUrl", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SiteBaseUrl
        {
            get;
            set;
        }
    }
}
