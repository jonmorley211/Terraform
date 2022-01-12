using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Neptune
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/neptune_orderable_db_instance aws_neptune_orderable_db_instance}.</summary>
    [JsiiClass(nativeType: typeof(aws.Neptune.DataAwsNeptuneOrderableDbInstance), fullyQualifiedName: "aws.neptune.DataAwsNeptuneOrderableDbInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.neptune.DataAwsNeptuneOrderableDbInstanceConfig\"}}]")]
    public class DataAwsNeptuneOrderableDbInstance : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/neptune_orderable_db_instance aws_neptune_orderable_db_instance} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsNeptuneOrderableDbInstance(Constructs.Construct scope, string id, aws.Neptune.IDataAwsNeptuneOrderableDbInstanceConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsNeptuneOrderableDbInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsNeptuneOrderableDbInstance(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEngine")]
        public virtual void ResetEngine()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEngineVersion")]
        public virtual void ResetEngineVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceClass")]
        public virtual void ResetInstanceClass()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLicenseModel")]
        public virtual void ResetLicenseModel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreferredInstanceClasses")]
        public virtual void ResetPreferredInstanceClasses()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpc")]
        public virtual void ResetVpc()
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
        = GetStaticProperty<string>(typeof(aws.Neptune.DataAwsNeptuneOrderableDbInstance))!;

        [JsiiProperty(name: "availabilityZones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AvailabilityZones
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxIopsPerDbInstance", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxIopsPerDbInstance
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxIopsPerGib", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxIopsPerGib
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxStorageSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxStorageSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minIopsPerDbInstance", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinIopsPerDbInstance
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minIopsPerGib", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinIopsPerGib
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minStorageSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinStorageSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "multiAzCapable", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object MultiAzCapable
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "readReplicaCapable", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object ReadReplicaCapable
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "supportsEnhancedMonitoring", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object SupportsEnhancedMonitoring
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "supportsIamDatabaseAuthentication", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object SupportsIamDatabaseAuthentication
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "supportsIops", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object SupportsIops
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "supportsPerformanceInsights", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object SupportsPerformanceInsights
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "supportsStorageEncryption", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object SupportsStorageEncryption
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "engineInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EngineInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "engineVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EngineVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceClassInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceClassInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "licenseModelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LicenseModelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preferredInstanceClassesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PreferredInstanceClassesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? VpcInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "engine", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Engine
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceClass
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseModel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preferredInstanceClasses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PreferredInstanceClasses
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpc", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Vpc
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
