using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution aws_cloudfront_distribution}.</summary>
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontDistribution), fullyQualifiedName: "aws.cloudfront.CloudfrontDistribution", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionConfig\"}}]")]
    public class CloudfrontDistribution : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution aws_cloudfront_distribution} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CloudfrontDistribution(Constructs.Construct scope, string id, aws.Cloudfront.ICloudfrontDistributionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistribution(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontDistribution(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDefaultCacheBehavior", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehavior\"}}]")]
        public virtual void PutDefaultCacheBehavior(aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehavior @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehavior)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoggingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionLoggingConfig\"}}]")]
        public virtual void PutLoggingConfig(aws.Cloudfront.ICloudfrontDistributionLoggingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontDistributionLoggingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRestrictions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionRestrictions\"}}]")]
        public virtual void PutRestrictions(aws.Cloudfront.ICloudfrontDistributionRestrictions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontDistributionRestrictions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putViewerCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionViewerCertificate\"}}]")]
        public virtual void PutViewerCertificate(aws.Cloudfront.ICloudfrontDistributionViewerCertificate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontDistributionViewerCertificate)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAliases")]
        public virtual void ResetAliases()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComment")]
        public virtual void ResetComment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomErrorResponse")]
        public virtual void ResetCustomErrorResponse()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultRootObject")]
        public virtual void ResetDefaultRootObject()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpVersion")]
        public virtual void ResetHttpVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsIpv6Enabled")]
        public virtual void ResetIsIpv6Enabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoggingConfig")]
        public virtual void ResetLoggingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrderedCacheBehavior")]
        public virtual void ResetOrderedCacheBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOriginGroup")]
        public virtual void ResetOriginGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPriceClass")]
        public virtual void ResetPriceClass()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetainOnDelete")]
        public virtual void ResetRetainOnDelete()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWaitForDeployment")]
        public virtual void ResetWaitForDeployment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebAclId")]
        public virtual void ResetWebAclId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "trustedKeyGroups", returnsJson: "{\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionTrustedKeyGroups\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Cloudfront.CloudfrontDistributionTrustedKeyGroups TrustedKeyGroups(string index)
        {
            return InvokeInstanceMethod<aws.Cloudfront.CloudfrontDistributionTrustedKeyGroups>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "trustedSigners", returnsJson: "{\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionTrustedSigners\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Cloudfront.CloudfrontDistributionTrustedSigners TrustedSigners(string index)
        {
            return InvokeInstanceMethod<aws.Cloudfront.CloudfrontDistributionTrustedSigners>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Cloudfront.CloudfrontDistribution))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "callerReference", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CallerReference
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultCacheBehavior", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehaviorOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontDistributionDefaultCacheBehaviorOutputReference DefaultCacheBehavior
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontDistributionDefaultCacheBehaviorOutputReference>()!;
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "etag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Etag
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostedZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostedZoneId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inProgressValidationBatches", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InProgressValidationBatches
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "lastModifiedTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModifiedTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "loggingConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionLoggingConfigOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontDistributionLoggingConfigOutputReference LoggingConfig
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontDistributionLoggingConfigOutputReference>()!;
        }

        [JsiiProperty(name: "restrictions", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionRestrictionsOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontDistributionRestrictionsOutputReference Restrictions
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontDistributionRestrictionsOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "viewerCertificate", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionViewerCertificateOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontDistributionViewerCertificateOutputReference ViewerCertificate
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontDistributionViewerCertificateOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "aliasesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AliasesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CommentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customErrorResponseInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionCustomErrorResponse\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontDistributionCustomErrorResponse[]? CustomErrorResponseInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionCustomErrorResponse[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultCacheBehaviorInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionDefaultCacheBehavior\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehavior? DefaultCacheBehaviorInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionDefaultCacheBehavior?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultRootObjectInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultRootObjectInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HttpVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isIpv6EnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsIpv6EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingConfigInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionLoggingConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontDistributionLoggingConfig? LoggingConfigInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionLoggingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orderedCacheBehaviorInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrderedCacheBehavior\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehavior[]? OrderedCacheBehaviorInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehavior[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originGroupInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginGroup\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontDistributionOriginGroup[]? OriginGroupInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionOriginGroup[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "originInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrigin\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontDistributionOrigin[]? OriginInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionOrigin[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priceClassInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PriceClassInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restrictionsInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionRestrictions\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontDistributionRestrictions? RestrictionsInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionRestrictions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retainOnDeleteInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RetainOnDeleteInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsAllInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "viewerCertificateInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionViewerCertificate\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontDistributionViewerCertificate? ViewerCertificateInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionViewerCertificate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitForDeploymentInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? WaitForDeploymentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webAclIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WebAclIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "aliases", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Aliases
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "comment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Comment
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customErrorResponse", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionCustomErrorResponse\"},\"kind\":\"array\"}}")]
        public virtual aws.Cloudfront.ICloudfrontDistributionCustomErrorResponse[] CustomErrorResponse
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionCustomErrorResponse[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultRootObject", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultRootObject
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HttpVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isIpv6Enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object IsIpv6Enabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "orderedCacheBehavior", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrderedCacheBehavior\"},\"kind\":\"array\"}}")]
        public virtual aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehavior[] OrderedCacheBehavior
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionOrderedCacheBehavior[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "origin", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOrigin\"},\"kind\":\"array\"}}")]
        public virtual aws.Cloudfront.ICloudfrontDistributionOrigin[] Origin
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionOrigin[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "originGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginGroup\"},\"kind\":\"array\"}}")]
        public virtual aws.Cloudfront.ICloudfrontDistributionOriginGroup[] OriginGroup
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontDistributionOriginGroup[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "priceClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PriceClass
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retainOnDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object RetainOnDelete
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object Tags
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object TagsAll
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "waitForDeployment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object WaitForDeployment
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "webAclId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebAclId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
