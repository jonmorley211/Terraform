using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontDistributionOrderedCacheBehaviorForwardedValuesOutputReference), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionOrderedCacheBehaviorForwardedValuesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudfrontDistributionOrderedCacheBehaviorForwardedValuesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CloudfrontDistributionOrderedCacheBehaviorForwardedValuesOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionOrderedCacheBehaviorForwardedValuesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionOrderedCacheBehaviorForwardedValuesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCookies", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies\"}}]")]
        public virtual void PutCookies(aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHeaders")]
        public virtual void ResetHeaders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryStringCacheKeys")]
        public virtual void ResetQueryStringCacheKeys()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookiesOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookiesOutputReference Cookies
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookiesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cookiesInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies? CookiesInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehaviorForwardedValuesCookies?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "headersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? HeadersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringCacheKeysInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? QueryStringCacheKeysInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? QueryStringInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Headers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queryString", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object QueryString
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queryStringCacheKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] QueryStringCacheKeys
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrderedCacheBehaviorForwardedValues\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehaviorForwardedValues? InternalValue
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehaviorForwardedValues?>();
            set => SetInstanceProperty(value);
        }
    }
}
