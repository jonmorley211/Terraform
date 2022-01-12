using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiByValue(fqn: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationApplicationRestoreConfiguration")]
    public class Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationApplicationRestoreConfiguration : aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationApplicationRestoreConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#application_restore_type Kinesisanalyticsv2Application#application_restore_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applicationRestoreType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ApplicationRestoreType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#snapshot_name Kinesisanalyticsv2Application#snapshot_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snapshotName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SnapshotName
        {
            get;
            set;
        }
    }
}
