using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiByValue(fqn: "aws.glue.GluePartitionIndexPartitionIndex")]
    public class GluePartitionIndexPartitionIndex : aws.Glue.IGluePartitionIndexPartitionIndex
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition_index#index_name GluePartitionIndex#index_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? IndexName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition_index#keys GluePartitionIndex#keys}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Keys
        {
            get;
            set;
        }
    }
}
