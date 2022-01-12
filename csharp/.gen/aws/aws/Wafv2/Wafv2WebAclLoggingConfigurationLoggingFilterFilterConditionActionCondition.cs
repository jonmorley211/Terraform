using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilterFilterConditionActionCondition")]
    public class Wafv2WebAclLoggingConfigurationLoggingFilterFilterConditionActionCondition : aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilterFilterConditionActionCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#action Wafv2WebAclLoggingConfiguration#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Action
        {
            get;
            set;
        }
    }
}
