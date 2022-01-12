using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Config
{
    [JsiiClass(nativeType: typeof(aws.Config.ConfigConfigRuleSourceOutputReference), fullyQualifiedName: "aws.config.ConfigConfigRuleSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ConfigConfigRuleSourceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public ConfigConfigRuleSourceOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigConfigRuleSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigConfigRuleSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSourceDetail")]
        public virtual void ResetSourceDetail()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "ownerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OwnerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceDetailInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.config.ConfigConfigRuleSourceSourceDetail\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Config.IConfigConfigRuleSourceSourceDetail[]? SourceDetailInput
        {
            get => GetInstanceProperty<aws.Config.IConfigConfigRuleSourceSourceDetail[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceIdentifierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceIdentifierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "owner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Owner
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceDetail", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.config.ConfigConfigRuleSourceSourceDetail\"},\"kind\":\"array\"}}")]
        public virtual aws.Config.IConfigConfigRuleSourceSourceDetail[] SourceDetail
        {
            get => GetInstanceProperty<aws.Config.IConfigConfigRuleSourceSourceDetail[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceIdentifier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.config.ConfigConfigRuleSource\"}", isOptional: true)]
        public virtual aws.Config.IConfigConfigRuleSource? InternalValue
        {
            get => GetInstanceProperty<aws.Config.IConfigConfigRuleSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
