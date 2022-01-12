using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.batch.BatchSchedulingPolicyFairSharePolicyShareDistribution")]
    public class BatchSchedulingPolicyFairSharePolicyShareDistribution : aws.Batch.IBatchSchedulingPolicyFairSharePolicyShareDistribution
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_scheduling_policy#share_identifier BatchSchedulingPolicy#share_identifier}.</summary>
        [JsiiProperty(name: "shareIdentifier", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ShareIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_scheduling_policy#weight_factor BatchSchedulingPolicy#weight_factor}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weightFactor", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? WeightFactor
        {
            get;
            set;
        }
    }
}
