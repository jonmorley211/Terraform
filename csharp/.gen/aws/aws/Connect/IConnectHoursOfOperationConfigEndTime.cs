using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Connect
{
    [JsiiInterface(nativeType: typeof(IConnectHoursOfOperationConfigEndTime), fullyQualifiedName: "aws.connect.ConnectHoursOfOperationConfigEndTime")]
    public interface IConnectHoursOfOperationConfigEndTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/connect_hours_of_operation#hours ConnectHoursOfOperation#hours}.</summary>
        [JsiiProperty(name: "hours", typeJson: "{\"primitive\":\"number\"}")]
        double Hours
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/connect_hours_of_operation#minutes ConnectHoursOfOperation#minutes}.</summary>
        [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}")]
        double Minutes
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectHoursOfOperationConfigEndTime), fullyQualifiedName: "aws.connect.ConnectHoursOfOperationConfigEndTime")]
        internal sealed class _Proxy : DeputyBase, aws.Connect.IConnectHoursOfOperationConfigEndTime
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/connect_hours_of_operation#hours ConnectHoursOfOperation#hours}.</summary>
            [JsiiProperty(name: "hours", typeJson: "{\"primitive\":\"number\"}")]
            public double Hours
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/connect_hours_of_operation#minutes ConnectHoursOfOperation#minutes}.</summary>
            [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}")]
            public double Minutes
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
