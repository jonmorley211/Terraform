using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    [JsiiByValue(fqn: "aws.config.ConfigConfigRuleScope")]
    public class ConfigConfigRuleScope : aws.Config.IConfigConfigRuleScope
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#compliance_resource_id ConfigConfigRule#compliance_resource_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "complianceResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ComplianceResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#compliance_resource_types ConfigConfigRule#compliance_resource_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "complianceResourceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? ComplianceResourceTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#tag_key ConfigConfigRule#tag_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TagKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_config_rule#tag_value ConfigConfigRule#tag_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TagValue
        {
            get;
            set;
        }
    }
}
