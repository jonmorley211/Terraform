using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontDistributionTrustedSigners), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionTrustedSigners", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudfrontDistributionTrustedSigners : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public CloudfrontDistributionTrustedSigners(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionTrustedSigners(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionTrustedSigners(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Enabled
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "items", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Items
        {
            get => GetInstanceProperty<object>()!;
        }
    }
}
