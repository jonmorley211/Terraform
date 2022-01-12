using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Globalaccelerator
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_listener aws_globalaccelerator_listener}.</summary>
    [JsiiClass(nativeType: typeof(aws.Globalaccelerator.GlobalacceleratorListener), fullyQualifiedName: "aws.globalaccelerator.GlobalacceleratorListener", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.globalaccelerator.GlobalacceleratorListenerConfig\"}}]")]
    public class GlobalacceleratorListener : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/globalaccelerator_listener aws_globalaccelerator_listener} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GlobalacceleratorListener(Constructs.Construct scope, string id, aws.Globalaccelerator.IGlobalacceleratorListenerConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlobalacceleratorListener(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlobalacceleratorListener(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.globalaccelerator.GlobalacceleratorListenerTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Globalaccelerator.IGlobalacceleratorListenerTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Globalaccelerator.IGlobalacceleratorListenerTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClientAffinity")]
        public virtual void ResetClientAffinity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.Globalaccelerator.GlobalacceleratorListener))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.globalaccelerator.GlobalacceleratorListenerTimeoutsOutputReference\"}")]
        public virtual aws.Globalaccelerator.GlobalacceleratorListenerTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Globalaccelerator.GlobalacceleratorListenerTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "acceleratorArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AcceleratorArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientAffinityInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientAffinityInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portRangeInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.globalaccelerator.GlobalacceleratorListenerPortRange\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Globalaccelerator.IGlobalacceleratorListenerPortRange[]? PortRangeInput
        {
            get => GetInstanceProperty<aws.Globalaccelerator.IGlobalacceleratorListenerPortRange[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.globalaccelerator.GlobalacceleratorListenerTimeouts\"}", isOptional: true)]
        public virtual aws.Globalaccelerator.IGlobalacceleratorListenerTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Globalaccelerator.IGlobalacceleratorListenerTimeouts?>();
        }

        [JsiiProperty(name: "acceleratorArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AcceleratorArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientAffinity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientAffinity
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "portRange", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.globalaccelerator.GlobalacceleratorListenerPortRange\"},\"kind\":\"array\"}}")]
        public virtual aws.Globalaccelerator.IGlobalacceleratorListenerPortRange[] PortRange
        {
            get => GetInstanceProperty<aws.Globalaccelerator.IGlobalacceleratorListenerPortRange[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
