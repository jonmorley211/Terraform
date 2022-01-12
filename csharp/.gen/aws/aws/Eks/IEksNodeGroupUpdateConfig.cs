using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eks
{
    [JsiiInterface(nativeType: typeof(IEksNodeGroupUpdateConfig), fullyQualifiedName: "aws.eks.EksNodeGroupUpdateConfig")]
    public interface IEksNodeGroupUpdateConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#max_unavailable EksNodeGroup#max_unavailable}.</summary>
        [JsiiProperty(name: "maxUnavailable", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxUnavailable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#max_unavailable_percentage EksNodeGroup#max_unavailable_percentage}.</summary>
        [JsiiProperty(name: "maxUnavailablePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxUnavailablePercentage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksNodeGroupUpdateConfig), fullyQualifiedName: "aws.eks.EksNodeGroupUpdateConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Eks.IEksNodeGroupUpdateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#max_unavailable EksNodeGroup#max_unavailable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxUnavailable", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxUnavailable
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/eks_node_group#max_unavailable_percentage EksNodeGroup#max_unavailable_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxUnavailablePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxUnavailablePercentage
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
