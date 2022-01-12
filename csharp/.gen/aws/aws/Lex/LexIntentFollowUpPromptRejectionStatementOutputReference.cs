using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    [JsiiClass(nativeType: typeof(aws.Lex.LexIntentFollowUpPromptRejectionStatementOutputReference), fullyQualifiedName: "aws.lex.LexIntentFollowUpPromptRejectionStatementOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LexIntentFollowUpPromptRejectionStatementOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public LexIntentFollowUpPromptRejectionStatementOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LexIntentFollowUpPromptRejectionStatementOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LexIntentFollowUpPromptRejectionStatementOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetResponseCard")]
        public virtual void ResetResponseCard()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "messageInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexIntentFollowUpPromptRejectionStatementMessage\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Lex.ILexIntentFollowUpPromptRejectionStatementMessage[]? MessageInput
        {
            get => GetInstanceProperty<aws.Lex.ILexIntentFollowUpPromptRejectionStatementMessage[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseCardInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResponseCardInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "message", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexIntentFollowUpPromptRejectionStatementMessage\"},\"kind\":\"array\"}}")]
        public virtual aws.Lex.ILexIntentFollowUpPromptRejectionStatementMessage[] Message
        {
            get => GetInstanceProperty<aws.Lex.ILexIntentFollowUpPromptRejectionStatementMessage[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "responseCard", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseCard
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lex.LexIntentFollowUpPromptRejectionStatement\"}", isOptional: true)]
        public virtual aws.Lex.ILexIntentFollowUpPromptRejectionStatement? InternalValue
        {
            get => GetInstanceProperty<aws.Lex.ILexIntentFollowUpPromptRejectionStatement?>();
            set => SetInstanceProperty(value);
        }
    }
}
