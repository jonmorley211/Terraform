using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/lex_bot aws_lex_bot}.</summary>
    [JsiiClass(nativeType: typeof(aws.Lex.LexBot), fullyQualifiedName: "aws.lex.LexBot", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lex.LexBotConfig\"}}]")]
    public class LexBot : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/lex_bot aws_lex_bot} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LexBot(Constructs.Construct scope, string id, aws.Lex.ILexBotConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LexBot(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LexBot(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAbortStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lex.LexBotAbortStatement\"}}]")]
        public virtual void PutAbortStatement(aws.Lex.ILexBotAbortStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lex.ILexBotAbortStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClarificationPrompt", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lex.LexBotClarificationPrompt\"}}]")]
        public virtual void PutClarificationPrompt(aws.Lex.ILexBotClarificationPrompt @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lex.ILexBotClarificationPrompt)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lex.LexBotTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Lex.ILexBotTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lex.ILexBotTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClarificationPrompt")]
        public virtual void ResetClarificationPrompt()
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

        [JsiiMethod(name: "resetDetectSentiment")]
        public virtual void ResetDetectSentiment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableModelImprovements")]
        public virtual void ResetEnableModelImprovements()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdleSessionTtlInSeconds")]
        public virtual void ResetIdleSessionTtlInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocale")]
        public virtual void ResetLocale()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNluIntentConfidenceThreshold")]
        public virtual void ResetNluIntentConfidenceThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProcessBehavior")]
        public virtual void ResetProcessBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVoiceId")]
        public virtual void ResetVoiceId()
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
        = GetStaticProperty<string>(typeof(aws.Lex.LexBot))!;

        [JsiiProperty(name: "abortStatement", typeJson: "{\"fqn\":\"aws.lex.LexBotAbortStatementOutputReference\"}")]
        public virtual aws.Lex.LexBotAbortStatementOutputReference AbortStatement
        {
            get => GetInstanceProperty<aws.Lex.LexBotAbortStatementOutputReference>()!;
        }

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

        [JsiiProperty(name: "clarificationPrompt", typeJson: "{\"fqn\":\"aws.lex.LexBotClarificationPromptOutputReference\"}")]
        public virtual aws.Lex.LexBotClarificationPromptOutputReference ClarificationPrompt
        {
            get => GetInstanceProperty<aws.Lex.LexBotClarificationPromptOutputReference>()!;
        }

        [JsiiProperty(name: "createdDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "failureReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FailureReason
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lex.LexBotTimeoutsOutputReference\"}")]
        public virtual aws.Lex.LexBotTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Lex.LexBotTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "abortStatementInput", typeJson: "{\"fqn\":\"aws.lex.LexBotAbortStatement\"}", isOptional: true)]
        public virtual aws.Lex.ILexBotAbortStatement? AbortStatementInput
        {
            get => GetInstanceProperty<aws.Lex.ILexBotAbortStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "childDirectedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ChildDirectedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clarificationPromptInput", typeJson: "{\"fqn\":\"aws.lex.LexBotClarificationPrompt\"}", isOptional: true)]
        public virtual aws.Lex.ILexBotClarificationPrompt? ClarificationPromptInput
        {
            get => GetInstanceProperty<aws.Lex.ILexBotClarificationPrompt?>();
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
        [JsiiProperty(name: "detectSentimentInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DetectSentimentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableModelImprovementsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableModelImprovementsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idleSessionTtlInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IdleSessionTtlInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "intentInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexBotIntent\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Lex.ILexBotIntent[]? IntentInput
        {
            get => GetInstanceProperty<aws.Lex.ILexBotIntent[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocaleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nluIntentConfidenceThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NluIntentConfidenceThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "processBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProcessBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.lex.LexBotTimeouts\"}", isOptional: true)]
        public virtual aws.Lex.ILexBotTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Lex.ILexBotTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "voiceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VoiceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "childDirected", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ChildDirected
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
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

        [JsiiProperty(name: "detectSentiment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DetectSentiment
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableModelImprovements", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnableModelImprovements
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "idleSessionTtlInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IdleSessionTtlInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "intent", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexBotIntent\"},\"kind\":\"array\"}}")]
        public virtual aws.Lex.ILexBotIntent[] Intent
        {
            get => GetInstanceProperty<aws.Lex.ILexBotIntent[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "locale", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Locale
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

        [JsiiProperty(name: "nluIntentConfidenceThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NluIntentConfidenceThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "processBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProcessBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "voiceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VoiceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
