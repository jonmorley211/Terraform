using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiClass(nativeType: typeof(aws.Autoscaling.AutoscalingGroupInstanceRefreshOutputReference), fullyQualifiedName: "aws.autoscaling.AutoscalingGroupInstanceRefreshOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AutoscalingGroupInstanceRefreshOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AutoscalingGroupInstanceRefreshOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroupInstanceRefreshOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroupInstanceRefreshOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPreferences", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscaling.AutoscalingGroupInstanceRefreshPreferences\"}}]")]
        public virtual void PutPreferences(aws.Autoscaling.IAutoscalingGroupInstanceRefreshPreferences @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Autoscaling.IAutoscalingGroupInstanceRefreshPreferences)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPreferences")]
        public virtual void ResetPreferences()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTriggers")]
        public virtual void ResetTriggers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "preferences", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupInstanceRefreshPreferencesOutputReference\"}")]
        public virtual aws.Autoscaling.AutoscalingGroupInstanceRefreshPreferencesOutputReference Preferences
        {
            get => GetInstanceProperty<aws.Autoscaling.AutoscalingGroupInstanceRefreshPreferencesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "preferencesInput", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupInstanceRefreshPreferences\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingGroupInstanceRefreshPreferences? PreferencesInput
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingGroupInstanceRefreshPreferences?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "strategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "triggersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TriggersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Strategy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "triggers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Triggers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupInstanceRefresh\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingGroupInstanceRefresh? InternalValue
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingGroupInstanceRefresh?>();
            set => SetInstanceProperty(value);
        }
    }
}
