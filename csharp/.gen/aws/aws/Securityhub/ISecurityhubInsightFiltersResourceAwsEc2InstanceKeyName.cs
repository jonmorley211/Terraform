using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Securityhub
{
    [JsiiInterface(nativeType: typeof(ISecurityhubInsightFiltersResourceAwsEc2InstanceKeyName), fullyQualifiedName: "aws.securityhub.SecurityhubInsightFiltersResourceAwsEc2InstanceKeyName")]
    public interface ISecurityhubInsightFiltersResourceAwsEc2InstanceKeyName
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#comparison SecurityhubInsight#comparison}.</summary>
        [JsiiProperty(name: "comparison", typeJson: "{\"primitive\":\"string\"}")]
        string Comparison
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#value SecurityhubInsight#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubInsightFiltersResourceAwsEc2InstanceKeyName), fullyQualifiedName: "aws.securityhub.SecurityhubInsightFiltersResourceAwsEc2InstanceKeyName")]
        internal sealed class _Proxy : DeputyBase, aws.Securityhub.ISecurityhubInsightFiltersResourceAwsEc2InstanceKeyName
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#comparison SecurityhubInsight#comparison}.</summary>
            [JsiiProperty(name: "comparison", typeJson: "{\"primitive\":\"string\"}")]
            public string Comparison
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#value SecurityhubInsight#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
