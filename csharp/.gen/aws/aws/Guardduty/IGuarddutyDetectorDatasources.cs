using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Guardduty
{
    [JsiiInterface(nativeType: typeof(IGuarddutyDetectorDatasources), fullyQualifiedName: "aws.guardduty.GuarddutyDetectorDatasources")]
    public interface IGuarddutyDetectorDatasources
    {
        /// <summary>s3_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_detector#s3_logs GuarddutyDetector#s3_logs}
        /// </remarks>
        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.guardduty.GuarddutyDetectorDatasourcesS3Logs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Guardduty.IGuarddutyDetectorDatasourcesS3Logs? S3Logs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGuarddutyDetectorDatasources), fullyQualifiedName: "aws.guardduty.GuarddutyDetectorDatasources")]
        internal sealed class _Proxy : DeputyBase, aws.Guardduty.IGuarddutyDetectorDatasources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_detector#s3_logs GuarddutyDetector#s3_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.guardduty.GuarddutyDetectorDatasourcesS3Logs\"}", isOptional: true)]
            public aws.Guardduty.IGuarddutyDetectorDatasourcesS3Logs? S3Logs
            {
                get => GetInstanceProperty<aws.Guardduty.IGuarddutyDetectorDatasourcesS3Logs?>();
            }
        }
    }
}
