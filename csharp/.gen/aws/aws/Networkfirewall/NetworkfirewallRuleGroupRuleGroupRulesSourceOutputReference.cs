using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    [JsiiClass(nativeType: typeof(aws.Networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceOutputReference), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class NetworkfirewallRuleGroupRuleGroupRulesSourceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public NetworkfirewallRuleGroupRuleGroupRulesSourceOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkfirewallRuleGroupRuleGroupRulesSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkfirewallRuleGroupRuleGroupRulesSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRulesSourceList", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceRulesSourceList\"}}]")]
        public virtual void PutRulesSourceList(aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceRulesSourceList @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceRulesSourceList)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStatelessRulesAndCustomActions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActions\"}}]")]
        public virtual void PutStatelessRulesAndCustomActions(aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRulesSourceList")]
        public virtual void ResetRulesSourceList()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRulesString")]
        public virtual void ResetRulesString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatefulRule")]
        public virtual void ResetStatefulRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatelessRulesAndCustomActions")]
        public virtual void ResetStatelessRulesAndCustomActions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "rulesSourceList", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceRulesSourceListOutputReference\"}")]
        public virtual aws.Networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceRulesSourceListOutputReference RulesSourceList
        {
            get => GetInstanceProperty<aws.Networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceRulesSourceListOutputReference>()!;
        }

        [JsiiProperty(name: "statelessRulesAndCustomActions", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsOutputReference\"}")]
        public virtual aws.Networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsOutputReference StatelessRulesAndCustomActions
        {
            get => GetInstanceProperty<aws.Networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rulesSourceListInput", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceRulesSourceList\"}", isOptional: true)]
        public virtual aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceRulesSourceList? RulesSourceListInput
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceRulesSourceList?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rulesStringInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RulesStringInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statefulRuleInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatefulRule\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatefulRule[]? StatefulRuleInput
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatefulRule[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statelessRulesAndCustomActionsInput", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActions\"}", isOptional: true)]
        public virtual aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActions? StatelessRulesAndCustomActionsInput
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatelessRulesAndCustomActions?>();
        }

        [JsiiProperty(name: "rulesString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RulesString
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "statefulRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceStatefulRule\"},\"kind\":\"array\"}}")]
        public virtual aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatefulRule[] StatefulRule
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSourceStatefulRule[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSource\"}", isOptional: true)]
        public virtual aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSource? InternalValue
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
