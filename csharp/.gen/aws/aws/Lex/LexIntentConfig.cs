using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    #pragma warning disable CS8618

    /// <summary>AWS Lex.</summary>
    [JsiiByValue(fqn: "aws.lex.LexIntentConfig")]
    public class LexIntentConfig : aws.Lex.ILexIntentConfig
    {
        /// <summary>fulfillment_activity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#fulfillment_activity LexIntent#fulfillment_activity}
        /// </remarks>
        [JsiiProperty(name: "fulfillmentActivity", typeJson: "{\"fqn\":\"aws.lex.LexIntentFulfillmentActivity\"}", isOverride: true)]
        public aws.Lex.ILexIntentFulfillmentActivity FulfillmentActivity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#name LexIntent#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>conclusion_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#conclusion_statement LexIntent#conclusion_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "conclusionStatement", typeJson: "{\"fqn\":\"aws.lex.LexIntentConclusionStatement\"}", isOptional: true, isOverride: true)]
        public aws.Lex.ILexIntentConclusionStatement? ConclusionStatement
        {
            get;
            set;
        }

        /// <summary>confirmation_prompt block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#confirmation_prompt LexIntent#confirmation_prompt}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "confirmationPrompt", typeJson: "{\"fqn\":\"aws.lex.LexIntentConfirmationPrompt\"}", isOptional: true, isOverride: true)]
        public aws.Lex.ILexIntentConfirmationPrompt? ConfirmationPrompt
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#create_version LexIntent#create_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "createVersion", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? CreateVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#description LexIntent#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>dialog_code_hook block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#dialog_code_hook LexIntent#dialog_code_hook}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dialogCodeHook", typeJson: "{\"fqn\":\"aws.lex.LexIntentDialogCodeHook\"}", isOptional: true, isOverride: true)]
        public aws.Lex.ILexIntentDialogCodeHook? DialogCodeHook
        {
            get;
            set;
        }

        /// <summary>follow_up_prompt block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#follow_up_prompt LexIntent#follow_up_prompt}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "followUpPrompt", typeJson: "{\"fqn\":\"aws.lex.LexIntentFollowUpPrompt\"}", isOptional: true, isOverride: true)]
        public aws.Lex.ILexIntentFollowUpPrompt? FollowUpPrompt
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#parent_intent_signature LexIntent#parent_intent_signature}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parentIntentSignature", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ParentIntentSignature
        {
            get;
            set;
        }

        /// <summary>rejection_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#rejection_statement LexIntent#rejection_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rejectionStatement", typeJson: "{\"fqn\":\"aws.lex.LexIntentRejectionStatement\"}", isOptional: true, isOverride: true)]
        public aws.Lex.ILexIntentRejectionStatement? RejectionStatement
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#sample_utterances LexIntent#sample_utterances}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sampleUtterances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SampleUtterances
        {
            get;
            set;
        }

        /// <summary>slot block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#slot LexIntent#slot}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "slot", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexIntentSlot\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Lex.ILexIntentSlot[]? Slot
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_intent#timeouts LexIntent#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lex.LexIntentTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.Lex.ILexIntentTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
