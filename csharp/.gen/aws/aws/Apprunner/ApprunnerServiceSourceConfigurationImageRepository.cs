using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apprunner
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apprunner.ApprunnerServiceSourceConfigurationImageRepository")]
    public class ApprunnerServiceSourceConfigurationImageRepository : aws.Apprunner.IApprunnerServiceSourceConfigurationImageRepository
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#image_identifier ApprunnerService#image_identifier}.</summary>
        [JsiiProperty(name: "imageIdentifier", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ImageIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#image_repository_type ApprunnerService#image_repository_type}.</summary>
        [JsiiProperty(name: "imageRepositoryType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ImageRepositoryType
        {
            get;
            set;
        }

        /// <summary>image_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#image_configuration ApprunnerService#image_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "imageConfiguration", typeJson: "{\"fqn\":\"aws.apprunner.ApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration\"}", isOptional: true, isOverride: true)]
        public aws.Apprunner.IApprunnerServiceSourceConfigurationImageRepositoryImageConfiguration? ImageConfiguration
        {
            get;
            set;
        }
    }
}
