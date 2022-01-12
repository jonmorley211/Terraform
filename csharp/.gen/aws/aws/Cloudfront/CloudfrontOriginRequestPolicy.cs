using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy aws_cloudfront_origin_request_policy}.</summary>
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontOriginRequestPolicy), fullyQualifiedName: "aws.cloudfront.CloudfrontOriginRequestPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyConfig\"}}]")]
    public class CloudfrontOriginRequestPolicy : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy aws_cloudfront_origin_request_policy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudfrontOriginRequestPolicy(Constructs.Construct scope, string id, aws.Cloudfront.ICloudfrontOriginRequestPolicyConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontOriginRequestPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontOriginRequestPolicy(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCookiesConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyCookiesConfig\"}}]")]
        public virtual void PutCookiesConfig(aws.Cloudfront.ICloudfrontOriginRequestPolicyCookiesConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontOriginRequestPolicyCookiesConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHeadersConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyHeadersConfig\"}}]")]
        public virtual void PutHeadersConfig(aws.Cloudfront.ICloudfrontOriginRequestPolicyHeadersConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontOriginRequestPolicyHeadersConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueryStringsConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyQueryStringsConfig\"}}]")]
        public virtual void PutQueryStringsConfig(aws.Cloudfront.ICloudfrontOriginRequestPolicyQueryStringsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontOriginRequestPolicyQueryStringsConfig)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.Cloudfront.CloudfrontOriginRequestPolicy))!;

        [JsiiProperty(name: "cookiesConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyCookiesConfigOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontOriginRequestPolicyCookiesConfigOutputReference CookiesConfig
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontOriginRequestPolicyCookiesConfigOutputReference>()!;
        }

        [JsiiProperty(name: "etag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Etag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "headersConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyHeadersConfigOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontOriginRequestPolicyHeadersConfigOutputReference HeadersConfig
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontOriginRequestPolicyHeadersConfigOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "queryStringsConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyQueryStringsConfigOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontOriginRequestPolicyQueryStringsConfigOutputReference QueryStringsConfig
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontOriginRequestPolicyQueryStringsConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "commentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CommentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cookiesConfigInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyCookiesConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontOriginRequestPolicyCookiesConfig? CookiesConfigInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontOriginRequestPolicyCookiesConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "headersConfigInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyHeadersConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontOriginRequestPolicyHeadersConfig? HeadersConfigInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontOriginRequestPolicyHeadersConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringsConfigInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyQueryStringsConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontOriginRequestPolicyQueryStringsConfig? QueryStringsConfigInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontOriginRequestPolicyQueryStringsConfig?>();
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
