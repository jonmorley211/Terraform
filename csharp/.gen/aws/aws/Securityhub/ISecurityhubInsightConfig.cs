using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Securityhub
{
    /// <summary>AWS Security Hub.</summary>
    [JsiiInterface(nativeType: typeof(ISecurityhubInsightConfig), fullyQualifiedName: "aws.securityhub.SecurityhubInsightConfig")]
    public interface ISecurityhubInsightConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>filters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#filters SecurityhubInsight#filters}
        /// </remarks>
        [JsiiProperty(name: "filters", typeJson: "{\"fqn\":\"aws.securityhub.SecurityhubInsightFilters\"}")]
        aws.Securityhub.ISecurityhubInsightFilters Filters
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#group_by_attribute SecurityhubInsight#group_by_attribute}.</summary>
        [JsiiProperty(name: "groupByAttribute", typeJson: "{\"primitive\":\"string\"}")]
        string GroupByAttribute
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#name SecurityhubInsight#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>AWS Security Hub.</summary>
        [JsiiTypeProxy(nativeType: typeof(ISecurityhubInsightConfig), fullyQualifiedName: "aws.securityhub.SecurityhubInsightConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Securityhub.ISecurityhubInsightConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>filters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#filters SecurityhubInsight#filters}
            /// </remarks>
            [JsiiProperty(name: "filters", typeJson: "{\"fqn\":\"aws.securityhub.SecurityhubInsightFilters\"}")]
            public aws.Securityhub.ISecurityhubInsightFilters Filters
            {
                get => GetInstanceProperty<aws.Securityhub.ISecurityhubInsightFilters>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#group_by_attribute SecurityhubInsight#group_by_attribute}.</summary>
            [JsiiProperty(name: "groupByAttribute", typeJson: "{\"primitive\":\"string\"}")]
            public string GroupByAttribute
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#name SecurityhubInsight#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
