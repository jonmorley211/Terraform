using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.DataAwsCloudfrontResponseHeadersPolicySecurityHeadersConfig), fullyQualifiedName: "aws.cloudfront.DataAwsCloudfrontResponseHeadersPolicySecurityHeadersConfig", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsCloudfrontResponseHeadersPolicySecurityHeadersConfig : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsCloudfrontResponseHeadersPolicySecurityHeadersConfig(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudfrontResponseHeadersPolicySecurityHeadersConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudfrontResponseHeadersPolicySecurityHeadersConfig(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "contentSecurityPolicy", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object ContentSecurityPolicy
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "contentTypeOptions", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object ContentTypeOptions
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "frameOptions", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object FrameOptions
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "referrerPolicy", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object ReferrerPolicy
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "strictTransportSecurity", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object StrictTransportSecurity
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "xssProtection", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object XssProtection
        {
            get => GetInstanceProperty<object>()!;
        }
    }
}
