using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiClass(nativeType: typeof(aws.Elb.AlbListenerDefaultActionForwardOutputReference), fullyQualifiedName: "aws.elb.AlbListenerDefaultActionForwardOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AlbListenerDefaultActionForwardOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AlbListenerDefaultActionForwardOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbListenerDefaultActionForwardOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbListenerDefaultActionForwardOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putStickiness", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elb.AlbListenerDefaultActionForwardStickiness\"}}]")]
        public virtual void PutStickiness(aws.Elb.IAlbListenerDefaultActionForwardStickiness @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elb.IAlbListenerDefaultActionForwardStickiness)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetStickiness")]
        public virtual void ResetStickiness()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.elb.AlbListenerDefaultActionForwardStickinessOutputReference\"}")]
        public virtual aws.Elb.AlbListenerDefaultActionForwardStickinessOutputReference Stickiness
        {
            get => GetInstanceProperty<aws.Elb.AlbListenerDefaultActionForwardStickinessOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "stickinessInput", typeJson: "{\"fqn\":\"aws.elb.AlbListenerDefaultActionForwardStickiness\"}", isOptional: true)]
        public virtual aws.Elb.IAlbListenerDefaultActionForwardStickiness? StickinessInput
        {
            get => GetInstanceProperty<aws.Elb.IAlbListenerDefaultActionForwardStickiness?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetGroupInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.AlbListenerDefaultActionForwardTargetGroup\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Elb.IAlbListenerDefaultActionForwardTargetGroup[]? TargetGroupInput
        {
            get => GetInstanceProperty<aws.Elb.IAlbListenerDefaultActionForwardTargetGroup[]?>();
        }

        [JsiiProperty(name: "targetGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.AlbListenerDefaultActionForwardTargetGroup\"},\"kind\":\"array\"}}")]
        public virtual aws.Elb.IAlbListenerDefaultActionForwardTargetGroup[] TargetGroup
        {
            get => GetInstanceProperty<aws.Elb.IAlbListenerDefaultActionForwardTargetGroup[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elb.AlbListenerDefaultActionForward\"}", isOptional: true)]
        public virtual aws.Elb.IAlbListenerDefaultActionForward? InternalValue
        {
            get => GetInstanceProperty<aws.Elb.IAlbListenerDefaultActionForward?>();
            set => SetInstanceProperty(value);
        }
    }
}
