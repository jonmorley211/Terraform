using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Securityhub
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.securityhub.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv4Addresses")]
    public class SecurityhubInsightFiltersResourceAwsEc2InstanceIpv4Addresses : aws.Securityhub.ISecurityhubInsightFiltersResourceAwsEc2InstanceIpv4Addresses
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#cidr SecurityhubInsight#cidr}.</summary>
        [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Cidr
        {
            get;
            set;
        }
    }
}
