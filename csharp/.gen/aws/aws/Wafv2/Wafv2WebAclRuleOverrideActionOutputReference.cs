using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2WebAclRuleOverrideActionOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleOverrideActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Wafv2WebAclRuleOverrideActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Wafv2WebAclRuleOverrideActionOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleOverrideActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleOverrideActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleOverrideActionCount\"}}]")]
        public virtual void PutCount(aws.Wafv2.IWafv2WebAclRuleOverrideActionCount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleOverrideActionCount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNone", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleOverrideActionNone\"}}]")]
        public virtual void PutNone(aws.Wafv2.IWafv2WebAclRuleOverrideActionNone @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleOverrideActionNone)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCount")]
        public virtual void ResetCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNone")]
        public virtual void ResetNone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "count", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleOverrideActionCountOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleOverrideActionCountOutputReference Count
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleOverrideActionCountOutputReference>()!;
        }

        [JsiiProperty(name: "none", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleOverrideActionNoneOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleOverrideActionNoneOutputReference None
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleOverrideActionNoneOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "countInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleOverrideActionCount\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleOverrideActionCount? CountInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleOverrideActionCount?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "noneInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleOverrideActionNone\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleOverrideActionNone? NoneInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleOverrideActionNone?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleOverrideAction\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleOverrideAction? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleOverrideAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
