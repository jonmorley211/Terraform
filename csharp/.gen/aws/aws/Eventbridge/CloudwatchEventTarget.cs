using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target aws_cloudwatch_event_target}.</summary>
    [JsiiClass(nativeType: typeof(aws.Eventbridge.CloudwatchEventTarget), fullyQualifiedName: "aws.eventbridge.CloudwatchEventTarget", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetConfig\"}}]")]
    public class CloudwatchEventTarget : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target aws_cloudwatch_event_target} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudwatchEventTarget(Constructs.Construct scope, string id, aws.Eventbridge.ICloudwatchEventTargetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventTarget(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventTarget(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBatchTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetBatchTarget\"}}]")]
        public virtual void PutBatchTarget(aws.Eventbridge.ICloudwatchEventTargetBatchTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eventbridge.ICloudwatchEventTargetBatchTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeadLetterConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetDeadLetterConfig\"}}]")]
        public virtual void PutDeadLetterConfig(aws.Eventbridge.ICloudwatchEventTargetDeadLetterConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eventbridge.ICloudwatchEventTargetDeadLetterConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEcsTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetEcsTarget\"}}]")]
        public virtual void PutEcsTarget(aws.Eventbridge.ICloudwatchEventTargetEcsTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eventbridge.ICloudwatchEventTargetEcsTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetHttpTarget\"}}]")]
        public virtual void PutHttpTarget(aws.Eventbridge.ICloudwatchEventTargetHttpTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eventbridge.ICloudwatchEventTargetHttpTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInputTransformer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetInputTransformer\"}}]")]
        public virtual void PutInputTransformer(aws.Eventbridge.ICloudwatchEventTargetInputTransformer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eventbridge.ICloudwatchEventTargetInputTransformer)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKinesisTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetKinesisTarget\"}}]")]
        public virtual void PutKinesisTarget(aws.Eventbridge.ICloudwatchEventTargetKinesisTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eventbridge.ICloudwatchEventTargetKinesisTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedshiftTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetRedshiftTarget\"}}]")]
        public virtual void PutRedshiftTarget(aws.Eventbridge.ICloudwatchEventTargetRedshiftTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eventbridge.ICloudwatchEventTargetRedshiftTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRetryPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetRetryPolicy\"}}]")]
        public virtual void PutRetryPolicy(aws.Eventbridge.ICloudwatchEventTargetRetryPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eventbridge.ICloudwatchEventTargetRetryPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSqsTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetSqsTarget\"}}]")]
        public virtual void PutSqsTarget(aws.Eventbridge.ICloudwatchEventTargetSqsTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Eventbridge.ICloudwatchEventTargetSqsTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBatchTarget")]
        public virtual void ResetBatchTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeadLetterConfig")]
        public virtual void ResetDeadLetterConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEcsTarget")]
        public virtual void ResetEcsTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventBusName")]
        public virtual void ResetEventBusName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpTarget")]
        public virtual void ResetHttpTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInput")]
        public virtual void ResetInput()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputPath")]
        public virtual void ResetInputPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputTransformer")]
        public virtual void ResetInputTransformer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesisTarget")]
        public virtual void ResetKinesisTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedshiftTarget")]
        public virtual void ResetRedshiftTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetryPolicy")]
        public virtual void ResetRetryPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoleArn")]
        public virtual void ResetRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRunCommandTargets")]
        public virtual void ResetRunCommandTargets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqsTarget")]
        public virtual void ResetSqsTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetId")]
        public virtual void ResetTargetId()
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
        = GetStaticProperty<string>(typeof(aws.Eventbridge.CloudwatchEventTarget))!;

        [JsiiProperty(name: "batchTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetBatchTargetOutputReference\"}")]
        public virtual aws.Eventbridge.CloudwatchEventTargetBatchTargetOutputReference BatchTarget
        {
            get => GetInstanceProperty<aws.Eventbridge.CloudwatchEventTargetBatchTargetOutputReference>()!;
        }

        [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetDeadLetterConfigOutputReference\"}")]
        public virtual aws.Eventbridge.CloudwatchEventTargetDeadLetterConfigOutputReference DeadLetterConfig
        {
            get => GetInstanceProperty<aws.Eventbridge.CloudwatchEventTargetDeadLetterConfigOutputReference>()!;
        }

        [JsiiProperty(name: "ecsTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetEcsTargetOutputReference\"}")]
        public virtual aws.Eventbridge.CloudwatchEventTargetEcsTargetOutputReference EcsTarget
        {
            get => GetInstanceProperty<aws.Eventbridge.CloudwatchEventTargetEcsTargetOutputReference>()!;
        }

        [JsiiProperty(name: "httpTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetHttpTargetOutputReference\"}")]
        public virtual aws.Eventbridge.CloudwatchEventTargetHttpTargetOutputReference HttpTarget
        {
            get => GetInstanceProperty<aws.Eventbridge.CloudwatchEventTargetHttpTargetOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inputTransformer", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetInputTransformerOutputReference\"}")]
        public virtual aws.Eventbridge.CloudwatchEventTargetInputTransformerOutputReference InputTransformer
        {
            get => GetInstanceProperty<aws.Eventbridge.CloudwatchEventTargetInputTransformerOutputReference>()!;
        }

        [JsiiProperty(name: "kinesisTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetKinesisTargetOutputReference\"}")]
        public virtual aws.Eventbridge.CloudwatchEventTargetKinesisTargetOutputReference KinesisTarget
        {
            get => GetInstanceProperty<aws.Eventbridge.CloudwatchEventTargetKinesisTargetOutputReference>()!;
        }

        [JsiiProperty(name: "redshiftTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetRedshiftTargetOutputReference\"}")]
        public virtual aws.Eventbridge.CloudwatchEventTargetRedshiftTargetOutputReference RedshiftTarget
        {
            get => GetInstanceProperty<aws.Eventbridge.CloudwatchEventTargetRedshiftTargetOutputReference>()!;
        }

        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetRetryPolicyOutputReference\"}")]
        public virtual aws.Eventbridge.CloudwatchEventTargetRetryPolicyOutputReference RetryPolicy
        {
            get => GetInstanceProperty<aws.Eventbridge.CloudwatchEventTargetRetryPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "sqsTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetSqsTargetOutputReference\"}")]
        public virtual aws.Eventbridge.CloudwatchEventTargetSqsTargetOutputReference SqsTarget
        {
            get => GetInstanceProperty<aws.Eventbridge.CloudwatchEventTargetSqsTargetOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "arnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "batchTargetInput", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetBatchTarget\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventTargetBatchTarget? BatchTargetInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetBatchTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deadLetterConfigInput", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetDeadLetterConfig\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventTargetDeadLetterConfig? DeadLetterConfigInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetDeadLetterConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ecsTargetInput", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetEcsTarget\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventTargetEcsTarget? EcsTargetInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetEcsTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventBusNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventBusNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpTargetInput", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetHttpTarget\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventTargetHttpTarget? HttpTargetInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetHttpTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputTransformerInput", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetInputTransformer\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventTargetInputTransformer? InputTransformerInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetInputTransformer?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisTargetInput", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetKinesisTarget\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventTargetKinesisTarget? KinesisTargetInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetKinesisTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redshiftTargetInput", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetRedshiftTarget\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventTargetRedshiftTarget? RedshiftTargetInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetRedshiftTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retryPolicyInput", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetRetryPolicy\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventTargetRetryPolicy? RetryPolicyInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetRetryPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runCommandTargetsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetRunCommandTargets\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventTargetRunCommandTargets[]? RunCommandTargetsInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetRunCommandTargets[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqsTargetInput", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetSqsTarget\"}", isOptional: true)]
        public virtual aws.Eventbridge.ICloudwatchEventTargetSqsTarget? SqsTargetInput
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetSqsTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventBusName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventBusName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "input", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Input
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inputPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Rule
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runCommandTargets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetRunCommandTargets\"},\"kind\":\"array\"}}")]
        public virtual aws.Eventbridge.ICloudwatchEventTargetRunCommandTargets[] RunCommandTargets
        {
            get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetRunCommandTargets[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
