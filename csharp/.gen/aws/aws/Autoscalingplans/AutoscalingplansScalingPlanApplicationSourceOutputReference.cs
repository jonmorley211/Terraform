using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscalingplans
{
    [JsiiClass(nativeType: typeof(aws.Autoscalingplans.AutoscalingplansScalingPlanApplicationSourceOutputReference), fullyQualifiedName: "aws.autoscalingplans.AutoscalingplansScalingPlanApplicationSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AutoscalingplansScalingPlanApplicationSourceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AutoscalingplansScalingPlanApplicationSourceOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingplansScalingPlanApplicationSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingplansScalingPlanApplicationSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCloudformationStackArn")]
        public virtual void ResetCloudformationStackArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagFilter")]
        public virtual void ResetTagFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudformationStackArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CloudformationStackArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagFilterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanApplicationSourceTagFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Autoscalingplans.IAutoscalingplansScalingPlanApplicationSourceTagFilter[]? TagFilterInput
        {
            get => GetInstanceProperty<aws.Autoscalingplans.IAutoscalingplansScalingPlanApplicationSourceTagFilter[]?>();
        }

        [JsiiProperty(name: "cloudformationStackArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudformationStackArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagFilter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanApplicationSourceTagFilter\"},\"kind\":\"array\"}}")]
        public virtual aws.Autoscalingplans.IAutoscalingplansScalingPlanApplicationSourceTagFilter[] TagFilter
        {
            get => GetInstanceProperty<aws.Autoscalingplans.IAutoscalingplansScalingPlanApplicationSourceTagFilter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanApplicationSource\"}", isOptional: true)]
        public virtual aws.Autoscalingplans.IAutoscalingplansScalingPlanApplicationSource? InternalValue
        {
            get => GetInstanceProperty<aws.Autoscalingplans.IAutoscalingplansScalingPlanApplicationSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
