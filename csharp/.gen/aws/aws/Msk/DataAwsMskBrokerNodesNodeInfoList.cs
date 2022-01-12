using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiClass(nativeType: typeof(aws.Msk.DataAwsMskBrokerNodesNodeInfoList), fullyQualifiedName: "aws.msk.DataAwsMskBrokerNodesNodeInfoList", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsMskBrokerNodesNodeInfoList : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsMskBrokerNodesNodeInfoList(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMskBrokerNodesNodeInfoList(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMskBrokerNodesNodeInfoList(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "attachedEniId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AttachedEniId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "brokerId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BrokerId
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "clientSubnet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientSubnet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientVpcIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientVpcIpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Endpoints
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "nodeArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeArn
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
