using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    [JsiiInterface(nativeType: typeof(IEmrClusterMasterInstanceGroup), fullyQualifiedName: "aws.emr.EmrClusterMasterInstanceGroup")]
    public interface IEmrClusterMasterInstanceGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#instance_type EmrCluster#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#bid_price EmrCluster#bid_price}.</summary>
        [JsiiProperty(name: "bidPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BidPrice
        {
            get
            {
                return null;
            }
        }

        /// <summary>ebs_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#ebs_config EmrCluster#ebs_config}
        /// </remarks>
        [JsiiProperty(name: "ebsConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterMasterInstanceGroupEbsConfig\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Emr.IEmrClusterMasterInstanceGroupEbsConfig[]? EbsConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#instance_count EmrCluster#instance_count}.</summary>
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InstanceCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#name EmrCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrClusterMasterInstanceGroup), fullyQualifiedName: "aws.emr.EmrClusterMasterInstanceGroup")]
        internal sealed class _Proxy : DeputyBase, aws.Emr.IEmrClusterMasterInstanceGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#instance_type EmrCluster#instance_type}.</summary>
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#bid_price EmrCluster#bid_price}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bidPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BidPrice
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ebs_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#ebs_config EmrCluster#ebs_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ebsConfig", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterMasterInstanceGroupEbsConfig\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Emr.IEmrClusterMasterInstanceGroupEbsConfig[]? EbsConfig
            {
                get => GetInstanceProperty<aws.Emr.IEmrClusterMasterInstanceGroupEbsConfig[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#instance_count EmrCluster#instance_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InstanceCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#name EmrCluster#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
