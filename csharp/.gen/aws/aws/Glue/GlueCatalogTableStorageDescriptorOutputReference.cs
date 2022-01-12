using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiClass(nativeType: typeof(aws.Glue.GlueCatalogTableStorageDescriptorOutputReference), fullyQualifiedName: "aws.glue.GlueCatalogTableStorageDescriptorOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class GlueCatalogTableStorageDescriptorOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public GlueCatalogTableStorageDescriptorOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCatalogTableStorageDescriptorOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCatalogTableStorageDescriptorOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSchemaReference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSchemaReference\"}}]")]
        public virtual void PutSchemaReference(aws.Glue.IGlueCatalogTableStorageDescriptorSchemaReference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueCatalogTableStorageDescriptorSchemaReference)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSerDeInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSerDeInfo\"}}]")]
        public virtual void PutSerDeInfo(aws.Glue.IGlueCatalogTableStorageDescriptorSerDeInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueCatalogTableStorageDescriptorSerDeInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSkewedInfo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSkewedInfo\"}}]")]
        public virtual void PutSkewedInfo(aws.Glue.IGlueCatalogTableStorageDescriptorSkewedInfo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueCatalogTableStorageDescriptorSkewedInfo)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBucketColumns")]
        public virtual void ResetBucketColumns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetColumns")]
        public virtual void ResetColumns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompressed")]
        public virtual void ResetCompressed()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInputFormat")]
        public virtual void ResetInputFormat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocation")]
        public virtual void ResetLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumberOfBuckets")]
        public virtual void ResetNumberOfBuckets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputFormat")]
        public virtual void ResetOutputFormat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParameters")]
        public virtual void ResetParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchemaReference")]
        public virtual void ResetSchemaReference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSerDeInfo")]
        public virtual void ResetSerDeInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSkewedInfo")]
        public virtual void ResetSkewedInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSortColumns")]
        public virtual void ResetSortColumns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStoredAsSubDirectories")]
        public virtual void ResetStoredAsSubDirectories()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "schemaReference", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSchemaReferenceOutputReference\"}")]
        public virtual aws.Glue.GlueCatalogTableStorageDescriptorSchemaReferenceOutputReference SchemaReference
        {
            get => GetInstanceProperty<aws.Glue.GlueCatalogTableStorageDescriptorSchemaReferenceOutputReference>()!;
        }

        [JsiiProperty(name: "serDeInfo", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSerDeInfoOutputReference\"}")]
        public virtual aws.Glue.GlueCatalogTableStorageDescriptorSerDeInfoOutputReference SerDeInfo
        {
            get => GetInstanceProperty<aws.Glue.GlueCatalogTableStorageDescriptorSerDeInfoOutputReference>()!;
        }

        [JsiiProperty(name: "skewedInfo", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSkewedInfoOutputReference\"}")]
        public virtual aws.Glue.GlueCatalogTableStorageDescriptorSkewedInfoOutputReference SkewedInfo
        {
            get => GetInstanceProperty<aws.Glue.GlueCatalogTableStorageDescriptorSkewedInfoOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketColumnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? BucketColumnsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "columnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorColumns\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Glue.IGlueCatalogTableStorageDescriptorColumns[]? ColumnsInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueCatalogTableStorageDescriptorColumns[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compressedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CompressedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inputFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InputFormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberOfBucketsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NumberOfBucketsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutputFormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parametersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? ParametersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaReferenceInput", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSchemaReference\"}", isOptional: true)]
        public virtual aws.Glue.IGlueCatalogTableStorageDescriptorSchemaReference? SchemaReferenceInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueCatalogTableStorageDescriptorSchemaReference?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serDeInfoInput", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSerDeInfo\"}", isOptional: true)]
        public virtual aws.Glue.IGlueCatalogTableStorageDescriptorSerDeInfo? SerDeInfoInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueCatalogTableStorageDescriptorSerDeInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skewedInfoInput", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSkewedInfo\"}", isOptional: true)]
        public virtual aws.Glue.IGlueCatalogTableStorageDescriptorSkewedInfo? SkewedInfoInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueCatalogTableStorageDescriptorSkewedInfo?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sortColumnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSortColumns\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Glue.IGlueCatalogTableStorageDescriptorSortColumns[]? SortColumnsInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueCatalogTableStorageDescriptorSortColumns[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storedAsSubDirectoriesInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? StoredAsSubDirectoriesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "bucketColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] BucketColumns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "columns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorColumns\"},\"kind\":\"array\"}}")]
        public virtual aws.Glue.IGlueCatalogTableStorageDescriptorColumns[] Columns
        {
            get => GetInstanceProperty<aws.Glue.IGlueCatalogTableStorageDescriptorColumns[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compressed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Compressed
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "inputFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InputFormat
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "numberOfBuckets", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfBuckets
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "outputFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputFormat
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object Parameters
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sortColumns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptorSortColumns\"},\"kind\":\"array\"}}")]
        public virtual aws.Glue.IGlueCatalogTableStorageDescriptorSortColumns[] SortColumns
        {
            get => GetInstanceProperty<aws.Glue.IGlueCatalogTableStorageDescriptorSortColumns[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storedAsSubDirectories", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object StoredAsSubDirectories
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glue.GlueCatalogTableStorageDescriptor\"}", isOptional: true)]
        public virtual aws.Glue.IGlueCatalogTableStorageDescriptor? InternalValue
        {
            get => GetInstanceProperty<aws.Glue.IGlueCatalogTableStorageDescriptor?>();
            set => SetInstanceProperty(value);
        }
    }
}
