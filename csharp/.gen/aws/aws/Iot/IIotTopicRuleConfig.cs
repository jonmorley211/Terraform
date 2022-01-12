using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Iot
{
    /// <summary>AWS IoT.</summary>
    [JsiiInterface(nativeType: typeof(IIotTopicRuleConfig), fullyQualifiedName: "aws.iot.IotTopicRuleConfig")]
    public interface IIotTopicRuleConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#enabled IotTopicRule#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#name IotTopicRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#sql IotTopicRule#sql}.</summary>
        [JsiiProperty(name: "sql", typeJson: "{\"primitive\":\"string\"}")]
        string Sql
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#sql_version IotTopicRule#sql_version}.</summary>
        [JsiiProperty(name: "sqlVersion", typeJson: "{\"primitive\":\"string\"}")]
        string SqlVersion
        {
            get;
        }

        /// <summary>cloudwatch_alarm block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#cloudwatch_alarm IotTopicRule#cloudwatch_alarm}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchAlarm", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleCloudwatchAlarm\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleCloudwatchAlarm[]? CloudwatchAlarm
        {
            get
            {
                return null;
            }
        }

        /// <summary>cloudwatch_metric block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#cloudwatch_metric IotTopicRule#cloudwatch_metric}
        /// </remarks>
        [JsiiProperty(name: "cloudwatchMetric", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleCloudwatchMetric\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleCloudwatchMetric[]? CloudwatchMetric
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#description IotTopicRule#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>dynamodb block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#dynamodb IotTopicRule#dynamodb}
        /// </remarks>
        [JsiiProperty(name: "dynamodb", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleDynamodb\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleDynamodb[]? Dynamodb
        {
            get
            {
                return null;
            }
        }

        /// <summary>dynamodbv2 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#dynamodbv2 IotTopicRule#dynamodbv2}
        /// </remarks>
        [JsiiProperty(name: "dynamodbv2", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleDynamodbv2\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleDynamodbv2[]? Dynamodbv2
        {
            get
            {
                return null;
            }
        }

        /// <summary>elasticsearch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#elasticsearch IotTopicRule#elasticsearch}
        /// </remarks>
        [JsiiProperty(name: "elasticsearch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleElasticsearch\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleElasticsearch[]? Elasticsearch
        {
            get
            {
                return null;
            }
        }

        /// <summary>error_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#error_action IotTopicRule#error_action}
        /// </remarks>
        [JsiiProperty(name: "errorAction", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleErrorAction? ErrorAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>firehose block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#firehose IotTopicRule#firehose}
        /// </remarks>
        [JsiiProperty(name: "firehose", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleFirehose\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleFirehose[]? Firehose
        {
            get
            {
                return null;
            }
        }

        /// <summary>iot_analytics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#iot_analytics IotTopicRule#iot_analytics}
        /// </remarks>
        [JsiiProperty(name: "iotAnalytics", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleIotAnalytics\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleIotAnalytics[]? IotAnalytics
        {
            get
            {
                return null;
            }
        }

        /// <summary>iot_events block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#iot_events IotTopicRule#iot_events}
        /// </remarks>
        [JsiiProperty(name: "iotEvents", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleIotEvents\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleIotEvents[]? IotEvents
        {
            get
            {
                return null;
            }
        }

        /// <summary>kinesis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#kinesis IotTopicRule#kinesis}
        /// </remarks>
        [JsiiProperty(name: "kinesis", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleKinesis\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleKinesis[]? Kinesis
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#lambda IotTopicRule#lambda}
        /// </remarks>
        [JsiiProperty(name: "lambda", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleLambda\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleLambda[]? Lambda
        {
            get
            {
                return null;
            }
        }

        /// <summary>republish block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#republish IotTopicRule#republish}
        /// </remarks>
        [JsiiProperty(name: "republish", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleRepublish\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleRepublish[]? Republish
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#s3 IotTopicRule#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleS3\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleS3[]? S3
        {
            get
            {
                return null;
            }
        }

        /// <summary>sns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#sns IotTopicRule#sns}
        /// </remarks>
        [JsiiProperty(name: "sns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleSns\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleSns[]? Sns
        {
            get
            {
                return null;
            }
        }

        /// <summary>sqs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#sqs IotTopicRule#sqs}
        /// </remarks>
        [JsiiProperty(name: "sqs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleSqs\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleSqs[]? Sqs
        {
            get
            {
                return null;
            }
        }

        /// <summary>step_functions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#step_functions IotTopicRule#step_functions}
        /// </remarks>
        [JsiiProperty(name: "stepFunctions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleStepFunctions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Iot.IIotTopicRuleStepFunctions[]? StepFunctions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#tags IotTopicRule#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#tags_all IotTopicRule#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TagsAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS IoT.</summary>
        [JsiiTypeProxy(nativeType: typeof(IIotTopicRuleConfig), fullyQualifiedName: "aws.iot.IotTopicRuleConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Iot.IIotTopicRuleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#enabled IotTopicRule#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#name IotTopicRule#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#sql IotTopicRule#sql}.</summary>
            [JsiiProperty(name: "sql", typeJson: "{\"primitive\":\"string\"}")]
            public string Sql
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#sql_version IotTopicRule#sql_version}.</summary>
            [JsiiProperty(name: "sqlVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string SqlVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>cloudwatch_alarm block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#cloudwatch_alarm IotTopicRule#cloudwatch_alarm}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchAlarm", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleCloudwatchAlarm\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Iot.IIotTopicRuleCloudwatchAlarm[]? CloudwatchAlarm
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleCloudwatchAlarm[]?>();
            }

            /// <summary>cloudwatch_metric block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#cloudwatch_metric IotTopicRule#cloudwatch_metric}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudwatchMetric", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleCloudwatchMetric\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Iot.IIotTopicRuleCloudwatchMetric[]? CloudwatchMetric
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleCloudwatchMetric[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#description IotTopicRule#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>dynamodb block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#dynamodb IotTopicRule#dynamodb}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dynamodb", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleDynamodb\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Iot.IIotTopicRuleDynamodb[]? Dynamodb
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleDynamodb[]?>();
            }

            /// <summary>dynamodbv2 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#dynamodbv2 IotTopicRule#dynamodbv2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dynamodbv2", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleDynamodbv2\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Iot.IIotTopicRuleDynamodbv2[]? Dynamodbv2
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleDynamodbv2[]?>();
            }

            /// <summary>elasticsearch block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#elasticsearch IotTopicRule#elasticsearch}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "elasticsearch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleElasticsearch\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Iot.IIotTopicRuleElasticsearch[]? Elasticsearch
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleElasticsearch[]?>();
            }

            /// <summary>error_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#error_action IotTopicRule#error_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "errorAction", typeJson: "{\"fqn\":\"aws.iot.IotTopicRuleErrorAction\"}", isOptional: true)]
            public aws.Iot.IIotTopicRuleErrorAction? ErrorAction
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleErrorAction?>();
            }

            /// <summary>firehose block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#firehose IotTopicRule#firehose}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "firehose", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleFirehose\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Iot.IIotTopicRuleFirehose[]? Firehose
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleFirehose[]?>();
            }

            /// <summary>iot_analytics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#iot_analytics IotTopicRule#iot_analytics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iotAnalytics", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleIotAnalytics\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Iot.IIotTopicRuleIotAnalytics[]? IotAnalytics
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleIotAnalytics[]?>();
            }

            /// <summary>iot_events block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#iot_events IotTopicRule#iot_events}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iotEvents", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleIotEvents\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Iot.IIotTopicRuleIotEvents[]? IotEvents
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleIotEvents[]?>();
            }

            /// <summary>kinesis block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#kinesis IotTopicRule#kinesis}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kinesis", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleKinesis\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Iot.IIotTopicRuleKinesis[]? Kinesis
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleKinesis[]?>();
            }

            /// <summary>lambda block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#lambda IotTopicRule#lambda}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambda", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleLambda\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Iot.IIotTopicRuleLambda[]? Lambda
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleLambda[]?>();
            }

            /// <summary>republish block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#republish IotTopicRule#republish}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "republish", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleRepublish\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Iot.IIotTopicRuleRepublish[]? Republish
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleRepublish[]?>();
            }

            /// <summary>s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#s3 IotTopicRule#s3}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleS3\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Iot.IIotTopicRuleS3[]? S3
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleS3[]?>();
            }

            /// <summary>sns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#sns IotTopicRule#sns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleSns\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Iot.IIotTopicRuleSns[]? Sns
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleSns[]?>();
            }

            /// <summary>sqs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#sqs IotTopicRule#sqs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sqs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleSqs\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Iot.IIotTopicRuleSqs[]? Sqs
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleSqs[]?>();
            }

            /// <summary>step_functions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#step_functions IotTopicRule#step_functions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stepFunctions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iot.IotTopicRuleStepFunctions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Iot.IIotTopicRuleStepFunctions[]? StepFunctions
            {
                get => GetInstanceProperty<aws.Iot.IIotTopicRuleStepFunctions[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#tags IotTopicRule#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Tags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/iot_topic_rule#tags_all IotTopicRule#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? TagsAll
            {
                get => GetInstanceProperty<object?>();
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
