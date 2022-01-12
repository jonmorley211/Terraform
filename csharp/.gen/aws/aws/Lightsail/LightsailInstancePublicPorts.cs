using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lightsail
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/lightsail_instance_public_ports aws_lightsail_instance_public_ports}.</summary>
    [JsiiClass(nativeType: typeof(aws.Lightsail.LightsailInstancePublicPorts), fullyQualifiedName: "aws.lightsail.LightsailInstancePublicPorts", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lightsail.LightsailInstancePublicPortsConfig\"}}]")]
    public class LightsailInstancePublicPorts : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/lightsail_instance_public_ports aws_lightsail_instance_public_ports} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LightsailInstancePublicPorts(Constructs.Construct scope, string id, aws.Lightsail.ILightsailInstancePublicPortsConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LightsailInstancePublicPorts(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LightsailInstancePublicPorts(DeputyProps props): base(props)
        {
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
        = GetStaticProperty<string>(typeof(aws.Lightsail.LightsailInstancePublicPorts))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portInfoInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lightsail.LightsailInstancePublicPortsPortInfo\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Lightsail.ILightsailInstancePublicPortsPortInfo[]? PortInfoInput
        {
            get => GetInstanceProperty<aws.Lightsail.ILightsailInstancePublicPortsPortInfo[]?>();
        }

        [JsiiProperty(name: "instanceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "portInfo", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lightsail.LightsailInstancePublicPortsPortInfo\"},\"kind\":\"array\"}}")]
        public virtual aws.Lightsail.ILightsailInstancePublicPortsPortInfo[] PortInfo
        {
            get => GetInstanceProperty<aws.Lightsail.ILightsailInstancePublicPortsPortInfo[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
