using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    [JsiiInterface(nativeType: typeof(IEmrInstanceFleetInstanceTypeConfigs), fullyQualifiedName: "aws.emr.EmrInstanceFleetInstanceTypeConfigs")]
    public interface IEmrInstanceFleetInstanceTypeConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#instance_type EmrInstanceFleet#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#bid_price EmrInstanceFleet#bid_price}.</summary>
        [JsiiProperty(name: "bidPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BidPrice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#bid_price_as_percentage_of_on_demand_price EmrInstanceFleet#bid_price_as_percentage_of_on_demand_price}.</summary>
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
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#configurations EmrInstanceFleet#configurations}
        /// </remarks>
        [JsiiProperty(name: "configurations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrInstanceFleetInstanceTypeConfigsConfigurations\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Emr.IEmrInstanceFleetInstanceTypeConfigsConfigurations[]? Configurations
        {
            get
            {
                return null;
            }
        }

        /// <summary>ebs_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#ebs_config EmrInstanceFleet#ebs_config}
        /// </remarks>
        [JsiiProperty(name: "ebsConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrInstanceFleetInstanceTypeConfigsEbsConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Emr.IEmrInstanceFleetInstanceTypeConfigsEbsConfig[]? EbsConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#weighted_capacity EmrInstanceFleet#weighted_capacity}.</summary>
        [JsiiProperty(name: "weightedCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WeightedCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrInstanceFleetInstanceTypeConfigs), fullyQualifiedName: "aws.emr.EmrInstanceFleetInstanceTypeConfigs")]
        internal sealed class _Proxy : DeputyBase, aws.Emr.IEmrInstanceFleetInstanceTypeConfigs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#instance_type EmrInstanceFleet#instance_type}.</summary>
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#bid_price EmrInstanceFleet#bid_price}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bidPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BidPrice
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#bid_price_as_percentage_of_on_demand_price EmrInstanceFleet#bid_price_as_percentage_of_on_demand_price}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bidPriceAsPercentageOfOnDemandPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BidPriceAsPercentageOfOnDemandPrice
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>configurations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#configurations EmrInstanceFleet#configurations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configurations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrInstanceFleetInstanceTypeConfigsConfigurations\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Emr.IEmrInstanceFleetInstanceTypeConfigsConfigurations[]? Configurations
            {
                get => GetInstanceProperty<aws.Emr.IEmrInstanceFleetInstanceTypeConfigsConfigurations[]?>();
            }

            /// <summary>ebs_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#ebs_config EmrInstanceFleet#ebs_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ebsConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrInstanceFleetInstanceTypeConfigsEbsConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Emr.IEmrInstanceFleetInstanceTypeConfigsEbsConfig[]? EbsConfig
            {
                get => GetInstanceProperty<aws.Emr.IEmrInstanceFleetInstanceTypeConfigsEbsConfig[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#weighted_capacity EmrInstanceFleet#weighted_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weightedCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WeightedCapacity
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
