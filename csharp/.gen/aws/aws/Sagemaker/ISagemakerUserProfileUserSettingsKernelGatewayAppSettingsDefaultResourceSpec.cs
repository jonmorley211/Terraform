using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec), fullyQualifiedName: "aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec")]
    public interface ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#instance_type SagemakerUserProfile#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#lifecycle_config_arn SagemakerUserProfile#lifecycle_config_arn}.</summary>
        [JsiiProperty(name: "lifecycleConfigArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LifecycleConfigArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#sagemaker_image_arn SagemakerUserProfile#sagemaker_image_arn}.</summary>
        [JsiiProperty(name: "sagemakerImageArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SagemakerImageArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#sagemaker_image_version_arn SagemakerUserProfile#sagemaker_image_version_arn}.</summary>
        [JsiiProperty(name: "sagemakerImageVersionArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SagemakerImageVersionArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec), fullyQualifiedName: "aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#instance_type SagemakerUserProfile#instance_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#lifecycle_config_arn SagemakerUserProfile#lifecycle_config_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycleConfigArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LifecycleConfigArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#sagemaker_image_arn SagemakerUserProfile#sagemaker_image_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sagemakerImageArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SagemakerImageArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#sagemaker_image_version_arn SagemakerUserProfile#sagemaker_image_version_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sagemakerImageVersionArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SagemakerImageVersionArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
