using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lex.LexBotIntent")]
    public class LexBotIntent : aws.Lex.ILexBotIntent
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_bot#intent_name LexBot#intent_name}.</summary>
        [JsiiProperty(name: "intentName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string IntentName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_bot#intent_version LexBot#intent_version}.</summary>
        [JsiiProperty(name: "intentVersion", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string IntentVersion
        {
            get;
            set;
        }
    }
}
