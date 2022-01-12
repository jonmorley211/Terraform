using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2WebAclDefaultActionBlockCustomResponseOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2WebAclDefaultActionBlockCustomResponseOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Wafv2WebAclDefaultActionBlockCustomResponseOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Wafv2WebAclDefaultActionBlockCustomResponseOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclDefaultActionBlockCustomResponseOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclDefaultActionBlockCustomResponseOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCustomResponseBodyKey")]
        public virtual void ResetCustomResponseBodyKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResponseHeader")]
        public virtual void ResetResponseHeader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "customResponseBodyKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomResponseBodyKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseCodeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ResponseCodeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseHeaderInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionBlockCustomResponseResponseHeader\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclDefaultActionBlockCustomResponseResponseHeader[]? ResponseHeaderInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclDefaultActionBlockCustomResponseResponseHeader[]?>();
        }

        [JsiiProperty(name: "customResponseBodyKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomResponseBodyKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ResponseCode
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "responseHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionBlockCustomResponseResponseHeader\"},\"kind\":\"array\"}}")]
        public virtual aws.Wafv2.IWafv2WebAclDefaultActionBlockCustomResponseResponseHeader[] ResponseHeader
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclDefaultActionBlockCustomResponseResponseHeader[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionBlockCustomResponse\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclDefaultActionBlockCustomResponse? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclDefaultActionBlockCustomResponse?>();
            set => SetInstanceProperty(value);
        }
    }
}
