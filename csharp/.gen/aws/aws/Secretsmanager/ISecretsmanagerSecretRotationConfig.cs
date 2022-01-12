using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Secretsmanager
{
    /// <summary>AWS Secrets Manager.</summary>
    [JsiiInterface(nativeType: typeof(ISecretsmanagerSecretRotationConfig), fullyQualifiedName: "aws.secretsmanager.SecretsmanagerSecretRotationConfig")]
    public interface ISecretsmanagerSecretRotationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_rotation#rotation_lambda_arn SecretsmanagerSecretRotation#rotation_lambda_arn}.</summary>
        [JsiiProperty(name: "rotationLambdaArn", typeJson: "{\"primitive\":\"string\"}")]
        string RotationLambdaArn
        {
            get;
        }

        /// <summary>rotation_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_rotation#rotation_rules SecretsmanagerSecretRotation#rotation_rules}
        /// </remarks>
        [JsiiProperty(name: "rotationRules", typeJson: "{\"fqn\":\"aws.secretsmanager.SecretsmanagerSecretRotationRotationRules\"}")]
        aws.Secretsmanager.ISecretsmanagerSecretRotationRotationRules RotationRules
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_rotation#secret_id SecretsmanagerSecretRotation#secret_id}.</summary>
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
        string SecretId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_rotation#tags SecretsmanagerSecretRotation#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Secrets Manager.</summary>
        [JsiiTypeProxy(nativeType: typeof(ISecretsmanagerSecretRotationConfig), fullyQualifiedName: "aws.secretsmanager.SecretsmanagerSecretRotationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Secretsmanager.ISecretsmanagerSecretRotationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_rotation#rotation_lambda_arn SecretsmanagerSecretRotation#rotation_lambda_arn}.</summary>
            [JsiiProperty(name: "rotationLambdaArn", typeJson: "{\"primitive\":\"string\"}")]
            public string RotationLambdaArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>rotation_rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_rotation#rotation_rules SecretsmanagerSecretRotation#rotation_rules}
            /// </remarks>
            [JsiiProperty(name: "rotationRules", typeJson: "{\"fqn\":\"aws.secretsmanager.SecretsmanagerSecretRotationRotationRules\"}")]
            public aws.Secretsmanager.ISecretsmanagerSecretRotationRotationRules RotationRules
            {
                get => GetInstanceProperty<aws.Secretsmanager.ISecretsmanagerSecretRotationRotationRules>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_rotation#secret_id SecretsmanagerSecretRotation#secret_id}.</summary>
            [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/secretsmanager_secret_rotation#tags SecretsmanagerSecretRotation#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Tags
            {
                get => GetInstanceProperty<object?>();
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
