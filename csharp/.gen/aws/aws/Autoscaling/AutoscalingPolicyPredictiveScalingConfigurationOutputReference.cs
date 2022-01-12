using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiClass(nativeType: typeof(aws.Autoscaling.AutoscalingPolicyPredictiveScalingConfigurationOutputReference), fullyQualifiedName: "aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AutoscalingPolicyPredictiveScalingConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AutoscalingPolicyPredictiveScalingConfigurationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingPolicyPredictiveScalingConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingPolicyPredictiveScalingConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMetricSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecification\"}}]")]
        public virtual void PutMetricSpecification(aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMaxCapacityBreachBehavior")]
        public virtual void ResetMaxCapacityBreachBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxCapacityBuffer")]
        public virtual void ResetMaxCapacityBuffer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMode")]
        public virtual void ResetMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchedulingBufferTime")]
        public virtual void ResetSchedulingBufferTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "metricSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationOutputReference\"}")]
        public virtual aws.Autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationOutputReference MetricSpecification
        {
            get => GetInstanceProperty<aws.Autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxCapacityBreachBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaxCapacityBreachBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxCapacityBufferInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaxCapacityBufferInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricSpecificationInput", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecification\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecification? MetricSpecificationInput
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schedulingBufferTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SchedulingBufferTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "maxCapacityBreachBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxCapacityBreachBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxCapacityBuffer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxCapacityBuffer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schedulingBufferTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SchedulingBufferTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfiguration\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
