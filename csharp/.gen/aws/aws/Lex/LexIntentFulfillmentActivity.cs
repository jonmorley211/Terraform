using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lex.LexIntentFulfillmentActivity")]
    public class LexIntentFulfillmentActivity : aws.Lex.ILexIntentFulfillmentActivity
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#type LexIntent#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        /// <summary>code_hook block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#code_hook LexIntent#code_hook}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "codeHook", typeJson: "{\"fqn\":\"aws.lex.LexIntentFulfillmentActivityCodeHook\"}", isOptional: true, isOverride: true)]
        public aws.Lex.ILexIntentFulfillmentActivityCodeHook? CodeHook
        {
            get;
            set;
        }
    }
}
