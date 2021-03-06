using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fsx.FsxOpenzfsVolumeOriginSnapshot")]
    public class FsxOpenzfsVolumeOriginSnapshot : aws.Fsx.IFsxOpenzfsVolumeOriginSnapshot
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_volume#copy_strategy FsxOpenzfsVolume#copy_strategy}.</summary>
        [JsiiProperty(name: "copyStrategy", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string CopyStrategy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_volume#snapshot_arn FsxOpenzfsVolume#snapshot_arn}.</summary>
        [JsiiProperty(name: "snapshotArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SnapshotArn
        {
            get;
            set;
        }
    }
}
