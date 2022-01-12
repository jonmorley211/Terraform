using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Eventbridge
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.eventbridge.CloudwatchEventTargetRedshiftTarget")]
    public class CloudwatchEventTargetRedshiftTarget : aws.Eventbridge.ICloudwatchEventTargetRedshiftTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#database CloudwatchEventTarget#database}.</summary>
        [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Database
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#db_user CloudwatchEventTarget#db_user}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DbUser
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#secrets_manager_arn CloudwatchEventTarget#secrets_manager_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretsManagerArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SecretsManagerArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#sql CloudwatchEventTarget#sql}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sql", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Sql
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#statement_name CloudwatchEventTarget#statement_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "statementName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? StatementName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudwatch_event_target#with_event CloudwatchEventTarget#with_event}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "withEvent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? WithEvent
        {
            get;
            set;
        }
    }
}
