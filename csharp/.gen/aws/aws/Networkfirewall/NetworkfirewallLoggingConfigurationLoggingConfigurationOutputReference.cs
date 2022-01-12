using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    [JsiiClass(nativeType: typeof(aws.Networkfirewall.NetworkfirewallLoggingConfigurationLoggingConfigurationOutputReference), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallLoggingConfigurationLoggingConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class NetworkfirewallLoggingConfigurationLoggingConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public NetworkfirewallLoggingConfigurationLoggingConfigurationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkfirewallLoggingConfigurationLoggingConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkfirewallLoggingConfigurationLoggingConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "logDestinationConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Networkfirewall.INetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig[]? LogDestinationConfigInput
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig[]?>();
        }

        [JsiiProperty(name: "logDestinationConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig\"},\"kind\":\"array\"}}")]
        public virtual aws.Networkfirewall.INetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig[] LogDestinationConfig
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallLoggingConfigurationLoggingConfigurationLogDestinationConfig[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallLoggingConfigurationLoggingConfiguration\"}", isOptional: true)]
        public virtual aws.Networkfirewall.INetworkfirewallLoggingConfigurationLoggingConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallLoggingConfigurationLoggingConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
