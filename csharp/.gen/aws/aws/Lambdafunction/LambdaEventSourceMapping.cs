using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping aws_lambda_event_source_mapping}.</summary>
    [JsiiClass(nativeType: typeof(aws.Lambdafunction.LambdaEventSourceMapping), fullyQualifiedName: "aws.lambdafunction.LambdaEventSourceMapping", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingConfig\"}}]")]
    public class LambdaEventSourceMapping : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping aws_lambda_event_source_mapping} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LambdaEventSourceMapping(Constructs.Construct scope, string id, aws.Lambdafunction.ILambdaEventSourceMappingConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaEventSourceMapping(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaEventSourceMapping(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDestinationConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingDestinationConfig\"}}]")]
        public virtual void PutDestinationConfig(aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFilterCriteria", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingFilterCriteria\"}}]")]
        public virtual void PutFilterCriteria(aws.Lambdafunction.ILambdaEventSourceMappingFilterCriteria @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lambdafunction.ILambdaEventSourceMappingFilterCriteria)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSelfManagedEventSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingSelfManagedEventSource\"}}]")]
        public virtual void PutSelfManagedEventSource(aws.Lambdafunction.ILambdaEventSourceMappingSelfManagedEventSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lambdafunction.ILambdaEventSourceMappingSelfManagedEventSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBatchSize")]
        public virtual void ResetBatchSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBisectBatchOnFunctionError")]
        public virtual void ResetBisectBatchOnFunctionError()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDestinationConfig")]
        public virtual void ResetDestinationConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventSourceArn")]
        public virtual void ResetEventSourceArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilterCriteria")]
        public virtual void ResetFilterCriteria()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFunctionResponseTypes")]
        public virtual void ResetFunctionResponseTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumBatchingWindowInSeconds")]
        public virtual void ResetMaximumBatchingWindowInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumRecordAgeInSeconds")]
        public virtual void ResetMaximumRecordAgeInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumRetryAttempts")]
        public virtual void ResetMaximumRetryAttempts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParallelizationFactor")]
        public virtual void ResetParallelizationFactor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueues")]
        public virtual void ResetQueues()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSelfManagedEventSource")]
        public virtual void ResetSelfManagedEventSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceAccessConfiguration")]
        public virtual void ResetSourceAccessConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartingPosition")]
        public virtual void ResetStartingPosition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartingPositionTimestamp")]
        public virtual void ResetStartingPositionTimestamp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTopics")]
        public virtual void ResetTopics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTumblingWindowInSeconds")]
        public virtual void ResetTumblingWindowInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Lambdafunction.LambdaEventSourceMapping))!;

        [JsiiProperty(name: "destinationConfig", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingDestinationConfigOutputReference\"}")]
        public virtual aws.Lambdafunction.LambdaEventSourceMappingDestinationConfigOutputReference DestinationConfig
        {
            get => GetInstanceProperty<aws.Lambdafunction.LambdaEventSourceMappingDestinationConfigOutputReference>()!;
        }

        [JsiiProperty(name: "filterCriteria", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingFilterCriteriaOutputReference\"}")]
        public virtual aws.Lambdafunction.LambdaEventSourceMappingFilterCriteriaOutputReference FilterCriteria
        {
            get => GetInstanceProperty<aws.Lambdafunction.LambdaEventSourceMappingFilterCriteriaOutputReference>()!;
        }

        [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastProcessingResult", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastProcessingResult
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "selfManagedEventSource", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingSelfManagedEventSourceOutputReference\"}")]
        public virtual aws.Lambdafunction.LambdaEventSourceMappingSelfManagedEventSourceOutputReference SelfManagedEventSource
        {
            get => GetInstanceProperty<aws.Lambdafunction.LambdaEventSourceMappingSelfManagedEventSourceOutputReference>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "stateTransitionReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StateTransitionReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "batchSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BatchSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bisectBatchOnFunctionErrorInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? BisectBatchOnFunctionErrorInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationConfigInput", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingDestinationConfig\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfig? DestinationConfigInput
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaEventSourceMappingDestinationConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventSourceArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventSourceArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterCriteriaInput", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingFilterCriteria\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaEventSourceMappingFilterCriteria? FilterCriteriaInput
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaEventSourceMappingFilterCriteria?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "functionNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FunctionNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "functionResponseTypesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? FunctionResponseTypesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumBatchingWindowInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumBatchingWindowInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumRecordAgeInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumRecordAgeInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumRetryAttemptsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumRetryAttemptsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parallelizationFactorInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ParallelizationFactorInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queuesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? QueuesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "selfManagedEventSourceInput", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingSelfManagedEventSource\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaEventSourceMappingSelfManagedEventSource? SelfManagedEventSourceInput
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaEventSourceMappingSelfManagedEventSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceAccessConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingSourceAccessConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaEventSourceMappingSourceAccessConfiguration[]? SourceAccessConfigurationInput
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaEventSourceMappingSourceAccessConfiguration[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startingPositionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartingPositionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startingPositionTimestampInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartingPositionTimestampInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "topicsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TopicsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tumblingWindowInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TumblingWindowInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BatchSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bisectBatchOnFunctionError", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object BisectBatchOnFunctionError
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventSourceArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventSourceArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "functionName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "functionResponseTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] FunctionResponseTypes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumBatchingWindowInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumBatchingWindowInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumRecordAgeInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumRecordAgeInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumRetryAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumRetryAttempts
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parallelizationFactor", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ParallelizationFactor
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Queues
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceAccessConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingSourceAccessConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.Lambdafunction.ILambdaEventSourceMappingSourceAccessConfiguration[] SourceAccessConfiguration
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaEventSourceMappingSourceAccessConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startingPosition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartingPosition
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startingPositionTimestamp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartingPositionTimestamp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "topics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Topics
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tumblingWindowInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TumblingWindowInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
