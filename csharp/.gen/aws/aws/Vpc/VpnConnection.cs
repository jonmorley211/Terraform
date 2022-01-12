using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/vpn_connection aws_vpn_connection}.</summary>
    [JsiiClass(nativeType: typeof(aws.Vpc.VpnConnection), fullyQualifiedName: "aws.vpc.VpnConnection", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.vpc.VpnConnectionConfig\"}}]")]
    public class VpnConnection : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/vpn_connection aws_vpn_connection} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public VpnConnection(Constructs.Construct scope, string id, aws.Vpc.IVpnConnectionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpnConnection(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpnConnection(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEnableAcceleration")]
        public virtual void ResetEnableAcceleration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalIpv4NetworkCidr")]
        public virtual void ResetLocalIpv4NetworkCidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalIpv6NetworkCidr")]
        public virtual void ResetLocalIpv6NetworkCidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRemoteIpv4NetworkCidr")]
        public virtual void ResetRemoteIpv4NetworkCidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRemoteIpv6NetworkCidr")]
        public virtual void ResetRemoteIpv6NetworkCidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStaticRoutesOnly")]
        public virtual void ResetStaticRoutesOnly()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransitGatewayId")]
        public virtual void ResetTransitGatewayId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel1DpdTimeoutAction")]
        public virtual void ResetTunnel1DpdTimeoutAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel1DpdTimeoutSeconds")]
        public virtual void ResetTunnel1DpdTimeoutSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel1IkeVersions")]
        public virtual void ResetTunnel1IkeVersions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel1InsideCidr")]
        public virtual void ResetTunnel1InsideCidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel1InsideIpv6Cidr")]
        public virtual void ResetTunnel1InsideIpv6Cidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel1Phase1DhGroupNumbers")]
        public virtual void ResetTunnel1Phase1DhGroupNumbers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel1Phase1EncryptionAlgorithms")]
        public virtual void ResetTunnel1Phase1EncryptionAlgorithms()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel1Phase1IntegrityAlgorithms")]
        public virtual void ResetTunnel1Phase1IntegrityAlgorithms()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel1Phase1LifetimeSeconds")]
        public virtual void ResetTunnel1Phase1LifetimeSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel1Phase2DhGroupNumbers")]
        public virtual void ResetTunnel1Phase2DhGroupNumbers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel1Phase2EncryptionAlgorithms")]
        public virtual void ResetTunnel1Phase2EncryptionAlgorithms()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel1Phase2IntegrityAlgorithms")]
        public virtual void ResetTunnel1Phase2IntegrityAlgorithms()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel1Phase2LifetimeSeconds")]
        public virtual void ResetTunnel1Phase2LifetimeSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel1PresharedKey")]
        public virtual void ResetTunnel1PresharedKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel1RekeyFuzzPercentage")]
        public virtual void ResetTunnel1RekeyFuzzPercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel1RekeyMarginTimeSeconds")]
        public virtual void ResetTunnel1RekeyMarginTimeSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel1ReplayWindowSize")]
        public virtual void ResetTunnel1ReplayWindowSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel1StartupAction")]
        public virtual void ResetTunnel1StartupAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel2DpdTimeoutAction")]
        public virtual void ResetTunnel2DpdTimeoutAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel2DpdTimeoutSeconds")]
        public virtual void ResetTunnel2DpdTimeoutSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel2IkeVersions")]
        public virtual void ResetTunnel2IkeVersions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel2InsideCidr")]
        public virtual void ResetTunnel2InsideCidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel2InsideIpv6Cidr")]
        public virtual void ResetTunnel2InsideIpv6Cidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel2Phase1DhGroupNumbers")]
        public virtual void ResetTunnel2Phase1DhGroupNumbers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel2Phase1EncryptionAlgorithms")]
        public virtual void ResetTunnel2Phase1EncryptionAlgorithms()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel2Phase1IntegrityAlgorithms")]
        public virtual void ResetTunnel2Phase1IntegrityAlgorithms()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel2Phase1LifetimeSeconds")]
        public virtual void ResetTunnel2Phase1LifetimeSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel2Phase2DhGroupNumbers")]
        public virtual void ResetTunnel2Phase2DhGroupNumbers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel2Phase2EncryptionAlgorithms")]
        public virtual void ResetTunnel2Phase2EncryptionAlgorithms()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel2Phase2IntegrityAlgorithms")]
        public virtual void ResetTunnel2Phase2IntegrityAlgorithms()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel2Phase2LifetimeSeconds")]
        public virtual void ResetTunnel2Phase2LifetimeSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel2PresharedKey")]
        public virtual void ResetTunnel2PresharedKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel2RekeyFuzzPercentage")]
        public virtual void ResetTunnel2RekeyFuzzPercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel2RekeyMarginTimeSeconds")]
        public virtual void ResetTunnel2RekeyMarginTimeSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel2ReplayWindowSize")]
        public virtual void ResetTunnel2ReplayWindowSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnel2StartupAction")]
        public virtual void ResetTunnel2StartupAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTunnelInsideIpVersion")]
        public virtual void ResetTunnelInsideIpVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVpnGatewayId")]
        public virtual void ResetVpnGatewayId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "routes", returnsJson: "{\"type\":{\"fqn\":\"aws.vpc.VpnConnectionRoutes\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Vpc.VpnConnectionRoutes Routes(string index)
        {
            return InvokeInstanceMethod<aws.Vpc.VpnConnectionRoutes>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "vgwTelemetry", returnsJson: "{\"type\":{\"fqn\":\"aws.vpc.VpnConnectionVgwTelemetry\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Vpc.VpnConnectionVgwTelemetry VgwTelemetry(string index)
        {
            return InvokeInstanceMethod<aws.Vpc.VpnConnectionVgwTelemetry>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Vpc.VpnConnection))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerGatewayConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerGatewayConfiguration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "transitGatewayAttachmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransitGatewayAttachmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tunnel1Address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel1Address
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tunnel1BgpAsn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel1BgpAsn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tunnel1BgpHoldtime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tunnel1BgpHoldtime
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tunnel1CgwInsideAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel1CgwInsideAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tunnel1VgwInsideAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel1VgwInsideAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tunnel2Address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel2Address
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tunnel2BgpAsn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel2BgpAsn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tunnel2BgpHoldtime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tunnel2BgpHoldtime
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tunnel2CgwInsideAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel2CgwInsideAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tunnel2VgwInsideAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel2VgwInsideAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerGatewayIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerGatewayIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableAccelerationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableAccelerationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localIpv4NetworkCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocalIpv4NetworkCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localIpv6NetworkCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocalIpv6NetworkCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "remoteIpv4NetworkCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RemoteIpv4NetworkCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "remoteIpv6NetworkCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RemoteIpv6NetworkCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "staticRoutesOnlyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? StaticRoutesOnlyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsAllInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transitGatewayIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TransitGatewayIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel1DpdTimeoutActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Tunnel1DpdTimeoutActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel1DpdTimeoutSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? Tunnel1DpdTimeoutSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel1IkeVersionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? Tunnel1IkeVersionsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel1InsideCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Tunnel1InsideCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel1InsideIpv6CidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Tunnel1InsideIpv6CidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel1Phase1DhGroupNumbersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual double[]? Tunnel1Phase1DhGroupNumbersInput
        {
            get => GetInstanceProperty<double[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel1Phase1EncryptionAlgorithmsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? Tunnel1Phase1EncryptionAlgorithmsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel1Phase1IntegrityAlgorithmsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? Tunnel1Phase1IntegrityAlgorithmsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel1Phase1LifetimeSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? Tunnel1Phase1LifetimeSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel1Phase2DhGroupNumbersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual double[]? Tunnel1Phase2DhGroupNumbersInput
        {
            get => GetInstanceProperty<double[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel1Phase2EncryptionAlgorithmsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? Tunnel1Phase2EncryptionAlgorithmsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel1Phase2IntegrityAlgorithmsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? Tunnel1Phase2IntegrityAlgorithmsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel1Phase2LifetimeSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? Tunnel1Phase2LifetimeSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel1PresharedKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Tunnel1PresharedKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel1RekeyFuzzPercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? Tunnel1RekeyFuzzPercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel1RekeyMarginTimeSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? Tunnel1RekeyMarginTimeSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel1ReplayWindowSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? Tunnel1ReplayWindowSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel1StartupActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Tunnel1StartupActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel2DpdTimeoutActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Tunnel2DpdTimeoutActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel2DpdTimeoutSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? Tunnel2DpdTimeoutSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel2IkeVersionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? Tunnel2IkeVersionsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel2InsideCidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Tunnel2InsideCidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel2InsideIpv6CidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Tunnel2InsideIpv6CidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel2Phase1DhGroupNumbersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual double[]? Tunnel2Phase1DhGroupNumbersInput
        {
            get => GetInstanceProperty<double[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel2Phase1EncryptionAlgorithmsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? Tunnel2Phase1EncryptionAlgorithmsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel2Phase1IntegrityAlgorithmsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? Tunnel2Phase1IntegrityAlgorithmsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel2Phase1LifetimeSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? Tunnel2Phase1LifetimeSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel2Phase2DhGroupNumbersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual double[]? Tunnel2Phase2DhGroupNumbersInput
        {
            get => GetInstanceProperty<double[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel2Phase2EncryptionAlgorithmsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? Tunnel2Phase2EncryptionAlgorithmsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel2Phase2IntegrityAlgorithmsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? Tunnel2Phase2IntegrityAlgorithmsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel2Phase2LifetimeSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? Tunnel2Phase2LifetimeSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel2PresharedKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Tunnel2PresharedKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel2RekeyFuzzPercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? Tunnel2RekeyFuzzPercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel2RekeyMarginTimeSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? Tunnel2RekeyMarginTimeSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel2ReplayWindowSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? Tunnel2ReplayWindowSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnel2StartupActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Tunnel2StartupActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tunnelInsideIpVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TunnelInsideIpVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpnGatewayIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VpnGatewayIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "customerGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerGatewayId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableAcceleration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnableAcceleration
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localIpv4NetworkCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalIpv4NetworkCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localIpv6NetworkCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalIpv6NetworkCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "remoteIpv4NetworkCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemoteIpv4NetworkCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "remoteIpv6NetworkCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemoteIpv6NetworkCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "staticRoutesOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object StaticRoutesOnly
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object Tags
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object TagsAll
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transitGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransitGatewayId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel1DpdTimeoutAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel1DpdTimeoutAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel1DpdTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tunnel1DpdTimeoutSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel1IkeVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tunnel1IkeVersions
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel1InsideCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel1InsideCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel1InsideIpv6Cidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel1InsideIpv6Cidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel1Phase1DhGroupNumbers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] Tunnel1Phase1DhGroupNumbers
        {
            get => GetInstanceProperty<double[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel1Phase1EncryptionAlgorithms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tunnel1Phase1EncryptionAlgorithms
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel1Phase1IntegrityAlgorithms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tunnel1Phase1IntegrityAlgorithms
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel1Phase1LifetimeSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tunnel1Phase1LifetimeSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel1Phase2DhGroupNumbers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] Tunnel1Phase2DhGroupNumbers
        {
            get => GetInstanceProperty<double[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel1Phase2EncryptionAlgorithms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tunnel1Phase2EncryptionAlgorithms
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel1Phase2IntegrityAlgorithms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tunnel1Phase2IntegrityAlgorithms
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel1Phase2LifetimeSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tunnel1Phase2LifetimeSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel1PresharedKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel1PresharedKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel1RekeyFuzzPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tunnel1RekeyFuzzPercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel1RekeyMarginTimeSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tunnel1RekeyMarginTimeSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel1ReplayWindowSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tunnel1ReplayWindowSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel1StartupAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel1StartupAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel2DpdTimeoutAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel2DpdTimeoutAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel2DpdTimeoutSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tunnel2DpdTimeoutSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel2IkeVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tunnel2IkeVersions
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel2InsideCidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel2InsideCidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel2InsideIpv6Cidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel2InsideIpv6Cidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel2Phase1DhGroupNumbers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] Tunnel2Phase1DhGroupNumbers
        {
            get => GetInstanceProperty<double[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel2Phase1EncryptionAlgorithms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tunnel2Phase1EncryptionAlgorithms
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel2Phase1IntegrityAlgorithms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tunnel2Phase1IntegrityAlgorithms
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel2Phase1LifetimeSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tunnel2Phase1LifetimeSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel2Phase2DhGroupNumbers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] Tunnel2Phase2DhGroupNumbers
        {
            get => GetInstanceProperty<double[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel2Phase2EncryptionAlgorithms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tunnel2Phase2EncryptionAlgorithms
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel2Phase2IntegrityAlgorithms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tunnel2Phase2IntegrityAlgorithms
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel2Phase2LifetimeSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tunnel2Phase2LifetimeSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel2PresharedKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel2PresharedKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel2RekeyFuzzPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tunnel2RekeyFuzzPercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel2RekeyMarginTimeSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tunnel2RekeyMarginTimeSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel2ReplayWindowSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Tunnel2ReplayWindowSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnel2StartupAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tunnel2StartupAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tunnelInsideIpVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TunnelInsideIpVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vpnGatewayId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpnGatewayId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
