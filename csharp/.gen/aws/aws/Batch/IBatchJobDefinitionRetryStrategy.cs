using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    [JsiiInterface(nativeType: typeof(IBatchJobDefinitionRetryStrategy), fullyQualifiedName: "aws.batch.BatchJobDefinitionRetryStrategy")]
    public interface IBatchJobDefinitionRetryStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#attempts BatchJobDefinition#attempts}.</summary>
        [JsiiProperty(name: "attempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Attempts
        {
            get
            {
                return null;
            }
        }

        /// <summary>evaluate_on_exit block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#evaluate_on_exit BatchJobDefinition#evaluate_on_exit}
        /// </remarks>
        [JsiiProperty(name: "evaluateOnExit", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batch.BatchJobDefinitionRetryStrategyEvaluateOnExit\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Batch.IBatchJobDefinitionRetryStrategyEvaluateOnExit[]? EvaluateOnExit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchJobDefinitionRetryStrategy), fullyQualifiedName: "aws.batch.BatchJobDefinitionRetryStrategy")]
        internal sealed class _Proxy : DeputyBase, aws.Batch.IBatchJobDefinitionRetryStrategy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#attempts BatchJobDefinition#attempts}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Attempts
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>evaluate_on_exit block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/batch_job_definition#evaluate_on_exit BatchJobDefinition#evaluate_on_exit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "evaluateOnExit", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batch.BatchJobDefinitionRetryStrategyEvaluateOnExit\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Batch.IBatchJobDefinitionRetryStrategyEvaluateOnExit[]? EvaluateOnExit
            {
                get => GetInstanceProperty<aws.Batch.IBatchJobDefinitionRetryStrategyEvaluateOnExit[]?>();
            }
        }
    }
}
