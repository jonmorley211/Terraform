using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOriginsOutputReference), fullyQualifiedName: "aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOriginsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOriginsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOriginsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOriginsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOriginsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetItems")]
        public virtual void ResetItems()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "itemsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ItemsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Items
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins? InternalValue
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins?>();
            set => SetInstanceProperty(value);
        }
    }
}
