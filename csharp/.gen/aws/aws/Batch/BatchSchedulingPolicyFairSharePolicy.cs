using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    [JsiiByValue(fqn: "aws.batch.BatchSchedulingPolicyFairSharePolicy")]
    public class BatchSchedulingPolicyFairSharePolicy : aws.Batch.IBatchSchedulingPolicyFairSharePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_scheduling_policy#compute_reservation BatchSchedulingPolicy#compute_reservation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "computeReservation", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ComputeReservation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_scheduling_policy#share_decay_seconds BatchSchedulingPolicy#share_decay_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shareDecaySeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ShareDecaySeconds
        {
            get;
            set;
        }

        /// <summary>share_distribution block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_scheduling_policy#share_distribution BatchSchedulingPolicy#share_distribution}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shareDistribution", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batch.BatchSchedulingPolicyFairSharePolicyShareDistribution\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Batch.IBatchSchedulingPolicyFairSharePolicyShareDistribution[]? ShareDistribution
        {
            get;
            set;
        }
    }
}
