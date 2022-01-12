using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiClass(nativeType: typeof(aws.Cognito.CognitoUserPoolLambdaConfigCustomEmailSenderOutputReference), fullyQualifiedName: "aws.cognito.CognitoUserPoolLambdaConfigCustomEmailSenderOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CognitoUserPoolLambdaConfigCustomEmailSenderOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CognitoUserPoolLambdaConfigCustomEmailSenderOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPoolLambdaConfigCustomEmailSenderOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPoolLambdaConfigCustomEmailSenderOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LambdaArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LambdaVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "lambdaArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LambdaArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lambdaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LambdaVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolLambdaConfigCustomEmailSender\"}", isOptional: true)]
        public virtual aws.Cognito.ICognitoUserPoolLambdaConfigCustomEmailSender? InternalValue
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolLambdaConfigCustomEmailSender?>();
            set => SetInstanceProperty(value);
        }
    }
}
