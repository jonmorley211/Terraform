using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Securityhub
{
    [JsiiInterface(nativeType: typeof(ISecurityhubInsightFiltersProcessLaunchedAt), fullyQualifiedName: "aws.securityhub.SecurityhubInsightFiltersProcessLaunchedAt")]
    public interface ISecurityhubInsightFiltersProcessLaunchedAt
    {
        /// <summary>date_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#date_range SecurityhubInsight#date_range}
        /// </remarks>
        [JsiiProperty(name: "dateRange", typeJson: "{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersProcessLaunchedAtDateRange\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Securityhub.ISecurityhubInsightFiltersProcessLaunchedAtDateRange? DateRange
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#end SecurityhubInsight#end}.</summary>
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? End
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#start SecurityhubInsight#start}.</summary>
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Start
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubInsightFiltersProcessLaunchedAt), fullyQualifiedName: "aws.securityhub.SecurityhubInsightFiltersProcessLaunchedAt")]
        internal sealed class _Proxy : DeputyBase, aws.Securityhub.ISecurityhubInsightFiltersProcessLaunchedAt
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>date_range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#date_range SecurityhubInsight#date_range}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dateRange", typeJson: "{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersProcessLaunchedAtDateRange\"}", isOptional: true)]
            public aws.Securityhub.ISecurityhubInsightFiltersProcessLaunchedAtDateRange? DateRange
            {
                get => GetInstanceProperty<aws.Securityhub.ISecurityhubInsightFiltersProcessLaunchedAtDateRange?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#end SecurityhubInsight#end}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? End
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#start SecurityhubInsight#start}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Start
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
