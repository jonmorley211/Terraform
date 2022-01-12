using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisanalyticsv2ApplicationApplicationConfiguration), fullyQualifiedName: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfiguration")]
    public interface IKinesisanalyticsv2ApplicationApplicationConfiguration
    {
        /// <summary>application_code_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#application_code_configuration Kinesisanalyticsv2Application#application_code_configuration}
        /// </remarks>
        [JsiiProperty(name: "applicationCodeConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfiguration\"}")]
        aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfiguration ApplicationCodeConfiguration
        {
            get;
        }

        /// <summary>application_snapshot_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#application_snapshot_configuration Kinesisanalyticsv2Application#application_snapshot_configuration}
        /// </remarks>
        [JsiiProperty(name: "applicationSnapshotConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationSnapshotConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationApplicationSnapshotConfiguration? ApplicationSnapshotConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>environment_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#environment_properties Kinesisanalyticsv2Application#environment_properties}
        /// </remarks>
        [JsiiProperty(name: "environmentProperties", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentProperties\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentProperties? EnvironmentProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>flink_application_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#flink_application_configuration Kinesisanalyticsv2Application#flink_application_configuration}
        /// </remarks>
        [JsiiProperty(name: "flinkApplicationConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationFlinkApplicationConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationFlinkApplicationConfiguration? FlinkApplicationConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>run_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#run_configuration Kinesisanalyticsv2Application#run_configuration}
        /// </remarks>
        [JsiiProperty(name: "runConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfiguration? RunConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>sql_application_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#sql_application_configuration Kinesisanalyticsv2Application#sql_application_configuration}
        /// </remarks>
        [JsiiProperty(name: "sqlApplicationConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfiguration? SqlApplicationConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>vpc_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#vpc_configuration Kinesisanalyticsv2Application#vpc_configuration}
        /// </remarks>
        [JsiiProperty(name: "vpcConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationVpcConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationVpcConfiguration? VpcConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisanalyticsv2ApplicationApplicationConfiguration), fullyQualifiedName: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>application_code_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#application_code_configuration Kinesisanalyticsv2Application#application_code_configuration}
            /// </remarks>
            [JsiiProperty(name: "applicationCodeConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfiguration\"}")]
            public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfiguration ApplicationCodeConfiguration
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationApplicationCodeConfiguration>()!;
            }

            /// <summary>application_snapshot_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#application_snapshot_configuration Kinesisanalyticsv2Application#application_snapshot_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationSnapshotConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationApplicationSnapshotConfiguration\"}", isOptional: true)]
            public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationApplicationSnapshotConfiguration? ApplicationSnapshotConfiguration
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationApplicationSnapshotConfiguration?>();
            }

            /// <summary>environment_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#environment_properties Kinesisanalyticsv2Application#environment_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "environmentProperties", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentProperties\"}", isOptional: true)]
            public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentProperties? EnvironmentProperties
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentProperties?>();
            }

            /// <summary>flink_application_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#flink_application_configuration Kinesisanalyticsv2Application#flink_application_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flinkApplicationConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationFlinkApplicationConfiguration\"}", isOptional: true)]
            public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationFlinkApplicationConfiguration? FlinkApplicationConfiguration
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationFlinkApplicationConfiguration?>();
            }

            /// <summary>run_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#run_configuration Kinesisanalyticsv2Application#run_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfiguration\"}", isOptional: true)]
            public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfiguration? RunConfiguration
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfiguration?>();
            }

            /// <summary>sql_application_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#sql_application_configuration Kinesisanalyticsv2Application#sql_application_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sqlApplicationConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfiguration\"}", isOptional: true)]
            public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfiguration? SqlApplicationConfiguration
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationSqlApplicationConfiguration?>();
            }

            /// <summary>vpc_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#vpc_configuration Kinesisanalyticsv2Application#vpc_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpcConfiguration", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationVpcConfiguration\"}", isOptional: true)]
            public aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationVpcConfiguration? VpcConfiguration
            {
                get => GetInstanceProperty<aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationVpcConfiguration?>();
            }
        }
    }
}
