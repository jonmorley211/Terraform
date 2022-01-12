using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apprunner
{
    [JsiiByValue(fqn: "aws.apprunner.ApprunnerServiceSourceConfiguration")]
    public class ApprunnerServiceSourceConfiguration : aws.Apprunner.IApprunnerServiceSourceConfiguration
    {
        /// <summary>authentication_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#authentication_configuration ApprunnerService#authentication_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationConfiguration", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationAuthenticationConfiguration\"}", isOptional: true, isOverride: true)]
        public aws.Apprunner.IApprunnerServiceSourceConfigurationAuthenticationConfiguration? AuthenticationConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#auto_deployments_enabled ApprunnerService#auto_deployments_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoDeploymentsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? AutoDeploymentsEnabled
        {
            get;
            set;
        }

        /// <summary>code_repository block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#code_repository ApprunnerService#code_repository}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeRepository", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepository\"}", isOptional: true, isOverride: true)]
        public aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepository? CodeRepository
        {
            get;
            set;
        }

        /// <summary>image_repository block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#image_repository ApprunnerService#image_repository}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "imageRepository", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationImageRepository\"}", isOptional: true, isOverride: true)]
        public aws.Apprunner.IApprunnerServiceSourceConfigurationImageRepository? ImageRepository
        {
            get;
            set;
        }
    }
}
