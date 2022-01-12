using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_config aws_cloudfront_field_level_encryption_config}.</summary>
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontFieldLevelEncryptionConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontFieldLevelEncryptionConfig", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigConfig\"}}]")]
    public class CloudfrontFieldLevelEncryptionConfig : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_config aws_cloudfront_field_level_encryption_config} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudfrontFieldLevelEncryptionConfig(Constructs.Construct scope, string id, aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontFieldLevelEncryptionConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontFieldLevelEncryptionConfig(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putContentTypeProfileConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig\"}}]")]
        public virtual void PutContentTypeProfileConfig(aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueryArgProfileConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig\"}}]")]
        public virtual void PutQueryArgProfileConfig(aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.Cloudfront.CloudfrontFieldLevelEncryptionConfig))!;

        [JsiiProperty(name: "callerReference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CallerReference
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "contentTypeProfileConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigOutputReference ContentTypeProfileConfig
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigOutputReference>()!;
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

        [JsiiProperty(name: "queryArgProfileConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigOutputReference QueryArgProfileConfig
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "commentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CommentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentTypeProfileConfigInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig? ContentTypeProfileConfigInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryArgProfileConfigInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig? QueryArgProfileConfigInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig?>();
        }

        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Comment
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
