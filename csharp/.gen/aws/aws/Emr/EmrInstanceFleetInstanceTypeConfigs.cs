using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emr.EmrInstanceFleetInstanceTypeConfigs")]
    public class EmrInstanceFleetInstanceTypeConfigs : aws.Emr.IEmrInstanceFleetInstanceTypeConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#instance_type EmrInstanceFleet#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string InstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#bid_price EmrInstanceFleet#bid_price}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bidPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? BidPrice
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#bid_price_as_percentage_of_on_demand_price EmrInstanceFleet#bid_price_as_percentage_of_on_demand_price}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bidPriceAsPercentageOfOnDemandPrice", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? BidPriceAsPercentageOfOnDemandPrice
        {
            get;
            set;
        }

        /// <summary>configurations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#configurations EmrInstanceFleet#configurations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configurations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrInstanceFleetInstanceTypeConfigsConfigurations\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Emr.IEmrInstanceFleetInstanceTypeConfigsConfigurations[]? Configurations
        {
            get;
            set;
        }

        /// <summary>ebs_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#ebs_config EmrInstanceFleet#ebs_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ebsConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrInstanceFleetInstanceTypeConfigsEbsConfig\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Emr.IEmrInstanceFleetInstanceTypeConfigsEbsConfig[]? EbsConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet#weighted_capacity EmrInstanceFleet#weighted_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weightedCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? WeightedCapacity
        {
            get;
            set;
        }
    }
}
