using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    [JsiiClass(nativeType: typeof(aws.Lex.LexIntentFulfillmentActivityOutputReference), fullyQualifiedName: "aws.lex.LexIntentFulfillmentActivityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LexIntentFulfillmentActivityOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public LexIntentFulfillmentActivityOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LexIntentFulfillmentActivityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LexIntentFulfillmentActivityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCodeHook", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lex.LexIntentFulfillmentActivityCodeHook\"}}]")]
        public virtual void PutCodeHook(aws.Lex.ILexIntentFulfillmentActivityCodeHook @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lex.ILexIntentFulfillmentActivityCodeHook)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCodeHook")]
        public virtual void ResetCodeHook()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "codeHook", typeJson: "{\"fqn\":\"aws.lex.LexIntentFulfillmentActivityCodeHookOutputReference\"}")]
        public virtual aws.Lex.LexIntentFulfillmentActivityCodeHookOutputReference CodeHook
        {
            get => GetInstanceProperty<aws.Lex.LexIntentFulfillmentActivityCodeHookOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeHookInput", typeJson: "{\"fqn\":\"aws.lex.LexIntentFulfillmentActivityCodeHook\"}", isOptional: true)]
        public virtual aws.Lex.ILexIntentFulfillmentActivityCodeHook? CodeHookInput
        {
            get => GetInstanceProperty<aws.Lex.ILexIntentFulfillmentActivityCodeHook?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lex.LexIntentFulfillmentActivity\"}", isOptional: true)]
        public virtual aws.Lex.ILexIntentFulfillmentActivity? InternalValue
        {
            get => GetInstanceProperty<aws.Lex.ILexIntentFulfillmentActivity?>();
            set => SetInstanceProperty(value);
        }
    }
}
