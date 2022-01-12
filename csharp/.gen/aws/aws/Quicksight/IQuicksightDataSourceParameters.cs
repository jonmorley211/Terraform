using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSourceParameters), fullyQualifiedName: "aws.quicksight.QuicksightDataSourceParameters")]
    public interface IQuicksightDataSourceParameters
    {
        /// <summary>amazon_elasticsearch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#amazon_elasticsearch QuicksightDataSource#amazon_elasticsearch}
        /// </remarks>
        [JsiiProperty(name: "amazonElasticsearch", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAmazonElasticsearch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Quicksight.IQuicksightDataSourceParametersAmazonElasticsearch? AmazonElasticsearch
        {
            get
            {
                return null;
            }
        }

        /// <summary>athena block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#athena QuicksightDataSource#athena}
        /// </remarks>
        [JsiiProperty(name: "athena", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAthena\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Quicksight.IQuicksightDataSourceParametersAthena? Athena
        {
            get
            {
                return null;
            }
        }

        /// <summary>aurora block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#aurora QuicksightDataSource#aurora}
        /// </remarks>
        [JsiiProperty(name: "aurora", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAurora\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Quicksight.IQuicksightDataSourceParametersAurora? Aurora
        {
            get
            {
                return null;
            }
        }

        /// <summary>aurora_postgresql block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#aurora_postgresql QuicksightDataSource#aurora_postgresql}
        /// </remarks>
        [JsiiProperty(name: "auroraPostgresql", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAuroraPostgresql\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Quicksight.IQuicksightDataSourceParametersAuroraPostgresql? AuroraPostgresql
        {
            get
            {
                return null;
            }
        }

        /// <summary>aws_iot_analytics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#aws_iot_analytics QuicksightDataSource#aws_iot_analytics}
        /// </remarks>
        [JsiiProperty(name: "awsIotAnalytics", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAwsIotAnalytics\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Quicksight.IQuicksightDataSourceParametersAwsIotAnalytics? AwsIotAnalytics
        {
            get
            {
                return null;
            }
        }

        /// <summary>jira block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#jira QuicksightDataSource#jira}
        /// </remarks>
        [JsiiProperty(name: "jira", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersJira\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Quicksight.IQuicksightDataSourceParametersJira? Jira
        {
            get
            {
                return null;
            }
        }

        /// <summary>maria_db block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#maria_db QuicksightDataSource#maria_db}
        /// </remarks>
        [JsiiProperty(name: "mariaDb", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersMariaDb\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Quicksight.IQuicksightDataSourceParametersMariaDb? MariaDb
        {
            get
            {
                return null;
            }
        }

        /// <summary>mysql block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#mysql QuicksightDataSource#mysql}
        /// </remarks>
        [JsiiProperty(name: "mysql", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersMysql\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Quicksight.IQuicksightDataSourceParametersMysql? Mysql
        {
            get
            {
                return null;
            }
        }

        /// <summary>oracle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#oracle QuicksightDataSource#oracle}
        /// </remarks>
        [JsiiProperty(name: "oracle", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersOracle\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Quicksight.IQuicksightDataSourceParametersOracle? Oracle
        {
            get
            {
                return null;
            }
        }

        /// <summary>postgresql block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#postgresql QuicksightDataSource#postgresql}
        /// </remarks>
        [JsiiProperty(name: "postgresql", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersPostgresql\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Quicksight.IQuicksightDataSourceParametersPostgresql? Postgresql
        {
            get
            {
                return null;
            }
        }

        /// <summary>presto block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#presto QuicksightDataSource#presto}
        /// </remarks>
        [JsiiProperty(name: "presto", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersPresto\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Quicksight.IQuicksightDataSourceParametersPresto? Presto
        {
            get
            {
                return null;
            }
        }

        /// <summary>rds block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#rds QuicksightDataSource#rds}
        /// </remarks>
        [JsiiProperty(name: "rds", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersRds\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Quicksight.IQuicksightDataSourceParametersRds? Rds
        {
            get
            {
                return null;
            }
        }

        /// <summary>redshift block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#redshift QuicksightDataSource#redshift}
        /// </remarks>
        [JsiiProperty(name: "redshift", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersRedshift\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Quicksight.IQuicksightDataSourceParametersRedshift? Redshift
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#s3 QuicksightDataSource#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersS3\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Quicksight.IQuicksightDataSourceParametersS3? S3
        {
            get
            {
                return null;
            }
        }

        /// <summary>service_now block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#service_now QuicksightDataSource#service_now}
        /// </remarks>
        [JsiiProperty(name: "serviceNow", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersServiceNow\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Quicksight.IQuicksightDataSourceParametersServiceNow? ServiceNow
        {
            get
            {
                return null;
            }
        }

        /// <summary>snowflake block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#snowflake QuicksightDataSource#snowflake}
        /// </remarks>
        [JsiiProperty(name: "snowflake", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersSnowflake\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Quicksight.IQuicksightDataSourceParametersSnowflake? Snowflake
        {
            get
            {
                return null;
            }
        }

        /// <summary>spark block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#spark QuicksightDataSource#spark}
        /// </remarks>
        [JsiiProperty(name: "spark", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersSpark\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Quicksight.IQuicksightDataSourceParametersSpark? Spark
        {
            get
            {
                return null;
            }
        }

        /// <summary>sql_server block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#sql_server QuicksightDataSource#sql_server}
        /// </remarks>
        [JsiiProperty(name: "sqlServer", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersSqlServer\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Quicksight.IQuicksightDataSourceParametersSqlServer? SqlServer
        {
            get
            {
                return null;
            }
        }

        /// <summary>teradata block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#teradata QuicksightDataSource#teradata}
        /// </remarks>
        [JsiiProperty(name: "teradata", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersTeradata\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Quicksight.IQuicksightDataSourceParametersTeradata? Teradata
        {
            get
            {
                return null;
            }
        }

        /// <summary>twitter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#twitter QuicksightDataSource#twitter}
        /// </remarks>
        [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersTwitter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Quicksight.IQuicksightDataSourceParametersTwitter? Twitter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSourceParameters), fullyQualifiedName: "aws.quicksight.QuicksightDataSourceParameters")]
        internal sealed class _Proxy : DeputyBase, aws.Quicksight.IQuicksightDataSourceParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>amazon_elasticsearch block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#amazon_elasticsearch QuicksightDataSource#amazon_elasticsearch}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amazonElasticsearch", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAmazonElasticsearch\"}", isOptional: true)]
            public aws.Quicksight.IQuicksightDataSourceParametersAmazonElasticsearch? AmazonElasticsearch
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersAmazonElasticsearch?>();
            }

            /// <summary>athena block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#athena QuicksightDataSource#athena}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "athena", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAthena\"}", isOptional: true)]
            public aws.Quicksight.IQuicksightDataSourceParametersAthena? Athena
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersAthena?>();
            }

            /// <summary>aurora block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#aurora QuicksightDataSource#aurora}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "aurora", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAurora\"}", isOptional: true)]
            public aws.Quicksight.IQuicksightDataSourceParametersAurora? Aurora
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersAurora?>();
            }

            /// <summary>aurora_postgresql block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#aurora_postgresql QuicksightDataSource#aurora_postgresql}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auroraPostgresql", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAuroraPostgresql\"}", isOptional: true)]
            public aws.Quicksight.IQuicksightDataSourceParametersAuroraPostgresql? AuroraPostgresql
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersAuroraPostgresql?>();
            }

            /// <summary>aws_iot_analytics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#aws_iot_analytics QuicksightDataSource#aws_iot_analytics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsIotAnalytics", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAwsIotAnalytics\"}", isOptional: true)]
            public aws.Quicksight.IQuicksightDataSourceParametersAwsIotAnalytics? AwsIotAnalytics
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersAwsIotAnalytics?>();
            }

            /// <summary>jira block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#jira QuicksightDataSource#jira}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jira", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersJira\"}", isOptional: true)]
            public aws.Quicksight.IQuicksightDataSourceParametersJira? Jira
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersJira?>();
            }

            /// <summary>maria_db block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#maria_db QuicksightDataSource#maria_db}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mariaDb", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersMariaDb\"}", isOptional: true)]
            public aws.Quicksight.IQuicksightDataSourceParametersMariaDb? MariaDb
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersMariaDb?>();
            }

            /// <summary>mysql block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#mysql QuicksightDataSource#mysql}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mysql", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersMysql\"}", isOptional: true)]
            public aws.Quicksight.IQuicksightDataSourceParametersMysql? Mysql
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersMysql?>();
            }

            /// <summary>oracle block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#oracle QuicksightDataSource#oracle}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oracle", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersOracle\"}", isOptional: true)]
            public aws.Quicksight.IQuicksightDataSourceParametersOracle? Oracle
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersOracle?>();
            }

            /// <summary>postgresql block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#postgresql QuicksightDataSource#postgresql}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "postgresql", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersPostgresql\"}", isOptional: true)]
            public aws.Quicksight.IQuicksightDataSourceParametersPostgresql? Postgresql
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersPostgresql?>();
            }

            /// <summary>presto block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#presto QuicksightDataSource#presto}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "presto", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersPresto\"}", isOptional: true)]
            public aws.Quicksight.IQuicksightDataSourceParametersPresto? Presto
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersPresto?>();
            }

            /// <summary>rds block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#rds QuicksightDataSource#rds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rds", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersRds\"}", isOptional: true)]
            public aws.Quicksight.IQuicksightDataSourceParametersRds? Rds
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersRds?>();
            }

            /// <summary>redshift block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#redshift QuicksightDataSource#redshift}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redshift", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersRedshift\"}", isOptional: true)]
            public aws.Quicksight.IQuicksightDataSourceParametersRedshift? Redshift
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersRedshift?>();
            }

            /// <summary>s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#s3 QuicksightDataSource#s3}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersS3\"}", isOptional: true)]
            public aws.Quicksight.IQuicksightDataSourceParametersS3? S3
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersS3?>();
            }

            /// <summary>service_now block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#service_now QuicksightDataSource#service_now}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceNow", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersServiceNow\"}", isOptional: true)]
            public aws.Quicksight.IQuicksightDataSourceParametersServiceNow? ServiceNow
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersServiceNow?>();
            }

            /// <summary>snowflake block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#snowflake QuicksightDataSource#snowflake}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "snowflake", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersSnowflake\"}", isOptional: true)]
            public aws.Quicksight.IQuicksightDataSourceParametersSnowflake? Snowflake
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersSnowflake?>();
            }

            /// <summary>spark block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#spark QuicksightDataSource#spark}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spark", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersSpark\"}", isOptional: true)]
            public aws.Quicksight.IQuicksightDataSourceParametersSpark? Spark
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersSpark?>();
            }

            /// <summary>sql_server block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#sql_server QuicksightDataSource#sql_server}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sqlServer", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersSqlServer\"}", isOptional: true)]
            public aws.Quicksight.IQuicksightDataSourceParametersSqlServer? SqlServer
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersSqlServer?>();
            }

            /// <summary>teradata block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#teradata QuicksightDataSource#teradata}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "teradata", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersTeradata\"}", isOptional: true)]
            public aws.Quicksight.IQuicksightDataSourceParametersTeradata? Teradata
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersTeradata?>();
            }

            /// <summary>twitter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#twitter QuicksightDataSource#twitter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersTwitter\"}", isOptional: true)]
            public aws.Quicksight.IQuicksightDataSourceParametersTwitter? Twitter
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersTwitter?>();
            }
        }
    }
}
