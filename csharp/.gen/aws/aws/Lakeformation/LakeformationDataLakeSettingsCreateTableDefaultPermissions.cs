using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lakeformation
{
    [JsiiByValue(fqn: "aws.lakeformation.LakeformationDataLakeSettingsCreateTableDefaultPermissions")]
    public class LakeformationDataLakeSettingsCreateTableDefaultPermissions : aws.Lakeformation.ILakeformationDataLakeSettingsCreateTableDefaultPermissions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_data_lake_settings#permissions LakeformationDataLakeSettings#permissions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Permissions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lakeformation_data_lake_settings#principal LakeformationDataLakeSettings#principal}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Principal
        {
            get;
            set;
        }
    }
}
