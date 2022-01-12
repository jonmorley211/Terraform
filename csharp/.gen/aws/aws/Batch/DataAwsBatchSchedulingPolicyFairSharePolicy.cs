using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    [JsiiClass(nativeType: typeof(aws.Batch.DataAwsBatchSchedulingPolicyFairSharePolicy), fullyQualifiedName: "aws.batch.DataAwsBatchSchedulingPolicyFairSharePolicy", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsBatchSchedulingPolicyFairSharePolicy : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsBatchSchedulingPolicyFairSharePolicy(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsBatchSchedulingPolicyFairSharePolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsBatchSchedulingPolicyFairSharePolicy(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "computeReservation", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ComputeReservation
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "shareDecaySeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ShareDecaySeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "shareDistribution", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object ShareDistribution
        {
            get => GetInstanceProperty<object>()!;
        }
    }
}
