using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontOriginRequestPolicyQueryStringsConfigOutputReference), fullyQualifiedName: "aws.cloudfront.CloudfrontOriginRequestPolicyQueryStringsConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudfrontOriginRequestPolicyQueryStringsConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CloudfrontOriginRequestPolicyQueryStringsConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontOriginRequestPolicyQueryStringsConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontOriginRequestPolicyQueryStringsConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putQueryStrings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyQueryStringsConfigQueryStrings\"}}]")]
        public virtual void PutQueryStrings(aws.Cloudfront.ICloudfrontOriginRequestPolicyQueryStringsConfigQueryStrings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontOriginRequestPolicyQueryStringsConfigQueryStrings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetQueryStrings")]
        public virtual void ResetQueryStrings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "queryStrings", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyQueryStringsConfigQueryStringsOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontOriginRequestPolicyQueryStringsConfigQueryStringsOutputReference QueryStrings
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontOriginRequestPolicyQueryStringsConfigQueryStringsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QueryStringBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryStringsInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyQueryStringsConfigQueryStrings\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontOriginRequestPolicyQueryStringsConfigQueryStrings? QueryStringsInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontOriginRequestPolicyQueryStringsConfigQueryStrings?>();
        }

        [JsiiProperty(name: "queryStringBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QueryStringBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyQueryStringsConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontOriginRequestPolicyQueryStringsConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontOriginRequestPolicyQueryStringsConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
