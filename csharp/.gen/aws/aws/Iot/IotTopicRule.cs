using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule aws_iot_topic_rule}.</summary>
    [JsiiClass(nativeType: typeof(aws.Iot.IotTopicRule), fullyQualifiedName: "aws.iot.IotTopicRule", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.iot.IotTopicRuleConfig\"}}]")]
    public class IotTopicRule : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule aws_iot_topic_rule} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IotTopicRule(Constructs.Construct scope, string id, aws.Iot.IIotTopicRuleConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotTopicRule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotTopicRule(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putErrorAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iot.IotTopicRuleErrorAction\"}}]")]
        public virtual void PutErrorAction(aws.Iot.IIotTopicRuleErrorAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Iot.IIotTopicRuleErrorAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchAlarm")]
        public virtual void ResetCloudwatchAlarm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCloudwatchMetric")]
        public virtual void ResetCloudwatchMetric()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDynamodb")]
        public virtual void ResetDynamodb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDynamodbv2")]
        public virtual void ResetDynamodbv2()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetElasticsearch")]
        public virtual void ResetElasticsearch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetErrorAction")]
        public virtual void ResetErrorAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFirehose")]
        public virtual void ResetFirehose()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIotAnalytics")]
        public virtual void ResetIotAnalytics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIotEvents")]
        public virtual void ResetIotEvents()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesis")]
        public virtual void ResetKinesis()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambda")]
        public virtual void ResetLambda()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRepublish")]
        public virtual void ResetRepublish()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3")]
        public virtual void ResetS3()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSns")]
        public virtual void ResetSns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqs")]
        public virtual void ResetSqs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepFunctions")]
        public virtual void ResetStepFunctions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
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
        = GetStaticProperty<string>(typeof(aws.Iot.IotTopicRule))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errorAction", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorActionOutputReference\"}")]
        public virtual aws.Iot.IotTopicRuleErrorActionOutputReference ErrorAction
        {
            get => GetInstanceProperty<aws.Iot.IotTopicRuleErrorActionOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchAlarmInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleCloudwatchAlarm\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleCloudwatchAlarm[]? CloudwatchAlarmInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleCloudwatchAlarm[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchMetricInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleCloudwatchMetric\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleCloudwatchMetric[]? CloudwatchMetricInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleCloudwatchMetric[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynamodbInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleDynamodb\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleDynamodb[]? DynamodbInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleDynamodb[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynamodbv2Input", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleDynamodbv2\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleDynamodbv2[]? Dynamodbv2Input
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleDynamodbv2[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "elasticsearchInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleElasticsearch\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleElasticsearch[]? ElasticsearchInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleElasticsearch[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorActionInput", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorAction\"}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleErrorAction? ErrorActionInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "firehoseInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleFirehose\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleFirehose[]? FirehoseInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleFirehose[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iotAnalyticsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleIotAnalytics\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleIotAnalytics[]? IotAnalyticsInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleIotAnalytics[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iotEventsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleIotEvents\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleIotEvents[]? IotEventsInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleIotEvents[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleKinesis\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleKinesis[]? KinesisInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleKinesis[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleLambda\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleLambda[]? LambdaInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleLambda[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "republishInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleRepublish\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleRepublish[]? RepublishInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleRepublish[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Input", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleS3\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleS3[]? S3Input
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleS3[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleSns\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleSns[]? SnsInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleSns[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SqlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SqlVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleSqs\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleSqs[]? SqsInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleSqs[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepFunctionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleStepFunctions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Iot.IIotTopicRuleStepFunctions[]? StepFunctionsInput
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleStepFunctions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsAllInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "cloudwatchAlarm", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleCloudwatchAlarm\"},\"kind\":\"array\"}}")]
        public virtual aws.Iot.IIotTopicRuleCloudwatchAlarm[] CloudwatchAlarm
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleCloudwatchAlarm[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cloudwatchMetric", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleCloudwatchMetric\"},\"kind\":\"array\"}}")]
        public virtual aws.Iot.IIotTopicRuleCloudwatchMetric[] CloudwatchMetric
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleCloudwatchMetric[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dynamodb", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleDynamodb\"},\"kind\":\"array\"}}")]
        public virtual aws.Iot.IIotTopicRuleDynamodb[] Dynamodb
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleDynamodb[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dynamodbv2", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleDynamodbv2\"},\"kind\":\"array\"}}")]
        public virtual aws.Iot.IIotTopicRuleDynamodbv2[] Dynamodbv2
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleDynamodbv2[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "elasticsearch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleElasticsearch\"},\"kind\":\"array\"}}")]
        public virtual aws.Iot.IIotTopicRuleElasticsearch[] Elasticsearch
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleElasticsearch[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "firehose", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleFirehose\"},\"kind\":\"array\"}}")]
        public virtual aws.Iot.IIotTopicRuleFirehose[] Firehose
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleFirehose[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iotAnalytics", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleIotAnalytics\"},\"kind\":\"array\"}}")]
        public virtual aws.Iot.IIotTopicRuleIotAnalytics[] IotAnalytics
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleIotAnalytics[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iotEvents", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleIotEvents\"},\"kind\":\"array\"}}")]
        public virtual aws.Iot.IIotTopicRuleIotEvents[] IotEvents
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleIotEvents[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kinesis", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleKinesis\"},\"kind\":\"array\"}}")]
        public virtual aws.Iot.IIotTopicRuleKinesis[] Kinesis
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleKinesis[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lambda", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleLambda\"},\"kind\":\"array\"}}")]
        public virtual aws.Iot.IIotTopicRuleLambda[] Lambda
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleLambda[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "republish", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleRepublish\"},\"kind\":\"array\"}}")]
        public virtual aws.Iot.IIotTopicRuleRepublish[] Republish
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleRepublish[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleS3\"},\"kind\":\"array\"}}")]
        public virtual aws.Iot.IIotTopicRuleS3[] S3
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleS3[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleSns\"},\"kind\":\"array\"}}")]
        public virtual aws.Iot.IIotTopicRuleSns[] Sns
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleSns[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sql", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sql
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sqlVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sqs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleSqs\"},\"kind\":\"array\"}}")]
        public virtual aws.Iot.IIotTopicRuleSqs[] Sqs
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleSqs[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stepFunctions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleStepFunctions\"},\"kind\":\"array\"}}")]
        public virtual aws.Iot.IIotTopicRuleStepFunctions[] StepFunctions
        {
            get => GetInstanceProperty<aws.Iot.IIotTopicRuleStepFunctions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object Tags
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object TagsAll
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
