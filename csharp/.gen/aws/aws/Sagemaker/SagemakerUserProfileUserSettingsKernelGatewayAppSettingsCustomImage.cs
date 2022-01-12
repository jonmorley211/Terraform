using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage")]
    public class SagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage : aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#app_image_config_name SagemakerUserProfile#app_image_config_name}.</summary>
        [JsiiProperty(name: "appImageConfigName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AppImageConfigName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#image_name SagemakerUserProfile#image_name}.</summary>
        [JsiiProperty(name: "imageName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ImageName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#image_version_number SagemakerUserProfile#image_version_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageVersionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ImageVersionNumber
        {
            get;
            set;
        }
    }
}
