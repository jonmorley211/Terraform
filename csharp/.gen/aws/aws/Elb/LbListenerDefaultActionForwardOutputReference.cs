using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiClass(nativeType: typeof(aws.Elb.LbListenerDefaultActionForwardOutputReference), fullyQualifiedName: "aws.elb.LbListenerDefaultActionForwardOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LbListenerDefaultActionForwardOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public LbListenerDefaultActionForwardOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbListenerDefaultActionForwardOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbListenerDefaultActionForwardOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putStickiness", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elb.LbListenerDefaultActionForwardStickiness\"}}]")]
        public virtual void PutStickiness(aws.Elb.ILbListenerDefaultActionForwardStickiness @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elb.ILbListenerDefaultActionForwardStickiness)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetStickiness")]
        public virtual void ResetStickiness()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.elb.LbListenerDefaultActionForwardStickinessOutputReference\"}")]
        public virtual aws.Elb.LbListenerDefaultActionForwardStickinessOutputReference Stickiness
        {
            get => GetInstanceProperty<aws.Elb.LbListenerDefaultActionForwardStickinessOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "stickinessInput", typeJson: "{\"fqn\":\"aws.elb.LbListenerDefaultActionForwardStickiness\"}", isOptional: true)]
        public virtual aws.Elb.ILbListenerDefaultActionForwardStickiness? StickinessInput
        {
            get => GetInstanceProperty<aws.Elb.ILbListenerDefaultActionForwardStickiness?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetGroupInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.LbListenerDefaultActionForwardTargetGroup\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Elb.ILbListenerDefaultActionForwardTargetGroup[]? TargetGroupInput
        {
            get => GetInstanceProperty<aws.Elb.ILbListenerDefaultActionForwardTargetGroup[]?>();
        }

        [JsiiProperty(name: "targetGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.LbListenerDefaultActionForwardTargetGroup\"},\"kind\":\"array\"}}")]
        public virtual aws.Elb.ILbListenerDefaultActionForwardTargetGroup[] TargetGroup
        {
            get => GetInstanceProperty<aws.Elb.ILbListenerDefaultActionForwardTargetGroup[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elb.LbListenerDefaultActionForward\"}", isOptional: true)]
        public virtual aws.Elb.ILbListenerDefaultActionForward? InternalValue
        {
            get => GetInstanceProperty<aws.Elb.ILbListenerDefaultActionForward?>();
            set => SetInstanceProperty(value);
        }
    }
}
