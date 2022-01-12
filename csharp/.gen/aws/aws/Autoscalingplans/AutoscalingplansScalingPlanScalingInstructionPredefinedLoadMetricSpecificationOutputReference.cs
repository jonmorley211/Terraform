using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscalingplans
{
    [JsiiClass(nativeType: typeof(aws.Autoscalingplans.AutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecificationOutputReference), fullyQualifiedName: "aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecificationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecificationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecificationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecificationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecificationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetResourceLabel")]
        public virtual void ResetResourceLabel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "predefinedLoadMetricTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PredefinedLoadMetricTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceLabelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceLabelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "predefinedLoadMetricType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PredefinedLoadMetricType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceLabel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecification\"}", isOptional: true)]
        public virtual aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecification? InternalValue
        {
            get => GetInstanceProperty<aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstructionPredefinedLoadMetricSpecification?>();
            set => SetInstanceProperty(value);
        }
    }
}
