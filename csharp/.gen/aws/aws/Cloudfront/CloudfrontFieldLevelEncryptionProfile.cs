using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_profile aws_cloudfront_field_level_encryption_profile}.</summary>
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontFieldLevelEncryptionProfile), fullyQualifiedName: "aws.cloudfront.CloudfrontFieldLevelEncryptionProfile", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionProfileConfig\"}}]")]
    public class CloudfrontFieldLevelEncryptionProfile : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_profile aws_cloudfront_field_level_encryption_profile} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudfrontFieldLevelEncryptionProfile(Constructs.Construct scope, string id, aws.Cloudfront.ICloudfrontFieldLevelEncryptionProfileConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontFieldLevelEncryptionProfile(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontFieldLevelEncryptionProfile(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEncryptionEntities", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionProfileEncryptionEntities\"}}]")]
        public virtual void PutEncryptionEntities(aws.Cloudfront.ICloudfrontFieldLevelEncryptionProfileEncryptionEntities @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontFieldLevelEncryptionProfileEncryptionEntities)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetComment")]
        public virtual void ResetComment()
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
        = GetStaticProperty<string>(typeof(aws.Cloudfront.CloudfrontFieldLevelEncryptionProfile))!;

        [JsiiProperty(name: "callerReference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CallerReference
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptionEntities", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionProfileEncryptionEntitiesOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontFieldLevelEncryptionProfileEncryptionEntitiesOutputReference EncryptionEntities
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontFieldLevelEncryptionProfileEncryptionEntitiesOutputReference>()!;
        }

        [JsiiProperty(name: "etag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Etag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "commentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CommentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionEntitiesInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionProfileEncryptionEntities\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontFieldLevelEncryptionProfileEncryptionEntities? EncryptionEntitiesInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontFieldLevelEncryptionProfileEncryptionEntities?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Comment
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
