using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    [JsiiClass(nativeType: typeof(aws.Batch.BatchSchedulingPolicyFairSharePolicyOutputReference), fullyQualifiedName: "aws.batch.BatchSchedulingPolicyFairSharePolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class BatchSchedulingPolicyFairSharePolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public BatchSchedulingPolicyFairSharePolicyOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchSchedulingPolicyFairSharePolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchSchedulingPolicyFairSharePolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetComputeReservation")]
        public virtual void ResetComputeReservation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShareDecaySeconds")]
        public virtual void ResetShareDecaySeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShareDistribution")]
        public virtual void ResetShareDistribution()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "computeReservationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ComputeReservationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shareDecaySecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ShareDecaySecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shareDistributionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batch.BatchSchedulingPolicyFairSharePolicyShareDistribution\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Batch.IBatchSchedulingPolicyFairSharePolicyShareDistribution[]? ShareDistributionInput
        {
            get => GetInstanceProperty<aws.Batch.IBatchSchedulingPolicyFairSharePolicyShareDistribution[]?>();
        }

        [JsiiProperty(name: "computeReservation", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ComputeReservation
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shareDecaySeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ShareDecaySeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shareDistribution", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batch.BatchSchedulingPolicyFairSharePolicyShareDistribution\"},\"kind\":\"array\"}}")]
        public virtual aws.Batch.IBatchSchedulingPolicyFairSharePolicyShareDistribution[] ShareDistribution
        {
            get => GetInstanceProperty<aws.Batch.IBatchSchedulingPolicyFairSharePolicyShareDistribution[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.batch.BatchSchedulingPolicyFairSharePolicy\"}", isOptional: true)]
        public virtual aws.Batch.IBatchSchedulingPolicyFairSharePolicy? InternalValue
        {
            get => GetInstanceProperty<aws.Batch.IBatchSchedulingPolicyFairSharePolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
