using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    [JsiiByValue(fqn: "aws.batch.BatchJobDefinitionRetryStrategy")]
    public class BatchJobDefinitionRetryStrategy : aws.Batch.IBatchJobDefinitionRetryStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#attempts BatchJobDefinition#attempts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Attempts
        {
            get;
            set;
        }

        /// <summary>evaluate_on_exit block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#evaluate_on_exit BatchJobDefinition#evaluate_on_exit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "evaluateOnExit", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batch.BatchJobDefinitionRetryStrategyEvaluateOnExit\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Batch.IBatchJobDefinitionRetryStrategyEvaluateOnExit[]? EvaluateOnExit
        {
            get;
            set;
        }
    }
}
