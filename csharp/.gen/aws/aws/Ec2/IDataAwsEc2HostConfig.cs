using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>AWS EC2.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsEc2HostConfig), fullyQualifiedName: "aws.ec2.DataAwsEc2HostConfig")]
    public interface IDataAwsEc2HostConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_host#filter DataAwsEc2Host#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2HostFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.IDataAwsEc2HostFilter[]? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_host#host_id DataAwsEc2Host#host_id}.</summary>
        [JsiiProperty(name: "hostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_host#tags DataAwsEc2Host#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS EC2.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2HostConfig), fullyQualifiedName: "aws.ec2.DataAwsEc2HostConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.IDataAwsEc2HostConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_host#filter DataAwsEc2Host#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2HostFilter\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Ec2.IDataAwsEc2HostFilter[]? Filter
            {
                get => GetInstanceProperty<aws.Ec2.IDataAwsEc2HostFilter[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_host#host_id DataAwsEc2Host#host_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_host#tags DataAwsEc2Host#tags}.</summary>
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
