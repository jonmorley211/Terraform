using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigOutputReference), fullyQualifiedName: "aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCookies", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies\"}}]")]
        public virtual void PutCookies(aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCookies")]
        public virtual void ResetCookies()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigCookiesOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigCookiesOutputReference Cookies
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigCookiesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cookieBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CookieBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cookiesInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies? CookiesInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfigCookies?>();
        }

        [JsiiProperty(name: "cookieBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CookieBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontCachePolicyParametersInCacheKeyAndForwardedToOriginCookiesConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
