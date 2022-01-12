using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiClass(nativeType: typeof(aws.Autoscaling.AutoscalingGroupInstanceRefreshPreferencesOutputReference), fullyQualifiedName: "aws.autoscaling.AutoscalingGroupInstanceRefreshPreferencesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AutoscalingGroupInstanceRefreshPreferencesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AutoscalingGroupInstanceRefreshPreferencesOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroupInstanceRefreshPreferencesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroupInstanceRefreshPreferencesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCheckpointDelay")]
        public virtual void ResetCheckpointDelay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCheckpointPercentages")]
        public virtual void ResetCheckpointPercentages()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceWarmup")]
        public virtual void ResetInstanceWarmup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinHealthyPercentage")]
        public virtual void ResetMinHealthyPercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "checkpointDelayInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CheckpointDelayInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "checkpointPercentagesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual double[]? CheckpointPercentagesInput
        {
            get => GetInstanceProperty<double[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceWarmupInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceWarmupInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minHealthyPercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinHealthyPercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "checkpointDelay", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CheckpointDelay
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "checkpointPercentages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] CheckpointPercentages
        {
            get => GetInstanceProperty<double[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceWarmup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceWarmup
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minHealthyPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinHealthyPercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupInstanceRefreshPreferences\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingGroupInstanceRefreshPreferences? InternalValue
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingGroupInstanceRefreshPreferences?>();
            set => SetInstanceProperty(value);
        }
    }
}
