using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketOwnershipControlsRule")]
    public class S3BucketOwnershipControlsRule : aws.S3.IS3BucketOwnershipControlsRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_ownership_controls#object_ownership S3BucketOwnershipControls#object_ownership}.</summary>
        [JsiiProperty(name: "objectOwnership", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ObjectOwnership
        {
            get;
            set;
        }
    }
}
