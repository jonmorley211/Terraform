using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy aws_cloudfront_response_headers_policy}.</summary>
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontResponseHeadersPolicy), fullyQualifiedName: "aws.cloudfront.CloudfrontResponseHeadersPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyConfig\"}}]")]
    public class CloudfrontResponseHeadersPolicy : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy aws_cloudfront_response_headers_policy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudfrontResponseHeadersPolicy(Constructs.Construct scope, string id, aws.Cloudfront.ICloudfrontResponseHeadersPolicyConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontResponseHeadersPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontResponseHeadersPolicy(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCorsConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfig\"}}]")]
        public virtual void PutCorsConfig(aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomHeadersConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCustomHeadersConfig\"}}]")]
        public virtual void PutCustomHeadersConfig(aws.Cloudfront.ICloudfrontResponseHeadersPolicyCustomHeadersConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontResponseHeadersPolicyCustomHeadersConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecurityHeadersConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfig\"}}]")]
        public virtual void PutSecurityHeadersConfig(aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetComment")]
        public virtual void ResetComment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCorsConfig")]
        public virtual void ResetCorsConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomHeadersConfig")]
        public virtual void ResetCustomHeadersConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEtag")]
        public virtual void ResetEtag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityHeadersConfig")]
        public virtual void ResetSecurityHeadersConfig()
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
        = GetStaticProperty<string>(typeof(aws.Cloudfront.CloudfrontResponseHeadersPolicy))!;

        [JsiiProperty(name: "corsConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontResponseHeadersPolicyCorsConfigOutputReference CorsConfig
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontResponseHeadersPolicyCorsConfigOutputReference>()!;
        }

        [JsiiProperty(name: "customHeadersConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCustomHeadersConfigOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontResponseHeadersPolicyCustomHeadersConfigOutputReference CustomHeadersConfig
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontResponseHeadersPolicyCustomHeadersConfigOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityHeadersConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigOutputReference SecurityHeadersConfig
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "commentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CommentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "corsConfigInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfig? CorsConfigInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customHeadersConfigInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCustomHeadersConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontResponseHeadersPolicyCustomHeadersConfig? CustomHeadersConfigInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicyCustomHeadersConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "etagInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EtagInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityHeadersConfigInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfig? SecurityHeadersConfigInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfig?>();
        }

        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Comment
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "etag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Etag
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
