using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscalingplans
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan aws_autoscalingplans_scaling_plan}.</summary>
    [JsiiClass(nativeType: typeof(aws.Autoscalingplans.AutoscalingplansScalingPlan), fullyQualifiedName: "aws.autoscalingplans.AutoscalingplansScalingPlan", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanConfig\"}}]")]
    public class AutoscalingplansScalingPlan : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/autoscalingplans_scaling_plan aws_autoscalingplans_scaling_plan} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AutoscalingplansScalingPlan(Constructs.Construct scope, string id, aws.Autoscalingplans.IAutoscalingplansScalingPlanConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingplansScalingPlan(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingplansScalingPlan(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putApplicationSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanApplicationSource\"}}]")]
        public virtual void PutApplicationSource(aws.Autoscalingplans.IAutoscalingplansScalingPlanApplicationSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Autoscalingplans.IAutoscalingplansScalingPlanApplicationSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Autoscalingplans.AutoscalingplansScalingPlan))!;

        [JsiiProperty(name: "applicationSource", typeJson: "{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanApplicationSourceOutputReference\"}")]
        public virtual aws.Autoscalingplans.AutoscalingplansScalingPlanApplicationSourceOutputReference ApplicationSource
        {
            get => GetInstanceProperty<aws.Autoscalingplans.AutoscalingplansScalingPlanApplicationSourceOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scalingPlanVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScalingPlanVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationSourceInput", typeJson: "{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanApplicationSource\"}", isOptional: true)]
        public virtual aws.Autoscalingplans.IAutoscalingplansScalingPlanApplicationSource? ApplicationSourceInput
        {
            get => GetInstanceProperty<aws.Autoscalingplans.IAutoscalingplansScalingPlanApplicationSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scalingInstructionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstruction\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstruction[]? ScalingInstructionInput
        {
            get => GetInstanceProperty<aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstruction[]?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scalingInstruction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.autoscalingplans.AutoscalingplansScalingPlanScalingInstruction\"},\"kind\":\"array\"}}")]
        public virtual aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstruction[] ScalingInstruction
        {
            get => GetInstanceProperty<aws.Autoscalingplans.IAutoscalingplansScalingPlanScalingInstruction[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
