using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetection")]
    public class AppmeshVirtualNodeSpecListenerOutlierDetection : aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetection
    {
        /// <summary>base_ejection_duration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#base_ejection_duration AppmeshVirtualNode#base_ejection_duration}
        /// </remarks>
        [JsiiProperty(name: "baseEjectionDuration", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetectionBaseEjectionDuration\"}", isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetectionBaseEjectionDuration BaseEjectionDuration
        {
            get;
            set;
        }

        /// <summary>interval block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#interval AppmeshVirtualNode#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetectionInterval\"}", isOverride: true)]
        public aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetectionInterval Interval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#max_ejection_percent AppmeshVirtualNode#max_ejection_percent}.</summary>
        [JsiiProperty(name: "maxEjectionPercent", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double MaxEjectionPercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#max_server_errors AppmeshVirtualNode#max_server_errors}.</summary>
        [JsiiProperty(name: "maxServerErrors", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double MaxServerErrors
        {
            get;
            set;
        }
    }
}
