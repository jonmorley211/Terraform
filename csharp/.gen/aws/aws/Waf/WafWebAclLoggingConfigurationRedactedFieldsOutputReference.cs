using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    [JsiiClass(nativeType: typeof(aws.Waf.WafWebAclLoggingConfigurationRedactedFieldsOutputReference), fullyQualifiedName: "aws.waf.WafWebAclLoggingConfigurationRedactedFieldsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class WafWebAclLoggingConfigurationRedactedFieldsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public WafWebAclLoggingConfigurationRedactedFieldsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafWebAclLoggingConfigurationRedactedFieldsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafWebAclLoggingConfigurationRedactedFieldsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "fieldToMatchInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.waf.WafWebAclLoggingConfigurationRedactedFieldsFieldToMatch\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Waf.IWafWebAclLoggingConfigurationRedactedFieldsFieldToMatch[]? FieldToMatchInput
        {
            get => GetInstanceProperty<aws.Waf.IWafWebAclLoggingConfigurationRedactedFieldsFieldToMatch[]?>();
        }

        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.waf.WafWebAclLoggingConfigurationRedactedFieldsFieldToMatch\"},\"kind\":\"array\"}}")]
        public virtual aws.Waf.IWafWebAclLoggingConfigurationRedactedFieldsFieldToMatch[] FieldToMatch
        {
            get => GetInstanceProperty<aws.Waf.IWafWebAclLoggingConfigurationRedactedFieldsFieldToMatch[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.waf.WafWebAclLoggingConfigurationRedactedFields\"}", isOptional: true)]
        public virtual aws.Waf.IWafWebAclLoggingConfigurationRedactedFields? InternalValue
        {
            get => GetInstanceProperty<aws.Waf.IWafWebAclLoggingConfigurationRedactedFields?>();
            set => SetInstanceProperty(value);
        }
    }
}
