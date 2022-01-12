using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    [JsiiByValue(fqn: "aws.eks.EksNodeGroupUpdateConfig")]
    public class EksNodeGroupUpdateConfig : aws.Eks.IEksNodeGroupUpdateConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#max_unavailable EksNodeGroup#max_unavailable}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxUnavailable", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxUnavailable
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#max_unavailable_percentage EksNodeGroup#max_unavailable_percentage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxUnavailablePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxUnavailablePercentage
        {
            get;
            set;
        }
    }
}
