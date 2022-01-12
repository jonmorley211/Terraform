using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Securityhub
{
    [JsiiByValue(fqn: "aws.securityhub.SecurityhubInsightFiltersResourceContainerLaunchedAt")]
    public class SecurityhubInsightFiltersResourceContainerLaunchedAt : aws.Securityhub.ISecurityhubInsightFiltersResourceContainerLaunchedAt
    {
        /// <summary>date_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#date_range SecurityhubInsight#date_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dateRange", typeJson: "{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceContainerLaunchedAtDateRange\"}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceContainerLaunchedAtDateRange? DateRange
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#end SecurityhubInsight#end}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? End
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#start SecurityhubInsight#start}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Start
        {
            get;
            set;
        }
    }
}
