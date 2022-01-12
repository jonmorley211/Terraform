using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Securityhub
{
    [JsiiInterface(nativeType: typeof(ISecurityhubInsightFiltersResourceAwsEc2InstanceIpv6Addresses), fullyQualifiedName: "aws.securityhub.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv6Addresses")]
    public interface ISecurityhubInsightFiltersResourceAwsEc2InstanceIpv6Addresses
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#cidr SecurityhubInsight#cidr}.</summary>
        [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}")]
        string Cidr
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubInsightFiltersResourceAwsEc2InstanceIpv6Addresses), fullyQualifiedName: "aws.securityhub.SecurityhubInsightFiltersResourceAwsEc2InstanceIpv6Addresses")]
        internal sealed class _Proxy : DeputyBase, aws.Securityhub.ISecurityhubInsightFiltersResourceAwsEc2InstanceIpv6Addresses
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#cidr SecurityhubInsight#cidr}.</summary>
            [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}")]
            public string Cidr
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
