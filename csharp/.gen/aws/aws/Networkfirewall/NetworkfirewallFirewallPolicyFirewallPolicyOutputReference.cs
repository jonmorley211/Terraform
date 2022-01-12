using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    [JsiiClass(nativeType: typeof(aws.Networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyOutputReference), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class NetworkfirewallFirewallPolicyFirewallPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public NetworkfirewallFirewallPolicyFirewallPolicyOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkfirewallFirewallPolicyFirewallPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkfirewallFirewallPolicyFirewallPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putStatefulEngineOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptions\"}}]")]
        public virtual void PutStatefulEngineOptions(aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetStatefulDefaultActions")]
        public virtual void ResetStatefulDefaultActions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatefulEngineOptions")]
        public virtual void ResetStatefulEngineOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatefulRuleGroupReference")]
        public virtual void ResetStatefulRuleGroupReference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatelessCustomAction")]
        public virtual void ResetStatelessCustomAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatelessRuleGroupReference")]
        public virtual void ResetStatelessRuleGroupReference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "statefulEngineOptions", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptionsOutputReference\"}")]
        public virtual aws.Networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptionsOutputReference StatefulEngineOptions
        {
            get => GetInstanceProperty<aws.Networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "statefulDefaultActionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? StatefulDefaultActionsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statefulEngineOptionsInput", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptions\"}", isOptional: true)]
        public virtual aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptions? StatefulEngineOptionsInput
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatefulEngineOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statefulRuleGroupReferenceInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReference\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReference[]? StatefulRuleGroupReferenceInput
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReference[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statelessCustomActionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatelessCustomAction\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatelessCustomAction[]? StatelessCustomActionInput
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatelessCustomAction[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statelessDefaultActionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? StatelessDefaultActionsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statelessFragmentDefaultActionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? StatelessFragmentDefaultActionsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statelessRuleGroupReferenceInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference[]? StatelessRuleGroupReferenceInput
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference[]?>();
        }

        [JsiiProperty(name: "statefulDefaultActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] StatefulDefaultActions
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "statefulRuleGroupReference", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReference\"},\"kind\":\"array\"}}")]
        public virtual aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReference[] StatefulRuleGroupReference
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatefulRuleGroupReference[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "statelessCustomAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatelessCustomAction\"},\"kind\":\"array\"}}")]
        public virtual aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatelessCustomAction[] StatelessCustomAction
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatelessCustomAction[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "statelessDefaultActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] StatelessDefaultActions
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "statelessFragmentDefaultActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] StatelessFragmentDefaultActions
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "statelessRuleGroupReference", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference\"},\"kind\":\"array\"}}")]
        public virtual aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference[] StatelessRuleGroupReference
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicyStatelessRuleGroupReference[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallFirewallPolicyFirewallPolicy\"}", isOptional: true)]
        public virtual aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicy? InternalValue
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallFirewallPolicyFirewallPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
