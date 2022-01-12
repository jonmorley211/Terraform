using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type aws_ec2_instance_type}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ec2.DataAwsEc2InstanceType), fullyQualifiedName: "aws.ec2.DataAwsEc2InstanceType", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypeConfig\"}}]")]
    public class DataAwsEc2InstanceType : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_type aws_ec2_instance_type} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsEc2InstanceType(Constructs.Construct scope, string id, aws.Ec2.IDataAwsEc2InstanceTypeConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2InstanceType(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2InstanceType(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDefaultCores")]
        public virtual void ResetDefaultCores()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultThreadsPerCore")]
        public virtual void ResetDefaultThreadsPerCore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFpgas")]
        public virtual void ResetFpgas()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGpus")]
        public virtual void ResetGpus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHypervisor")]
        public virtual void ResetHypervisor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInferenceAccelerators")]
        public virtual void ResetInferenceAccelerators()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceDisks")]
        public virtual void ResetInstanceDisks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaximumIpv6AddressesPerInterface")]
        public virtual void ResetMaximumIpv6AddressesPerInterface()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTotalFpgaMemory")]
        public virtual void ResetTotalFpgaMemory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTotalGpuMemory")]
        public virtual void ResetTotalGpuMemory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTotalInstanceStorage")]
        public virtual void ResetTotalInstanceStorage()
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
        = GetStaticProperty<string>(typeof(aws.Ec2.DataAwsEc2InstanceType))!;

        [JsiiProperty(name: "autoRecoverySupported", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object AutoRecoverySupported
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "bareMetal", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object BareMetal
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "burstablePerformanceSupported", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object BurstablePerformanceSupported
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "currentGeneration", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object CurrentGeneration
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "dedicatedHostsSupported", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object DedicatedHostsSupported
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "defaultVcpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultVcpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ebsEncryptionSupport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EbsEncryptionSupport
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ebsNvmeSupport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EbsNvmeSupport
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ebsOptimizedSupport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EbsOptimizedSupport
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ebsPerformanceBaselineBandwidth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EbsPerformanceBaselineBandwidth
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ebsPerformanceBaselineIops", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EbsPerformanceBaselineIops
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ebsPerformanceBaselineThroughput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EbsPerformanceBaselineThroughput
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ebsPerformanceMaximumBandwidth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EbsPerformanceMaximumBandwidth
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ebsPerformanceMaximumIops", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EbsPerformanceMaximumIops
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ebsPerformanceMaximumThroughput", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EbsPerformanceMaximumThroughput
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "efaSupported", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object EfaSupported
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "enaSupport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnaSupport
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptionInTransitSupported", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object EncryptionInTransitSupported
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "freeTierEligible", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object FreeTierEligible
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "hibernationSupported", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object HibernationSupported
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceStorageSupported", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object InstanceStorageSupported
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "ipv6Supported", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object Ipv6Supported
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "maximumIpv4AddressesPerInterface", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumIpv4AddressesPerInterface
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maximumNetworkInterfaces", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumNetworkInterfaces
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "memorySize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemorySize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "networkPerformance", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkPerformance
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "supportedArchitectures", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SupportedArchitectures
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "supportedPlacementStrategies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SupportedPlacementStrategies
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "supportedRootDeviceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SupportedRootDeviceTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "supportedUsagesClasses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SupportedUsagesClasses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "supportedVirtualizationTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SupportedVirtualizationTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sustainedClockSpeed", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SustainedClockSpeed
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "validCores", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object ValidCores
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "validThreadsPerCore", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object ValidThreadsPerCore
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultCoresInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DefaultCoresInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultThreadsPerCoreInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DefaultThreadsPerCoreInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fpgasInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypeFpgas\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ec2.IDataAwsEc2InstanceTypeFpgas[]? FpgasInput
        {
            get => GetInstanceProperty<aws.Ec2.IDataAwsEc2InstanceTypeFpgas[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gpusInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypeGpus\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ec2.IDataAwsEc2InstanceTypeGpus[]? GpusInput
        {
            get => GetInstanceProperty<aws.Ec2.IDataAwsEc2InstanceTypeGpus[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hypervisorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HypervisorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inferenceAcceleratorsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypeInferenceAccelerators\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ec2.IDataAwsEc2InstanceTypeInferenceAccelerators[]? InferenceAcceleratorsInput
        {
            get => GetInstanceProperty<aws.Ec2.IDataAwsEc2InstanceTypeInferenceAccelerators[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceDisksInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypeInstanceDisks\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ec2.IDataAwsEc2InstanceTypeInstanceDisks[]? InstanceDisksInput
        {
            get => GetInstanceProperty<aws.Ec2.IDataAwsEc2InstanceTypeInstanceDisks[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumIpv6AddressesPerInterfaceInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumIpv6AddressesPerInterfaceInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "totalFpgaMemoryInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TotalFpgaMemoryInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "totalGpuMemoryInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TotalGpuMemoryInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "totalInstanceStorageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TotalInstanceStorageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "defaultCores", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultCores
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultThreadsPerCore", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultThreadsPerCore
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fpgas", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypeFpgas\"},\"kind\":\"array\"}}")]
        public virtual aws.Ec2.IDataAwsEc2InstanceTypeFpgas[] Fpgas
        {
            get => GetInstanceProperty<aws.Ec2.IDataAwsEc2InstanceTypeFpgas[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gpus", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypeGpus\"},\"kind\":\"array\"}}")]
        public virtual aws.Ec2.IDataAwsEc2InstanceTypeGpus[] Gpus
        {
            get => GetInstanceProperty<aws.Ec2.IDataAwsEc2InstanceTypeGpus[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hypervisor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hypervisor
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inferenceAccelerators", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypeInferenceAccelerators\"},\"kind\":\"array\"}}")]
        public virtual aws.Ec2.IDataAwsEc2InstanceTypeInferenceAccelerators[] InferenceAccelerators
        {
            get => GetInstanceProperty<aws.Ec2.IDataAwsEc2InstanceTypeInferenceAccelerators[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceDisks", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypeInstanceDisks\"},\"kind\":\"array\"}}")]
        public virtual aws.Ec2.IDataAwsEc2InstanceTypeInstanceDisks[] InstanceDisks
        {
            get => GetInstanceProperty<aws.Ec2.IDataAwsEc2InstanceTypeInstanceDisks[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maximumIpv6AddressesPerInterface", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumIpv6AddressesPerInterface
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "totalFpgaMemory", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalFpgaMemory
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "totalGpuMemory", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalGpuMemory
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "totalInstanceStorage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalInstanceStorage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
