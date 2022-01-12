using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2WebAclRuleActionCountCustomRequestHandlingOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleActionCountCustomRequestHandlingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Wafv2WebAclRuleActionCountCustomRequestHandlingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Wafv2WebAclRuleActionCountCustomRequestHandlingOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleActionCountCustomRequestHandlingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleActionCountCustomRequestHandlingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "insertHeaderInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionCountCustomRequestHandlingInsertHeader\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleActionCountCustomRequestHandlingInsertHeader[]? InsertHeaderInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleActionCountCustomRequestHandlingInsertHeader[]?>();
        }

        [JsiiProperty(name: "insertHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionCountCustomRequestHandlingInsertHeader\"},\"kind\":\"array\"}}")]
        public virtual aws.Wafv2.IWafv2WebAclRuleActionCountCustomRequestHandlingInsertHeader[] InsertHeader
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleActionCountCustomRequestHandlingInsertHeader[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionCountCustomRequestHandling\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleActionCountCustomRequestHandling? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleActionCountCustomRequestHandling?>();
            set => SetInstanceProperty(value);
        }
    }
}
