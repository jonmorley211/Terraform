using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclLoggingConfigurationLoggingFilter), fullyQualifiedName: "aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilter")]
    public interface IWafv2WebAclLoggingConfigurationLoggingFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#default_behavior Wafv2WebAclLoggingConfiguration#default_behavior}.</summary>
        [JsiiProperty(name: "defaultBehavior", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultBehavior
        {
            get;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#filter Wafv2WebAclLoggingConfiguration#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilterFilter\"},\"kind\":\"array\"}}")]
        aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilterFilter[] Filter
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclLoggingConfigurationLoggingFilter), fullyQualifiedName: "aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilter")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#default_behavior Wafv2WebAclLoggingConfiguration#default_behavior}.</summary>
            [JsiiProperty(name: "defaultBehavior", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultBehavior
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#filter Wafv2WebAclLoggingConfiguration#filter}
            /// </remarks>
            [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilterFilter\"},\"kind\":\"array\"}}")]
            public aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilterFilter[] Filter
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilterFilter[]>()!;
            }
        }
    }
}
