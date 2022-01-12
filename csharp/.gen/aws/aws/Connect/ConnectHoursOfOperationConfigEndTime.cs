using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Connect
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.connect.ConnectHoursOfOperationConfigEndTime")]
    public class ConnectHoursOfOperationConfigEndTime : aws.Connect.IConnectHoursOfOperationConfigEndTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/connect_hours_of_operation#hours ConnectHoursOfOperation#hours}.</summary>
        [JsiiProperty(name: "hours", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Hours
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/connect_hours_of_operation#minutes ConnectHoursOfOperation#minutes}.</summary>
        [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Minutes
        {
            get;
            set;
        }
    }
}
