using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2WebAclDefaultActionAllowOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2WebAclDefaultActionAllowOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Wafv2WebAclDefaultActionAllowOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Wafv2WebAclDefaultActionAllowOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclDefaultActionAllowOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclDefaultActionAllowOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomRequestHandling", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionAllowCustomRequestHandling\"}}]")]
        public virtual void PutCustomRequestHandling(aws.Wafv2.IWafv2WebAclDefaultActionAllowCustomRequestHandling @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclDefaultActionAllowCustomRequestHandling)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomRequestHandling")]
        public virtual void ResetCustomRequestHandling()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customRequestHandling", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionAllowCustomRequestHandlingOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclDefaultActionAllowCustomRequestHandlingOutputReference CustomRequestHandling
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclDefaultActionAllowCustomRequestHandlingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customRequestHandlingInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionAllowCustomRequestHandling\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclDefaultActionAllowCustomRequestHandling? CustomRequestHandlingInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclDefaultActionAllowCustomRequestHandling?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionAllow\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclDefaultActionAllow? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclDefaultActionAllow?>();
            set => SetInstanceProperty(value);
        }
    }
}
