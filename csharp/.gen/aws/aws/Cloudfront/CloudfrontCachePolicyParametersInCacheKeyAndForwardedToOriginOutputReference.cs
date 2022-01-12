using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginOutputReference), fullyQualifiedName: "aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCookiesConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfig\"}}]")]
        public virtual void PutCookiesConfig(aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHeadersConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfig\"}}]")]
        public virtual void PutHeadersConfig(aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putQueryStringsConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfig\"}}]")]
        public virtual void PutQueryStringsConfig(aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnableAcceptEncodingBrotli")]
        public virtual void ResetEnableAcceptEncodingBrotli()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableAcceptEncodingGzip")]
        public virtual void ResetEnableAcceptEncodingGzip()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cookiesConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigOutputReference CookiesConfig
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigOutputReference>()!;
        }

        [JsiiProperty(name: "headersConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfigOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfigOutputReference HeadersConfig
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfigOutputReference>()!;
        }

        [JsiiProperty(name: "queryStringsConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfigOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfigOutputReference QueryStringsConfig
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cookiesConfigInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfig? CookiesConfigInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableAcceptEncodingBrotliInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableAcceptEncodingBrotliInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableAcceptEncodingGzipInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableAcceptEncodingGzipInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "headersConfigInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfig? HeadersConfigInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginHeadersConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringsConfigInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfig? QueryStringsConfigInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginQueryStringsConfig?>();
        }

        [JsiiProperty(name: "enableAcceptEncodingBrotli", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnableAcceptEncodingBrotli
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableAcceptEncodingGzip", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnableAcceptEncodingGzip
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOrigin\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOrigin? InternalValue
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOrigin?>();
            set => SetInstanceProperty(value);
        }
    }
}
