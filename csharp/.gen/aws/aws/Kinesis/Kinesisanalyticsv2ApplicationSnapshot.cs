using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesis
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application_snapshot aws_kinesisanalyticsv2_application_snapshot}.</summary>
    [JsiiClass(nativeType: typeof(aws.Kinesis.Kinesisanalyticsv2ApplicationSnapshot), fullyQualifiedName: "aws.kinesis.Kinesisanalyticsv2ApplicationSnapshot", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationSnapshotConfig\"}}]")]
    public class Kinesisanalyticsv2ApplicationSnapshot : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/kinesisanalyticsv2_application_snapshot aws_kinesisanalyticsv2_application_snapshot} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Kinesisanalyticsv2ApplicationSnapshot(Constructs.Construct scope, string id, aws.Kinesis.IKinesisanalyticsv2ApplicationSnapshotConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Kinesisanalyticsv2ApplicationSnapshot(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Kinesisanalyticsv2ApplicationSnapshot(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationSnapshotTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Kinesis.IKinesisanalyticsv2ApplicationSnapshotTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Kinesis.IKinesisanalyticsv2ApplicationSnapshotTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.Kinesis.Kinesisanalyticsv2ApplicationSnapshot))!;

        [JsiiProperty(name: "applicationVersionId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ApplicationVersionId
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "snapshotCreationTimestamp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SnapshotCreationTimestamp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationSnapshotTimeoutsOutputReference\"}")]
        public virtual aws.Kinesis.Kinesisanalyticsv2ApplicationSnapshotTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Kinesis.Kinesisanalyticsv2ApplicationSnapshotTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplicationNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SnapshotNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.kinesis.Kinesisanalyticsv2ApplicationSnapshotTimeouts\"}", isOptional: true)]
        public virtual aws.Kinesis.IKinesisanalyticsv2ApplicationSnapshotTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Kinesis.IKinesisanalyticsv2ApplicationSnapshotTimeouts?>();
        }

        [JsiiProperty(name: "applicationName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "snapshotName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SnapshotName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
