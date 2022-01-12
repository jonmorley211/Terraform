using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Synthetics
{
    [JsiiInterface(nativeType: typeof(ISyntheticsCanaryArtifactConfig), fullyQualifiedName: "aws.synthetics.SyntheticsCanaryArtifactConfig")]
    public interface ISyntheticsCanaryArtifactConfig
    {
        /// <summary>s3_encryption block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/synthetics_canary#s3_encryption SyntheticsCanary#s3_encryption}
        /// </remarks>
        [JsiiProperty(name: "s3Encryption", typeJson: "{\"fqn\":\"aws.synthetics.SyntheticsCanaryArtifactConfigS3Encryption\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Synthetics.ISyntheticsCanaryArtifactConfigS3Encryption? S3Encryption
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISyntheticsCanaryArtifactConfig), fullyQualifiedName: "aws.synthetics.SyntheticsCanaryArtifactConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Synthetics.ISyntheticsCanaryArtifactConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_encryption block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/synthetics_canary#s3_encryption SyntheticsCanary#s3_encryption}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Encryption", typeJson: "{\"fqn\":\"aws.synthetics.SyntheticsCanaryArtifactConfigS3Encryption\"}", isOptional: true)]
            public aws.Synthetics.ISyntheticsCanaryArtifactConfigS3Encryption? S3Encryption
            {
                get => GetInstanceProperty<aws.Synthetics.ISyntheticsCanaryArtifactConfigS3Encryption?>();
            }
        }
    }
}
