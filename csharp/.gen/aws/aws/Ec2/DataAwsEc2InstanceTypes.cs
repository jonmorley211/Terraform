using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_types aws_ec2_instance_types}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ec2.DataAwsEc2InstanceTypes), fullyQualifiedName: "aws.ec2.DataAwsEc2InstanceTypes", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypesConfig\"}}]")]
    public class DataAwsEc2InstanceTypes : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/ec2_instance_types aws_ec2_instance_types} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsEc2InstanceTypes(Constructs.Construct scope, string id, aws.Ec2.IDataAwsEc2InstanceTypesConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2InstanceTypes(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2InstanceTypes(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
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
        = GetStaticProperty<string>(typeof(aws.Ec2.DataAwsEc2InstanceTypes))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] InstanceTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypesFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ec2.IDataAwsEc2InstanceTypesFilter[]? FilterInput
        {
            get => GetInstanceProperty<aws.Ec2.IDataAwsEc2InstanceTypesFilter[]?>();
        }

        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.DataAwsEc2InstanceTypesFilter\"},\"kind\":\"array\"}}")]
        public virtual aws.Ec2.IDataAwsEc2InstanceTypesFilter[] Filter
        {
            get => GetInstanceProperty<aws.Ec2.IDataAwsEc2InstanceTypesFilter[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}