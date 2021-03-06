using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    [JsiiInterface(nativeType: typeof(IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationFlinkRunConfiguration), fullyQualifiedName: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationFlinkRunConfiguration")]
    public interface IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationFlinkRunConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#allow_non_restored_state Kinesisanalyticsv2Application#allow_non_restored_state}.</summary>
        [JsiiProperty(name: "allowNonRestoredState", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowNonRestoredState
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationFlinkRunConfiguration), fullyQualifiedName: "aws.kinesis.Kinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationFlinkRunConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Kinesis.IKinesisanalyticsv2ApplicationApplicationConfigurationRunConfigurationFlinkRunConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application#allow_non_restored_state Kinesisanalyticsv2Application#allow_non_restored_state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowNonRestoredState", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowNonRestoredState
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
