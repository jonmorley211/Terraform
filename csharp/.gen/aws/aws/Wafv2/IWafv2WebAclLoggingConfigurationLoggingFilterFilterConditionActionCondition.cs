using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclLoggingConfigurationLoggingFilterFilterConditionActionCondition), fullyQualifiedName: "aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilterFilterConditionActionCondition")]
    public interface IWafv2WebAclLoggingConfigurationLoggingFilterFilterConditionActionCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#action Wafv2WebAclLoggingConfiguration#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclLoggingConfigurationLoggingFilterFilterConditionActionCondition), fullyQualifiedName: "aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilterFilterConditionActionCondition")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilterFilterConditionActionCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#action Wafv2WebAclLoggingConfiguration#action}.</summary>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
