using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lex.LexIntentFollowUpPrompt")]
    public class LexIntentFollowUpPrompt : aws.Lex.ILexIntentFollowUpPrompt
    {
        /// <summary>prompt block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#prompt LexIntent#prompt}
        /// </remarks>
        [JsiiProperty(name: "prompt", typeJson: "{\"fqn\":\"aws.lex.LexIntentFollowUpPromptPrompt\"}", isOverride: true)]
        public aws.Lex.ILexIntentFollowUpPromptPrompt Prompt
        {
            get;
            set;
        }

        /// <summary>rejection_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#rejection_statement LexIntent#rejection_statement}
        /// </remarks>
        [JsiiProperty(name: "rejectionStatement", typeJson: "{\"fqn\":\"aws.lex.LexIntentFollowUpPromptRejectionStatement\"}", isOverride: true)]
        public aws.Lex.ILexIntentFollowUpPromptRejectionStatement RejectionStatement
        {
            get;
            set;
        }
    }
}
