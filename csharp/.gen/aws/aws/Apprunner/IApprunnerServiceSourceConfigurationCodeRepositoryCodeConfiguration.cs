using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apprunner
{
    [JsiiInterface(nativeType: typeof(IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration), fullyQualifiedName: "aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration")]
    public interface IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#configuration_source ApprunnerService#configuration_source}.</summary>
        [JsiiProperty(name: "configurationSource", typeJson: "{\"primitive\":\"string\"}")]
        string ConfigurationSource
        {
            get;
        }

        /// <summary>code_configuration_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#code_configuration_values ApprunnerService#code_configuration_values}
        /// </remarks>
        [JsiiProperty(name: "codeConfigurationValues", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues? CodeConfigurationValues
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration), fullyQualifiedName: "aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#configuration_source ApprunnerService#configuration_source}.</summary>
            [JsiiProperty(name: "configurationSource", typeJson: "{\"primitive\":\"string\"}")]
            public string ConfigurationSource
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>code_configuration_values block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#code_configuration_values ApprunnerService#code_configuration_values}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeConfigurationValues", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues\"}", isOptional: true)]
            public aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues? CodeConfigurationValues
            {
                get => GetInstanceProperty<aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues?>();
            }
        }
    }
}
