using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/efs_access_point aws_efs_access_point}.</summary>
    [JsiiClass(nativeType: typeof(aws.Efs.DataAwsEfsAccessPoint), fullyQualifiedName: "aws.efs.DataAwsEfsAccessPoint", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.efs.DataAwsEfsAccessPointConfig\"}}]")]
    public class DataAwsEfsAccessPoint : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/efs_access_point aws_efs_access_point} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsEfsAccessPoint(Constructs.Construct scope, string id, aws.Efs.IDataAwsEfsAccessPointConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEfsAccessPoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEfsAccessPoint(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "posixUser", returnsJson: "{\"type\":{\"fqn\":\"aws.efs.DataAwsEfsAccessPointPosixUser\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Efs.DataAwsEfsAccessPointPosixUser PosixUser(string index)
        {
            return InvokeInstanceMethod<aws.Efs.DataAwsEfsAccessPointPosixUser>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "rootDirectory", returnsJson: "{\"type\":{\"fqn\":\"aws.efs.DataAwsEfsAccessPointRootDirectory\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Efs.DataAwsEfsAccessPointRootDirectory RootDirectory(string index)
        {
            return InvokeInstanceMethod<aws.Efs.DataAwsEfsAccessPointRootDirectory>(new System.Type[]{typeof(string)}, new object[]{index})!;
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
        = GetStaticProperty<string>(typeof(aws.Efs.DataAwsEfsAccessPoint))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fileSystemArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileSystemArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileSystemId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessPointIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccessPointIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accessPointId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessPointId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object Tags
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
