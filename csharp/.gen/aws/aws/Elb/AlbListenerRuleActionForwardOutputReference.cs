using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiClass(nativeType: typeof(aws.Elb.AlbListenerRuleActionForwardOutputReference), fullyQualifiedName: "aws.elb.AlbListenerRuleActionForwardOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AlbListenerRuleActionForwardOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AlbListenerRuleActionForwardOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbListenerRuleActionForwardOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbListenerRuleActionForwardOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putStickiness", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elb.AlbListenerRuleActionForwardStickiness\"}}]")]
        public virtual void PutStickiness(aws.Elb.IAlbListenerRuleActionForwardStickiness @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elb.IAlbListenerRuleActionForwardStickiness)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetStickiness")]
        public virtual void ResetStickiness()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionForwardStickinessOutputReference\"}")]
        public virtual aws.Elb.AlbListenerRuleActionForwardStickinessOutputReference Stickiness
        {
            get => GetInstanceProperty<aws.Elb.AlbListenerRuleActionForwardStickinessOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "stickinessInput", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionForwardStickiness\"}", isOptional: true)]
        public virtual aws.Elb.IAlbListenerRuleActionForwardStickiness? StickinessInput
        {
            get => GetInstanceProperty<aws.Elb.IAlbListenerRuleActionForwardStickiness?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetGroupInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.AlbListenerRuleActionForwardTargetGroup\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Elb.IAlbListenerRuleActionForwardTargetGroup[]? TargetGroupInput
        {
            get => GetInstanceProperty<aws.Elb.IAlbListenerRuleActionForwardTargetGroup[]?>();
        }

        [JsiiProperty(name: "targetGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.AlbListenerRuleActionForwardTargetGroup\"},\"kind\":\"array\"}}")]
        public virtual aws.Elb.IAlbListenerRuleActionForwardTargetGroup[] TargetGroup
        {
            get => GetInstanceProperty<aws.Elb.IAlbListenerRuleActionForwardTargetGroup[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleActionForward\"}", isOptional: true)]
        public virtual aws.Elb.IAlbListenerRuleActionForward? InternalValue
        {
            get => GetInstanceProperty<aws.Elb.IAlbListenerRuleActionForward?>();
            set => SetInstanceProperty(value);
        }
    }
}
