using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Guardduty
{
    [JsiiByValue(fqn: "aws.guardduty.GuarddutyDetectorDatasources")]
    public class GuarddutyDetectorDatasources : aws.Guardduty.IGuarddutyDetectorDatasources
    {
        /// <summary>s3_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_detector#s3_logs GuarddutyDetector#s3_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.guardduty.GuarddutyDetectorDatasourcesS3Logs\"}", isOptional: true, isOverride: true)]
        public aws.Guardduty.IGuarddutyDetectorDatasourcesS3Logs? S3Logs
        {
            get;
            set;
        }
    }
}
