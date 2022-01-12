using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    [JsiiByValue(fqn: "aws.config.ConfigRemediationConfigurationExecutionControls")]
    public class ConfigRemediationConfigurationExecutionControls : aws.Config.IConfigRemediationConfigurationExecutionControls
    {
        /// <summary>ssm_controls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_remediation_configuration#ssm_controls ConfigRemediationConfiguration#ssm_controls}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ssmControls", typeJson: "{\"fqn\":\"aws.config.ConfigRemediationConfigurationExecutionControlsSsmControls\"}", isOptional: true, isOverride: true)]
        public aws.Config.IConfigRemediationConfigurationExecutionControlsSsmControls? SsmControls
        {
            get;
            set;
        }
    }
}
