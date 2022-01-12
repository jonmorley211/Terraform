using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appautoscaling
{
    [JsiiClass(nativeType: typeof(aws.Appautoscaling.AppautoscalingScheduledActionScalableTargetActionOutputReference), fullyQualifiedName: "aws.appautoscaling.AppautoscalingScheduledActionScalableTargetActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppautoscalingScheduledActionScalableTargetActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppautoscalingScheduledActionScalableTargetActionOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppautoscalingScheduledActionScalableTargetActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppautoscalingScheduledActionScalableTargetActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaxCapacity")]
        public virtual void ResetMaxCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinCapacity")]
        public virtual void ResetMinCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxCapacityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaxCapacityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minCapacityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MinCapacityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxCapacity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MinCapacity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appautoscaling.AppautoscalingScheduledActionScalableTargetAction\"}", isOptional: true)]
        public virtual aws.Appautoscaling.IAppautoscalingScheduledActionScalableTargetAction? InternalValue
        {
            get => GetInstanceProperty<aws.Appautoscaling.IAppautoscalingScheduledActionScalableTargetAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
