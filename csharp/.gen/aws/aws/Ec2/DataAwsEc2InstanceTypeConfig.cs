using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    #pragma warning disable CS8618

    /// <summary>AWS EC2.</summary>
    [JsiiByValue(fqn: "aws.ec2.DataAwsEc2InstanceTypeConfig")]
    public class DataAwsEc2InstanceTypeConfig : aws.Ec2.IDataAwsEc2InstanceTypeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#instance_type DataAwsEc2InstanceType#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string InstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#default_cores DataAwsEc2InstanceType#default_cores}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultCores", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? DefaultCores
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#default_threads_per_core DataAwsEc2InstanceType#default_threads_per_core}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultThreadsPerCore", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? DefaultThreadsPerCore
        {
            get;
            set;
        }

        /// <summary>fpgas block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#fpgas DataAwsEc2InstanceType#fpgas}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fpgas", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypeFpgas\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Ec2.IDataAwsEc2InstanceTypeFpgas[]? Fpgas
        {
            get;
            set;
        }

        /// <summary>gpus block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#gpus DataAwsEc2InstanceType#gpus}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gpus", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypeGpus\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Ec2.IDataAwsEc2InstanceTypeGpus[]? Gpus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#hypervisor DataAwsEc2InstanceType#hypervisor}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hypervisor", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Hypervisor
        {
            get;
            set;
        }

        /// <summary>inference_accelerators block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#inference_accelerators DataAwsEc2InstanceType#inference_accelerators}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inferenceAccelerators", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypeInferenceAccelerators\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Ec2.IDataAwsEc2InstanceTypeInferenceAccelerators[]? InferenceAccelerators
        {
            get;
            set;
        }

        /// <summary>instance_disks block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#instance_disks DataAwsEc2InstanceType#instance_disks}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "instanceDisks", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypeInstanceDisks\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Ec2.IDataAwsEc2InstanceTypeInstanceDisks[]? InstanceDisks
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#maximum_ipv6_addresses_per_interface DataAwsEc2InstanceType#maximum_ipv6_addresses_per_interface}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumIpv6AddressesPerInterface", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaximumIpv6AddressesPerInterface
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#total_fpga_memory DataAwsEc2InstanceType#total_fpga_memory}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "totalFpgaMemory", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? TotalFpgaMemory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#total_gpu_memory DataAwsEc2InstanceType#total_gpu_memory}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "totalGpuMemory", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? TotalGpuMemory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type#total_instance_storage DataAwsEc2InstanceType#total_instance_storage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "totalInstanceStorage", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? TotalInstanceStorage
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
