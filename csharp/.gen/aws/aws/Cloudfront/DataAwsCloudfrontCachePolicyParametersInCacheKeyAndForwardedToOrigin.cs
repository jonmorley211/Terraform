using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.DataAwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOrigin), fullyQualifiedName: "aws.cloudfront.DataAwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOrigin", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOrigin : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOrigin(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOrigin(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudfrontCachePolicyParametersInCacheKeyAndForwardedToOrigin(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "cookiesConfig", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object CookiesConfig
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "enableAcceptEncodingBrotli", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object EnableAcceptEncodingBrotli
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "enableAcceptEncodingGzip", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object EnableAcceptEncodingGzip
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "headersConfig", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object HeadersConfig
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "queryStringsConfig", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object QueryStringsConfig
        {
            get => GetInstanceProperty<object>()!;
        }
    }
}
