using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshVirtualNodeSpecListenerOutlierDetection), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetection")]
    public interface IAppmeshVirtualNodeSpecListenerOutlierDetection
    {
        /// <summary>base_ejection_duration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#base_ejection_duration AppmeshVirtualNode#base_ejection_duration}
        /// </remarks>
        [JsiiProperty(name: "baseEjectionDuration", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetectionBaseEjectionDuration\"}")]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetectionBaseEjectionDuration BaseEjectionDuration
        {
            get;
        }

        /// <summary>interval block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#interval AppmeshVirtualNode#interval}
        /// </remarks>
        [JsiiProperty(name: "interval", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetectionInterval\"}")]
        aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetectionInterval Interval
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#max_ejection_percent AppmeshVirtualNode#max_ejection_percent}.</summary>
        [JsiiProperty(name: "maxEjectionPercent", typeJson: "{\"primitive\":\"number\"}")]
        double MaxEjectionPercent
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#max_server_errors AppmeshVirtualNode#max_server_errors}.</summary>
        [JsiiProperty(name: "maxServerErrors", typeJson: "{\"primitive\":\"number\"}")]
        double MaxServerErrors
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshVirtualNodeSpecListenerOutlierDetection), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetection")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>base_ejection_duration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#base_ejection_duration AppmeshVirtualNode#base_ejection_duration}
            /// </remarks>
            [JsiiProperty(name: "baseEjectionDuration", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetectionBaseEjectionDuration\"}")]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetectionBaseEjectionDuration BaseEjectionDuration
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetectionBaseEjectionDuration>()!;
            }

            /// <summary>interval block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#interval AppmeshVirtualNode#interval}
            /// </remarks>
            [JsiiProperty(name: "interval", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerOutlierDetectionInterval\"}")]
            public aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetectionInterval Interval
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerOutlierDetectionInterval>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#max_ejection_percent AppmeshVirtualNode#max_ejection_percent}.</summary>
            [JsiiProperty(name: "maxEjectionPercent", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxEjectionPercent
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_virtual_node#max_server_errors AppmeshVirtualNode#max_server_errors}.</summary>
            [JsiiProperty(name: "maxServerErrors", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxServerErrors
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
