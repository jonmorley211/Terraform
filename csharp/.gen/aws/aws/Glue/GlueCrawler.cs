using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler aws_glue_crawler}.</summary>
    [JsiiClass(nativeType: typeof(aws.Glue.GlueCrawler), fullyQualifiedName: "aws.glue.GlueCrawler", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.glue.GlueCrawlerConfig\"}}]")]
    public class GlueCrawler : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/glue_crawler aws_glue_crawler} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public GlueCrawler(Constructs.Construct scope, string id, aws.Glue.IGlueCrawlerConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCrawler(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueCrawler(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLineageConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueCrawlerLineageConfiguration\"}}]")]
        public virtual void PutLineageConfiguration(aws.Glue.IGlueCrawlerLineageConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueCrawlerLineageConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRecrawlPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueCrawlerRecrawlPolicy\"}}]")]
        public virtual void PutRecrawlPolicy(aws.Glue.IGlueCrawlerRecrawlPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueCrawlerRecrawlPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchemaChangePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glue.GlueCrawlerSchemaChangePolicy\"}}]")]
        public virtual void PutSchemaChangePolicy(aws.Glue.IGlueCrawlerSchemaChangePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Glue.IGlueCrawlerSchemaChangePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCatalogTarget")]
        public virtual void ResetCatalogTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClassifiers")]
        public virtual void ResetClassifiers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfiguration")]
        public virtual void ResetConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDynamodbTarget")]
        public virtual void ResetDynamodbTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJdbcTarget")]
        public virtual void ResetJdbcTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLineageConfiguration")]
        public virtual void ResetLineageConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMongodbTarget")]
        public virtual void ResetMongodbTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecrawlPolicy")]
        public virtual void ResetRecrawlPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Target")]
        public virtual void ResetS3Target()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchedule")]
        public virtual void ResetSchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchemaChangePolicy")]
        public virtual void ResetSchemaChangePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityConfiguration")]
        public virtual void ResetSecurityConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTablePrefix")]
        public virtual void ResetTablePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Glue.GlueCrawler))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lineageConfiguration", typeJson: "{\"fqn\":\"aws.glue.GlueCrawlerLineageConfigurationOutputReference\"}")]
        public virtual aws.Glue.GlueCrawlerLineageConfigurationOutputReference LineageConfiguration
        {
            get => GetInstanceProperty<aws.Glue.GlueCrawlerLineageConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "recrawlPolicy", typeJson: "{\"fqn\":\"aws.glue.GlueCrawlerRecrawlPolicyOutputReference\"}")]
        public virtual aws.Glue.GlueCrawlerRecrawlPolicyOutputReference RecrawlPolicy
        {
            get => GetInstanceProperty<aws.Glue.GlueCrawlerRecrawlPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "schemaChangePolicy", typeJson: "{\"fqn\":\"aws.glue.GlueCrawlerSchemaChangePolicyOutputReference\"}")]
        public virtual aws.Glue.GlueCrawlerSchemaChangePolicyOutputReference SchemaChangePolicy
        {
            get => GetInstanceProperty<aws.Glue.GlueCrawlerSchemaChangePolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "catalogTargetInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCrawlerCatalogTarget\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Glue.IGlueCrawlerCatalogTarget[]? CatalogTargetInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueCrawlerCatalogTarget[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "classifiersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ClassifiersInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dynamodbTargetInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCrawlerDynamodbTarget\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Glue.IGlueCrawlerDynamodbTarget[]? DynamodbTargetInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueCrawlerDynamodbTarget[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jdbcTargetInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCrawlerJdbcTarget\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Glue.IGlueCrawlerJdbcTarget[]? JdbcTargetInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueCrawlerJdbcTarget[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lineageConfigurationInput", typeJson: "{\"fqn\":\"aws.glue.GlueCrawlerLineageConfiguration\"}", isOptional: true)]
        public virtual aws.Glue.IGlueCrawlerLineageConfiguration? LineageConfigurationInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueCrawlerLineageConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mongodbTargetInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCrawlerMongodbTarget\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Glue.IGlueCrawlerMongodbTarget[]? MongodbTargetInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueCrawlerMongodbTarget[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recrawlPolicyInput", typeJson: "{\"fqn\":\"aws.glue.GlueCrawlerRecrawlPolicy\"}", isOptional: true)]
        public virtual aws.Glue.IGlueCrawlerRecrawlPolicy? RecrawlPolicyInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueCrawlerRecrawlPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3TargetInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCrawlerS3Target\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Glue.IGlueCrawlerS3Target[]? S3TargetInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueCrawlerS3Target[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScheduleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaChangePolicyInput", typeJson: "{\"fqn\":\"aws.glue.GlueCrawlerSchemaChangePolicy\"}", isOptional: true)]
        public virtual aws.Glue.IGlueCrawlerSchemaChangePolicy? SchemaChangePolicyInput
        {
            get => GetInstanceProperty<aws.Glue.IGlueCrawlerSchemaChangePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityConfigurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityConfigurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tablePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TablePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsAllInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "catalogTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCrawlerCatalogTarget\"},\"kind\":\"array\"}}")]
        public virtual aws.Glue.IGlueCrawlerCatalogTarget[] CatalogTarget
        {
            get => GetInstanceProperty<aws.Glue.IGlueCrawlerCatalogTarget[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "classifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Classifiers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Configuration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dynamodbTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCrawlerDynamodbTarget\"},\"kind\":\"array\"}}")]
        public virtual aws.Glue.IGlueCrawlerDynamodbTarget[] DynamodbTarget
        {
            get => GetInstanceProperty<aws.Glue.IGlueCrawlerDynamodbTarget[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "jdbcTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCrawlerJdbcTarget\"},\"kind\":\"array\"}}")]
        public virtual aws.Glue.IGlueCrawlerJdbcTarget[] JdbcTarget
        {
            get => GetInstanceProperty<aws.Glue.IGlueCrawlerJdbcTarget[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mongodbTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCrawlerMongodbTarget\"},\"kind\":\"array\"}}")]
        public virtual aws.Glue.IGlueCrawlerMongodbTarget[] MongodbTarget
        {
            get => GetInstanceProperty<aws.Glue.IGlueCrawlerMongodbTarget[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Role
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "s3Target", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueCrawlerS3Target\"},\"kind\":\"array\"}}")]
        public virtual aws.Glue.IGlueCrawlerS3Target[] S3Target
        {
            get => GetInstanceProperty<aws.Glue.IGlueCrawlerS3Target[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Schedule
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityConfiguration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tablePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TablePrefix
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

        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object TagsAll
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
