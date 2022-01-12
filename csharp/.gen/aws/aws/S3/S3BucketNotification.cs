using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification aws_s3_bucket_notification}.</summary>
    [JsiiClass(nativeType: typeof(aws.S3.S3BucketNotification), fullyQualifiedName: "aws.s3.S3BucketNotification", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.s3.S3BucketNotificationConfig\"}}]")]
    public class S3BucketNotification : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification aws_s3_bucket_notification} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public S3BucketNotification(Constructs.Construct scope, string id, aws.S3.IS3BucketNotificationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketNotification(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketNotification(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetLambdaFunction")]
        public virtual void ResetLambdaFunction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueue")]
        public virtual void ResetQueue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTopic")]
        public virtual void ResetTopic()
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
        = GetStaticProperty<string>(typeof(aws.S3.S3BucketNotification))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaFunctionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketNotificationLambdaFunction\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.S3.IS3BucketNotificationLambdaFunction[]? LambdaFunctionInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketNotificationLambdaFunction[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queueInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketNotificationQueue\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.S3.IS3BucketNotificationQueue[]? QueueInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketNotificationQueue[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "topicInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketNotificationTopic\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.S3.IS3BucketNotificationTopic[]? TopicInput
        {
            get => GetInstanceProperty<aws.S3.IS3BucketNotificationTopic[]?>();
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lambdaFunction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketNotificationLambdaFunction\"},\"kind\":\"array\"}}")]
        public virtual aws.S3.IS3BucketNotificationLambdaFunction[] LambdaFunction
        {
            get => GetInstanceProperty<aws.S3.IS3BucketNotificationLambdaFunction[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queue", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketNotificationQueue\"},\"kind\":\"array\"}}")]
        public virtual aws.S3.IS3BucketNotificationQueue[] Queue
        {
            get => GetInstanceProperty<aws.S3.IS3BucketNotificationQueue[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "topic", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketNotificationTopic\"},\"kind\":\"array\"}}")]
        public virtual aws.S3.IS3BucketNotificationTopic[] Topic
        {
            get => GetInstanceProperty<aws.S3.IS3BucketNotificationTopic[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
