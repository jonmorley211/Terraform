using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lex.LexBotClarificationPrompt")]
    public class LexBotClarificationPrompt : aws.Lex.ILexBotClarificationPrompt
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_bot#max_attempts LexBot#max_attempts}.</summary>
        [JsiiProperty(name: "maxAttempts", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double MaxAttempts
        {
            get;
            set;
        }

        /// <summary>message block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_bot#message LexBot#message}
        /// </remarks>
        [JsiiProperty(name: "message", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexBotClarificationPromptMessage\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Lex.ILexBotClarificationPromptMessage[] Message
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_bot#response_card LexBot#response_card}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseCard", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ResponseCard
        {
            get;
            set;
        }
    }
}
