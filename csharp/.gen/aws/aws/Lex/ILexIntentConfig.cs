using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    /// <summary>AWS Lex.</summary>
    [JsiiInterface(nativeType: typeof(ILexIntentConfig), fullyQualifiedName: "aws.lex.LexIntentConfig")]
    public interface ILexIntentConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>fulfillment_activity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#fulfillment_activity LexIntent#fulfillment_activity}
        /// </remarks>
        [JsiiProperty(name: "fulfillmentActivity", typeJson: "{\"fqn\":\"aws.lex.LexIntentFulfillmentActivity\"}")]
        aws.Lex.ILexIntentFulfillmentActivity FulfillmentActivity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#name LexIntent#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>conclusion_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#conclusion_statement LexIntent#conclusion_statement}
        /// </remarks>
        [JsiiProperty(name: "conclusionStatement", typeJson: "{\"fqn\":\"aws.lex.LexIntentConclusionStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lex.ILexIntentConclusionStatement? ConclusionStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>confirmation_prompt block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#confirmation_prompt LexIntent#confirmation_prompt}
        /// </remarks>
        [JsiiProperty(name: "confirmationPrompt", typeJson: "{\"fqn\":\"aws.lex.LexIntentConfirmationPrompt\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lex.ILexIntentConfirmationPrompt? ConfirmationPrompt
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#create_version LexIntent#create_version}.</summary>
        [JsiiProperty(name: "createVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CreateVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#description LexIntent#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>dialog_code_hook block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#dialog_code_hook LexIntent#dialog_code_hook}
        /// </remarks>
        [JsiiProperty(name: "dialogCodeHook", typeJson: "{\"fqn\":\"aws.lex.LexIntentDialogCodeHook\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lex.ILexIntentDialogCodeHook? DialogCodeHook
        {
            get
            {
                return null;
            }
        }

        /// <summary>follow_up_prompt block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#follow_up_prompt LexIntent#follow_up_prompt}
        /// </remarks>
        [JsiiProperty(name: "followUpPrompt", typeJson: "{\"fqn\":\"aws.lex.LexIntentFollowUpPrompt\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lex.ILexIntentFollowUpPrompt? FollowUpPrompt
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#parent_intent_signature LexIntent#parent_intent_signature}.</summary>
        [JsiiProperty(name: "parentIntentSignature", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ParentIntentSignature
        {
            get
            {
                return null;
            }
        }

        /// <summary>rejection_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#rejection_statement LexIntent#rejection_statement}
        /// </remarks>
        [JsiiProperty(name: "rejectionStatement", typeJson: "{\"fqn\":\"aws.lex.LexIntentRejectionStatement\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lex.ILexIntentRejectionStatement? RejectionStatement
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#sample_utterances LexIntent#sample_utterances}.</summary>
        [JsiiProperty(name: "sampleUtterances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SampleUtterances
        {
            get
            {
                return null;
            }
        }

        /// <summary>slot block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#slot LexIntent#slot}
        /// </remarks>
        [JsiiProperty(name: "slot", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexIntentSlot\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lex.ILexIntentSlot[]? Slot
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#timeouts LexIntent#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lex.LexIntentTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lex.ILexIntentTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Lex.</summary>
        [JsiiTypeProxy(nativeType: typeof(ILexIntentConfig), fullyQualifiedName: "aws.lex.LexIntentConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Lex.ILexIntentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>fulfillment_activity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#fulfillment_activity LexIntent#fulfillment_activity}
            /// </remarks>
            [JsiiProperty(name: "fulfillmentActivity", typeJson: "{\"fqn\":\"aws.lex.LexIntentFulfillmentActivity\"}")]
            public aws.Lex.ILexIntentFulfillmentActivity FulfillmentActivity
            {
                get => GetInstanceProperty<aws.Lex.ILexIntentFulfillmentActivity>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#name LexIntent#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>conclusion_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#conclusion_statement LexIntent#conclusion_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "conclusionStatement", typeJson: "{\"fqn\":\"aws.lex.LexIntentConclusionStatement\"}", isOptional: true)]
            public aws.Lex.ILexIntentConclusionStatement? ConclusionStatement
            {
                get => GetInstanceProperty<aws.Lex.ILexIntentConclusionStatement?>();
            }

            /// <summary>confirmation_prompt block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#confirmation_prompt LexIntent#confirmation_prompt}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "confirmationPrompt", typeJson: "{\"fqn\":\"aws.lex.LexIntentConfirmationPrompt\"}", isOptional: true)]
            public aws.Lex.ILexIntentConfirmationPrompt? ConfirmationPrompt
            {
                get => GetInstanceProperty<aws.Lex.ILexIntentConfirmationPrompt?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#create_version LexIntent#create_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "createVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CreateVersion
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#description LexIntent#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>dialog_code_hook block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#dialog_code_hook LexIntent#dialog_code_hook}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dialogCodeHook", typeJson: "{\"fqn\":\"aws.lex.LexIntentDialogCodeHook\"}", isOptional: true)]
            public aws.Lex.ILexIntentDialogCodeHook? DialogCodeHook
            {
                get => GetInstanceProperty<aws.Lex.ILexIntentDialogCodeHook?>();
            }

            /// <summary>follow_up_prompt block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#follow_up_prompt LexIntent#follow_up_prompt}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "followUpPrompt", typeJson: "{\"fqn\":\"aws.lex.LexIntentFollowUpPrompt\"}", isOptional: true)]
            public aws.Lex.ILexIntentFollowUpPrompt? FollowUpPrompt
            {
                get => GetInstanceProperty<aws.Lex.ILexIntentFollowUpPrompt?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#parent_intent_signature LexIntent#parent_intent_signature}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parentIntentSignature", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ParentIntentSignature
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>rejection_statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#rejection_statement LexIntent#rejection_statement}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rejectionStatement", typeJson: "{\"fqn\":\"aws.lex.LexIntentRejectionStatement\"}", isOptional: true)]
            public aws.Lex.ILexIntentRejectionStatement? RejectionStatement
            {
                get => GetInstanceProperty<aws.Lex.ILexIntentRejectionStatement?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#sample_utterances LexIntent#sample_utterances}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sampleUtterances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SampleUtterances
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>slot block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#slot LexIntent#slot}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "slot", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexIntentSlot\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Lex.ILexIntentSlot[]? Slot
            {
                get => GetInstanceProperty<aws.Lex.ILexIntentSlot[]?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#timeouts LexIntent#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lex.LexIntentTimeouts\"}", isOptional: true)]
            public aws.Lex.ILexIntentTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.Lex.ILexIntentTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
