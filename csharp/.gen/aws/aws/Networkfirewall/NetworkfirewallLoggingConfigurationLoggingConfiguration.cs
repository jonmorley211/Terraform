using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkfirewall.NetworkfirewallLoggingConfigurationLoggingConfiguration")]
    public class NetworkfirewallLoggingConfigurationLoggingConfiguration : aws.Networkfirewall.INetworkfirewallLoggingConfigurationLoggingConfiguration
    {
        /// <summary>log_destination_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_logging_configuration#log_destination_config NetworkfirewallLoggingConfiguration#log_destination_config}
        /// </remarks>
        [JsiiProperty(name: "logDestinationConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Networkfirewall.INetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig[] LogDestinationConfig
        {
            get;
            set;
        }
    }
}
