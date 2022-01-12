using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Securityhub
{
    [JsiiByValue(fqn: "aws.securityhub.SecurityhubInsightFiltersResourceAwsEc2InstanceLaunchedAt")]
    public class SecurityhubInsightFiltersResourceAwsEc2InstanceLaunchedAt : aws.Securityhub.ISecurityhubInsightFiltersResourceAwsEc2InstanceLaunchedAt
    {
        /// <summary>date_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#date_range SecurityhubInsight#date_range}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dateRange", typeJson: "{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersResourceAwsEc2InstanceLaunchedAtDateRange\"}", isOptional: true, isOverride: true)]
        public aws.Securityhub.ISecurityhubInsightFiltersResourceAwsEc2InstanceLaunchedAtDateRange? DateRange
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
