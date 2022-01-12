using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Batch
{
    [JsiiClass(nativeType: typeof(aws.Batch.BatchJobDefinitionRetryStrategyOutputReference), fullyQualifiedName: "aws.batch.BatchJobDefinitionRetryStrategyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class BatchJobDefinitionRetryStrategyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public BatchJobDefinitionRetryStrategyOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchJobDefinitionRetryStrategyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BatchJobDefinitionRetryStrategyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAttempts")]
        public virtual void ResetAttempts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEvaluateOnExit")]
        public virtual void ResetEvaluateOnExit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "attemptsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AttemptsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "evaluateOnExitInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batch.BatchJobDefinitionRetryStrategyEvaluateOnExit\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Batch.IBatchJobDefinitionRetryStrategyEvaluateOnExit[]? EvaluateOnExitInput
        {
            get => GetInstanceProperty<aws.Batch.IBatchJobDefinitionRetryStrategyEvaluateOnExit[]?>();
        }

        [JsiiProperty(name: "attempts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Attempts
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "evaluateOnExit", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batch.BatchJobDefinitionRetryStrategyEvaluateOnExit\"},\"kind\":\"array\"}}")]
        public virtual aws.Batch.IBatchJobDefinitionRetryStrategyEvaluateOnExit[] EvaluateOnExit
        {
            get => GetInstanceProperty<aws.Batch.IBatchJobDefinitionRetryStrategyEvaluateOnExit[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.batch.BatchJobDefinitionRetryStrategy\"}", isOptional: true)]
        public virtual aws.Batch.IBatchJobDefinitionRetryStrategy? InternalValue
        {
            get => GetInstanceProperty<aws.Batch.IBatchJobDefinitionRetryStrategy?>();
            set => SetInstanceProperty(value);
        }
    }
}
