using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glue.GluePartitionStorageDescriptorSortColumns")]
    public class GluePartitionStorageDescriptorSortColumns : aws.Glue.IGluePartitionStorageDescriptorSortColumns
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#column GluePartition#column}.</summary>
        [JsiiProperty(name: "column", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Column
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#sort_order GluePartition#sort_order}.</summary>
        [JsiiProperty(name: "sortOrder", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double SortOrder
        {
            get;
            set;
        }
    }
}
