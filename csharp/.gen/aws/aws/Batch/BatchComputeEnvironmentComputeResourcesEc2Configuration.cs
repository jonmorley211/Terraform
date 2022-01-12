using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    [JsiiByValue(fqn: "aws.batch.BatchComputeEnvironmentComputeResourcesEc2Configuration")]
    public class BatchComputeEnvironmentComputeResourcesEc2Configuration : aws.Batch.IBatchComputeEnvironmentComputeResourcesEc2Configuration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#image_id_override BatchComputeEnvironment#image_id_override}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageIdOverride", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ImageIdOverride
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_compute_environment#image_type BatchComputeEnvironment#image_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ImageType
        {
            get;
            set;
        }
    }
}
