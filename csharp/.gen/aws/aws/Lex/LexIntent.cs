using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/lex_intent aws_lex_intent}.</summary>
    [JsiiClass(nativeType: typeof(aws.Lex.LexIntent), fullyQualifiedName: "aws.lex.LexIntent", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lex.LexIntentConfig\"}}]")]
    public class LexIntent : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/lex_intent aws_lex_intent} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LexIntent(Constructs.Construct scope, string id, aws.Lex.ILexIntentConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LexIntent(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LexIntent(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConclusionStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lex.LexIntentConclusionStatement\"}}]")]
        public virtual void PutConclusionStatement(aws.Lex.ILexIntentConclusionStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lex.ILexIntentConclusionStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putConfirmationPrompt", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lex.LexIntentConfirmationPrompt\"}}]")]
        public virtual void PutConfirmationPrompt(aws.Lex.ILexIntentConfirmationPrompt @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lex.ILexIntentConfirmationPrompt)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDialogCodeHook", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lex.LexIntentDialogCodeHook\"}}]")]
        public virtual void PutDialogCodeHook(aws.Lex.ILexIntentDialogCodeHook @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lex.ILexIntentDialogCodeHook)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFollowUpPrompt", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lex.LexIntentFollowUpPrompt\"}}]")]
        public virtual void PutFollowUpPrompt(aws.Lex.ILexIntentFollowUpPrompt @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lex.ILexIntentFollowUpPrompt)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFulfillmentActivity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lex.LexIntentFulfillmentActivity\"}}]")]
        public virtual void PutFulfillmentActivity(aws.Lex.ILexIntentFulfillmentActivity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lex.ILexIntentFulfillmentActivity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRejectionStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lex.LexIntentRejectionStatement\"}}]")]
        public virtual void PutRejectionStatement(aws.Lex.ILexIntentRejectionStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lex.ILexIntentRejectionStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lex.LexIntentTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Lex.ILexIntentTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lex.ILexIntentTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConclusionStatement")]
        public virtual void ResetConclusionStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfirmationPrompt")]
        public virtual void ResetConfirmationPrompt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateVersion")]
        public virtual void ResetCreateVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDialogCodeHook")]
        public virtual void ResetDialogCodeHook()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFollowUpPrompt")]
        public virtual void ResetFollowUpPrompt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParentIntentSignature")]
        public virtual void ResetParentIntentSignature()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRejectionStatement")]
        public virtual void ResetRejectionStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSampleUtterances")]
        public virtual void ResetSampleUtterances()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSlot")]
        public virtual void ResetSlot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Lex.LexIntent))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "checksum", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Checksum
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "conclusionStatement", typeJson: "{\"fqn\":\"aws.lex.LexIntentConclusionStatementOutputReference\"}")]
        public virtual aws.Lex.LexIntentConclusionStatementOutputReference ConclusionStatement
        {
            get => GetInstanceProperty<aws.Lex.LexIntentConclusionStatementOutputReference>()!;
        }

        [JsiiProperty(name: "confirmationPrompt", typeJson: "{\"fqn\":\"aws.lex.LexIntentConfirmationPromptOutputReference\"}")]
        public virtual aws.Lex.LexIntentConfirmationPromptOutputReference ConfirmationPrompt
        {
            get => GetInstanceProperty<aws.Lex.LexIntentConfirmationPromptOutputReference>()!;
        }

        [JsiiProperty(name: "createdDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dialogCodeHook", typeJson: "{\"fqn\":\"aws.lex.LexIntentDialogCodeHookOutputReference\"}")]
        public virtual aws.Lex.LexIntentDialogCodeHookOutputReference DialogCodeHook
        {
            get => GetInstanceProperty<aws.Lex.LexIntentDialogCodeHookOutputReference>()!;
        }

        [JsiiProperty(name: "followUpPrompt", typeJson: "{\"fqn\":\"aws.lex.LexIntentFollowUpPromptOutputReference\"}")]
        public virtual aws.Lex.LexIntentFollowUpPromptOutputReference FollowUpPrompt
        {
            get => GetInstanceProperty<aws.Lex.LexIntentFollowUpPromptOutputReference>()!;
        }

        [JsiiProperty(name: "fulfillmentActivity", typeJson: "{\"fqn\":\"aws.lex.LexIntentFulfillmentActivityOutputReference\"}")]
        public virtual aws.Lex.LexIntentFulfillmentActivityOutputReference FulfillmentActivity
        {
            get => GetInstanceProperty<aws.Lex.LexIntentFulfillmentActivityOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastUpdatedDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastUpdatedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rejectionStatement", typeJson: "{\"fqn\":\"aws.lex.LexIntentRejectionStatementOutputReference\"}")]
        public virtual aws.Lex.LexIntentRejectionStatementOutputReference RejectionStatement
        {
            get => GetInstanceProperty<aws.Lex.LexIntentRejectionStatementOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lex.LexIntentTimeoutsOutputReference\"}")]
        public virtual aws.Lex.LexIntentTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Lex.LexIntentTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "conclusionStatementInput", typeJson: "{\"fqn\":\"aws.lex.LexIntentConclusionStatement\"}", isOptional: true)]
        public virtual aws.Lex.ILexIntentConclusionStatement? ConclusionStatementInput
        {
            get => GetInstanceProperty<aws.Lex.ILexIntentConclusionStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "confirmationPromptInput", typeJson: "{\"fqn\":\"aws.lex.LexIntentConfirmationPrompt\"}", isOptional: true)]
        public virtual aws.Lex.ILexIntentConfirmationPrompt? ConfirmationPromptInput
        {
            get => GetInstanceProperty<aws.Lex.ILexIntentConfirmationPrompt?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createVersionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CreateVersionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dialogCodeHookInput", typeJson: "{\"fqn\":\"aws.lex.LexIntentDialogCodeHook\"}", isOptional: true)]
        public virtual aws.Lex.ILexIntentDialogCodeHook? DialogCodeHookInput
        {
            get => GetInstanceProperty<aws.Lex.ILexIntentDialogCodeHook?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "followUpPromptInput", typeJson: "{\"fqn\":\"aws.lex.LexIntentFollowUpPrompt\"}", isOptional: true)]
        public virtual aws.Lex.ILexIntentFollowUpPrompt? FollowUpPromptInput
        {
            get => GetInstanceProperty<aws.Lex.ILexIntentFollowUpPrompt?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fulfillmentActivityInput", typeJson: "{\"fqn\":\"aws.lex.LexIntentFulfillmentActivity\"}", isOptional: true)]
        public virtual aws.Lex.ILexIntentFulfillmentActivity? FulfillmentActivityInput
        {
            get => GetInstanceProperty<aws.Lex.ILexIntentFulfillmentActivity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parentIntentSignatureInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ParentIntentSignatureInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rejectionStatementInput", typeJson: "{\"fqn\":\"aws.lex.LexIntentRejectionStatement\"}", isOptional: true)]
        public virtual aws.Lex.ILexIntentRejectionStatement? RejectionStatementInput
        {
            get => GetInstanceProperty<aws.Lex.ILexIntentRejectionStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sampleUtterancesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SampleUtterancesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "slotInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexIntentSlot\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Lex.ILexIntentSlot[]? SlotInput
        {
            get => GetInstanceProperty<aws.Lex.ILexIntentSlot[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.lex.LexIntentTimeouts\"}", isOptional: true)]
        public virtual aws.Lex.ILexIntentTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Lex.ILexIntentTimeouts?>();
        }

        [JsiiProperty(name: "createVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object CreateVersion
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parentIntentSignature", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParentIntentSignature
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sampleUtterances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SampleUtterances
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "slot", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexIntentSlot\"},\"kind\":\"array\"}}")]
        public virtual aws.Lex.ILexIntentSlot[] Slot
        {
            get => GetInstanceProperty<aws.Lex.ILexIntentSlot[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
