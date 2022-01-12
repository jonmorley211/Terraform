using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/cloudfront_origin_request_policy aws_cloudfront_origin_request_policy}.</summary>
    [JsiiClass(nativeType: typeof(aws.Cloudfront.DataAwsCloudfrontOriginRequestPolicy), fullyQualifiedName: "aws.cloudfront.DataAwsCloudfrontOriginRequestPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.cloudfront.DataAwsCloudfrontOriginRequestPolicyConfig\"}}]")]
    public class DataAwsCloudfrontOriginRequestPolicy : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/cloudfront_origin_request_policy aws_cloudfront_origin_request_policy} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsCloudfrontOriginRequestPolicy(Constructs.Construct scope, string id, aws.Cloudfront.IDataAwsCloudfrontOriginRequestPolicyConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudfrontOriginRequestPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudfrontOriginRequestPolicy(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "cookiesConfig", returnsJson: "{\"type\":{\"fqn\":\"aws.cloudfront.DataAwsCloudfrontOriginRequestPolicyCookiesConfig\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Cloudfront.DataAwsCloudfrontOriginRequestPolicyCookiesConfig CookiesConfig(string index)
        {
            return InvokeInstanceMethod<aws.Cloudfront.DataAwsCloudfrontOriginRequestPolicyCookiesConfig>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "headersConfig", returnsJson: "{\"type\":{\"fqn\":\"aws.cloudfront.DataAwsCloudfrontOriginRequestPolicyHeadersConfig\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Cloudfront.DataAwsCloudfrontOriginRequestPolicyHeadersConfig HeadersConfig(string index)
        {
            return InvokeInstanceMethod<aws.Cloudfront.DataAwsCloudfrontOriginRequestPolicyHeadersConfig>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "queryStringsConfig", returnsJson: "{\"type\":{\"fqn\":\"aws.cloudfront.DataAwsCloudfrontOriginRequestPolicyQueryStringsConfig\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Cloudfront.DataAwsCloudfrontOriginRequestPolicyQueryStringsConfig QueryStringsConfig(string index)
        {
            return InvokeInstanceMethod<aws.Cloudfront.DataAwsCloudfrontOriginRequestPolicyQueryStringsConfig>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
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
        = GetStaticProperty<string>(typeof(aws.Cloudfront.DataAwsCloudfrontOriginRequestPolicy))!;

        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Comment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "etag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Etag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
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
