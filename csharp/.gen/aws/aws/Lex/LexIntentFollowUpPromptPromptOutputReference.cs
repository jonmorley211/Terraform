using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    [JsiiClass(nativeType: typeof(aws.Lex.LexIntentFollowUpPromptPromptOutputReference), fullyQualifiedName: "aws.lex.LexIntentFollowUpPromptPromptOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LexIntentFollowUpPromptPromptOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public LexIntentFollowUpPromptPromptOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LexIntentFollowUpPromptPromptOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LexIntentFollowUpPromptPromptOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetResponseCard")]
        public virtual void ResetResponseCard()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxAttemptsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxAttemptsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "messageInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexIntentFollowUpPromptPromptMessage\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Lex.ILexIntentFollowUpPromptPromptMessage[]? MessageInput
        {
            get => GetInstanceProperty<aws.Lex.ILexIntentFollowUpPromptPromptMessage[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "responseCardInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResponseCardInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "maxAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxAttempts
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "message", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexIntentFollowUpPromptPromptMessage\"},\"kind\":\"array\"}}")]
        public virtual aws.Lex.ILexIntentFollowUpPromptPromptMessage[] Message
        {
            get => GetInstanceProperty<aws.Lex.ILexIntentFollowUpPromptPromptMessage[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "responseCard", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResponseCard
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lex.LexIntentFollowUpPromptPrompt\"}", isOptional: true)]
        public virtual aws.Lex.ILexIntentFollowUpPromptPrompt? InternalValue
        {
            get => GetInstanceProperty<aws.Lex.ILexIntentFollowUpPromptPrompt?>();
            set => SetInstanceProperty(value);
        }
    }
}
