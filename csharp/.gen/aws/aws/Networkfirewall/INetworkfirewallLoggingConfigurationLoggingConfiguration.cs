using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallLoggingConfigurationLoggingConfiguration), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallLoggingConfigurationLoggingConfiguration")]
    public interface INetworkfirewallLoggingConfigurationLoggingConfiguration
    {
        /// <summary>log_destination_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_logging_configuration#log_destination_config NetworkfirewallLoggingConfiguration#log_destination_config}
        /// </remarks>
        [JsiiProperty(name: "logDestinationConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig\"},\"kind\":\"array\"}}")]
        aws.Networkfirewall.INetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig[] LogDestinationConfig
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallLoggingConfigurationLoggingConfiguration), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallLoggingConfigurationLoggingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Networkfirewall.INetworkfirewallLoggingConfigurationLoggingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>log_destination_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_logging_configuration#log_destination_config NetworkfirewallLoggingConfiguration#log_destination_config}
            /// </remarks>
            [JsiiProperty(name: "logDestinationConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig\"},\"kind\":\"array\"}}")]
            public aws.Networkfirewall.INetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig[] LogDestinationConfig
            {
                get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig[]>()!;
            }
        }
    }
}
