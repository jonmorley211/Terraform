using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig), fullyQualifiedName: "aws.sagemaker.SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig")]
    public interface ISagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_app_image_config#default_gid SagemakerAppImageConfig#default_gid}.</summary>
        [JsiiProperty(name: "defaultGid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DefaultGid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_app_image_config#default_uid SagemakerAppImageConfig#default_uid}.</summary>
        [JsiiProperty(name: "defaultUid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DefaultUid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_app_image_config#mount_path SagemakerAppImageConfig#mount_path}.</summary>
        [JsiiProperty(name: "mountPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MountPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig), fullyQualifiedName: "aws.sagemaker.SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_app_image_config#default_gid SagemakerAppImageConfig#default_gid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultGid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DefaultGid
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_app_image_config#default_uid SagemakerAppImageConfig#default_uid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultUid", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DefaultUid
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_app_image_config#mount_path SagemakerAppImageConfig#mount_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mountPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MountPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
