using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatementOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatementOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatementOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatementOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatementOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatementOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFieldToMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatementFieldToMatch\"}}]")]
        public virtual void PutFieldToMatch(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatementFieldToMatch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatementFieldToMatch)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFieldToMatch")]
        public virtual void ResetFieldToMatch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatementFieldToMatchOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatementFieldToMatchOutputReference FieldToMatch
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatementFieldToMatchOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldToMatchInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatementFieldToMatch\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatementFieldToMatch? FieldToMatchInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatementFieldToMatch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "textTransformationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatementTextTransformation\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatementTextTransformation[]? TextTransformationInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatementTextTransformation[]?>();
        }

        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatementTextTransformation\"},\"kind\":\"array\"}}")]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatementTextTransformation[] TextTransformation
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatementTextTransformation[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatement? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementSqliMatchStatement?>();
            set => SetInstanceProperty(value);
        }
    }
}
