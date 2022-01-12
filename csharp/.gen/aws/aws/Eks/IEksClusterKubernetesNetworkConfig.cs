using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    [JsiiInterface(nativeType: typeof(IEksClusterKubernetesNetworkConfig), fullyQualifiedName: "aws.eks.EksClusterKubernetesNetworkConfig")]
    public interface IEksClusterKubernetesNetworkConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_cluster#service_ipv4_cidr EksCluster#service_ipv4_cidr}.</summary>
        [JsiiProperty(name: "serviceIpv4Cidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceIpv4Cidr
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterKubernetesNetworkConfig), fullyQualifiedName: "aws.eks.EksClusterKubernetesNetworkConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Eks.IEksClusterKubernetesNetworkConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_cluster#service_ipv4_cidr EksCluster#service_ipv4_cidr}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceIpv4Cidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceIpv4Cidr
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
