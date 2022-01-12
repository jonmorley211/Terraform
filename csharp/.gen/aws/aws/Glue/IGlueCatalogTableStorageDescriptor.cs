using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogTableStorageDescriptor), fullyQualifiedName: "aws.glue.GlueCatalogTableStorageDescriptor")]
    public interface IGlueCatalogTableStorageDescriptor
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#bucket_columns GlueCatalogTable#bucket_columns}.</summary>
        [JsiiProperty(name: "bucketColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? BucketColumns
        {
            get
            {
                return null;
            }
        }

        /// <summary>columns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#columns GlueCatalogTable#columns}
        /// </remarks>
        [JsiiProperty(name: "columns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorColumns\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Glue.IGlueCatalogTableStorageDescriptorColumns[]? Columns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#compressed GlueCatalogTable#compressed}.</summary>
        [JsiiProperty(name: "compressed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Compressed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#input_format GlueCatalogTable#input_format}.</summary>
        [JsiiProperty(name: "inputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InputFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#location GlueCatalogTable#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Location
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#number_of_buckets GlueCatalogTable#number_of_buckets}.</summary>
        [JsiiProperty(name: "numberOfBuckets", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NumberOfBuckets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#output_format GlueCatalogTable#output_format}.</summary>
        [JsiiProperty(name: "outputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutputFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#parameters GlueCatalogTable#parameters}.</summary>
        [JsiiProperty(name: "parameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Parameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>schema_reference block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#schema_reference GlueCatalogTable#schema_reference}
        /// </remarks>
        [JsiiProperty(name: "schemaReference", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSchemaReference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Glue.IGlueCatalogTableStorageDescriptorSchemaReference? SchemaReference
        {
            get
            {
                return null;
            }
        }

        /// <summary>ser_de_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#ser_de_info GlueCatalogTable#ser_de_info}
        /// </remarks>
        [JsiiProperty(name: "serDeInfo", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSerDeInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Glue.IGlueCatalogTableStorageDescriptorSerDeInfo? SerDeInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>skewed_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#skewed_info GlueCatalogTable#skewed_info}
        /// </remarks>
        [JsiiProperty(name: "skewedInfo", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSkewedInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Glue.IGlueCatalogTableStorageDescriptorSkewedInfo? SkewedInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>sort_columns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#sort_columns GlueCatalogTable#sort_columns}
        /// </remarks>
        [JsiiProperty(name: "sortColumns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSortColumns\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Glue.IGlueCatalogTableStorageDescriptorSortColumns[]? SortColumns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#stored_as_sub_directories GlueCatalogTable#stored_as_sub_directories}.</summary>
        [JsiiProperty(name: "storedAsSubDirectories", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StoredAsSubDirectories
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogTableStorageDescriptor), fullyQualifiedName: "aws.glue.GlueCatalogTableStorageDescriptor")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueCatalogTableStorageDescriptor
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#bucket_columns GlueCatalogTable#bucket_columns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bucketColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? BucketColumns
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>columns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#columns GlueCatalogTable#columns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "columns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorColumns\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Glue.IGlueCatalogTableStorageDescriptorColumns[]? Columns
            {
                get => GetInstanceProperty<aws.Glue.IGlueCatalogTableStorageDescriptorColumns[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#compressed GlueCatalogTable#compressed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compressed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Compressed
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#input_format GlueCatalogTable#input_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#location GlueCatalogTable#location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Location
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#number_of_buckets GlueCatalogTable#number_of_buckets}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "numberOfBuckets", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NumberOfBuckets
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#output_format GlueCatalogTable#output_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutputFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#parameters GlueCatalogTable#parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Parameters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>schema_reference block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#schema_reference GlueCatalogTable#schema_reference}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schemaReference", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSchemaReference\"}", isOptional: true)]
            public aws.Glue.IGlueCatalogTableStorageDescriptorSchemaReference? SchemaReference
            {
                get => GetInstanceProperty<aws.Glue.IGlueCatalogTableStorageDescriptorSchemaReference?>();
            }

            /// <summary>ser_de_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#ser_de_info GlueCatalogTable#ser_de_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serDeInfo", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSerDeInfo\"}", isOptional: true)]
            public aws.Glue.IGlueCatalogTableStorageDescriptorSerDeInfo? SerDeInfo
            {
                get => GetInstanceProperty<aws.Glue.IGlueCatalogTableStorageDescriptorSerDeInfo?>();
            }

            /// <summary>skewed_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#skewed_info GlueCatalogTable#skewed_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skewedInfo", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSkewedInfo\"}", isOptional: true)]
            public aws.Glue.IGlueCatalogTableStorageDescriptorSkewedInfo? SkewedInfo
            {
                get => GetInstanceProperty<aws.Glue.IGlueCatalogTableStorageDescriptorSkewedInfo?>();
            }

            /// <summary>sort_columns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#sort_columns GlueCatalogTable#sort_columns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sortColumns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSortColumns\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Glue.IGlueCatalogTableStorageDescriptorSortColumns[]? SortColumns
            {
                get => GetInstanceProperty<aws.Glue.IGlueCatalogTableStorageDescriptorSortColumns[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_catalog_table#stored_as_sub_directories GlueCatalogTable#stored_as_sub_directories}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storedAsSubDirectories", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? StoredAsSubDirectories
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
