using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Signer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.signer.SignerSigningJobDestination")]
    public class SignerSigningJobDestination : aws.Signer.ISignerSigningJobDestination
    {
        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/signer_signing_job#s3 SignerSigningJob#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.signer.SignerSigningJobDestinationS3\"}", isOverride: true)]
        public aws.Signer.ISignerSigningJobDestinationS3 S3
        {
            get;
            set;
        }
    }
}
