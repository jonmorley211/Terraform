using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    /// <summary>AWS Network Firewall.</summary>
    [JsiiInterface(nativeType: typeof(INetworkfirewallLoggingConfigurationConfig), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallLoggingConfigurationConfig")]
    public interface INetworkfirewallLoggingConfigurationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_logging_configuration#firewall_arn NetworkfirewallLoggingConfiguration#firewall_arn}.</summary>
        [JsiiProperty(name: "firewallArn", typeJson: "{\"primitive\":\"string\"}")]
        string FirewallArn
        {
            get;
        }

        /// <summary>logging_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_logging_configuration#logging_configuration NetworkfirewallLoggingConfiguration#logging_configuration}
        /// </remarks>
        [JsiiProperty(name: "loggingConfiguration", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallLoggingConfigurationLoggingConfiguration\"}")]
        aws.Networkfirewall.INetworkfirewallLoggingConfigurationLoggingConfiguration LoggingConfiguration
        {
            get;
        }

        /// <summary>AWS Network Firewall.</summary>
        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallLoggingConfigurationConfig), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallLoggingConfigurationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Networkfirewall.INetworkfirewallLoggingConfigurationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_logging_configuration#firewall_arn NetworkfirewallLoggingConfiguration#firewall_arn}.</summary>
            [JsiiProperty(name: "firewallArn", typeJson: "{\"primitive\":\"string\"}")]
            public string FirewallArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>logging_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_logging_configuration#logging_configuration NetworkfirewallLoggingConfiguration#logging_configuration}
            /// </remarks>
            [JsiiProperty(name: "loggingConfiguration", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallLoggingConfigurationLoggingConfiguration\"}")]
            public aws.Networkfirewall.INetworkfirewallLoggingConfigurationLoggingConfiguration LoggingConfiguration
            {
                get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallLoggingConfigurationLoggingConfiguration>()!;
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
