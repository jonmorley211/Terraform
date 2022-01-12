using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkfirewall.NetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig")]
    public class NetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig : aws.Networkfirewall.INetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_logging_configuration#log_destination NetworkfirewallLoggingConfiguration#log_destination}.</summary>
        [JsiiProperty(name: "logDestination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOverride: true)]
        public object LogDestination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_logging_configuration#log_destination_type NetworkfirewallLoggingConfiguration#log_destination_type}.</summary>
        [JsiiProperty(name: "logDestinationType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string LogDestinationType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_logging_configuration#log_type NetworkfirewallLoggingConfiguration#log_type}.</summary>
        [JsiiProperty(name: "logType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string LogType
        {
            get;
            set;
        }
    }
}
