using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/load_balancer_listener_policy aws_load_balancer_listener_policy}.</summary>
    [JsiiClass(nativeType: typeof(aws.Elb.LoadBalancerListenerPolicy), fullyQualifiedName: "aws.elb.LoadBalancerListenerPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.elb.LoadBalancerListenerPolicyConfig\"}}]")]
    public class LoadBalancerListenerPolicy : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/load_balancer_listener_policy aws_load_balancer_listener_policy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LoadBalancerListenerPolicy(Constructs.Construct scope, string id, aws.Elb.ILoadBalancerListenerPolicyConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadBalancerListenerPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoadBalancerListenerPolicy(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetPolicyNames")]
        public virtual void ResetPolicyNames()
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
        = GetStaticProperty<string>(typeof(aws.Elb.LoadBalancerListenerPolicy))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoadBalancerNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LoadBalancerPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyNamesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PolicyNamesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "loadBalancerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoadBalancerName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loadBalancerPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LoadBalancerPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policyNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PolicyNames
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
