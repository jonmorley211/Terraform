using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/ecr_registry_scanning_configuration aws_ecr_registry_scanning_configuration}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ecr.EcrRegistryScanningConfiguration), fullyQualifiedName: "aws.ecr.EcrRegistryScanningConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ecr.EcrRegistryScanningConfigurationConfig\"}}]")]
    public class EcrRegistryScanningConfiguration : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/ecr_registry_scanning_configuration aws_ecr_registry_scanning_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EcrRegistryScanningConfiguration(Constructs.Construct scope, string id, aws.Ecr.IEcrRegistryScanningConfigurationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcrRegistryScanningConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcrRegistryScanningConfiguration(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetRule")]
        public virtual void ResetRule()
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
        = GetStaticProperty<string>(typeof(aws.Ecr.EcrRegistryScanningConfiguration))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "registryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegistryId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecr.EcrRegistryScanningConfigurationRule\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ecr.IEcrRegistryScanningConfigurationRule[]? RuleInput
        {
            get => GetInstanceProperty<aws.Ecr.IEcrRegistryScanningConfigurationRule[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scanTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScanTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "rule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecr.EcrRegistryScanningConfigurationRule\"},\"kind\":\"array\"}}")]
        public virtual aws.Ecr.IEcrRegistryScanningConfigurationRule[] Rule
        {
            get => GetInstanceProperty<aws.Ecr.IEcrRegistryScanningConfigurationRule[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scanType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScanType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
