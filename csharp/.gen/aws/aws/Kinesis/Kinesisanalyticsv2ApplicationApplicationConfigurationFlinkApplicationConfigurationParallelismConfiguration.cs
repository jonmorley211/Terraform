using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationFlinkApplicationConfigurationParallelismConfiguration")]
    public class Kinesisanalyticsv2ApplicationApplicationConfigurationFlinkApplicationConfigurationParallelismConfiguration : aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationFlinkApplicationConfigurationParallelismConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#configuration_type Kinesisanalyticsv2Application#configuration_type}.</summary>
        [JsiiProperty(name: "configurationType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ConfigurationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#auto_scaling_enabled Kinesisanalyticsv2Application#auto_scaling_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoScalingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? AutoScalingEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#parallelism Kinesisanalyticsv2Application#parallelism}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parallelism", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Parallelism
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#parallelism_per_kpu Kinesisanalyticsv2Application#parallelism_per_kpu}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parallelismPerKpu", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ParallelismPerKpu
        {
            get;
            set;
        }
    }
}
