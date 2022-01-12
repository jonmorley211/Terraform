using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    [JsiiByValue(fqn: "aws.config.ConfigRemediationConfigurationExecutionControlsSsmControls")]
    public class ConfigRemediationConfigurationExecutionControlsSsmControls : aws.Config.IConfigRemediationConfigurationExecutionControlsSsmControls
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_remediation_configuration#concurrent_execution_rate_percentage ConfigRemediationConfiguration#concurrent_execution_rate_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "concurrentExecutionRatePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ConcurrentExecutionRatePercentage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_remediation_configuration#error_percentage ConfigRemediationConfiguration#error_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "errorPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ErrorPercentage
        {
            get;
            set;
        }
    }
}
