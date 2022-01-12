using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclLoggingConfigurationLoggingFilterFilterConditionLabelNameCondition), fullyQualifiedName: "aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilterFilterConditionLabelNameCondition")]
    public interface IWafv2WebAclLoggingConfigurationLoggingFilterFilterConditionLabelNameCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#label_name Wafv2WebAclLoggingConfiguration#label_name}.</summary>
        [JsiiProperty(name: "labelName", typeJson: "{\"primitive\":\"string\"}")]
        string LabelName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclLoggingConfigurationLoggingFilterFilterConditionLabelNameCondition), fullyQualifiedName: "aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilterFilterConditionLabelNameCondition")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilterFilterConditionLabelNameCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#label_name Wafv2WebAclLoggingConfiguration#label_name}.</summary>
            [JsiiProperty(name: "labelName", typeJson: "{\"primitive\":\"string\"}")]
            public string LabelName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
