using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>AWS EC2.</summary>
    [JsiiInterface(nativeType: typeof(IDataAwsEc2InstanceTypeConfig), fullyQualifiedName: "aws.ec2.DataAwsEc2InstanceTypeConfig")]
    public interface IDataAwsEc2InstanceTypeConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#instance_type DataAwsEc2InstanceType#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#default_cores DataAwsEc2InstanceType#default_cores}.</summary>
        [JsiiProperty(name: "defaultCores", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DefaultCores
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#default_threads_per_core DataAwsEc2InstanceType#default_threads_per_core}.</summary>
        [JsiiProperty(name: "defaultThreadsPerCore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DefaultThreadsPerCore
        {
            get
            {
                return null;
            }
        }

        /// <summary>fpgas block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#fpgas DataAwsEc2InstanceType#fpgas}
        /// </remarks>
        [JsiiProperty(name: "fpgas", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypeFpgas\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.IDataAwsEc2InstanceTypeFpgas[]? Fpgas
        {
            get
            {
                return null;
            }
        }

        /// <summary>gpus block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#gpus DataAwsEc2InstanceType#gpus}
        /// </remarks>
        [JsiiProperty(name: "gpus", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypeGpus\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.IDataAwsEc2InstanceTypeGpus[]? Gpus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#hypervisor DataAwsEc2InstanceType#hypervisor}.</summary>
        [JsiiProperty(name: "hypervisor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Hypervisor
        {
            get
            {
                return null;
            }
        }

        /// <summary>inference_accelerators block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#inference_accelerators DataAwsEc2InstanceType#inference_accelerators}
        /// </remarks>
        [JsiiProperty(name: "inferenceAccelerators", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypeInferenceAccelerators\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.IDataAwsEc2InstanceTypeInferenceAccelerators[]? InferenceAccelerators
        {
            get
            {
                return null;
            }
        }

        /// <summary>instance_disks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#instance_disks DataAwsEc2InstanceType#instance_disks}
        /// </remarks>
        [JsiiProperty(name: "instanceDisks", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypeInstanceDisks\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2.IDataAwsEc2InstanceTypeInstanceDisks[]? InstanceDisks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#maximum_ipv6_addresses_per_interface DataAwsEc2InstanceType#maximum_ipv6_addresses_per_interface}.</summary>
        [JsiiProperty(name: "maximumIpv6AddressesPerInterface", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumIpv6AddressesPerInterface
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#total_fpga_memory DataAwsEc2InstanceType#total_fpga_memory}.</summary>
        [JsiiProperty(name: "totalFpgaMemory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TotalFpgaMemory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#total_gpu_memory DataAwsEc2InstanceType#total_gpu_memory}.</summary>
        [JsiiProperty(name: "totalGpuMemory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TotalGpuMemory
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#total_instance_storage DataAwsEc2InstanceType#total_instance_storage}.</summary>
        [JsiiProperty(name: "totalInstanceStorage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TotalInstanceStorage
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS EC2.</summary>
        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2InstanceTypeConfig), fullyQualifiedName: "aws.ec2.DataAwsEc2InstanceTypeConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2.IDataAwsEc2InstanceTypeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#instance_type DataAwsEc2InstanceType#instance_type}.</summary>
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#default_cores DataAwsEc2InstanceType#default_cores}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultCores", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DefaultCores
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#default_threads_per_core DataAwsEc2InstanceType#default_threads_per_core}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultThreadsPerCore", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DefaultThreadsPerCore
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>fpgas block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#fpgas DataAwsEc2InstanceType#fpgas}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fpgas", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypeFpgas\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Ec2.IDataAwsEc2InstanceTypeFpgas[]? Fpgas
            {
                get => GetInstanceProperty<aws.Ec2.IDataAwsEc2InstanceTypeFpgas[]?>();
            }

            /// <summary>gpus block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#gpus DataAwsEc2InstanceType#gpus}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gpus", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypeGpus\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Ec2.IDataAwsEc2InstanceTypeGpus[]? Gpus
            {
                get => GetInstanceProperty<aws.Ec2.IDataAwsEc2InstanceTypeGpus[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#hypervisor DataAwsEc2InstanceType#hypervisor}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hypervisor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Hypervisor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>inference_accelerators block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#inference_accelerators DataAwsEc2InstanceType#inference_accelerators}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inferenceAccelerators", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypeInferenceAccelerators\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Ec2.IDataAwsEc2InstanceTypeInferenceAccelerators[]? InferenceAccelerators
            {
                get => GetInstanceProperty<aws.Ec2.IDataAwsEc2InstanceTypeInferenceAccelerators[]?>();
            }

            /// <summary>instance_disks block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#instance_disks DataAwsEc2InstanceType#instance_disks}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "instanceDisks", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypeInstanceDisks\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Ec2.IDataAwsEc2InstanceTypeInstanceDisks[]? InstanceDisks
            {
                get => GetInstanceProperty<aws.Ec2.IDataAwsEc2InstanceTypeInstanceDisks[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#maximum_ipv6_addresses_per_interface DataAwsEc2InstanceType#maximum_ipv6_addresses_per_interface}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumIpv6AddressesPerInterface", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumIpv6AddressesPerInterface
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#total_fpga_memory DataAwsEc2InstanceType#total_fpga_memory}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "totalFpgaMemory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalFpgaMemory
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#total_gpu_memory DataAwsEc2InstanceType#total_gpu_memory}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "totalGpuMemory", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalGpuMemory
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#total_instance_storage DataAwsEc2InstanceType#total_instance_storage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "totalInstanceStorage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalInstanceStorage
            {
                get => GetInstanceProperty<double?>();
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
