using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerAppImageConfigKernelGatewayImageConfig")]
    public class SagemakerAppImageConfigKernelGatewayImageConfig : aws.Sagemaker.ISagemakerAppImageConfigKernelGatewayImageConfig
    {
        /// <summary>kernel_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_app_image_config#kernel_spec SagemakerAppImageConfig#kernel_spec}
        /// </remarks>
        [JsiiProperty(name: "kernelSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerAppImageConfigKernelGatewayImageConfigKernelSpec\"}", isOverride: true)]
        public aws.Sagemaker.ISagemakerAppImageConfigKernelGatewayImageConfigKernelSpec KernelSpec
        {
            get;
            set;
        }

        /// <summary>file_system_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_app_image_config#file_system_config SagemakerAppImageConfig#file_system_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystemConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig? FileSystemConfig
        {
            get;
            set;
        }
    }
}
