using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    [JsiiInterface(nativeType: typeof(IConfigRemediationConfigurationExecutionControls), fullyQualifiedName: "aws.config.ConfigRemediationConfigurationExecutionControls")]
    public interface IConfigRemediationConfigurationExecutionControls
    {
        /// <summary>ssm_controls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_remediation_configuration#ssm_controls ConfigRemediationConfiguration#ssm_controls}
        /// </remarks>
        [JsiiProperty(name: "ssmControls", typeJson: "{\"fqn\":\"aws.config.ConfigRemediationConfigurationExecutionControlsSsmControls\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Config.IConfigRemediationConfigurationExecutionControlsSsmControls? SsmControls
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigRemediationConfigurationExecutionControls), fullyQualifiedName: "aws.config.ConfigRemediationConfigurationExecutionControls")]
        internal sealed class _Proxy : DeputyBase, aws.Config.IConfigRemediationConfigurationExecutionControls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ssm_controls block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/config_remediation_configuration#ssm_controls ConfigRemediationConfiguration#ssm_controls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ssmControls", typeJson: "{\"fqn\":\"aws.config.ConfigRemediationConfigurationExecutionControlsSsmControls\"}", isOptional: true)]
            public aws.Config.IConfigRemediationConfigurationExecutionControlsSsmControls? SsmControls
            {
                get => GetInstanceProperty<aws.Config.IConfigRemediationConfigurationExecutionControlsSsmControls?>();
            }
        }
    }
}
