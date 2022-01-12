using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.DataAwsCloudfrontOriginRequestPolicyQueryStringsConfig), fullyQualifiedName: "aws.cloudfront.DataAwsCloudfrontOriginRequestPolicyQueryStringsConfig", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsCloudfrontOriginRequestPolicyQueryStringsConfig : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsCloudfrontOriginRequestPolicyQueryStringsConfig(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudfrontOriginRequestPolicyQueryStringsConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCloudfrontOriginRequestPolicyQueryStringsConfig(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "queryStringBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QueryStringBehavior
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "queryStrings", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object QueryStrings
        {
            get => GetInstanceProperty<object>()!;
        }
    }
}
