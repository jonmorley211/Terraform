using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerAppImageConfigKernelGatewayImageConfig), fullyQualifiedName: "aws.sagemaker.SagemakerAppImageConfigKernelGatewayImageConfig")]
    public interface ISagemakerAppImageConfigKernelGatewayImageConfig
    {
        /// <summary>kernel_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_app_image_config#kernel_spec SagemakerAppImageConfig#kernel_spec}
        /// </remarks>
        [JsiiProperty(name: "kernelSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerAppImageConfigKernelGatewayImageConfigKernelSpec\"}")]
        aws.Sagemaker.ISagemakerAppImageConfigKernelGatewayImageConfigKernelSpec KernelSpec
        {
            get;
        }

        /// <summary>file_system_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_app_image_config#file_system_config SagemakerAppImageConfig#file_system_config}
        /// </remarks>
        [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig? FileSystemConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerAppImageConfigKernelGatewayImageConfig), fullyQualifiedName: "aws.sagemaker.SagemakerAppImageConfigKernelGatewayImageConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerAppImageConfigKernelGatewayImageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>kernel_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_app_image_config#kernel_spec SagemakerAppImageConfig#kernel_spec}
            /// </remarks>
            [JsiiProperty(name: "kernelSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerAppImageConfigKernelGatewayImageConfigKernelSpec\"}")]
            public aws.Sagemaker.ISagemakerAppImageConfigKernelGatewayImageConfigKernelSpec KernelSpec
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerAppImageConfigKernelGatewayImageConfigKernelSpec>()!;
            }

            /// <summary>file_system_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_app_image_config#file_system_config SagemakerAppImageConfig#file_system_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig? FileSystemConfig
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig?>();
            }
        }
    }
}
