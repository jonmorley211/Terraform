using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/launch_template aws_launch_template}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ec2.DataAwsLaunchTemplate), fullyQualifiedName: "aws.ec2.DataAwsLaunchTemplate", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateConfig\"}}]")]
    public class DataAwsLaunchTemplate : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/launch_template aws_launch_template} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsLaunchTemplate(Constructs.Construct scope, string id, aws.Ec2.IDataAwsLaunchTemplateConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLaunchTemplate(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLaunchTemplate(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "blockDeviceMappings", returnsJson: "{\"type\":{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateBlockDeviceMappings\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Ec2.DataAwsLaunchTemplateBlockDeviceMappings BlockDeviceMappings(string index)
        {
            return InvokeInstanceMethod<aws.Ec2.DataAwsLaunchTemplateBlockDeviceMappings>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "creditSpecification", returnsJson: "{\"type\":{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateCreditSpecification\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Ec2.DataAwsLaunchTemplateCreditSpecification CreditSpecification(string index)
        {
            return InvokeInstanceMethod<aws.Ec2.DataAwsLaunchTemplateCreditSpecification>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "elasticGpuSpecifications", returnsJson: "{\"type\":{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateElasticGpuSpecifications\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Ec2.DataAwsLaunchTemplateElasticGpuSpecifications ElasticGpuSpecifications(string index)
        {
            return InvokeInstanceMethod<aws.Ec2.DataAwsLaunchTemplateElasticGpuSpecifications>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "enclaveOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateEnclaveOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Ec2.DataAwsLaunchTemplateEnclaveOptions EnclaveOptions(string index)
        {
            return InvokeInstanceMethod<aws.Ec2.DataAwsLaunchTemplateEnclaveOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "hibernationOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateHibernationOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Ec2.DataAwsLaunchTemplateHibernationOptions HibernationOptions(string index)
        {
            return InvokeInstanceMethod<aws.Ec2.DataAwsLaunchTemplateHibernationOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "iamInstanceProfile", returnsJson: "{\"type\":{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateIamInstanceProfile\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Ec2.DataAwsLaunchTemplateIamInstanceProfile IamInstanceProfile(string index)
        {
            return InvokeInstanceMethod<aws.Ec2.DataAwsLaunchTemplateIamInstanceProfile>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "instanceMarketOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateInstanceMarketOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Ec2.DataAwsLaunchTemplateInstanceMarketOptions InstanceMarketOptions(string index)
        {
            return InvokeInstanceMethod<aws.Ec2.DataAwsLaunchTemplateInstanceMarketOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "metadataOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateMetadataOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Ec2.DataAwsLaunchTemplateMetadataOptions MetadataOptions(string index)
        {
            return InvokeInstanceMethod<aws.Ec2.DataAwsLaunchTemplateMetadataOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "monitoring", returnsJson: "{\"type\":{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateMonitoring\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Ec2.DataAwsLaunchTemplateMonitoring Monitoring(string index)
        {
            return InvokeInstanceMethod<aws.Ec2.DataAwsLaunchTemplateMonitoring>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "networkInterfaces", returnsJson: "{\"type\":{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateNetworkInterfaces\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Ec2.DataAwsLaunchTemplateNetworkInterfaces NetworkInterfaces(string index)
        {
            return InvokeInstanceMethod<aws.Ec2.DataAwsLaunchTemplateNetworkInterfaces>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "placement", returnsJson: "{\"type\":{\"fqn\":\"aws.ec2.DataAwsLaunchTemplatePlacement\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Ec2.DataAwsLaunchTemplatePlacement Placement(string index)
        {
            return InvokeInstanceMethod<aws.Ec2.DataAwsLaunchTemplatePlacement>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "tagSpecifications", returnsJson: "{\"type\":{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateTagSpecifications\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Ec2.DataAwsLaunchTemplateTagSpecifications TagSpecifications(string index)
        {
            return InvokeInstanceMethod<aws.Ec2.DataAwsLaunchTemplateTagSpecifications>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Ec2.DataAwsLaunchTemplate))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disableApiTermination", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object DisableApiTermination
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EbsOptimized
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceInitiatedShutdownBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceInitiatedShutdownBehavior
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kernelId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KernelId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "latestVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LatestVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ramDiskId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RamDiskId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityGroupNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserData
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpcSecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ec2.IDataAwsLaunchTemplateFilter[]? FilterInput
        {
            get => GetInstanceProperty<aws.Ec2.IDataAwsLaunchTemplateFilter[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsLaunchTemplateFilter\"},\"kind\":\"array\"}}")]
        public virtual aws.Ec2.IDataAwsLaunchTemplateFilter[] Filter
        {
            get => GetInstanceProperty<aws.Ec2.IDataAwsLaunchTemplateFilter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object Tags
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
