using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lex.LexIntentFulfillmentActivityCodeHook")]
    public class LexIntentFulfillmentActivityCodeHook : aws.Lex.ILexIntentFulfillmentActivityCodeHook
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#message_version LexIntent#message_version}.</summary>
        [JsiiProperty(name: "messageVersion", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string MessageVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#uri LexIntent#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Uri
        {
            get;
            set;
        }
    }
}
