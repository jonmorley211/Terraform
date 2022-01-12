using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Securityhub
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.securityhub.SecurityhubInsightFiltersKeyword")]
    public class SecurityhubInsightFiltersKeyword : aws.Securityhub.ISecurityhubInsightFiltersKeyword
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#value SecurityhubInsight#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Value
        {
            get;
            set;
        }
    }
}
