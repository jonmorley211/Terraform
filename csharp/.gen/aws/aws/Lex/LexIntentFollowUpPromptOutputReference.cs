using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    [JsiiClass(nativeType: typeof(aws.Lex.LexIntentFollowUpPromptOutputReference), fullyQualifiedName: "aws.lex.LexIntentFollowUpPromptOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LexIntentFollowUpPromptOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public LexIntentFollowUpPromptOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LexIntentFollowUpPromptOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LexIntentFollowUpPromptOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPrompt", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lex.LexIntentFollowUpPromptPrompt\"}}]")]
        public virtual void PutPrompt(aws.Lex.ILexIntentFollowUpPromptPrompt @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lex.ILexIntentFollowUpPromptPrompt)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRejectionStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lex.LexIntentFollowUpPromptRejectionStatement\"}}]")]
        public virtual void PutRejectionStatement(aws.Lex.ILexIntentFollowUpPromptRejectionStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lex.ILexIntentFollowUpPromptRejectionStatement)}, new object[]{@value});
        }

        [JsiiProperty(name: "prompt", typeJson: "{\"fqn\":\"aws.lex.LexIntentFollowUpPromptPromptOutputReference\"}")]
        public virtual aws.Lex.LexIntentFollowUpPromptPromptOutputReference Prompt
        {
            get => GetInstanceProperty<aws.Lex.LexIntentFollowUpPromptPromptOutputReference>()!;
        }

        [JsiiProperty(name: "rejectionStatement", typeJson: "{\"fqn\":\"aws.lex.LexIntentFollowUpPromptRejectionStatementOutputReference\"}")]
        public virtual aws.Lex.LexIntentFollowUpPromptRejectionStatementOutputReference RejectionStatement
        {
            get => GetInstanceProperty<aws.Lex.LexIntentFollowUpPromptRejectionStatementOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "promptInput", typeJson: "{\"fqn\":\"aws.lex.LexIntentFollowUpPromptPrompt\"}", isOptional: true)]
        public virtual aws.Lex.ILexIntentFollowUpPromptPrompt? PromptInput
        {
            get => GetInstanceProperty<aws.Lex.ILexIntentFollowUpPromptPrompt?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rejectionStatementInput", typeJson: "{\"fqn\":\"aws.lex.LexIntentFollowUpPromptRejectionStatement\"}", isOptional: true)]
        public virtual aws.Lex.ILexIntentFollowUpPromptRejectionStatement? RejectionStatementInput
        {
            get => GetInstanceProperty<aws.Lex.ILexIntentFollowUpPromptRejectionStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lex.LexIntentFollowUpPrompt\"}", isOptional: true)]
        public virtual aws.Lex.ILexIntentFollowUpPrompt? InternalValue
        {
            get => GetInstanceProperty<aws.Lex.ILexIntentFollowUpPrompt?>();
            set => SetInstanceProperty(value);
        }
    }
}
