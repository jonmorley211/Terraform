using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    [JsiiClass(nativeType: typeof(aws.Quicksight.QuicksightDataSourceParametersOutputReference), fullyQualifiedName: "aws.quicksight.QuicksightDataSourceParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class QuicksightDataSourceParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public QuicksightDataSourceParametersOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSourceParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSourceParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAmazonElasticsearch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAmazonElasticsearch\"}}]")]
        public virtual void PutAmazonElasticsearch(aws.Quicksight.IQuicksightDataSourceParametersAmazonElasticsearch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParametersAmazonElasticsearch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAthena", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAthena\"}}]")]
        public virtual void PutAthena(aws.Quicksight.IQuicksightDataSourceParametersAthena @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParametersAthena)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAurora", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAurora\"}}]")]
        public virtual void PutAurora(aws.Quicksight.IQuicksightDataSourceParametersAurora @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParametersAurora)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuroraPostgresql", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAuroraPostgresql\"}}]")]
        public virtual void PutAuroraPostgresql(aws.Quicksight.IQuicksightDataSourceParametersAuroraPostgresql @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParametersAuroraPostgresql)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAwsIotAnalytics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAwsIotAnalytics\"}}]")]
        public virtual void PutAwsIotAnalytics(aws.Quicksight.IQuicksightDataSourceParametersAwsIotAnalytics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParametersAwsIotAnalytics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJira", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersJira\"}}]")]
        public virtual void PutJira(aws.Quicksight.IQuicksightDataSourceParametersJira @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParametersJira)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMariaDb", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersMariaDb\"}}]")]
        public virtual void PutMariaDb(aws.Quicksight.IQuicksightDataSourceParametersMariaDb @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParametersMariaDb)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMysql", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersMysql\"}}]")]
        public virtual void PutMysql(aws.Quicksight.IQuicksightDataSourceParametersMysql @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParametersMysql)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOracle", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersOracle\"}}]")]
        public virtual void PutOracle(aws.Quicksight.IQuicksightDataSourceParametersOracle @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParametersOracle)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPostgresql", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersPostgresql\"}}]")]
        public virtual void PutPostgresql(aws.Quicksight.IQuicksightDataSourceParametersPostgresql @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParametersPostgresql)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPresto", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersPresto\"}}]")]
        public virtual void PutPresto(aws.Quicksight.IQuicksightDataSourceParametersPresto @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParametersPresto)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRds", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersRds\"}}]")]
        public virtual void PutRds(aws.Quicksight.IQuicksightDataSourceParametersRds @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParametersRds)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedshift", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersRedshift\"}}]")]
        public virtual void PutRedshift(aws.Quicksight.IQuicksightDataSourceParametersRedshift @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParametersRedshift)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersS3\"}}]")]
        public virtual void PutS3(aws.Quicksight.IQuicksightDataSourceParametersS3 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParametersS3)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceNow", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersServiceNow\"}}]")]
        public virtual void PutServiceNow(aws.Quicksight.IQuicksightDataSourceParametersServiceNow @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParametersServiceNow)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSnowflake", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersSnowflake\"}}]")]
        public virtual void PutSnowflake(aws.Quicksight.IQuicksightDataSourceParametersSnowflake @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParametersSnowflake)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSpark", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersSpark\"}}]")]
        public virtual void PutSpark(aws.Quicksight.IQuicksightDataSourceParametersSpark @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParametersSpark)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSqlServer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersSqlServer\"}}]")]
        public virtual void PutSqlServer(aws.Quicksight.IQuicksightDataSourceParametersSqlServer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParametersSqlServer)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTeradata", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersTeradata\"}}]")]
        public virtual void PutTeradata(aws.Quicksight.IQuicksightDataSourceParametersTeradata @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParametersTeradata)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTwitter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersTwitter\"}}]")]
        public virtual void PutTwitter(aws.Quicksight.IQuicksightDataSourceParametersTwitter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParametersTwitter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAmazonElasticsearch")]
        public virtual void ResetAmazonElasticsearch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAthena")]
        public virtual void ResetAthena()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAurora")]
        public virtual void ResetAurora()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuroraPostgresql")]
        public virtual void ResetAuroraPostgresql()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAwsIotAnalytics")]
        public virtual void ResetAwsIotAnalytics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJira")]
        public virtual void ResetJira()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMariaDb")]
        public virtual void ResetMariaDb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMysql")]
        public virtual void ResetMysql()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOracle")]
        public virtual void ResetOracle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPostgresql")]
        public virtual void ResetPostgresql()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPresto")]
        public virtual void ResetPresto()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRds")]
        public virtual void ResetRds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedshift")]
        public virtual void ResetRedshift()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3")]
        public virtual void ResetS3()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceNow")]
        public virtual void ResetServiceNow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnowflake")]
        public virtual void ResetSnowflake()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpark")]
        public virtual void ResetSpark()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqlServer")]
        public virtual void ResetSqlServer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTeradata")]
        public virtual void ResetTeradata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTwitter")]
        public virtual void ResetTwitter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "amazonElasticsearch", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAmazonElasticsearchOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersAmazonElasticsearchOutputReference AmazonElasticsearch
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersAmazonElasticsearchOutputReference>()!;
        }

        [JsiiProperty(name: "athena", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAthenaOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersAthenaOutputReference Athena
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersAthenaOutputReference>()!;
        }

        [JsiiProperty(name: "aurora", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAuroraOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersAuroraOutputReference Aurora
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersAuroraOutputReference>()!;
        }

        [JsiiProperty(name: "auroraPostgresql", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAuroraPostgresqlOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersAuroraPostgresqlOutputReference AuroraPostgresql
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersAuroraPostgresqlOutputReference>()!;
        }

        [JsiiProperty(name: "awsIotAnalytics", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAwsIotAnalyticsOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersAwsIotAnalyticsOutputReference AwsIotAnalytics
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersAwsIotAnalyticsOutputReference>()!;
        }

        [JsiiProperty(name: "jira", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersJiraOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersJiraOutputReference Jira
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersJiraOutputReference>()!;
        }

        [JsiiProperty(name: "mariaDb", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersMariaDbOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersMariaDbOutputReference MariaDb
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersMariaDbOutputReference>()!;
        }

        [JsiiProperty(name: "mysql", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersMysqlOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersMysqlOutputReference Mysql
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersMysqlOutputReference>()!;
        }

        [JsiiProperty(name: "oracle", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersOracleOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersOracleOutputReference Oracle
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersOracleOutputReference>()!;
        }

        [JsiiProperty(name: "postgresql", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersPostgresqlOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersPostgresqlOutputReference Postgresql
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersPostgresqlOutputReference>()!;
        }

        [JsiiProperty(name: "presto", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersPrestoOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersPrestoOutputReference Presto
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersPrestoOutputReference>()!;
        }

        [JsiiProperty(name: "rds", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersRdsOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersRdsOutputReference Rds
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersRdsOutputReference>()!;
        }

        [JsiiProperty(name: "redshift", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersRedshiftOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersRedshiftOutputReference Redshift
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersRedshiftOutputReference>()!;
        }

        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersS3OutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersS3OutputReference S3
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersS3OutputReference>()!;
        }

        [JsiiProperty(name: "serviceNow", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersServiceNowOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersServiceNowOutputReference ServiceNow
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersServiceNowOutputReference>()!;
        }

        [JsiiProperty(name: "snowflake", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersSnowflakeOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersSnowflakeOutputReference Snowflake
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersSnowflakeOutputReference>()!;
        }

        [JsiiProperty(name: "spark", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersSparkOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersSparkOutputReference Spark
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersSparkOutputReference>()!;
        }

        [JsiiProperty(name: "sqlServer", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersSqlServerOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersSqlServerOutputReference SqlServer
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersSqlServerOutputReference>()!;
        }

        [JsiiProperty(name: "teradata", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersTeradataOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersTeradataOutputReference Teradata
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersTeradataOutputReference>()!;
        }

        [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersTwitterOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersTwitterOutputReference Twitter
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersTwitterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amazonElasticsearchInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAmazonElasticsearch\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersAmazonElasticsearch? AmazonElasticsearchInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersAmazonElasticsearch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "athenaInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAthena\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersAthena? AthenaInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersAthena?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "auroraInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAurora\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersAurora? AuroraInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersAurora?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "auroraPostgresqlInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAuroraPostgresql\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersAuroraPostgresql? AuroraPostgresqlInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersAuroraPostgresql?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsIotAnalyticsInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAwsIotAnalytics\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersAwsIotAnalytics? AwsIotAnalyticsInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersAwsIotAnalytics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jiraInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersJira\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersJira? JiraInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersJira?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mariaDbInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersMariaDb\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersMariaDb? MariaDbInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersMariaDb?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mysqlInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersMysql\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersMysql? MysqlInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersMysql?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oracleInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersOracle\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersOracle? OracleInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersOracle?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "postgresqlInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersPostgresql\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersPostgresql? PostgresqlInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersPostgresql?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prestoInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersPresto\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersPresto? PrestoInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersPresto?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rdsInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersRds\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersRds? RdsInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersRds?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redshiftInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersRedshift\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersRedshift? RedshiftInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersRedshift?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Input", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersS3\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersS3? S3Input
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersS3?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceNowInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersServiceNow\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersServiceNow? ServiceNowInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersServiceNow?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snowflakeInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersSnowflake\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersSnowflake? SnowflakeInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersSnowflake?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sparkInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersSpark\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersSpark? SparkInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersSpark?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlServerInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersSqlServer\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersSqlServer? SqlServerInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersSqlServer?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "teradataInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersTeradata\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersTeradata? TeradataInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersTeradata?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "twitterInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersTwitter\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersTwitter? TwitterInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersTwitter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParameters\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParameters? InternalValue
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
