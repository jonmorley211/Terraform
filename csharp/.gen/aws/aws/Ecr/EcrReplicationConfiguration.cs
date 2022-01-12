using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration aws_ecr_replication_configuration}.</summary>
    [JsiiClass(nativeType: typeof(aws.Ecr.EcrReplicationConfiguration), fullyQualifiedName: "aws.ecr.EcrReplicationConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.ecr.EcrReplicationConfigurationConfig\"}}]")]
    public class EcrReplicationConfiguration : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/ecr_replication_configuration aws_ecr_replication_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EcrReplicationConfiguration(Constructs.Construct scope, string id, aws.Ecr.IEcrReplicationConfigurationConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcrReplicationConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcrReplicationConfiguration(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putReplicationConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecr.EcrReplicationConfigurationReplicationConfiguration\"}}]")]
        public virtual void PutReplicationConfiguration(aws.Ecr.IEcrReplicationConfigurationReplicationConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ecr.IEcrReplicationConfigurationReplicationConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetReplicationConfiguration")]
        public virtual void ResetReplicationConfiguration()
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
        = GetStaticProperty<string>(typeof(aws.Ecr.EcrReplicationConfiguration))!;

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

        [JsiiProperty(name: "replicationConfiguration", typeJson: "{\"fqn\":\"aws.ecr.EcrReplicationConfigurationReplicationConfigurationOutputReference\"}")]
        public virtual aws.Ecr.EcrReplicationConfigurationReplicationConfigurationOutputReference ReplicationConfiguration
        {
            get => GetInstanceProperty<aws.Ecr.EcrReplicationConfigurationReplicationConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationConfigurationInput", typeJson: "{\"fqn\":\"aws.ecr.EcrReplicationConfigurationReplicationConfiguration\"}", isOptional: true)]
        public virtual aws.Ecr.IEcrReplicationConfigurationReplicationConfiguration? ReplicationConfigurationInput
        {
            get => GetInstanceProperty<aws.Ecr.IEcrReplicationConfigurationReplicationConfiguration?>();
        }
    }
}
