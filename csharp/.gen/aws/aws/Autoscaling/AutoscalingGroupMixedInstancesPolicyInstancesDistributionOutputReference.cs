using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Autoscaling
{
    [JsiiClass(nativeType: typeof(aws.Autoscaling.AutoscalingGroupMixedInstancesPolicyInstancesDistributionOutputReference), fullyQualifiedName: "aws.autoscaling.AutoscalingGroupMixedInstancesPolicyInstancesDistributionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AutoscalingGroupMixedInstancesPolicyInstancesDistributionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AutoscalingGroupMixedInstancesPolicyInstancesDistributionOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroupMixedInstancesPolicyInstancesDistributionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroupMixedInstancesPolicyInstancesDistributionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetOnDemandAllocationStrategy")]
        public virtual void ResetOnDemandAllocationStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnDemandBaseCapacity")]
        public virtual void ResetOnDemandBaseCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOnDemandPercentageAboveBaseCapacity")]
        public virtual void ResetOnDemandPercentageAboveBaseCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpotAllocationStrategy")]
        public virtual void ResetSpotAllocationStrategy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpotInstancePools")]
        public virtual void ResetSpotInstancePools()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpotMaxPrice")]
        public virtual void ResetSpotMaxPrice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "onDemandAllocationStrategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OnDemandAllocationStrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onDemandBaseCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OnDemandBaseCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "onDemandPercentageAboveBaseCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OnDemandPercentageAboveBaseCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotAllocationStrategyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpotAllocationStrategyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotInstancePoolsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SpotInstancePoolsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "spotMaxPriceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SpotMaxPriceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "onDemandAllocationStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OnDemandAllocationStrategy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onDemandBaseCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OnDemandBaseCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "onDemandPercentageAboveBaseCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OnDemandPercentageAboveBaseCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "spotAllocationStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpotAllocationStrategy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "spotInstancePools", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SpotInstancePools
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "spotMaxPrice", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpotMaxPrice
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.autoscaling.AutoscalingGroupMixedInstancesPolicyInstancesDistribution\"}", isOptional: true)]
        public virtual aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyInstancesDistribution? InternalValue
        {
            get => GetInstanceProperty<aws.Autoscaling.IAutoscalingGroupMixedInstancesPolicyInstancesDistribution?>();
            set => SetInstanceProperty(value);
        }
    }
}
