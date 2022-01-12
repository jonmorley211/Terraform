using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    [JsiiInterface(nativeType: typeof(ILexBotAbortStatement), fullyQualifiedName: "aws.lex.LexBotAbortStatement")]
    public interface ILexBotAbortStatement
    {
        /// <summary>message block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_bot#message LexBot#message}
        /// </remarks>
        [JsiiProperty(name: "message", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexBotAbortStatementMessage\"},\"kind\":\"array\"}}")]
        aws.Lex.ILexBotAbortStatementMessage[] Message
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

        [JsiiTypeProxy(nativeType: typeof(ILexBotAbortStatement), fullyQualifiedName: "aws.lex.LexBotAbortStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Lex.ILexBotAbortStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>message block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_bot#message LexBot#message}
            /// </remarks>
            [JsiiProperty(name: "message", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexBotAbortStatementMessage\"},\"kind\":\"array\"}}")]
            public aws.Lex.ILexBotAbortStatementMessage[] Message
            {
                get => GetInstanceProperty<aws.Lex.ILexBotAbortStatementMessage[]>()!;
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
