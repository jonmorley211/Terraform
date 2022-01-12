using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontDistributionViewerCertificateOutputReference), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionViewerCertificateOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudfrontDistributionViewerCertificateOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CloudfrontDistributionViewerCertificateOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionViewerCertificateOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistributionViewerCertificateOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAcmCertificateArn")]
        public virtual void ResetAcmCertificateArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCloudfrontDefaultCertificate")]
        public virtual void ResetCloudfrontDefaultCertificate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIamCertificateId")]
        public virtual void ResetIamCertificateId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinimumProtocolVersion")]
        public virtual void ResetMinimumProtocolVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSslSupportMethod")]
        public virtual void ResetSslSupportMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "acmCertificateArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AcmCertificateArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudfrontDefaultCertificateInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CloudfrontDefaultCertificateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamCertificateIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IamCertificateIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumProtocolVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MinimumProtocolVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sslSupportMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SslSupportMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "acmCertificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AcmCertificateArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cloudfrontDefaultCertificate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object CloudfrontDefaultCertificate
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iamCertificateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IamCertificateId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minimumProtocolVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MinimumProtocolVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sslSupportMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SslSupportMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionViewerCertificate\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontDistributionViewerCertificate? InternalValue
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionViewerCertificate?>();
            set => SetInstanceProperty(value);
        }
    }
}
