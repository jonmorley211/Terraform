using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce aws_sagemaker_workforce}.</summary>
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerWorkforce), fullyQualifiedName: "aws.sagemaker.SagemakerWorkforce", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerWorkforceConfig\"}}]")]
    public class SagemakerWorkforce : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce aws_sagemaker_workforce} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SagemakerWorkforce(Constructs.Construct scope, string id, aws.Sagemaker.ISagemakerWorkforceConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerWorkforce(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerWorkforce(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCognitoConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerWorkforceCognitoConfig\"}}]")]
        public virtual void PutCognitoConfig(aws.Sagemaker.ISagemakerWorkforceCognitoConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerWorkforceCognitoConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOidcConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerWorkforceOidcConfig\"}}]")]
        public virtual void PutOidcConfig(aws.Sagemaker.ISagemakerWorkforceOidcConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerWorkforceOidcConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceIpConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerWorkforceSourceIpConfig\"}}]")]
        public virtual void PutSourceIpConfig(aws.Sagemaker.ISagemakerWorkforceSourceIpConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerWorkforceSourceIpConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCognitoConfig")]
        public virtual void ResetCognitoConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOidcConfig")]
        public virtual void ResetOidcConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceIpConfig")]
        public virtual void ResetSourceIpConfig()
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
        = GetStaticProperty<string>(typeof(aws.Sagemaker.SagemakerWorkforce))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cognitoConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerWorkforceCognitoConfigOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerWorkforceCognitoConfigOutputReference CognitoConfig
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerWorkforceCognitoConfigOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oidcConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerWorkforceOidcConfigOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerWorkforceOidcConfigOutputReference OidcConfig
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerWorkforceOidcConfigOutputReference>()!;
        }

        [JsiiProperty(name: "sourceIpConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerWorkforceSourceIpConfigOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerWorkforceSourceIpConfigOutputReference SourceIpConfig
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerWorkforceSourceIpConfigOutputReference>()!;
        }

        [JsiiProperty(name: "subdomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Subdomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cognitoConfigInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerWorkforceCognitoConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerWorkforceCognitoConfig? CognitoConfigInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerWorkforceCognitoConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcConfigInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerWorkforceOidcConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerWorkforceOidcConfig? OidcConfigInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerWorkforceOidcConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceIpConfigInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerWorkforceSourceIpConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerWorkforceSourceIpConfig? SourceIpConfigInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerWorkforceSourceIpConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workforceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkforceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "workforceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkforceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
