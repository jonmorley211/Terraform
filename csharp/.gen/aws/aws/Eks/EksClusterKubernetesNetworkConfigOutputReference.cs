using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    [JsiiClass(nativeType: typeof(aws.Eks.EksClusterKubernetesNetworkConfigOutputReference), fullyQualifiedName: "aws.eks.EksClusterKubernetesNetworkConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class EksClusterKubernetesNetworkConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public EksClusterKubernetesNetworkConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksClusterKubernetesNetworkConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EksClusterKubernetesNetworkConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetServiceIpv4Cidr")]
        public virtual void ResetServiceIpv4Cidr()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceIpv4CidrInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceIpv4CidrInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "serviceIpv4Cidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceIpv4Cidr
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.eks.EksClusterKubernetesNetworkConfig\"}", isOptional: true)]
        public virtual aws.Eks.IEksClusterKubernetesNetworkConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Eks.IEksClusterKubernetesNetworkConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
