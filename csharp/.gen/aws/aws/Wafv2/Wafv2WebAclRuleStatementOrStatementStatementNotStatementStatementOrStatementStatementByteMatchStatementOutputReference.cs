using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatementOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatementOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatementOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatementOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatementOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatementOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFieldToMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatementFieldToMatch\"}}]")]
        public virtual void PutFieldToMatch(aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatementFieldToMatch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatementFieldToMatch)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFieldToMatch")]
        public virtual void ResetFieldToMatch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatementFieldToMatchOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatementFieldToMatchOutputReference FieldToMatch
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatementFieldToMatchOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldToMatchInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatementFieldToMatch\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatementFieldToMatch? FieldToMatchInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatementFieldToMatch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "positionalConstraintInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PositionalConstraintInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "searchStringInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SearchStringInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "textTransformationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatementTextTransformation\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatementTextTransformation[]? TextTransformationInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatementTextTransformation[]?>();
        }

        [JsiiProperty(name: "positionalConstraint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PositionalConstraint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "searchString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SearchString
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "textTransformation", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatementTextTransformation\"},\"kind\":\"array\"}}")]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatementTextTransformation[] TextTransformation
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatementTextTransformation[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatement? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementNotStatementStatementOrStatementStatementByteMatchStatement?>();
            set => SetInstanceProperty(value);
        }
    }
}
