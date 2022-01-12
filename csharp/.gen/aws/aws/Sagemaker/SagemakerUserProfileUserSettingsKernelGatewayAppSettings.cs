using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettings")]
    public class SagemakerUserProfileUserSettingsKernelGatewayAppSettings : aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettings
    {
        /// <summary>default_resource_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#default_resource_spec SagemakerUserProfile#default_resource_spec}
        /// </remarks>
        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec\"}", isOverride: true)]
        public aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec DefaultResourceSpec
        {
            get;
            set;
        }

        /// <summary>custom_image block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#custom_image SagemakerUserProfile#custom_image}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customImage", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage[]? CustomImage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#lifecycle_config_arns SagemakerUserProfile#lifecycle_config_arns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycleConfigArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? LifecycleConfigArns
        {
            get;
            set;
        }
    }
}
