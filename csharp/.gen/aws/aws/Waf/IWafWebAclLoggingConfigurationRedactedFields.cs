using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    [JsiiInterface(nativeType: typeof(IWafWebAclLoggingConfigurationRedactedFields), fullyQualifiedName: "aws.waf.WafWebAclLoggingConfigurationRedactedFields")]
    public interface IWafWebAclLoggingConfigurationRedactedFields
    {
        /// <summary>field_to_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#field_to_match WafWebAcl#field_to_match}
        /// </remarks>
        [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.waf.WafWebAclLoggingConfigurationRedactedFieldsFieldToMatch\"},\"kind\":\"array\"}}")]
        aws.Waf.IWafWebAclLoggingConfigurationRedactedFieldsFieldToMatch[] FieldToMatch
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafWebAclLoggingConfigurationRedactedFields), fullyQualifiedName: "aws.waf.WafWebAclLoggingConfigurationRedactedFields")]
        internal sealed class _Proxy : DeputyBase, aws.Waf.IWafWebAclLoggingConfigurationRedactedFields
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_to_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/waf_web_acl#field_to_match WafWebAcl#field_to_match}
            /// </remarks>
            [JsiiProperty(name: "fieldToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.waf.WafWebAclLoggingConfigurationRedactedFieldsFieldToMatch\"},\"kind\":\"array\"}}")]
            public aws.Waf.IWafWebAclLoggingConfigurationRedactedFieldsFieldToMatch[] FieldToMatch
            {
                get => GetInstanceProperty<aws.Waf.IWafWebAclLoggingConfigurationRedactedFieldsFieldToMatch[]>()!;
            }
        }
    }
}
