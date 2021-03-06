using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogTableStorageDescriptorSortColumns), fullyQualifiedName: "aws.glue.GlueCatalogTableStorageDescriptorSortColumns")]
    public interface IGlueCatalogTableStorageDescriptorSortColumns
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#column GlueCatalogTable#column}.</summary>
        [JsiiProperty(name: "column", typeJson: "{\"primitive\":\"string\"}")]
        string Column
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#sort_order GlueCatalogTable#sort_order}.</summary>
        [JsiiProperty(name: "sortOrder", typeJson: "{\"primitive\":\"number\"}")]
        double SortOrder
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogTableStorageDescriptorSortColumns), fullyQualifiedName: "aws.glue.GlueCatalogTableStorageDescriptorSortColumns")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueCatalogTableStorageDescriptorSortColumns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#column GlueCatalogTable#column}.</summary>
            [JsiiProperty(name: "column", typeJson: "{\"primitive\":\"string\"}")]
            public string Column
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#sort_order GlueCatalogTable#sort_order}.</summary>
            [JsiiProperty(name: "sortOrder", typeJson: "{\"primitive\":\"number\"}")]
            public double SortOrder
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
