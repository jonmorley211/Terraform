using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssm.SsmMaintenanceWindowTaskTargets")]
    public class SsmMaintenanceWindowTaskTargets : aws.Ssm.ISsmMaintenanceWindowTaskTargets
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#key SsmMaintenanceWindowTask#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ssm_maintenance_window_task#values SsmMaintenanceWindowTask#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] Values
        {
            get;
            set;
        }
    }
}
