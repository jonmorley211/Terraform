using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasources
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/launch_configuration aws_launch_configuration}.</summary>
    [JsiiClass(nativeType: typeof(aws.Datasources.DataAwsLaunchConfiguration), fullyQualifiedName: "aws.datasources.DataAwsLaunchConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.datasources.DataAwsLaunchConfigurationConfig\"}}]")]
    public class DataAwsLaunchConfiguration : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/launch_configuration aws_launch_configuration} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsLaunchConfiguration(Constructs.Construct scope, string id, aws.Datasources.IDataAwsLaunchConfigurationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLaunchConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLaunchConfiguration(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "ebsBlockDevice", returnsJson: "{\"type\":{\"fqn\":\"aws.datasources.DataAwsLaunchConfigurationEbsBlockDevice\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Datasources.DataAwsLaunchConfigurationEbsBlockDevice EbsBlockDevice(string index)
        {
            return InvokeInstanceMethod<aws.Datasources.DataAwsLaunchConfigurationEbsBlockDevice>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "ephemeralBlockDevice", returnsJson: "{\"type\":{\"fqn\":\"aws.datasources.DataAwsLaunchConfigurationEphemeralBlockDevice\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Datasources.DataAwsLaunchConfigurationEphemeralBlockDevice EphemeralBlockDevice(string index)
        {
            return InvokeInstanceMethod<aws.Datasources.DataAwsLaunchConfigurationEphemeralBlockDevice>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "metadataOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.datasources.DataAwsLaunchConfigurationMetadataOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Datasources.DataAwsLaunchConfigurationMetadataOptions MetadataOptions(string index)
        {
            return InvokeInstanceMethod<aws.Datasources.DataAwsLaunchConfigurationMetadataOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "rootBlockDevice", returnsJson: "{\"type\":{\"fqn\":\"aws.datasources.DataAwsLaunchConfigurationRootBlockDevice\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Datasources.DataAwsLaunchConfigurationRootBlockDevice RootBlockDevice(string index)
        {
            return InvokeInstanceMethod<aws.Datasources.DataAwsLaunchConfigurationRootBlockDevice>(new System.Type[]{typeof(string)}, new object[]{index})!;
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
        = GetStaticProperty<string>(typeof(aws.Datasources.DataAwsLaunchConfiguration))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "associatePublicIpAddress", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object AssociatePublicIpAddress
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object EbsOptimized
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "enableMonitoring", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object EnableMonitoring
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IamInstanceProfile
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

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "placementTenancy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlacementTenancy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "spotPrice", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpotPrice
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserData
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcClassicLinkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcClassicLinkId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vpcClassicLinkSecurityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpcClassicLinkSecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
