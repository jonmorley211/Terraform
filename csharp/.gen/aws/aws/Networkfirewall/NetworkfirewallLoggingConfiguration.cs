using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_logging_configuration aws_networkfirewall_logging_configuration}.</summary>
    [JsiiClass(nativeType: typeof(aws.Networkfirewall.NetworkfirewallLoggingConfiguration), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallLoggingConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallLoggingConfigurationConfig\"}}]")]
    public class NetworkfirewallLoggingConfiguration : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/networkfirewall_logging_configuration aws_networkfirewall_logging_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public NetworkfirewallLoggingConfiguration(Constructs.Construct scope, string id, aws.Networkfirewall.INetworkfirewallLoggingConfigurationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkfirewallLoggingConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkfirewallLoggingConfiguration(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLoggingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallLoggingConfigurationLoggingConfiguration\"}}]")]
        public virtual void PutLoggingConfiguration(aws.Networkfirewall.INetworkfirewallLoggingConfigurationLoggingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Networkfirewall.INetworkfirewallLoggingConfigurationLoggingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Networkfirewall.NetworkfirewallLoggingConfiguration))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loggingConfiguration", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallLoggingConfigurationLoggingConfigurationOutputReference\"}")]
        public virtual aws.Networkfirewall.NetworkfirewallLoggingConfigurationLoggingConfigurationOutputReference LoggingConfiguration
        {
            get => GetInstanceProperty<aws.Networkfirewall.NetworkfirewallLoggingConfigurationLoggingConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "firewallArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FirewallArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingConfigurationInput", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallLoggingConfigurationLoggingConfiguration\"}", isOptional: true)]
        public virtual aws.Networkfirewall.INetworkfirewallLoggingConfigurationLoggingConfiguration? LoggingConfigurationInput
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallLoggingConfigurationLoggingConfiguration?>();
        }

        [JsiiProperty(name: "firewallArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FirewallArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
