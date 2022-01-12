using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/msk_broker_nodes aws_msk_broker_nodes}.</summary>
    [JsiiClass(nativeType: typeof(aws.Msk.DataAwsMskBrokerNodes), fullyQualifiedName: "aws.msk.DataAwsMskBrokerNodes", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.msk.DataAwsMskBrokerNodesConfig\"}}]")]
    public class DataAwsMskBrokerNodes : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/msk_broker_nodes aws_msk_broker_nodes} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsMskBrokerNodes(Constructs.Construct scope, string id, aws.Msk.IDataAwsMskBrokerNodesConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMskBrokerNodes(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMskBrokerNodes(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "nodeInfoList", returnsJson: "{\"type\":{\"fqn\":\"aws.msk.DataAwsMskBrokerNodesNodeInfoList\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Msk.DataAwsMskBrokerNodesNodeInfoList NodeInfoList(string index)
        {
            return InvokeInstanceMethod<aws.Msk.DataAwsMskBrokerNodesNodeInfoList>(new System.Type[]{typeof(string)}, new object[]{index})!;
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
        = GetStaticProperty<string>(typeof(aws.Msk.DataAwsMskBrokerNodes))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "clusterArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
