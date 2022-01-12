using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationSnapshotConfiguration")]
    public class Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationSnapshotConfiguration : aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationApplicationSnapshotConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#snapshots_enabled Kinesisanalyticsv2Application#snapshots_enabled}.</summary>
        [JsiiProperty(name: "snapshotsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOverride: true)]
        public object SnapshotsEnabled
        {
            get;
            set;
        }
    }
}
