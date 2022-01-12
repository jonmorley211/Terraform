using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    [JsiiByValue(fqn: "aws.eks.EksClusterKubernetesNetworkConfig")]
    public class EksClusterKubernetesNetworkConfig : aws.Eks.IEksClusterKubernetesNetworkConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_cluster#service_ipv4_cidr EksCluster#service_ipv4_cidr}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceIpv4Cidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ServiceIpv4Cidr
        {
            get;
            set;
        }
    }
}
