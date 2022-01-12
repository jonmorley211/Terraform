using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apprunner
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration")]
    public class ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration : aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#configuration_source ApprunnerService#configuration_source}.</summary>
        [JsiiProperty(name: "configurationSource", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ConfigurationSource
        {
            get;
            set;
        }

        /// <summary>code_configuration_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#code_configuration_values ApprunnerService#code_configuration_values}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeConfigurationValues", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues\"}", isOptional: true, isOverride: true)]
        public aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfigurationCodeConfigurationValues? CodeConfigurationValues
        {
            get;
            set;
        }
    }
}
