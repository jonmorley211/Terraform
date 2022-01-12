using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/lambda_code_signing_config aws_lambda_code_signing_config}.</summary>
    [JsiiClass(nativeType: typeof(aws.Lambdafunction.LambdaCodeSigningConfig), fullyQualifiedName: "aws.lambdafunction.LambdaCodeSigningConfig", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaCodeSigningConfigConfig\"}}]")]
    public class LambdaCodeSigningConfig : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/lambda_code_signing_config aws_lambda_code_signing_config} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LambdaCodeSigningConfig(Constructs.Construct scope, string id, aws.Lambdafunction.ILambdaCodeSigningConfigConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaCodeSigningConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaCodeSigningConfig(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAllowedPublishers", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaCodeSigningConfigAllowedPublishers\"}}]")]
        public virtual void PutAllowedPublishers(aws.Lambdafunction.ILambdaCodeSigningConfigAllowedPublishers @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lambdafunction.ILambdaCodeSigningConfigAllowedPublishers)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPolicies", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lambdafunction.LambdaCodeSigningConfigPolicies\"}}]")]
        public virtual void PutPolicies(aws.Lambdafunction.ILambdaCodeSigningConfigPolicies @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lambdafunction.ILambdaCodeSigningConfigPolicies)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicies")]
        public virtual void ResetPolicies()
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
        = GetStaticProperty<string>(typeof(aws.Lambdafunction.LambdaCodeSigningConfig))!;

        [JsiiProperty(name: "allowedPublishers", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaCodeSigningConfigAllowedPublishersOutputReference\"}")]
        public virtual aws.Lambdafunction.LambdaCodeSigningConfigAllowedPublishersOutputReference AllowedPublishers
        {
            get => GetInstanceProperty<aws.Lambdafunction.LambdaCodeSigningConfigAllowedPublishersOutputReference>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastModified", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModified
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "policies", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaCodeSigningConfigPoliciesOutputReference\"}")]
        public virtual aws.Lambdafunction.LambdaCodeSigningConfigPoliciesOutputReference Policies
        {
            get => GetInstanceProperty<aws.Lambdafunction.LambdaCodeSigningConfigPoliciesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedPublishersInput", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaCodeSigningConfigAllowedPublishers\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaCodeSigningConfigAllowedPublishers? AllowedPublishersInput
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaCodeSigningConfigAllowedPublishers?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policiesInput", typeJson: "{\"fqn\":\"aws.lambdafunction.LambdaCodeSigningConfigPolicies\"}", isOptional: true)]
        public virtual aws.Lambdafunction.ILambdaCodeSigningConfigPolicies? PoliciesInput
        {
            get => GetInstanceProperty<aws.Lambdafunction.ILambdaCodeSigningConfigPolicies?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
