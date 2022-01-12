using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiClass(nativeType: typeof(aws.Cognito.CognitoUserPoolLambdaConfigOutputReference), fullyQualifiedName: "aws.cognito.CognitoUserPoolLambdaConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CognitoUserPoolLambdaConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CognitoUserPoolLambdaConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPoolLambdaConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPoolLambdaConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomEmailSender", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognito.CognitoUserPoolLambdaConfigCustomEmailSender\"}}]")]
        public virtual void PutCustomEmailSender(aws.Cognito.ICognitoUserPoolLambdaConfigCustomEmailSender @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cognito.ICognitoUserPoolLambdaConfigCustomEmailSender)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomSmsSender", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognito.CognitoUserPoolLambdaConfigCustomSmsSender\"}}]")]
        public virtual void PutCustomSmsSender(aws.Cognito.ICognitoUserPoolLambdaConfigCustomSmsSender @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cognito.ICognitoUserPoolLambdaConfigCustomSmsSender)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCreateAuthChallenge")]
        public virtual void ResetCreateAuthChallenge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomEmailSender")]
        public virtual void ResetCustomEmailSender()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomMessage")]
        public virtual void ResetCustomMessage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomSmsSender")]
        public virtual void ResetCustomSmsSender()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefineAuthChallenge")]
        public virtual void ResetDefineAuthChallenge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyId")]
        public virtual void ResetKmsKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPostAuthentication")]
        public virtual void ResetPostAuthentication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPostConfirmation")]
        public virtual void ResetPostConfirmation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreAuthentication")]
        public virtual void ResetPreAuthentication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreSignUp")]
        public virtual void ResetPreSignUp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreTokenGeneration")]
        public virtual void ResetPreTokenGeneration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserMigration")]
        public virtual void ResetUserMigration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerifyAuthChallengeResponse")]
        public virtual void ResetVerifyAuthChallengeResponse()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customEmailSender", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolLambdaConfigCustomEmailSenderOutputReference\"}")]
        public virtual aws.Cognito.CognitoUserPoolLambdaConfigCustomEmailSenderOutputReference CustomEmailSender
        {
            get => GetInstanceProperty<aws.Cognito.CognitoUserPoolLambdaConfigCustomEmailSenderOutputReference>()!;
        }

        [JsiiProperty(name: "customSmsSender", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolLambdaConfigCustomSmsSenderOutputReference\"}")]
        public virtual aws.Cognito.CognitoUserPoolLambdaConfigCustomSmsSenderOutputReference CustomSmsSender
        {
            get => GetInstanceProperty<aws.Cognito.CognitoUserPoolLambdaConfigCustomSmsSenderOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "createAuthChallengeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreateAuthChallengeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customEmailSenderInput", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolLambdaConfigCustomEmailSender\"}", isOptional: true)]
        public virtual aws.Cognito.ICognitoUserPoolLambdaConfigCustomEmailSender? CustomEmailSenderInput
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolLambdaConfigCustomEmailSender?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customMessageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomMessageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customSmsSenderInput", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolLambdaConfigCustomSmsSender\"}", isOptional: true)]
        public virtual aws.Cognito.ICognitoUserPoolLambdaConfigCustomSmsSender? CustomSmsSenderInput
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolLambdaConfigCustomSmsSender?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defineAuthChallengeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefineAuthChallengeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "postAuthenticationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PostAuthenticationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "postConfirmationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PostConfirmationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preAuthenticationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreAuthenticationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preSignUpInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreSignUpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preTokenGenerationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreTokenGenerationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userMigrationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserMigrationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "verifyAuthChallengeResponseInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VerifyAuthChallengeResponseInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "createAuthChallenge", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreateAuthChallenge
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomMessage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defineAuthChallenge", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefineAuthChallenge
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "postAuthentication", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PostAuthentication
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "postConfirmation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PostConfirmation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preAuthentication", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreAuthentication
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preSignUp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreSignUp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preTokenGeneration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreTokenGeneration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userMigration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserMigration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "verifyAuthChallengeResponse", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VerifyAuthChallengeResponse
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolLambdaConfig\"}", isOptional: true)]
        public virtual aws.Cognito.ICognitoUserPoolLambdaConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolLambdaConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
