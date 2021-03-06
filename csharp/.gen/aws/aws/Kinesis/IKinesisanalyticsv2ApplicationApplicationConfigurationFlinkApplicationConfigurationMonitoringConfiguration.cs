using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisanalyticsv2ApplicationApplicationConfigurationFlinkApplicationConfigurationMonitoringConfiguration), fullyQualifiedName: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationFlinkApplicationConfigurationMonitoringConfiguration")]
    public interface IKinesisanalyticsv2ApplicationApplicationConfigurationFlinkApplicationConfigurationMonitoringConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#configuration_type Kinesisanalyticsv2Application#configuration_type}.</summary>
        [JsiiProperty(name: "configurationType", typeJson: "{\"primitive\":\"string\"}")]
        string ConfigurationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#log_level Kinesisanalyticsv2Application#log_level}.</summary>
        [JsiiProperty(name: "logLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#metrics_level Kinesisanalyticsv2Application#metrics_level}.</summary>
        [JsiiProperty(name: "metricsLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MetricsLevel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisanalyticsv2ApplicationApplicationConfigurationFlinkApplicationConfigurationMonitoringConfiguration), fullyQualifiedName: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationFlinkApplicationConfigurationMonitoringConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationFlinkApplicationConfigurationMonitoringConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#configuration_type Kinesisanalyticsv2Application#configuration_type}.</summary>
            [JsiiProperty(name: "configurationType", typeJson: "{\"primitive\":\"string\"}")]
            public string ConfigurationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#log_level Kinesisanalyticsv2Application#log_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#metrics_level Kinesisanalyticsv2Application#metrics_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricsLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MetricsLevel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
