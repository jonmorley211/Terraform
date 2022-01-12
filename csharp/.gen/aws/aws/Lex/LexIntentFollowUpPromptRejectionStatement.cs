using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lex.LexIntentFollowUpPromptRejectionStatement")]
    public class LexIntentFollowUpPromptRejectionStatement : aws.Lex.ILexIntentFollowUpPromptRejectionStatement
    {
        /// <summary>message block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#message LexIntent#message}
        /// </remarks>
        [JsiiProperty(name: "message", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexIntentFollowUpPromptRejectionStatementMessage\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Lex.ILexIntentFollowUpPromptRejectionStatementMessage[] Message
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#response_card LexIntent#response_card}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseCard", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ResponseCard
        {
            get;
            set;
        }
    }
}
