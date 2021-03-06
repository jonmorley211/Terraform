using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudformation
{
    [JsiiInterface(nativeType: typeof(ICloudformationTypeLoggingConfig), fullyQualifiedName: "aws.cloudformation.CloudformationTypeLoggingConfig")]
    public interface ICloudformationTypeLoggingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_type#log_group_name CloudformationType#log_group_name}.</summary>
        [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string LogGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_type#log_role_arn CloudformationType#log_role_arn}.</summary>
        [JsiiProperty(name: "logRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string LogRoleArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudformationTypeLoggingConfig), fullyQualifiedName: "aws.cloudformation.CloudformationTypeLoggingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudformation.ICloudformationTypeLoggingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_type#log_group_name CloudformationType#log_group_name}.</summary>
            [JsiiProperty(name: "logGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string LogGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_type#log_role_arn CloudformationType#log_role_arn}.</summary>
            [JsiiProperty(name: "logRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string LogRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
