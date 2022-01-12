using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    [JsiiInterface(nativeType: typeof(ILexBotClarificationPrompt), fullyQualifiedName: "aws.lex.LexBotClarificationPrompt")]
    public interface ILexBotClarificationPrompt
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_bot#max_attempts LexBot#max_attempts}.</summary>
        [JsiiProperty(name: "maxAttempts", typeJson: "{\"primitive\":\"number\"}")]
        double MaxAttempts
        {
            get;
        }

        /// <summary>message block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_bot#message LexBot#message}
        /// </remarks>
        [JsiiProperty(name: "message", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexBotClarificationPromptMessage\"},\"kind\":\"array\"}}")]
        aws.Lex.ILexBotClarificationPromptMessage[] Message
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_bot#response_card LexBot#response_card}.</summary>
        [JsiiProperty(name: "responseCard", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResponseCard
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexBotClarificationPrompt), fullyQualifiedName: "aws.lex.LexBotClarificationPrompt")]
        internal sealed class _Proxy : DeputyBase, aws.Lex.ILexBotClarificationPrompt
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_bot#max_attempts LexBot#max_attempts}.</summary>
            [JsiiProperty(name: "maxAttempts", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxAttempts
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>message block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_bot#message LexBot#message}
            /// </remarks>
            [JsiiProperty(name: "message", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexBotClarificationPromptMessage\"},\"kind\":\"array\"}}")]
            public aws.Lex.ILexBotClarificationPromptMessage[] Message
            {
                get => GetInstanceProperty<aws.Lex.ILexBotClarificationPromptMessage[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_bot#response_card LexBot#response_card}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "responseCard", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResponseCard
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
