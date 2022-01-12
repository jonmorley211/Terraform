using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiClass(nativeType: typeof(aws.Autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationOutputReference), fullyQualifiedName: "aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPredefinedLoadMetricSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification\"}}]")]
        public virtual void PutPredefinedLoadMetricSpecification(aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPredefinedMetricPairSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification\"}}]")]
        public virtual void PutPredefinedMetricPairSpecification(aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPredefinedScalingMetricSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification\"}}]")]
        public virtual void PutPredefinedScalingMetricSpecification(aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPredefinedLoadMetricSpecification")]
        public virtual void ResetPredefinedLoadMetricSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPredefinedMetricPairSpecification")]
        public virtual void ResetPredefinedMetricPairSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPredefinedScalingMetricSpecification")]
        public virtual void ResetPredefinedScalingMetricSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "predefinedLoadMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecificationOutputReference\"}")]
        public virtual aws.Autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecificationOutputReference PredefinedLoadMetricSpecification
        {
            get => GetInstanceProperty<aws.Autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecificationOutputReference>()!;
        }

        [JsiiProperty(name: "predefinedMetricPairSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecificationOutputReference\"}")]
        public virtual aws.Autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecificationOutputReference PredefinedMetricPairSpecification
        {
            get => GetInstanceProperty<aws.Autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecificationOutputReference>()!;
        }

        [JsiiProperty(name: "predefinedScalingMetricSpecification", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecificationOutputReference\"}")]
        public virtual aws.Autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecificationOutputReference PredefinedScalingMetricSpecification
        {
            get => GetInstanceProperty<aws.Autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecificationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "predefinedLoadMetricSpecificationInput", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecificationInput
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "predefinedMetricPairSpecificationInput", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification? PredefinedMetricPairSpecificationInput
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "predefinedScalingMetricSpecificationInput", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecificationInput
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetValueInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetValueInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "targetValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetValue
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingPolicyPredictiveScalingConfigurationMetricSpecification\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecification? InternalValue
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingPolicyPredictiveScalingConfigurationMetricSpecification?>();
            set => SetInstanceProperty(value);
        }
    }
}
