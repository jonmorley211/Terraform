using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontOriginRequestPolicyHeadersConfigOutputReference), fullyQualifiedName: "aws.cloudfront.CloudfrontOriginRequestPolicyHeadersConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudfrontOriginRequestPolicyHeadersConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CloudfrontOriginRequestPolicyHeadersConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontOriginRequestPolicyHeadersConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontOriginRequestPolicyHeadersConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHeaders", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyHeadersConfigHeaders\"}}]")]
        public virtual void PutHeaders(aws.Cloudfront.ICloudfrontOriginRequestPolicyHeadersConfigHeaders @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontOriginRequestPolicyHeadersConfigHeaders)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHeaderBehavior")]
        public virtual void ResetHeaderBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHeaders")]
        public virtual void ResetHeaders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "headers", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyHeadersConfigHeadersOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontOriginRequestPolicyHeadersConfigHeadersOutputReference Headers
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontOriginRequestPolicyHeadersConfigHeadersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "headerBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HeaderBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "headersInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyHeadersConfigHeaders\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontOriginRequestPolicyHeadersConfigHeaders? HeadersInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontOriginRequestPolicyHeadersConfigHeaders?>();
        }

        [JsiiProperty(name: "headerBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HeaderBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyHeadersConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontOriginRequestPolicyHeadersConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontOriginRequestPolicyHeadersConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
