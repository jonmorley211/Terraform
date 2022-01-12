using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig")]
    public interface INetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_logging_configuration#log_destination NetworkfirewallLoggingConfiguration#log_destination}.</summary>
        [JsiiProperty(name: "logDestination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        object LogDestination
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_logging_configuration#log_destination_type NetworkfirewallLoggingConfiguration#log_destination_type}.</summary>
        [JsiiProperty(name: "logDestinationType", typeJson: "{\"primitive\":\"string\"}")]
        string LogDestinationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_logging_configuration#log_type NetworkfirewallLoggingConfiguration#log_type}.</summary>
        [JsiiProperty(name: "logType", typeJson: "{\"primitive\":\"string\"}")]
        string LogType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Networkfirewall.INetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_logging_configuration#log_destination NetworkfirewallLoggingConfiguration#log_destination}.</summary>
            [JsiiProperty(name: "logDestination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
            public object LogDestination
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_logging_configuration#log_destination_type NetworkfirewallLoggingConfiguration#log_destination_type}.</summary>
            [JsiiProperty(name: "logDestinationType", typeJson: "{\"primitive\":\"string\"}")]
            public string LogDestinationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_logging_configuration#log_type NetworkfirewallLoggingConfiguration#log_type}.</summary>
            [JsiiProperty(name: "logType", typeJson: "{\"primitive\":\"string\"}")]
            public string LogType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
