using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    [JsiiByValue(fqn: "aws.emr.EmrClusterMasterInstanceFleetInstanceTypeConfigsConfigurations")]
    public class EmrClusterMasterInstanceFleetInstanceTypeConfigsConfigurations : aws.Emr.IEmrClusterMasterInstanceFleetInstanceTypeConfigsConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#classification EmrCluster#classification}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "classification", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Classification
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#properties EmrCluster#properties}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "properties", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true, isOverride: true)]
        public object? Properties
        {
            get;
            set;
        }
    }
}
