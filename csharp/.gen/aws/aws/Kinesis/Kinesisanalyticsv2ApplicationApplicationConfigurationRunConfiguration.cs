using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiByValue(fqn: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfiguration")]
    public class Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfiguration : aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfiguration
    {
        /// <summary>application_restore_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#application_restore_configuration Kinesisanalyticsv2Application#application_restore_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applicationRestoreConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationApplicationRestoreConfiguration\"}", isOptional: true, isOverride: true)]
        public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationApplicationRestoreConfiguration? ApplicationRestoreConfiguration
        {
            get;
            set;
        }

        /// <summary>flink_run_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#flink_run_configuration Kinesisanalyticsv2Application#flink_run_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "flinkRunConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationFlinkRunConfiguration\"}", isOptional: true, isOverride: true)]
        public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationFlinkRunConfiguration? FlinkRunConfiguration
        {
            get;
            set;
        }
    }
}
