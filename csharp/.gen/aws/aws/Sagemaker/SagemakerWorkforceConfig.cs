using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    /// <summary>AWS SageMaker.</summary>
    [JsiiByValue(fqn: "aws.sagemaker.SagemakerWorkforceConfig")]
    public class SagemakerWorkforceConfig : aws.Sagemaker.ISagemakerWorkforceConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce#workforce_name SagemakerWorkforce#workforce_name}.</summary>
        [JsiiProperty(name: "workforceName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string WorkforceName
        {
            get;
            set;
        }

        /// <summary>cognito_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce#cognito_config SagemakerWorkforce#cognito_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cognitoConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerWorkforceCognitoConfig\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerWorkforceCognitoConfig? CognitoConfig
        {
            get;
            set;
        }

        /// <summary>oidc_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce#oidc_config SagemakerWorkforce#oidc_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oidcConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerWorkforceOidcConfig\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerWorkforceOidcConfig? OidcConfig
        {
            get;
            set;
        }

        /// <summary>source_ip_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_workforce#source_ip_config SagemakerWorkforce#source_ip_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceIpConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerWorkforceSourceIpConfig\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerWorkforceSourceIpConfig? SourceIpConfig
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
