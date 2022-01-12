using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudformation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudformation.CloudformationTypeLoggingConfig")]
    public class CloudformationTypeLoggingConfig : aws.Cloudformation.ICloudformationTypeLoggingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_type#log_group_name CloudformationType#log_group_name}.</summary>
        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string LogGroupName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_type#log_role_arn CloudformationType#log_role_arn}.</summary>
        [JsiiProperty(name: "logRoleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string LogRoleArn
        {
            get;
            set;
        }
    }
}
