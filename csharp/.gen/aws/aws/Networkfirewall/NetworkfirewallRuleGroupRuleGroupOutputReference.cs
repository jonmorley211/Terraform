using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Networkfirewall
{
    [JsiiClass(nativeType: typeof(aws.Networkfirewall.NetworkfirewallRuleGroupRuleGroupOutputReference), fullyQualifiedName: "aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class NetworkfirewallRuleGroupRuleGroupOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public NetworkfirewallRuleGroupRuleGroupOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkfirewallRuleGroupRuleGroupOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetworkfirewallRuleGroupRuleGroupOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRulesSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSource\"}}]")]
        public virtual void PutRulesSource(aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRuleVariables", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariables\"}}]")]
        public virtual void PutRuleVariables(aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariables @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariables)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStatefulRuleOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupStatefulRuleOptions\"}}]")]
        public virtual void PutStatefulRuleOptions(aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupStatefulRuleOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupStatefulRuleOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRuleVariables")]
        public virtual void ResetRuleVariables()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatefulRuleOptions")]
        public virtual void ResetStatefulRuleOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "rulesSource", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceOutputReference\"}")]
        public virtual aws.Networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceOutputReference RulesSource
        {
            get => GetInstanceProperty<aws.Networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSourceOutputReference>()!;
        }

        [JsiiProperty(name: "ruleVariables", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariablesOutputReference\"}")]
        public virtual aws.Networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariablesOutputReference RuleVariables
        {
            get => GetInstanceProperty<aws.Networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariablesOutputReference>()!;
        }

        [JsiiProperty(name: "statefulRuleOptions", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupStatefulRuleOptionsOutputReference\"}")]
        public virtual aws.Networkfirewall.NetworkfirewallRuleGroupRuleGroupStatefulRuleOptionsOutputReference StatefulRuleOptions
        {
            get => GetInstanceProperty<aws.Networkfirewall.NetworkfirewallRuleGroupRuleGroupStatefulRuleOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rulesSourceInput", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRulesSource\"}", isOptional: true)]
        public virtual aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSource? RulesSourceInput
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRulesSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleVariablesInput", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupRuleVariables\"}", isOptional: true)]
        public virtual aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariables? RuleVariablesInput
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupRuleVariables?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statefulRuleOptionsInput", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroupStatefulRuleOptions\"}", isOptional: true)]
        public virtual aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupStatefulRuleOptions? StatefulRuleOptionsInput
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroupStatefulRuleOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.networkfirewall.NetworkfirewallRuleGroupRuleGroup\"}", isOptional: true)]
        public virtual aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroup? InternalValue
        {
            get => GetInstanceProperty<aws.Networkfirewall.INetworkfirewallRuleGroupRuleGroup?>();
            set => SetInstanceProperty(value);
        }
    }
}
