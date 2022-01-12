using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiClass(nativeType: typeof(aws.Elb.LbListenerRuleActionForwardOutputReference), fullyQualifiedName: "aws.elb.LbListenerRuleActionForwardOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LbListenerRuleActionForwardOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public LbListenerRuleActionForwardOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbListenerRuleActionForwardOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbListenerRuleActionForwardOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putStickiness", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elb.LbListenerRuleActionForwardStickiness\"}}]")]
        public virtual void PutStickiness(aws.Elb.ILbListenerRuleActionForwardStickiness @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elb.ILbListenerRuleActionForwardStickiness)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetStickiness")]
        public virtual void ResetStickiness()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleActionForwardStickinessOutputReference\"}")]
        public virtual aws.Elb.LbListenerRuleActionForwardStickinessOutputReference Stickiness
        {
            get => GetInstanceProperty<aws.Elb.LbListenerRuleActionForwardStickinessOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "stickinessInput", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleActionForwardStickiness\"}", isOptional: true)]
        public virtual aws.Elb.ILbListenerRuleActionForwardStickiness? StickinessInput
        {
            get => GetInstanceProperty<aws.Elb.ILbListenerRuleActionForwardStickiness?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetGroupInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.LbListenerRuleActionForwardTargetGroup\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Elb.ILbListenerRuleActionForwardTargetGroup[]? TargetGroupInput
        {
            get => GetInstanceProperty<aws.Elb.ILbListenerRuleActionForwardTargetGroup[]?>();
        }

        [JsiiProperty(name: "targetGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.LbListenerRuleActionForwardTargetGroup\"},\"kind\":\"array\"}}")]
        public virtual aws.Elb.ILbListenerRuleActionForwardTargetGroup[] TargetGroup
        {
            get => GetInstanceProperty<aws.Elb.ILbListenerRuleActionForwardTargetGroup[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elb.LbListenerRuleActionForward\"}", isOptional: true)]
        public virtual aws.Elb.ILbListenerRuleActionForward? InternalValue
        {
            get => GetInstanceProperty<aws.Elb.ILbListenerRuleActionForward?>();
            set => SetInstanceProperty(value);
        }
    }
}
