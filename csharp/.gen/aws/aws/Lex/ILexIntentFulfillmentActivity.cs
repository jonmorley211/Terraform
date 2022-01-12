using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    [JsiiInterface(nativeType: typeof(ILexIntentFulfillmentActivity), fullyQualifiedName: "aws.lex.LexIntentFulfillmentActivity")]
    public interface ILexIntentFulfillmentActivity
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#type LexIntent#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>code_hook block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#code_hook LexIntent#code_hook}
        /// </remarks>
        [JsiiProperty(name: "codeHook", typeJson: "{\"fqn\":\"aws.lex.LexIntentFulfillmentActivityCodeHook\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lex.ILexIntentFulfillmentActivityCodeHook? CodeHook
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexIntentFulfillmentActivity), fullyQualifiedName: "aws.lex.LexIntentFulfillmentActivity")]
        internal sealed class _Proxy : DeputyBase, aws.Lex.ILexIntentFulfillmentActivity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#type LexIntent#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>code_hook block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#code_hook LexIntent#code_hook}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "codeHook", typeJson: "{\"fqn\":\"aws.lex.LexIntentFulfillmentActivityCodeHook\"}", isOptional: true)]
            public aws.Lex.ILexIntentFulfillmentActivityCodeHook? CodeHook
            {
                get => GetInstanceProperty<aws.Lex.ILexIntentFulfillmentActivityCodeHook?>();
            }
        }
    }
}
