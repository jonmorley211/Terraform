using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    [JsiiInterface(nativeType: typeof(ILexIntentConfirmationPrompt), fullyQualifiedName: "aws.lex.LexIntentConfirmationPrompt")]
    public interface ILexIntentConfirmationPrompt
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#max_attempts LexIntent#max_attempts}.</summary>
        [JsiiProperty(name: "maxAttempts", typeJson: "{\"primitive\":\"number\"}")]
        double MaxAttempts
        {
            get;
        }

        /// <summary>message block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#message LexIntent#message}
        /// </remarks>
        [JsiiProperty(name: "message", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexIntentConfirmationPromptMessage\"},\"kind\":\"array\"}}")]
        aws.Lex.ILexIntentConfirmationPromptMessage[] Message
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#response_card LexIntent#response_card}.</summary>
        [JsiiProperty(name: "responseCard", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResponseCard
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexIntentConfirmationPrompt), fullyQualifiedName: "aws.lex.LexIntentConfirmationPrompt")]
        internal sealed class _Proxy : DeputyBase, aws.Lex.ILexIntentConfirmationPrompt
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#max_attempts LexIntent#max_attempts}.</summary>
            [JsiiProperty(name: "maxAttempts", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxAttempts
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>message block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#message LexIntent#message}
            /// </remarks>
            [JsiiProperty(name: "message", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexIntentConfirmationPromptMessage\"},\"kind\":\"array\"}}")]
            public aws.Lex.ILexIntentConfirmationPromptMessage[] Message
            {
                get => GetInstanceProperty<aws.Lex.ILexIntentConfirmationPromptMessage[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#response_card LexIntent#response_card}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "responseCard", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResponseCard
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
