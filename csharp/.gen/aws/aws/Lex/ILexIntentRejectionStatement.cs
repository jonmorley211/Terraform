using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    [JsiiInterface(nativeType: typeof(ILexIntentRejectionStatement), fullyQualifiedName: "aws.lex.LexIntentRejectionStatement")]
    public interface ILexIntentRejectionStatement
    {
        /// <summary>message block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#message LexIntent#message}
        /// </remarks>
        [JsiiProperty(name: "message", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexIntentRejectionStatementMessage\"},\"kind\":\"array\"}}")]
        aws.Lex.ILexIntentRejectionStatementMessage[] Message
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

        [JsiiTypeProxy(nativeType: typeof(ILexIntentRejectionStatement), fullyQualifiedName: "aws.lex.LexIntentRejectionStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Lex.ILexIntentRejectionStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>message block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#message LexIntent#message}
            /// </remarks>
            [JsiiProperty(name: "message", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexIntentRejectionStatementMessage\"},\"kind\":\"array\"}}")]
            public aws.Lex.ILexIntentRejectionStatementMessage[] Message
            {
                get => GetInstanceProperty<aws.Lex.ILexIntentRejectionStatementMessage[]>()!;
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
