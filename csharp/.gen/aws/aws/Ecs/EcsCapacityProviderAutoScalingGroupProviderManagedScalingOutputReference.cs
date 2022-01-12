using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiClass(nativeType: typeof(aws.Ecs.EcsCapacityProviderAutoScalingGroupProviderManagedScalingOutputReference), fullyQualifiedName: "aws.ecs.EcsCapacityProviderAutoScalingGroupProviderManagedScalingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class EcsCapacityProviderAutoScalingGroupProviderManagedScalingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public EcsCapacityProviderAutoScalingGroupProviderManagedScalingOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsCapacityProviderAutoScalingGroupProviderManagedScalingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsCapacityProviderAutoScalingGroupProviderManagedScalingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetInstanceWarmupPeriod")]
        public virtual void ResetInstanceWarmupPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumScalingStepSize")]
        public virtual void ResetMaximumScalingStepSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinimumScalingStepSize")]
        public virtual void ResetMinimumScalingStepSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatus")]
        public virtual void ResetStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetCapacity")]
        public virtual void ResetTargetCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceWarmupPeriodInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InstanceWarmupPeriodInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumScalingStepSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumScalingStepSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumScalingStepSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinimumScalingStepSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "instanceWarmupPeriod", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceWarmupPeriod
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumScalingStepSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumScalingStepSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minimumScalingStepSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinimumScalingStepSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecs.EcsCapacityProviderAutoScalingGroupProviderManagedScaling\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling? InternalValue
        {
            get => GetInstanceProperty<aws.Ecs.IEcsCapacityProviderAutoScalingGroupProviderManagedScaling?>();
            set => SetInstanceProperty(value);
        }
    }
}
