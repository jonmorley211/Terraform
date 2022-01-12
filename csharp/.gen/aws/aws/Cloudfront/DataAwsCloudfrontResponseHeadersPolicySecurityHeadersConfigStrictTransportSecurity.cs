using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.DataAwsCloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity), fullyQualifiedName: "aws.cloudfront.DataAwsCloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsCloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsCloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessControlMaxAgeSec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AccessControlMaxAgeSec
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "includeSubdomains", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object IncludeSubdomains
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "override", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Override
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "preload", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Preload
        {
            get => GetInstanceProperty<object>()!;
        }
    }
}
