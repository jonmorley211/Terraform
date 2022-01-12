using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    /// <summary>AWS CloudWatch Event Bridge.</summary>
    [JsiiInterface(nativeType: typeof(ICloudwatchEventTargetConfig), fullyQualifiedName: "aws.eventbridge.CloudwatchEventTargetConfig")]
    public interface ICloudwatchEventTargetConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#arn CloudwatchEventTarget#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#rule CloudwatchEventTarget#rule}.</summary>
        [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}")]
        string Rule
        {
            get;
        }

        /// <summary>batch_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#batch_target CloudwatchEventTarget#batch_target}
        /// </remarks>
        [JsiiProperty(name: "batchTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetBatchTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventTargetBatchTarget? BatchTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>dead_letter_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#dead_letter_config CloudwatchEventTarget#dead_letter_config}
        /// </remarks>
        [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetDeadLetterConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventTargetDeadLetterConfig? DeadLetterConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>ecs_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#ecs_target CloudwatchEventTarget#ecs_target}
        /// </remarks>
        [JsiiProperty(name: "ecsTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetEcsTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventTargetEcsTarget? EcsTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#event_bus_name CloudwatchEventTarget#event_bus_name}.</summary>
        [JsiiProperty(name: "eventBusName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventBusName
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#http_target CloudwatchEventTarget#http_target}
        /// </remarks>
        [JsiiProperty(name: "httpTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetHttpTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventTargetHttpTarget? HttpTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#input CloudwatchEventTarget#input}.</summary>
        [JsiiProperty(name: "input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Input
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#input_path CloudwatchEventTarget#input_path}.</summary>
        [JsiiProperty(name: "inputPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InputPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>input_transformer block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#input_transformer CloudwatchEventTarget#input_transformer}
        /// </remarks>
        [JsiiProperty(name: "inputTransformer", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetInputTransformer\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventTargetInputTransformer? InputTransformer
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#kinesis_target CloudwatchEventTarget#kinesis_target}
        /// </remarks>
        [JsiiProperty(name: "kinesisTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetKinesisTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventTargetKinesisTarget? KinesisTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>redshift_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#redshift_target CloudwatchEventTarget#redshift_target}
        /// </remarks>
        [JsiiProperty(name: "redshiftTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetRedshiftTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventTargetRedshiftTarget? RedshiftTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>retry_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#retry_policy CloudwatchEventTarget#retry_policy}
        /// </remarks>
        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetRetryPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventTargetRetryPolicy? RetryPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#role_arn CloudwatchEventTarget#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>run_command_targets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#run_command_targets CloudwatchEventTarget#run_command_targets}
        /// </remarks>
        [JsiiProperty(name: "runCommandTargets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetRunCommandTargets\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventTargetRunCommandTargets[]? RunCommandTargets
        {
            get
            {
                return null;
            }
        }

        /// <summary>sqs_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#sqs_target CloudwatchEventTarget#sqs_target}
        /// </remarks>
        [JsiiProperty(name: "sqsTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetSqsTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Eventbridge.ICloudwatchEventTargetSqsTarget? SqsTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#target_id CloudwatchEventTarget#target_id}.</summary>
        [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS CloudWatch Event Bridge.</summary>
        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventTargetConfig), fullyQualifiedName: "aws.eventbridge.CloudwatchEventTargetConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Eventbridge.ICloudwatchEventTargetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#arn CloudwatchEventTarget#arn}.</summary>
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#rule CloudwatchEventTarget#rule}.</summary>
            [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}")]
            public string Rule
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>batch_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#batch_target CloudwatchEventTarget#batch_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "batchTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetBatchTarget\"}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventTargetBatchTarget? BatchTarget
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetBatchTarget?>();
            }

            /// <summary>dead_letter_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#dead_letter_config CloudwatchEventTarget#dead_letter_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deadLetterConfig", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetDeadLetterConfig\"}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventTargetDeadLetterConfig? DeadLetterConfig
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetDeadLetterConfig?>();
            }

            /// <summary>ecs_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#ecs_target CloudwatchEventTarget#ecs_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ecsTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetEcsTarget\"}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventTargetEcsTarget? EcsTarget
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetEcsTarget?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#event_bus_name CloudwatchEventTarget#event_bus_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventBusName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventBusName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>http_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#http_target CloudwatchEventTarget#http_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetHttpTarget\"}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventTargetHttpTarget? HttpTarget
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetHttpTarget?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#input CloudwatchEventTarget#input}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "input", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Input
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#input_path CloudwatchEventTarget#input_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>input_transformer block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#input_transformer CloudwatchEventTarget#input_transformer}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inputTransformer", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetInputTransformer\"}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventTargetInputTransformer? InputTransformer
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetInputTransformer?>();
            }

            /// <summary>kinesis_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#kinesis_target CloudwatchEventTarget#kinesis_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesisTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetKinesisTarget\"}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventTargetKinesisTarget? KinesisTarget
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetKinesisTarget?>();
            }

            /// <summary>redshift_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#redshift_target CloudwatchEventTarget#redshift_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redshiftTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetRedshiftTarget\"}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventTargetRedshiftTarget? RedshiftTarget
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetRedshiftTarget?>();
            }

            /// <summary>retry_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#retry_policy CloudwatchEventTarget#retry_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetRetryPolicy\"}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventTargetRetryPolicy? RetryPolicy
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetRetryPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#role_arn CloudwatchEventTarget#role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>run_command_targets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#run_command_targets CloudwatchEventTarget#run_command_targets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "runCommandTargets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetRunCommandTargets\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventTargetRunCommandTargets[]? RunCommandTargets
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetRunCommandTargets[]?>();
            }

            /// <summary>sqs_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#sqs_target CloudwatchEventTarget#sqs_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sqsTarget", typeJson: "{\"fqn\":\"aws.eventbridge.CloudwatchEventTargetSqsTarget\"}", isOptional: true)]
            public aws.Eventbridge.ICloudwatchEventTargetSqsTarget? SqsTarget
            {
                get => GetInstanceProperty<aws.Eventbridge.ICloudwatchEventTargetSqsTarget?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#target_id CloudwatchEventTarget#target_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
