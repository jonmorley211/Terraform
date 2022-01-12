using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    [JsiiClass(nativeType: typeof(aws.Networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariablesOutputReference), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariablesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class NetworkfirewallRuleGroupRuleGroupRuleVariablesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public NetworkfirewallRuleGroupRuleGroupRuleVariablesOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkfirewallRuleGroupRuleGroupRuleVariablesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkfirewallRuleGroupRuleGroupRuleVariablesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetIpSets")]
        public virtual void ResetIpSets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPortSets")]
        public virtual void ResetPortSets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipSetsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariablesIpSets\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariablesIpSets[]? IpSetsInput
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariablesIpSets[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portSetsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets[]? PortSetsInput
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets[]?>();
        }

        [JsiiProperty(name: "ipSets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariablesIpSets\"},\"kind\":\"array\"}}")]
        public virtual aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariablesIpSets[] IpSets
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariablesIpSets[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "portSets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets\"},\"kind\":\"array\"}}")]
        public virtual aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets[] PortSets
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariablesPortSets[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariables\"}", isOptional: true)]
        public virtual aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariables? InternalValue
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariables?>();
            set => SetInstanceProperty(value);
        }
    }
}
