using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigOutputReference), fullyQualifiedName: "aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudfrontResponseHeadersPolicySecurityHeadersConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CloudfrontResponseHeadersPolicySecurityHeadersConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontResponseHeadersPolicySecurityHeadersConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontResponseHeadersPolicySecurityHeadersConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putContentSecurityPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy\"}}]")]
        public virtual void PutContentSecurityPolicy(aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putContentTypeOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions\"}}]")]
        public virtual void PutContentTypeOptions(aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFrameOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions\"}}]")]
        public virtual void PutFrameOptions(aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putReferrerPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy\"}}]")]
        public virtual void PutReferrerPolicy(aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStrictTransportSecurity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity\"}}]")]
        public virtual void PutStrictTransportSecurity(aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putXssProtection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection\"}}]")]
        public virtual void PutXssProtection(aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetContentSecurityPolicy")]
        public virtual void ResetContentSecurityPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContentTypeOptions")]
        public virtual void ResetContentTypeOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFrameOptions")]
        public virtual void ResetFrameOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReferrerPolicy")]
        public virtual void ResetReferrerPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStrictTransportSecurity")]
        public virtual void ResetStrictTransportSecurity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetXssProtection")]
        public virtual void ResetXssProtection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "contentSecurityPolicy", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicyOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicyOutputReference ContentSecurityPolicy
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "contentTypeOptions", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptionsOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptionsOutputReference ContentTypeOptions
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "frameOptions", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptionsOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptionsOutputReference FrameOptions
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "referrerPolicy", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicyOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicyOutputReference ReferrerPolicy
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "strictTransportSecurity", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurityOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurityOutputReference StrictTransportSecurity
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurityOutputReference>()!;
        }

        [JsiiProperty(name: "xssProtection", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtectionOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtectionOutputReference XssProtection
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtectionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentSecurityPolicyInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy? ContentSecurityPolicyInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentTypeOptionsInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions? ContentTypeOptionsInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "frameOptionsInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions? FrameOptionsInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "referrerPolicyInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy? ReferrerPolicyInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "strictTransportSecurityInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity? StrictTransportSecurityInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "xssProtectionInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection? XssProtectionInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
