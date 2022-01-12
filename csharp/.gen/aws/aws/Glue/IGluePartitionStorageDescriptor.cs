using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IGluePartitionStorageDescriptor), fullyQualifiedName: "aws.glue.GluePartitionStorageDescriptor")]
    public interface IGluePartitionStorageDescriptor
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#bucket_columns GluePartition#bucket_columns}.</summary>
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
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#columns GluePartition#columns}
        /// </remarks>
        [JsiiProperty(name: "columns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GluePartitionStorageDescriptorColumns\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Glue.IGluePartitionStorageDescriptorColumns[]? Columns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#compressed GluePartition#compressed}.</summary>
        [JsiiProperty(name: "compressed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Compressed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#input_format GluePartition#input_format}.</summary>
        [JsiiProperty(name: "inputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InputFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#location GluePartition#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Location
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#number_of_buckets GluePartition#number_of_buckets}.</summary>
        [JsiiProperty(name: "numberOfBuckets", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NumberOfBuckets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#output_format GluePartition#output_format}.</summary>
        [JsiiProperty(name: "outputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutputFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#parameters GluePartition#parameters}.</summary>
        [JsiiProperty(name: "parameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Parameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>ser_de_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#ser_de_info GluePartition#ser_de_info}
        /// </remarks>
        [JsiiProperty(name: "serDeInfo", typeJson: "{\"fqn\":\"aws.glue.GluePartitionStorageDescriptorSerDeInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Glue.IGluePartitionStorageDescriptorSerDeInfo? SerDeInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>skewed_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#skewed_info GluePartition#skewed_info}
        /// </remarks>
        [JsiiProperty(name: "skewedInfo", typeJson: "{\"fqn\":\"aws.glue.GluePartitionStorageDescriptorSkewedInfo\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Glue.IGluePartitionStorageDescriptorSkewedInfo? SkewedInfo
        {
            get
            {
                return null;
            }
        }

        /// <summary>sort_columns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#sort_columns GluePartition#sort_columns}
        /// </remarks>
        [JsiiProperty(name: "sortColumns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GluePartitionStorageDescriptorSortColumns\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Glue.IGluePartitionStorageDescriptorSortColumns[]? SortColumns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#stored_as_sub_directories GluePartition#stored_as_sub_directories}.</summary>
        [JsiiProperty(name: "storedAsSubDirectories", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StoredAsSubDirectories
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGluePartitionStorageDescriptor), fullyQualifiedName: "aws.glue.GluePartitionStorageDescriptor")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGluePartitionStorageDescriptor
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#bucket_columns GluePartition#bucket_columns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bucketColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? BucketColumns
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>columns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#columns GluePartition#columns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "columns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GluePartitionStorageDescriptorColumns\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Glue.IGluePartitionStorageDescriptorColumns[]? Columns
            {
                get => GetInstanceProperty<aws.Glue.IGluePartitionStorageDescriptorColumns[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#compressed GluePartition#compressed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compressed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Compressed
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#input_format GluePartition#input_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "inputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InputFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#location GluePartition#location}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Location
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#number_of_buckets GluePartition#number_of_buckets}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "numberOfBuckets", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NumberOfBuckets
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#output_format GluePartition#output_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outputFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutputFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#parameters GluePartition#parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Parameters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ser_de_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#ser_de_info GluePartition#ser_de_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serDeInfo", typeJson: "{\"fqn\":\"aws.glue.GluePartitionStorageDescriptorSerDeInfo\"}", isOptional: true)]
            public aws.Glue.IGluePartitionStorageDescriptorSerDeInfo? SerDeInfo
            {
                get => GetInstanceProperty<aws.Glue.IGluePartitionStorageDescriptorSerDeInfo?>();
            }

            /// <summary>skewed_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#skewed_info GluePartition#skewed_info}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skewedInfo", typeJson: "{\"fqn\":\"aws.glue.GluePartitionStorageDescriptorSkewedInfo\"}", isOptional: true)]
            public aws.Glue.IGluePartitionStorageDescriptorSkewedInfo? SkewedInfo
            {
                get => GetInstanceProperty<aws.Glue.IGluePartitionStorageDescriptorSkewedInfo?>();
            }

            /// <summary>sort_columns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#sort_columns GluePartition#sort_columns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sortColumns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GluePartitionStorageDescriptorSortColumns\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Glue.IGluePartitionStorageDescriptorSortColumns[]? SortColumns
            {
                get => GetInstanceProperty<aws.Glue.IGluePartitionStorageDescriptorSortColumns[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_partition#stored_as_sub_directories GluePartition#stored_as_sub_directories}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storedAsSubDirectories", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? StoredAsSubDirectories
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
