using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2RuleGroupRuleActionBlockCustomResponseOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleActionBlockCustomResponseOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Wafv2RuleGroupRuleActionBlockCustomResponseOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Wafv2RuleGroupRuleActionBlockCustomResponseOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2RuleGroupRuleActionBlockCustomResponseOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2RuleGroupRuleActionBlockCustomResponseOutputReference(DeputyProps props): base(props)
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
        [JsiiProperty(name: "responseHeaderInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionBlockCustomResponseResponseHeader\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleActionBlockCustomResponseResponseHeader[]? ResponseHeaderInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleActionBlockCustomResponseResponseHeader[]?>();
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

        [JsiiProperty(name: "responseHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionBlockCustomResponseResponseHeader\"},\"kind\":\"array\"}}")]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleActionBlockCustomResponseResponseHeader[] ResponseHeader
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleActionBlockCustomResponseResponseHeader[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionBlockCustomResponse\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleActionBlockCustomResponse? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleActionBlockCustomResponse?>();
            set => SetInstanceProperty(value);
        }
    }
}
