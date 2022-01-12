using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontResponseHeadersPolicyCorsConfigOutputReference), fullyQualifiedName: "aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudfrontResponseHeadersPolicyCorsConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CloudfrontResponseHeadersPolicyCorsConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontResponseHeadersPolicyCorsConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontResponseHeadersPolicyCorsConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccessControlAllowHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders\"}}]")]
        public virtual void PutAccessControlAllowHeaders(aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAccessControlAllowMethods", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods\"}}]")]
        public virtual void PutAccessControlAllowMethods(aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAccessControlAllowOrigins", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins\"}}]")]
        public virtual void PutAccessControlAllowOrigins(aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAccessControlExposeHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders\"}}]")]
        public virtual void PutAccessControlExposeHeaders(aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessControlExposeHeaders")]
        public virtual void ResetAccessControlExposeHeaders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAccessControlMaxAgeSec")]
        public virtual void ResetAccessControlMaxAgeSec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "accessControlAllowHeaders", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeadersOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeadersOutputReference AccessControlAllowHeaders
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeadersOutputReference>()!;
        }

        [JsiiProperty(name: "accessControlAllowMethods", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethodsOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethodsOutputReference AccessControlAllowMethods
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethodsOutputReference>()!;
        }

        [JsiiProperty(name: "accessControlAllowOrigins", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOriginsOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOriginsOutputReference AccessControlAllowOrigins
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOriginsOutputReference>()!;
        }

        [JsiiProperty(name: "accessControlExposeHeaders", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeadersOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeadersOutputReference AccessControlExposeHeaders
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeadersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessControlAllowCredentialsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AccessControlAllowCredentialsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessControlAllowHeadersInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders? AccessControlAllowHeadersInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessControlAllowMethodsInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods? AccessControlAllowMethodsInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessControlAllowOriginsInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins? AccessControlAllowOriginsInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessControlExposeHeadersInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders? AccessControlExposeHeadersInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessControlMaxAgeSecInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AccessControlMaxAgeSecInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originOverrideInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? OriginOverrideInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accessControlAllowCredentials", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AccessControlAllowCredentials
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "accessControlMaxAgeSec", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AccessControlMaxAgeSec
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "originOverride", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object OriginOverride
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
