using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontOriginRequestPolicyCookiesConfigOutputReference), fullyQualifiedName: "aws.cloudfront.CloudfrontOriginRequestPolicyCookiesConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudfrontOriginRequestPolicyCookiesConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CloudfrontOriginRequestPolicyCookiesConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontOriginRequestPolicyCookiesConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontOriginRequestPolicyCookiesConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCookies", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyCookiesConfigCookies\"}}]")]
        public virtual void PutCookies(aws.Cloudfront.ICloudfrontOriginRequestPolicyCookiesConfigCookies @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontOriginRequestPolicyCookiesConfigCookies)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCookies")]
        public virtual void ResetCookies()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyCookiesConfigCookiesOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontOriginRequestPolicyCookiesConfigCookiesOutputReference Cookies
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontOriginRequestPolicyCookiesConfigCookiesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cookieBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CookieBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cookiesInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyCookiesConfigCookies\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontOriginRequestPolicyCookiesConfigCookies? CookiesInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontOriginRequestPolicyCookiesConfigCookies?>();
        }

        [JsiiProperty(name: "cookieBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CookieBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyCookiesConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontOriginRequestPolicyCookiesConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontOriginRequestPolicyCookiesConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
