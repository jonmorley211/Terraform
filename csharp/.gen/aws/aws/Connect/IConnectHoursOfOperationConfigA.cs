using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Connect
{
    [JsiiInterface(nativeType: typeof(IConnectHoursOfOperationConfigA), fullyQualifiedName: "aws.connect.ConnectHoursOfOperationConfigA")]
    public interface IConnectHoursOfOperationConfigA
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/connect_hours_of_operation#day ConnectHoursOfOperation#day}.</summary>
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}")]
        string Day
        {
            get;
        }

        /// <summary>end_time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/connect_hours_of_operation#end_time ConnectHoursOfOperation#end_time}
        /// </remarks>
        [JsiiProperty(name: "endTime", typeJson: "{\"fqn\":\"aws.connect.ConnectHoursOfOperationConfigEndTime\"}")]
        aws.Connect.IConnectHoursOfOperationConfigEndTime EndTime
        {
            get;
        }

        /// <summary>start_time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/connect_hours_of_operation#start_time ConnectHoursOfOperation#start_time}
        /// </remarks>
        [JsiiProperty(name: "startTime", typeJson: "{\"fqn\":\"aws.connect.ConnectHoursOfOperationConfigStartTime\"}")]
        aws.Connect.IConnectHoursOfOperationConfigStartTime StartTime
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectHoursOfOperationConfigA), fullyQualifiedName: "aws.connect.ConnectHoursOfOperationConfigA")]
        internal sealed class _Proxy : DeputyBase, aws.Connect.IConnectHoursOfOperationConfigA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/connect_hours_of_operation#day ConnectHoursOfOperation#day}.</summary>
            [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}")]
            public string Day
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>end_time block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/connect_hours_of_operation#end_time ConnectHoursOfOperation#end_time}
            /// </remarks>
            [JsiiProperty(name: "endTime", typeJson: "{\"fqn\":\"aws.connect.ConnectHoursOfOperationConfigEndTime\"}")]
            public aws.Connect.IConnectHoursOfOperationConfigEndTime EndTime
            {
                get => GetInstanceProperty<aws.Connect.IConnectHoursOfOperationConfigEndTime>()!;
            }

            /// <summary>start_time block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/connect_hours_of_operation#start_time ConnectHoursOfOperation#start_time}
            /// </remarks>
            [JsiiProperty(name: "startTime", typeJson: "{\"fqn\":\"aws.connect.ConnectHoursOfOperationConfigStartTime\"}")]
            public aws.Connect.IConnectHoursOfOperationConfigStartTime StartTime
            {
                get => GetInstanceProperty<aws.Connect.IConnectHoursOfOperationConfigStartTime>()!;
            }
        }
    }
}
