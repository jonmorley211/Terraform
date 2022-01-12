using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    [JsiiClass(nativeType: typeof(aws.Lex.LexBotAliasConversationLogsOutputReference), fullyQualifiedName: "aws.lex.LexBotAliasConversationLogsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LexBotAliasConversationLogsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public LexBotAliasConversationLogsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LexBotAliasConversationLogsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LexBotAliasConversationLogsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetLogSettings")]
        public virtual void ResetLogSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IamRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logSettingsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexBotAliasConversationLogsLogSettings\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Lex.ILexBotAliasConversationLogsLogSettings[]? LogSettingsInput
        {
            get => GetInstanceProperty<aws.Lex.ILexBotAliasConversationLogsLogSettings[]?>();
        }

        [JsiiProperty(name: "iamRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IamRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexBotAliasConversationLogsLogSettings\"},\"kind\":\"array\"}}")]
        public virtual aws.Lex.ILexBotAliasConversationLogsLogSettings[] LogSettings
        {
            get => GetInstanceProperty<aws.Lex.ILexBotAliasConversationLogsLogSettings[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lex.LexBotAliasConversationLogs\"}", isOptional: true)]
        public virtual aws.Lex.ILexBotAliasConversationLogs? InternalValue
        {
            get => GetInstanceProperty<aws.Lex.ILexBotAliasConversationLogs?>();
            set => SetInstanceProperty(value);
        }
    }
}
