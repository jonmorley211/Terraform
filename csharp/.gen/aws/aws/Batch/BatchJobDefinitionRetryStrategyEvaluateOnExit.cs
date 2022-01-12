using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.batch.BatchJobDefinitionRetryStrategyEvaluateOnExit")]
    public class BatchJobDefinitionRetryStrategyEvaluateOnExit : aws.Batch.IBatchJobDefinitionRetryStrategyEvaluateOnExit
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#action BatchJobDefinition#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#on_exit_code BatchJobDefinition#on_exit_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onExitCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OnExitCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#on_reason BatchJobDefinition#on_reason}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onReason", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OnReason
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#on_status_reason BatchJobDefinition#on_status_reason}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onStatusReason", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OnStatusReason
        {
            get;
            set;
        }
    }
}
