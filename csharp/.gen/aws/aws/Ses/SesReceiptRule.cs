using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule aws_ses_receipt_rule}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ses.SesReceiptRule), fullyQualifiedName: "aws.ses.SesReceiptRule", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ses.SesReceiptRuleConfig\"}}]")]
    public class SesReceiptRule : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule aws_ses_receipt_rule} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SesReceiptRule(Constructs.Construct scope, string id, aws.Ses.ISesReceiptRuleConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SesReceiptRule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SesReceiptRule(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAddHeaderAction")]
        public virtual void ResetAddHeaderAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAfter")]
        public virtual void ResetAfter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBounceAction")]
        public virtual void ResetBounceAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambdaAction")]
        public virtual void ResetLambdaAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecipients")]
        public virtual void ResetRecipients()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Action")]
        public virtual void ResetS3Action()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScanEnabled")]
        public virtual void ResetScanEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnsAction")]
        public virtual void ResetSnsAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStopAction")]
        public virtual void ResetStopAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTlsPolicy")]
        public virtual void ResetTlsPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkmailAction")]
        public virtual void ResetWorkmailAction()
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
        = GetStaticProperty<string>(typeof(aws.Ses.SesReceiptRule))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "addHeaderActionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleAddHeaderAction\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ses.ISesReceiptRuleAddHeaderAction[]? AddHeaderActionInput
        {
            get => GetInstanceProperty<aws.Ses.ISesReceiptRuleAddHeaderAction[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "afterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AfterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bounceActionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleBounceAction\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ses.ISesReceiptRuleBounceAction[]? BounceActionInput
        {
            get => GetInstanceProperty<aws.Ses.ISesReceiptRuleBounceAction[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaActionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleLambdaAction\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ses.ISesReceiptRuleLambdaAction[]? LambdaActionInput
        {
            get => GetInstanceProperty<aws.Ses.ISesReceiptRuleLambdaAction[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recipientsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? RecipientsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleSetNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuleSetNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3ActionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleS3Action\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ses.ISesReceiptRuleS3Action[]? S3ActionInput
        {
            get => GetInstanceProperty<aws.Ses.ISesReceiptRuleS3Action[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scanEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ScanEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snsActionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleSnsAction\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ses.ISesReceiptRuleSnsAction[]? SnsActionInput
        {
            get => GetInstanceProperty<aws.Ses.ISesReceiptRuleSnsAction[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stopActionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleStopAction\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ses.ISesReceiptRuleStopAction[]? StopActionInput
        {
            get => GetInstanceProperty<aws.Ses.ISesReceiptRuleStopAction[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TlsPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workmailActionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleWorkmailAction\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ses.ISesReceiptRuleWorkmailAction[]? WorkmailActionInput
        {
            get => GetInstanceProperty<aws.Ses.ISesReceiptRuleWorkmailAction[]?>();
        }

        [JsiiProperty(name: "addHeaderAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleAddHeaderAction\"},\"kind\":\"array\"}}")]
        public virtual aws.Ses.ISesReceiptRuleAddHeaderAction[] AddHeaderAction
        {
            get => GetInstanceProperty<aws.Ses.ISesReceiptRuleAddHeaderAction[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "after", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string After
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bounceAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleBounceAction\"},\"kind\":\"array\"}}")]
        public virtual aws.Ses.ISesReceiptRuleBounceAction[] BounceAction
        {
            get => GetInstanceProperty<aws.Ses.ISesReceiptRuleBounceAction[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lambdaAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleLambdaAction\"},\"kind\":\"array\"}}")]
        public virtual aws.Ses.ISesReceiptRuleLambdaAction[] LambdaAction
        {
            get => GetInstanceProperty<aws.Ses.ISesReceiptRuleLambdaAction[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "recipients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Recipients
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ruleSetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleSetName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleS3Action\"},\"kind\":\"array\"}}")]
        public virtual aws.Ses.ISesReceiptRuleS3Action[] S3Action
        {
            get => GetInstanceProperty<aws.Ses.ISesReceiptRuleS3Action[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scanEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ScanEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "snsAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleSnsAction\"},\"kind\":\"array\"}}")]
        public virtual aws.Ses.ISesReceiptRuleSnsAction[] SnsAction
        {
            get => GetInstanceProperty<aws.Ses.ISesReceiptRuleSnsAction[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stopAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleStopAction\"},\"kind\":\"array\"}}")]
        public virtual aws.Ses.ISesReceiptRuleStopAction[] StopAction
        {
            get => GetInstanceProperty<aws.Ses.ISesReceiptRuleStopAction[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tlsPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TlsPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workmailAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleWorkmailAction\"},\"kind\":\"array\"}}")]
        public virtual aws.Ses.ISesReceiptRuleWorkmailAction[] WorkmailAction
        {
            get => GetInstanceProperty<aws.Ses.ISesReceiptRuleWorkmailAction[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
