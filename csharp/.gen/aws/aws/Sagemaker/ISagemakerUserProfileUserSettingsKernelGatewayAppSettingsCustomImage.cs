using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage), fullyQualifiedName: "aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage")]
    public interface ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#app_image_config_name SagemakerUserProfile#app_image_config_name}.</summary>
        [JsiiProperty(name: "appImageConfigName", typeJson: "{\"primitive\":\"string\"}")]
        string AppImageConfigName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#image_name SagemakerUserProfile#image_name}.</summary>
        [JsiiProperty(name: "imageName", typeJson: "{\"primitive\":\"string\"}")]
        string ImageName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#image_version_number SagemakerUserProfile#image_version_number}.</summary>
        [JsiiProperty(name: "imageVersionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ImageVersionNumber
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage), fullyQualifiedName: "aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#app_image_config_name SagemakerUserProfile#app_image_config_name}.</summary>
            [JsiiProperty(name: "appImageConfigName", typeJson: "{\"primitive\":\"string\"}")]
            public string AppImageConfigName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#image_name SagemakerUserProfile#image_name}.</summary>
            [JsiiProperty(name: "imageName", typeJson: "{\"primitive\":\"string\"}")]
            public string ImageName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#image_version_number SagemakerUserProfile#image_version_number}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageVersionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ImageVersionNumber
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
