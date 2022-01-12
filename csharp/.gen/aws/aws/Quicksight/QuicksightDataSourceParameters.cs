using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    [JsiiByValue(fqn: "aws.quicksight.QuicksightDataSourceParameters")]
    public class QuicksightDataSourceParameters : aws.Quicksight.IQuicksightDataSourceParameters
    {
        /// <summary>amazon_elasticsearch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#amazon_elasticsearch QuicksightDataSource#amazon_elasticsearch}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amazonElasticsearch", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAmazonElasticsearch\"}", isOptional: true, isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceParametersAmazonElasticsearch? AmazonElasticsearch
        {
            get;
            set;
        }

        /// <summary>athena block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#athena QuicksightDataSource#athena}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "athena", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAthena\"}", isOptional: true, isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceParametersAthena? Athena
        {
            get;
            set;
        }

        /// <summary>aurora block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#aurora QuicksightDataSource#aurora}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aurora", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAurora\"}", isOptional: true, isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceParametersAurora? Aurora
        {
            get;
            set;
        }

        /// <summary>aurora_postgresql block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#aurora_postgresql QuicksightDataSource#aurora_postgresql}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auroraPostgresql", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAuroraPostgresql\"}", isOptional: true, isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceParametersAuroraPostgresql? AuroraPostgresql
        {
            get;
            set;
        }

        /// <summary>aws_iot_analytics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#aws_iot_analytics QuicksightDataSource#aws_iot_analytics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsIotAnalytics", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersAwsIotAnalytics\"}", isOptional: true, isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceParametersAwsIotAnalytics? AwsIotAnalytics
        {
            get;
            set;
        }

        /// <summary>jira block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#jira QuicksightDataSource#jira}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jira", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersJira\"}", isOptional: true, isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceParametersJira? Jira
        {
            get;
            set;
        }

        /// <summary>maria_db block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#maria_db QuicksightDataSource#maria_db}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mariaDb", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersMariaDb\"}", isOptional: true, isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceParametersMariaDb? MariaDb
        {
            get;
            set;
        }

        /// <summary>mysql block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#mysql QuicksightDataSource#mysql}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mysql", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersMysql\"}", isOptional: true, isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceParametersMysql? Mysql
        {
            get;
            set;
        }

        /// <summary>oracle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#oracle QuicksightDataSource#oracle}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oracle", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersOracle\"}", isOptional: true, isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceParametersOracle? Oracle
        {
            get;
            set;
        }

        /// <summary>postgresql block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#postgresql QuicksightDataSource#postgresql}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "postgresql", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersPostgresql\"}", isOptional: true, isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceParametersPostgresql? Postgresql
        {
            get;
            set;
        }

        /// <summary>presto block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#presto QuicksightDataSource#presto}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "presto", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersPresto\"}", isOptional: true, isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceParametersPresto? Presto
        {
            get;
            set;
        }

        /// <summary>rds block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#rds QuicksightDataSource#rds}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rds", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersRds\"}", isOptional: true, isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceParametersRds? Rds
        {
            get;
            set;
        }

        /// <summary>redshift block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#redshift QuicksightDataSource#redshift}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redshift", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersRedshift\"}", isOptional: true, isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceParametersRedshift? Redshift
        {
            get;
            set;
        }

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#s3 QuicksightDataSource#s3}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersS3\"}", isOptional: true, isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceParametersS3? S3
        {
            get;
            set;
        }

        /// <summary>service_now block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#service_now QuicksightDataSource#service_now}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceNow", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersServiceNow\"}", isOptional: true, isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceParametersServiceNow? ServiceNow
        {
            get;
            set;
        }

        /// <summary>snowflake block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#snowflake QuicksightDataSource#snowflake}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snowflake", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersSnowflake\"}", isOptional: true, isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceParametersSnowflake? Snowflake
        {
            get;
            set;
        }

        /// <summary>spark block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#spark QuicksightDataSource#spark}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spark", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersSpark\"}", isOptional: true, isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceParametersSpark? Spark
        {
            get;
            set;
        }

        /// <summary>sql_server block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#sql_server QuicksightDataSource#sql_server}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sqlServer", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersSqlServer\"}", isOptional: true, isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceParametersSqlServer? SqlServer
        {
            get;
            set;
        }

        /// <summary>teradata block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#teradata QuicksightDataSource#teradata}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "teradata", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersTeradata\"}", isOptional: true, isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceParametersTeradata? Teradata
        {
            get;
            set;
        }

        /// <summary>twitter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#twitter QuicksightDataSource#twitter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersTwitter\"}", isOptional: true, isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceParametersTwitter? Twitter
        {
            get;
            set;
        }
    }
}
