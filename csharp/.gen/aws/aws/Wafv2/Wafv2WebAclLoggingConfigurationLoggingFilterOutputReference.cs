using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2WebAclLoggingConfigurationLoggingFilterOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Wafv2WebAclLoggingConfigurationLoggingFilterOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Wafv2WebAclLoggingConfigurationLoggingFilterOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclLoggingConfigurationLoggingFilterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclLoggingConfigurationLoggingFilterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilterFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilterFilter[]? FilterInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilterFilter[]?>();
        }

        [JsiiProperty(name: "defaultBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilterFilter\"},\"kind\":\"array\"}}")]
        public virtual aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilterFilter[] Filter
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilterFilter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclLoggingConfigurationLoggingFilter\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilter? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclLoggingConfigurationLoggingFilter?>();
            set => SetInstanceProperty(value);
        }
    }
}
