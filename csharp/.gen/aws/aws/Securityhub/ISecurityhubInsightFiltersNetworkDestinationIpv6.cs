using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Securityhub
{
    [JsiiInterface(nativeType: typeof(ISecurityhubInsightFiltersNetworkDestinationIpv6), fullyQualifiedName: "aws.securityhub.SecurityhubInsightFiltersNetworkDestinationIpv6")]
    public interface ISecurityhubInsightFiltersNetworkDestinationIpv6
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#cidr SecurityhubInsight#cidr}.</summary>
        [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}")]
        string Cidr
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubInsightFiltersNetworkDestinationIpv6), fullyQualifiedName: "aws.securityhub.SecurityhubInsightFiltersNetworkDestinationIpv6")]
        internal sealed class _Proxy : DeputyBase, aws.Securityhub.ISecurityhubInsightFiltersNetworkDestinationIpv6
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
