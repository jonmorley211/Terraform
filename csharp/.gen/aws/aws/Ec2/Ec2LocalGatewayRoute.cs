using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/ec2_local_gateway_route aws_ec2_local_gateway_route}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ec2.Ec2LocalGatewayRoute), fullyQualifiedName: "aws.ec2.Ec2LocalGatewayRoute", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.ec2.Ec2LocalGatewayRouteConfig\"}}]")]
    public class Ec2LocalGatewayRoute : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/ec2_local_gateway_route aws_ec2_local_gateway_route} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Ec2LocalGatewayRoute(Constructs.Construct scope, string id, aws.Ec2.IEc2LocalGatewayRouteConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2LocalGatewayRoute(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Ec2LocalGatewayRoute(DeputyProps props): base(props)
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
        = GetStaticProperty<string>(typeof(aws.Ec2.Ec2LocalGatewayRoute))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationCidrBlockInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationCidrBlockInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localGatewayRouteTableIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocalGatewayRouteTableIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localGatewayVirtualInterfaceGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocalGatewayVirtualInterfaceGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "destinationCidrBlock", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationCidrBlock
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localGatewayRouteTableId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalGatewayRouteTableId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "localGatewayVirtualInterfaceGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalGatewayVirtualInterfaceGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
