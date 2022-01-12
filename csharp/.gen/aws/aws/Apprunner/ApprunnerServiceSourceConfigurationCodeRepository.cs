using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apprunner
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepository")]
    public class ApprunnerServiceSourceConfigurationCodeRepository : aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepository
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#repository_url ApprunnerService#repository_url}.</summary>
        [JsiiProperty(name: "repositoryUrl", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RepositoryUrl
        {
            get;
            set;
        }

        /// <summary>source_code_version block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#source_code_version ApprunnerService#source_code_version}
        /// </remarks>
        [JsiiProperty(name: "sourceCodeVersion", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion\"}", isOverride: true)]
        public aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositorySourceCodeVersion SourceCodeVersion
        {
            get;
            set;
        }

        /// <summary>code_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#code_configuration ApprunnerService#code_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeConfiguration", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration\"}", isOptional: true, isOverride: true)]
        public aws.Apprunner.IApprunnerServiceSourceConfigurationCodeRepositoryCodeConfiguration? CodeConfiguration
        {
            get;
            set;
        }
    }
}
