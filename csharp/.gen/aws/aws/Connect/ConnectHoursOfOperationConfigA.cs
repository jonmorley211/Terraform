using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Connect
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.connect.ConnectHoursOfOperationConfigA")]
    public class ConnectHoursOfOperationConfigA : aws.Connect.IConnectHoursOfOperationConfigA
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/connect_hours_of_operation#day ConnectHoursOfOperation#day}.</summary>
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Day
        {
            get;
            set;
        }

        /// <summary>end_time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/connect_hours_of_operation#end_time ConnectHoursOfOperation#end_time}
        /// </remarks>
        [JsiiProperty(name: "endTime", typeJson: "{\"fqn\":\"aws.connect.ConnectHoursOfOperationConfigEndTime\"}", isOverride: true)]
        public aws.Connect.IConnectHoursOfOperationConfigEndTime EndTime
        {
            get;
            set;
        }

        /// <summary>start_time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/connect_hours_of_operation#start_time ConnectHoursOfOperation#start_time}
        /// </remarks>
        [JsiiProperty(name: "startTime", typeJson: "{\"fqn\":\"aws.connect.ConnectHoursOfOperationConfigStartTime\"}", isOverride: true)]
        public aws.Connect.IConnectHoursOfOperationConfigStartTime StartTime
        {
            get;
            set;
        }
    }
}
