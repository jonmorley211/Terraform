using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.DataAwsCloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection), fullyQualifiedName: "aws.cloudfront.DataAwsCloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsCloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsCloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "modeBlock", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object ModeBlock
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "override", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Override
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "protection", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Protection
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "reportUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReportUri
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
