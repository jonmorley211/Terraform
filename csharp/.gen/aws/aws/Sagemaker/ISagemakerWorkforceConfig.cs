using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    /// <summary>AWS SageMaker.</summary>
    [JsiiInterface(nativeType: typeof(ISagemakerWorkforceConfig), fullyQualifiedName: "aws.sagemaker.SagemakerWorkforceConfig")]
    public interface ISagemakerWorkforceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce#workforce_name SagemakerWorkforce#workforce_name}.</summary>
        [JsiiProperty(name: "workforceName", typeJson: "{\"primitive\":\"string\"}")]
        string WorkforceName
        {
            get;
        }

        /// <summary>cognito_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce#cognito_config SagemakerWorkforce#cognito_config}
        /// </remarks>
        [JsiiProperty(name: "cognitoConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerWorkforceCognitoConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerWorkforceCognitoConfig? CognitoConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>oidc_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce#oidc_config SagemakerWorkforce#oidc_config}
        /// </remarks>
        [JsiiProperty(name: "oidcConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerWorkforceOidcConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerWorkforceOidcConfig? OidcConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_ip_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce#source_ip_config SagemakerWorkforce#source_ip_config}
        /// </remarks>
        [JsiiProperty(name: "sourceIpConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerWorkforceSourceIpConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerWorkforceSourceIpConfig? SourceIpConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS SageMaker.</summary>
        [JsiiTypeProxy(nativeType: typeof(ISagemakerWorkforceConfig), fullyQualifiedName: "aws.sagemaker.SagemakerWorkforceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerWorkforceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce#workforce_name SagemakerWorkforce#workforce_name}.</summary>
            [JsiiProperty(name: "workforceName", typeJson: "{\"primitive\":\"string\"}")]
            public string WorkforceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>cognito_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce#cognito_config SagemakerWorkforce#cognito_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cognitoConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerWorkforceCognitoConfig\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerWorkforceCognitoConfig? CognitoConfig
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerWorkforceCognitoConfig?>();
            }

            /// <summary>oidc_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce#oidc_config SagemakerWorkforce#oidc_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oidcConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerWorkforceOidcConfig\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerWorkforceOidcConfig? OidcConfig
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerWorkforceOidcConfig?>();
            }

            /// <summary>source_ip_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce#source_ip_config SagemakerWorkforce#source_ip_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceIpConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerWorkforceSourceIpConfig\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerWorkforceSourceIpConfig? SourceIpConfig
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerWorkforceSourceIpConfig?>();
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
