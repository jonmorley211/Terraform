using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    /// <summary>AWS EC2 Container Registry.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsEcrAuthorizationTokenConfig), fullyQualifiedName: "aws.ecr.DataAwsEcrAuthorizationTokenConfig")]
    public interface IDataAwsEcrAuthorizationTokenConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ecr_authorization_token#registry_id DataAwsEcrAuthorizationToken#registry_id}.</summary>
        [JsiiProperty(name: "registryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RegistryId
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS EC2 Container Registry.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsEcrAuthorizationTokenConfig), fullyQualifiedName: "aws.ecr.DataAwsEcrAuthorizationTokenConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ecr.IDataAwsEcrAuthorizationTokenConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ecr_authorization_token#registry_id DataAwsEcrAuthorizationToken#registry_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "registryId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegistryId
            {
                get => GetInstanceProperty<string?>();
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
