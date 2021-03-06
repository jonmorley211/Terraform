using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiByValue(fqn: "aws.cognito.CognitoUserPoolVerificationMessageTemplate")]
    public class CognitoUserPoolVerificationMessageTemplate : aws.Cognito.ICognitoUserPoolVerificationMessageTemplate
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#default_email_option CognitoUserPool#default_email_option}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultEmailOption", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DefaultEmailOption
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#email_message CognitoUserPool#email_message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EmailMessage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#email_message_by_link CognitoUserPool#email_message_by_link}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailMessageByLink", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EmailMessageByLink
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#email_subject CognitoUserPool#email_subject}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EmailSubject
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#email_subject_by_link CognitoUserPool#email_subject_by_link}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailSubjectByLink", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? EmailSubjectByLink
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_user_pool#sms_message CognitoUserPool#sms_message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "smsMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SmsMessage
        {
            get;
            set;
        }
    }
}
