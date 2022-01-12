using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilterFilterCondition")]
    public class Wafv2WebAclLoggingConfigurationLoggingFilterFilterCondition : aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilterFilterCondition
    {
        /// <summary>action_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#action_condition Wafv2WebAclLoggingConfiguration#action_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "actionCondition", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilterFilterConditionActionCondition\"}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilterFilterConditionActionCondition? ActionCondition
        {
            get;
            set;
        }

        /// <summary>label_name_condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#label_name_condition Wafv2WebAclLoggingConfiguration#label_name_condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "labelNameCondition", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilterFilterConditionLabelNameCondition\"}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilterFilterConditionLabelNameCondition? LabelNameCondition
        {
            get;
            set;
        }
    }
}
