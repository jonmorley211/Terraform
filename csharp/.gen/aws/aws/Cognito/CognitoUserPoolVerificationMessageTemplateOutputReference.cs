using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiClass(nativeType: typeof(aws.Cognito.CognitoUserPoolVerificationMessageTemplateOutputReference), fullyQualifiedName: "aws.cognito.CognitoUserPoolVerificationMessageTemplateOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CognitoUserPoolVerificationMessageTemplateOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CognitoUserPoolVerificationMessageTemplateOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPoolVerificationMessageTemplateOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPoolVerificationMessageTemplateOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDefaultEmailOption")]
        public virtual void ResetDefaultEmailOption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailMessage")]
        public virtual void ResetEmailMessage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailMessageByLink")]
        public virtual void ResetEmailMessageByLink()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailSubject")]
        public virtual void ResetEmailSubject()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailSubjectByLink")]
        public virtual void ResetEmailSubjectByLink()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmsMessage")]
        public virtual void ResetSmsMessage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultEmailOptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultEmailOptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailMessageByLinkInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailMessageByLinkInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailMessageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailMessageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailSubjectByLinkInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailSubjectByLinkInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailSubjectInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailSubjectInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smsMessageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SmsMessageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "defaultEmailOption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultEmailOption
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emailMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailMessage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emailMessageByLink", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailMessageByLink
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emailSubject", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailSubject
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emailSubjectByLink", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailSubjectByLink
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "smsMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SmsMessage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolVerificationMessageTemplate\"}", isOptional: true)]
        public virtual aws.Cognito.ICognitoUserPoolVerificationMessageTemplate? InternalValue
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolVerificationMessageTemplate?>();
            set => SetInstanceProperty(value);
        }
    }
}
