using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/route_table aws_route_table}.</summary>
    [JsiiClass(nativeType: typeof(aws.Vpc.RouteTable), fullyQualifiedName: "aws.vpc.RouteTable", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.vpc.RouteTableConfig\"}}]")]
    public class RouteTable : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/route_table aws_route_table} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public RouteTable(Constructs.Construct scope, string id, aws.Vpc.IRouteTableConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RouteTable(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RouteTable(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpc.RouteTableTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Vpc.IRouteTableTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Vpc.IRouteTableTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPropagatingVgws")]
        public virtual void ResetPropagatingVgws()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoute")]
        public virtual void ResetRoute()
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
        = GetStaticProperty<string>(typeof(aws.Vpc.RouteTable))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ownerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OwnerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.vpc.RouteTableTimeoutsOutputReference\"}")]
        public virtual aws.Vpc.RouteTableTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Vpc.RouteTableTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "propagatingVgwsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PropagatingVgwsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routeInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.vpc.RouteTableRoute\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Vpc.IRouteTableRoute[]? RouteInput
        {
            get => GetInstanceProperty<aws.Vpc.IRouteTableRoute[]?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.vpc.RouteTableTimeouts\"}", isOptional: true)]
        public virtual aws.Vpc.IRouteTableTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Vpc.IRouteTableTimeouts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vpcIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VpcIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "propagatingVgws", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PropagatingVgws
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "route", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.vpc.RouteTableRoute\"},\"kind\":\"array\"}}")]
        public virtual aws.Vpc.IRouteTableRoute[] Route
        {
            get => GetInstanceProperty<aws.Vpc.IRouteTableRoute[]>()!;
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

        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VpcId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
