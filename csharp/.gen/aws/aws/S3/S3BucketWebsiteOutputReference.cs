using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiClass(nativeType: typeof(aws.S3.S3BucketWebsiteOutputReference), fullyQualifiedName: "aws.s3.S3BucketWebsiteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class S3BucketWebsiteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public S3BucketWebsiteOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketWebsiteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3BucketWebsiteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetErrorDocument")]
        public virtual void ResetErrorDocument()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndexDocument")]
        public virtual void ResetIndexDocument()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedirectAllRequestsTo")]
        public virtual void ResetRedirectAllRequestsTo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutingRules")]
        public virtual void ResetRoutingRules()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorDocumentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ErrorDocumentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "indexDocumentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IndexDocumentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redirectAllRequestsToInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RedirectAllRequestsToInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routingRulesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoutingRulesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "errorDocument", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorDocument
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "indexDocument", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IndexDocument
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "redirectAllRequestsTo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RedirectAllRequestsTo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "routingRules", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoutingRules
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3.S3BucketWebsite\"}", isOptional: true)]
        public virtual aws.S3.IS3BucketWebsite? InternalValue
        {
            get => GetInstanceProperty<aws.S3.IS3BucketWebsite?>();
            set => SetInstanceProperty(value);
        }
    }
}
