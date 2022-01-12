using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Synthetics
{
    [JsiiByValue(fqn: "aws.synthetics.SyntheticsCanaryArtifactConfig")]
    public class SyntheticsCanaryArtifactConfig : aws.Synthetics.ISyntheticsCanaryArtifactConfig
    {
        /// <summary>s3_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/synthetics_canary#s3_encryption SyntheticsCanary#s3_encryption}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Encryption", typeJson: "{\"fqn\":\"aws.synthetics.SyntheticsCanaryArtifactConfigS3Encryption\"}", isOptional: true, isOverride: true)]
        public aws.Synthetics.ISyntheticsCanaryArtifactConfigS3Encryption? S3Encryption
        {
            get;
            set;
        }
    }
}
