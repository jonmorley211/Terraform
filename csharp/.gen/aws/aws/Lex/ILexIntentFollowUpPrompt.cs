using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    [JsiiInterface(nativeType: typeof(ILexIntentFollowUpPrompt), fullyQualifiedName: "aws.lex.LexIntentFollowUpPrompt")]
    public interface ILexIntentFollowUpPrompt
    {
        /// <summary>prompt block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#prompt LexIntent#prompt}
        /// </remarks>
        [JsiiProperty(name: "prompt", typeJson: "{\"fqn\":\"aws.lex.LexIntentFollowUpPromptPrompt\"}")]
        aws.Lex.ILexIntentFollowUpPromptPrompt Prompt
        {
            get;
        }

        /// <summary>rejection_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#rejection_statement LexIntent#rejection_statement}
        /// </remarks>
        [JsiiProperty(name: "rejectionStatement", typeJson: "{\"fqn\":\"aws.lex.LexIntentFollowUpPromptRejectionStatement\"}")]
        aws.Lex.ILexIntentFollowUpPromptRejectionStatement RejectionStatement
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILexIntentFollowUpPrompt), fullyQualifiedName: "aws.lex.LexIntentFollowUpPrompt")]
        internal sealed class _Proxy : DeputyBase, aws.Lex.ILexIntentFollowUpPrompt
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>prompt block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#prompt LexIntent#prompt}
            /// </remarks>
            [JsiiProperty(name: "prompt", typeJson: "{\"fqn\":\"aws.lex.LexIntentFollowUpPromptPrompt\"}")]
            public aws.Lex.ILexIntentFollowUpPromptPrompt Prompt
            {
                get => GetInstanceProperty<aws.Lex.ILexIntentFollowUpPromptPrompt>()!;
            }

            /// <summary>rejection_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#rejection_statement LexIntent#rejection_statement}
            /// </remarks>
            [JsiiProperty(name: "rejectionStatement", typeJson: "{\"fqn\":\"aws.lex.LexIntentFollowUpPromptRejectionStatement\"}")]
            public aws.Lex.ILexIntentFollowUpPromptRejectionStatement RejectionStatement
            {
                get => GetInstanceProperty<aws.Lex.ILexIntentFollowUpPromptRejectionStatement>()!;
            }
        }
    }
}
