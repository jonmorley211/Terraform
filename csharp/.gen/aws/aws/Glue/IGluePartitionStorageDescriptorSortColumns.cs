using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IGluePartitionStorageDescriptorSortColumns), fullyQualifiedName: "aws.glue.GluePartitionStorageDescriptorSortColumns")]
    public interface IGluePartitionStorageDescriptorSortColumns
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#column GluePartition#column}.</summary>
        [JsiiProperty(name: "column", typeJson: "{\"primitive\":\"string\"}")]
        string Column
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#sort_order GluePartition#sort_order}.</summary>
        [JsiiProperty(name: "sortOrder", typeJson: "{\"primitive\":\"number\"}")]
        double SortOrder
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGluePartitionStorageDescriptorSortColumns), fullyQualifiedName: "aws.glue.GluePartitionStorageDescriptorSortColumns")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGluePartitionStorageDescriptorSortColumns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#column GluePartition#column}.</summary>
            [JsiiProperty(name: "column", typeJson: "{\"primitive\":\"string\"}")]
            public string Column
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#sort_order GluePartition#sort_order}.</summary>
            [JsiiProperty(name: "sortOrder", typeJson: "{\"primitive\":\"number\"}")]
            public double SortOrder
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
