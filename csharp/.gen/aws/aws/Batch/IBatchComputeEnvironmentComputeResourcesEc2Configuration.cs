using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    [JsiiInterface(nativeType: typeof(IBatchComputeEnvironmentComputeResourcesEc2Configuration), fullyQualifiedName: "aws.batch.BatchComputeEnvironmentComputeResourcesEc2Configuration")]
    public interface IBatchComputeEnvironmentComputeResourcesEc2Configuration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#image_id_override BatchComputeEnvironment#image_id_override}.</summary>
        [JsiiProperty(name: "imageIdOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageIdOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#image_type BatchComputeEnvironment#image_type}.</summary>
        [JsiiProperty(name: "imageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ImageType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchComputeEnvironmentComputeResourcesEc2Configuration), fullyQualifiedName: "aws.batch.BatchComputeEnvironmentComputeResourcesEc2Configuration")]
        internal sealed class _Proxy : DeputyBase, aws.Batch.IBatchComputeEnvironmentComputeResourcesEc2Configuration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#image_id_override BatchComputeEnvironment#image_id_override}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageIdOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageIdOverride
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#image_type BatchComputeEnvironment#image_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "imageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ImageType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
