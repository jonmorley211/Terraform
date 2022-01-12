using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.DataAwsCloudfrontResponseHeadersPolicyCorsConfig), fullyQualifiedName: "aws.cloudfront.DataAwsCloudfrontResponseHeadersPolicyCorsConfig", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsCloudfrontResponseHeadersPolicyCorsConfig : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsCloudfrontResponseHeadersPolicyCorsConfig(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudfrontResponseHeadersPolicyCorsConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudfrontResponseHeadersPolicyCorsConfig(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessControlAllowCredentials", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object AccessControlAllowCredentials
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "accessControlAllowHeaders", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object AccessControlAllowHeaders
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "accessControlAllowMethods", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object AccessControlAllowMethods
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "accessControlAllowOrigins", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object AccessControlAllowOrigins
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "accessControlExposeHeaders", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object AccessControlExposeHeaders
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "accessControlMaxAgeSec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AccessControlMaxAgeSec
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "originOverride", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object OriginOverride
        {
            get => GetInstanceProperty<object>()!;
        }
    }
}
