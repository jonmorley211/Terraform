using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Signer
{
    [JsiiInterface(nativeType: typeof(ISignerSigningJobSource), fullyQualifiedName: "aws.signer.SignerSigningJobSource")]
    public interface ISignerSigningJobSource
    {
        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/signer_signing_job#s3 SignerSigningJob#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.signer.SignerSigningJobSourceS3\"}")]
        aws.Signer.ISignerSigningJobSourceS3 S3
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISignerSigningJobSource), fullyQualifiedName: "aws.signer.SignerSigningJobSource")]
        internal sealed class _Proxy : DeputyBase, aws.Signer.ISignerSigningJobSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/signer_signing_job#s3 SignerSigningJob#s3}
            /// </remarks>
            [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.signer.SignerSigningJobSourceS3\"}")]
            public aws.Signer.ISignerSigningJobSourceS3 S3
            {
                get => GetInstanceProperty<aws.Signer.ISignerSigningJobSourceS3>()!;
            }
        }
    }
}
