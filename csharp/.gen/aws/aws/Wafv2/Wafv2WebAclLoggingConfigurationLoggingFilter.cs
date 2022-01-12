using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilter")]
    public class Wafv2WebAclLoggingConfigurationLoggingFilter : aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#default_behavior Wafv2WebAclLoggingConfiguration#default_behavior}.</summary>
        [JsiiProperty(name: "defaultBehavior", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DefaultBehavior
        {
            get;
            set;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl_logging_configuration#filter Wafv2WebAclLoggingConfiguration#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilterFilter\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilterFilter[] Filter
        {
            get;
            set;
        }
    }
}
