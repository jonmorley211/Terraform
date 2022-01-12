using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ec2.EbsSnapshotImportDiskContainerUserBucket")]
    public class EbsSnapshotImportDiskContainerUserBucket : aws.Ec2.IEbsSnapshotImportDiskContainerUserBucket
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ebs_snapshot_import#s3_bucket EbsSnapshotImport#s3_bucket}.</summary>
        [JsiiProperty(name: "s3Bucket", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string S3Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ebs_snapshot_import#s3_key EbsSnapshotImport#s3_key}.</summary>
        [JsiiProperty(name: "s3Key", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string S3Key
        {
            get;
            set;
        }
    }
}
