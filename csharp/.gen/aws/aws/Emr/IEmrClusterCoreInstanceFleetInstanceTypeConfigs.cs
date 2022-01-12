using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    [JsiiInterface(nativeType: typeof(IEmrClusterCoreInstanceFleetInstanceTypeConfigs), fullyQualifiedName: "aws.emr.EmrClusterCoreInstanceFleetInstanceTypeConfigs")]
    public interface IEmrClusterCoreInstanceFleetInstanceTypeConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#instance_type EmrCluster#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#bid_price EmrCluster#bid_price}.</summary>
        [JsiiProperty(name: "bidPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BidPrice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#bid_price_as_percentage_of_on_demand_price EmrCluster#bid_price_as_percentage_of_on_demand_price}.</summary>
        [JsiiProperty(name: "bidPriceAsPercentageOfOnDemandPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BidPriceAsPercentageOfOnDemandPrice
        {
            get
            {
                return null;
            }
        }

        /// <summary>configurations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#configurations EmrCluster#configurations}
        /// </remarks>
        [JsiiProperty(name: "configurations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleetInstanceTypeConfigsConfigurations\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Emr.IEmrClusterCoreInstanceFleetInstanceTypeConfigsConfigurations[]? Configurations
        {
            get
            {
                return null;
            }
        }

        /// <summary>ebs_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#ebs_config EmrCluster#ebs_config}
        /// </remarks>
        [JsiiProperty(name: "ebsConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleetInstanceTypeConfigsEbsConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Emr.IEmrClusterCoreInstanceFleetInstanceTypeConfigsEbsConfig[]? EbsConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#weighted_capacity EmrCluster#weighted_capacity}.</summary>
        [JsiiProperty(name: "weightedCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WeightedCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterCoreInstanceFleetInstanceTypeConfigs), fullyQualifiedName: "aws.emr.EmrClusterCoreInstanceFleetInstanceTypeConfigs")]
        internal sealed class _Proxy : DeputyBase, aws.Emr.IEmrClusterCoreInstanceFleetInstanceTypeConfigs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#instance_type EmrCluster#instance_type}.</summary>
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#bid_price EmrCluster#bid_price}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bidPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BidPrice
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#bid_price_as_percentage_of_on_demand_price EmrCluster#bid_price_as_percentage_of_on_demand_price}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bidPriceAsPercentageOfOnDemandPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BidPriceAsPercentageOfOnDemandPrice
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>configurations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#configurations EmrCluster#configurations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configurations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleetInstanceTypeConfigsConfigurations\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Emr.IEmrClusterCoreInstanceFleetInstanceTypeConfigsConfigurations[]? Configurations
            {
                get => GetInstanceProperty<aws.Emr.IEmrClusterCoreInstanceFleetInstanceTypeConfigsConfigurations[]?>();
            }

            /// <summary>ebs_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#ebs_config EmrCluster#ebs_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ebsConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleetInstanceTypeConfigsEbsConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Emr.IEmrClusterCoreInstanceFleetInstanceTypeConfigsEbsConfig[]? EbsConfig
            {
                get => GetInstanceProperty<aws.Emr.IEmrClusterCoreInstanceFleetInstanceTypeConfigsEbsConfig[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#weighted_capacity EmrCluster#weighted_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weightedCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WeightedCapacity
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
