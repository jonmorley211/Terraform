using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dynamodb
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/dynamodb_table aws_dynamodb_table}.</summary>
    [JsiiClass(nativeType: typeof(aws.Dynamodb.DataAwsDynamodbTable), fullyQualifiedName: "aws.dynamodb.DataAwsDynamodbTable", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dynamodb.DataAwsDynamodbTableConfig\"}}]")]
    public class DataAwsDynamodbTable : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/dynamodb_table aws_dynamodb_table} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsDynamodbTable(Constructs.Construct scope, string id, aws.Dynamodb.IDataAwsDynamodbTableConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsDynamodbTable(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsDynamodbTable(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "attribute", returnsJson: "{\"type\":{\"fqn\":\"aws.dynamodb.DataAwsDynamodbTableAttribute\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Dynamodb.DataAwsDynamodbTableAttribute Attribute(string index)
        {
            return InvokeInstanceMethod<aws.Dynamodb.DataAwsDynamodbTableAttribute>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "globalSecondaryIndex", returnsJson: "{\"type\":{\"fqn\":\"aws.dynamodb.DataAwsDynamodbTableGlobalSecondaryIndex\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Dynamodb.DataAwsDynamodbTableGlobalSecondaryIndex GlobalSecondaryIndex(string index)
        {
            return InvokeInstanceMethod<aws.Dynamodb.DataAwsDynamodbTableGlobalSecondaryIndex>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "localSecondaryIndex", returnsJson: "{\"type\":{\"fqn\":\"aws.dynamodb.DataAwsDynamodbTableLocalSecondaryIndex\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Dynamodb.DataAwsDynamodbTableLocalSecondaryIndex LocalSecondaryIndex(string index)
        {
            return InvokeInstanceMethod<aws.Dynamodb.DataAwsDynamodbTableLocalSecondaryIndex>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "pointInTimeRecovery", returnsJson: "{\"type\":{\"fqn\":\"aws.dynamodb.DataAwsDynamodbTablePointInTimeRecovery\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Dynamodb.DataAwsDynamodbTablePointInTimeRecovery PointInTimeRecovery(string index)
        {
            return InvokeInstanceMethod<aws.Dynamodb.DataAwsDynamodbTablePointInTimeRecovery>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "putServerSideEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dynamodb.DataAwsDynamodbTableServerSideEncryption\"}}]")]
        public virtual void PutServerSideEncryption(aws.Dynamodb.IDataAwsDynamodbTableServerSideEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Dynamodb.IDataAwsDynamodbTableServerSideEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "replica", returnsJson: "{\"type\":{\"fqn\":\"aws.dynamodb.DataAwsDynamodbTableReplica\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Dynamodb.DataAwsDynamodbTableReplica Replica(string index)
        {
            return InvokeInstanceMethod<aws.Dynamodb.DataAwsDynamodbTableReplica>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "resetServerSideEncryption")]
        public virtual void ResetServerSideEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "ttl", returnsJson: "{\"type\":{\"fqn\":\"aws.dynamodb.DataAwsDynamodbTableTtl\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Dynamodb.DataAwsDynamodbTableTtl Ttl(string index)
        {
            return InvokeInstanceMethod<aws.Dynamodb.DataAwsDynamodbTableTtl>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Dynamodb.DataAwsDynamodbTable))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "billingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hashKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HashKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RangeKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "readCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReadCapacity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "serverSideEncryption", typeJson: "{\"fqn\":\"aws.dynamodb.DataAwsDynamodbTableServerSideEncryptionOutputReference\"}")]
        public virtual aws.Dynamodb.DataAwsDynamodbTableServerSideEncryptionOutputReference ServerSideEncryption
        {
            get => GetInstanceProperty<aws.Dynamodb.DataAwsDynamodbTableServerSideEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "streamArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "streamEnabled", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object StreamEnabled
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "streamLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamLabel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "streamViewType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StreamViewType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tableClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableClass
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "writeCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WriteCapacity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverSideEncryptionInput", typeJson: "{\"fqn\":\"aws.dynamodb.DataAwsDynamodbTableServerSideEncryption\"}", isOptional: true)]
        public virtual aws.Dynamodb.IDataAwsDynamodbTableServerSideEncryption? ServerSideEncryptionInput
        {
            get => GetInstanceProperty<aws.Dynamodb.IDataAwsDynamodbTableServerSideEncryption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object Tags
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
