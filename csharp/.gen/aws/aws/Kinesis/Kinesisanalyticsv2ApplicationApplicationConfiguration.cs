using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfiguration")]
    public class Kinesisanalyticsv2ApplicationApplicationConfiguration : aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfiguration
    {
        /// <summary>application_code_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#application_code_configuration Kinesisanalyticsv2Application#application_code_configuration}
        /// </remarks>
        [JsiiProperty(name: "applicationCodeConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfiguration\"}", isOverride: true)]
        public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfiguration ApplicationCodeConfiguration
        {
            get;
            set;
        }

        /// <summary>application_snapshot_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#application_snapshot_configuration Kinesisanalyticsv2Application#application_snapshot_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applicationSnapshotConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationSnapshotConfiguration\"}", isOptional: true, isOverride: true)]
        public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationApplicationSnapshotConfiguration? ApplicationSnapshotConfiguration
        {
            get;
            set;
        }

        /// <summary>environment_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#environment_properties Kinesisanalyticsv2Application#environment_properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "environmentProperties", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentProperties\"}", isOptional: true, isOverride: true)]
        public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentProperties? EnvironmentProperties
        {
            get;
            set;
        }

        /// <summary>flink_application_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#flink_application_configuration Kinesisanalyticsv2Application#flink_application_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "flinkApplicationConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationFlinkApplicationConfiguration\"}", isOptional: true, isOverride: true)]
        public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationFlinkApplicationConfiguration? FlinkApplicationConfiguration
        {
            get;
            set;
        }

        /// <summary>run_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#run_configuration Kinesisanalyticsv2Application#run_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "runConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfiguration\"}", isOptional: true, isOverride: true)]
        public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfiguration? RunConfiguration
        {
            get;
            set;
        }

        /// <summary>sql_application_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#sql_application_configuration Kinesisanalyticsv2Application#sql_application_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sqlApplicationConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfiguration\"}", isOptional: true, isOverride: true)]
        public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfiguration? SqlApplicationConfiguration
        {
            get;
            set;
        }

        /// <summary>vpc_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#vpc_configuration Kinesisanalyticsv2Application#vpc_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationVpcConfiguration\"}", isOptional: true, isOverride: true)]
        public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationVpcConfiguration? VpcConfiguration
        {
            get;
            set;
        }
    }
}
