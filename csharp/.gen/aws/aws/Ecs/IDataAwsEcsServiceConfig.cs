using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    /// <summary>AWS EC2 Container Service.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsEcsServiceConfig), fullyQualifiedName: "aws.ecs.DataAwsEcsServiceConfig")]
    public interface IDataAwsEcsServiceConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ecs_service#cluster_arn DataAwsEcsService#cluster_arn}.</summary>
        [JsiiProperty(name: "clusterArn", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ecs_service#service_name DataAwsEcsService#service_name}.</summary>
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceName
        {
            get;
        }

        /// <summary>AWS EC2 Container Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsEcsServiceConfig), fullyQualifiedName: "aws.ecs.DataAwsEcsServiceConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ecs.IDataAwsEcsServiceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ecs_service#cluster_arn DataAwsEcsService#cluster_arn}.</summary>
            [JsiiProperty(name: "clusterArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ecs_service#service_name DataAwsEcsService#service_name}.</summary>
            [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceName
            {
                get => GetInstanceProperty<string>()!;
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
