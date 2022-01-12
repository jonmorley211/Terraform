using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclLoggingConfigurationLoggingFilterFilterCondition), fullyQualifiedName: "aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilterFilterCondition")]
    public interface IWafv2WebAclLoggingConfigurationLoggingFilterFilterCondition
    {
        /// <summary>action_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#action_condition Wafv2WebAclLoggingConfiguration#action_condition}
        /// </remarks>
        [JsiiProperty(name: "actionCondition", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilterFilterConditionActionCondition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilterFilterConditionActionCondition? ActionCondition
        {
            get
            {
                return null;
            }
        }

        /// <summary>label_name_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#label_name_condition Wafv2WebAclLoggingConfiguration#label_name_condition}
        /// </remarks>
        [JsiiProperty(name: "labelNameCondition", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilterFilterConditionLabelNameCondition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilterFilterConditionLabelNameCondition? LabelNameCondition
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclLoggingConfigurationLoggingFilterFilterCondition), fullyQualifiedName: "aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilterFilterCondition")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilterFilterCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#action_condition Wafv2WebAclLoggingConfiguration#action_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "actionCondition", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilterFilterConditionActionCondition\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilterFilterConditionActionCondition? ActionCondition
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilterFilterConditionActionCondition?>();
            }

            /// <summary>label_name_condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#label_name_condition Wafv2WebAclLoggingConfiguration#label_name_condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "labelNameCondition", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilterFilterConditionLabelNameCondition\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilterFilterConditionLabelNameCondition? LabelNameCondition
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilterFilterConditionLabelNameCondition?>();
            }
        }
    }
}
