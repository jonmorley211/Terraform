using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerUserProfileUserSettingsKernelGatewayAppSettings), fullyQualifiedName: "aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettings")]
    public interface ISagemakerUserProfileUserSettingsKernelGatewayAppSettings
    {
        /// <summary>default_resource_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#default_resource_spec SagemakerUserProfile#default_resource_spec}
        /// </remarks>
        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec\"}")]
        aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec DefaultResourceSpec
        {
            get;
        }

        /// <summary>custom_image block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#custom_image SagemakerUserProfile#custom_image}
        /// </remarks>
        [JsiiProperty(name: "customImage", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage[]? CustomImage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#lifecycle_config_arns SagemakerUserProfile#lifecycle_config_arns}.</summary>
        [JsiiProperty(name: "lifecycleConfigArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? LifecycleConfigArns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerUserProfileUserSettingsKernelGatewayAppSettings), fullyQualifiedName: "aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettings")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_resource_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#default_resource_spec SagemakerUserProfile#default_resource_spec}
            /// </remarks>
            [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec\"}")]
            public aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec DefaultResourceSpec
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec>()!;
            }

            /// <summary>custom_image block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#custom_image SagemakerUserProfile#custom_image}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customImage", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage[]? CustomImage
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#lifecycle_config_arns SagemakerUserProfile#lifecycle_config_arns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycleConfigArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? LifecycleConfigArns
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
