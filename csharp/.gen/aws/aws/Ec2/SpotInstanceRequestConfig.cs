using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2
{
    /// <summary>AWS EC2.</summary>
    [JsiiByValue(fqn: "aws.ec2.SpotInstanceRequestConfig")]
    public class SpotInstanceRequestConfig : aws.Ec2.ISpotInstanceRequestConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#ami SpotInstanceRequest#ami}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ami", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Ami
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#associate_public_ip_address SpotInstanceRequest#associate_public_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "associatePublicIpAddress", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? AssociatePublicIpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#availability_zone SpotInstanceRequest#availability_zone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AvailabilityZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#block_duration_minutes SpotInstanceRequest#block_duration_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blockDurationMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? BlockDurationMinutes
        {
            get;
            set;
        }

        /// <summary>capacity_reservation_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#capacity_reservation_specification SpotInstanceRequest#capacity_reservation_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "capacityReservationSpecification", typeJson: "{\"fqn\":\"aws.ec2.SpotInstanceRequestCapacityReservationSpecification\"}", isOptional: true, isOverride: true)]
        public aws.Ec2.ISpotInstanceRequestCapacityReservationSpecification? CapacityReservationSpecification
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#cpu_core_count SpotInstanceRequest#cpu_core_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? CpuCoreCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#cpu_threads_per_core SpotInstanceRequest#cpu_threads_per_core}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuThreadsPerCore", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? CpuThreadsPerCore
        {
            get;
            set;
        }

        /// <summary>credit_specification block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#credit_specification SpotInstanceRequest#credit_specification}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "creditSpecification", typeJson: "{\"fqn\":\"aws.ec2.SpotInstanceRequestCreditSpecification\"}", isOptional: true, isOverride: true)]
        public aws.Ec2.ISpotInstanceRequestCreditSpecification? CreditSpecification
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#disable_api_termination SpotInstanceRequest#disable_api_termination}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disableApiTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? DisableApiTermination
        {
            get;
            set;
        }

        /// <summary>ebs_block_device block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#ebs_block_device SpotInstanceRequest#ebs_block_device}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ebsBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.SpotInstanceRequestEbsBlockDevice\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Ec2.ISpotInstanceRequestEbsBlockDevice[]? EbsBlockDevice
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#ebs_optimized SpotInstanceRequest#ebs_optimized}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ebsOptimized", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? EbsOptimized
        {
            get;
            set;
        }

        /// <summary>enclave_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#enclave_options SpotInstanceRequest#enclave_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enclaveOptions", typeJson: "{\"fqn\":\"aws.ec2.SpotInstanceRequestEnclaveOptions\"}", isOptional: true, isOverride: true)]
        public aws.Ec2.ISpotInstanceRequestEnclaveOptions? EnclaveOptions
        {
            get;
            set;
        }

        /// <summary>ephemeral_block_device block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#ephemeral_block_device SpotInstanceRequest#ephemeral_block_device}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ephemeralBlockDevice", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.SpotInstanceRequestEphemeralBlockDevice\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Ec2.ISpotInstanceRequestEphemeralBlockDevice[]? EphemeralBlockDevice
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#get_password_data SpotInstanceRequest#get_password_data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fetchPasswordData", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? FetchPasswordData
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#hibernation SpotInstanceRequest#hibernation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hibernation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? Hibernation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#host_id SpotInstanceRequest#host_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? HostId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#iam_instance_profile SpotInstanceRequest#iam_instance_profile}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iamInstanceProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? IamInstanceProfile
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#instance_initiated_shutdown_behavior SpotInstanceRequest#instance_initiated_shutdown_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceInitiatedShutdownBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InstanceInitiatedShutdownBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#instance_interruption_behavior SpotInstanceRequest#instance_interruption_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceInterruptionBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InstanceInterruptionBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#instance_interruption_behaviour SpotInstanceRequest#instance_interruption_behaviour}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceInterruptionBehaviour", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InstanceInterruptionBehaviour
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#instance_type SpotInstanceRequest#instance_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? InstanceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#ipv6_address_count SpotInstanceRequest#ipv6_address_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6AddressCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Ipv6AddressCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#ipv6_addresses SpotInstanceRequest#ipv6_addresses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6Addresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Ipv6Addresses
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#key_name SpotInstanceRequest#key_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KeyName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#launch_group SpotInstanceRequest#launch_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "launchGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LaunchGroup
        {
            get;
            set;
        }

        /// <summary>launch_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#launch_template SpotInstanceRequest#launch_template}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "launchTemplate", typeJson: "{\"fqn\":\"aws.ec2.SpotInstanceRequestLaunchTemplate\"}", isOptional: true, isOverride: true)]
        public aws.Ec2.ISpotInstanceRequestLaunchTemplate? LaunchTemplate
        {
            get;
            set;
        }

        /// <summary>metadata_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#metadata_options SpotInstanceRequest#metadata_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadataOptions", typeJson: "{\"fqn\":\"aws.ec2.SpotInstanceRequestMetadataOptions\"}", isOptional: true, isOverride: true)]
        public aws.Ec2.ISpotInstanceRequestMetadataOptions? MetadataOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#monitoring SpotInstanceRequest#monitoring}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "monitoring", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? Monitoring
        {
            get;
            set;
        }

        /// <summary>network_interface block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#network_interface SpotInstanceRequest#network_interface}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkInterface", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ec2.SpotInstanceRequestNetworkInterface\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Ec2.ISpotInstanceRequestNetworkInterface[]? NetworkInterface
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#placement_group SpotInstanceRequest#placement_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "placementGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PlacementGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#placement_partition_number SpotInstanceRequest#placement_partition_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "placementPartitionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? PlacementPartitionNumber
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#private_ip SpotInstanceRequest#private_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PrivateIp
        {
            get;
            set;
        }

        /// <summary>root_block_device block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#root_block_device SpotInstanceRequest#root_block_device}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rootBlockDevice", typeJson: "{\"fqn\":\"aws.ec2.SpotInstanceRequestRootBlockDevice\"}", isOptional: true, isOverride: true)]
        public aws.Ec2.ISpotInstanceRequestRootBlockDevice? RootBlockDevice
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#secondary_private_ips SpotInstanceRequest#secondary_private_ips}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secondaryPrivateIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SecondaryPrivateIps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#security_groups SpotInstanceRequest#security_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SecurityGroups
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#source_dest_check SpotInstanceRequest#source_dest_check}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceDestCheck", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? SourceDestCheck
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#spot_price SpotInstanceRequest#spot_price}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "spotPrice", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SpotPrice
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#spot_type SpotInstanceRequest#spot_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "spotType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SpotType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#subnet_id SpotInstanceRequest#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#tags SpotInstanceRequest#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true, isOverride: true)]
        public object? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#tags_all SpotInstanceRequest#tags_all}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true, isOverride: true)]
        public object? TagsAll
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#tenancy SpotInstanceRequest#tenancy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tenancy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Tenancy
        {
            get;
            set;
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#timeouts SpotInstanceRequest#timeouts}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.ec2.SpotInstanceRequestTimeouts\"}", isOptional: true, isOverride: true)]
        public aws.Ec2.ISpotInstanceRequestTimeouts? Timeouts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#user_data SpotInstanceRequest#user_data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userData", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? UserData
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#user_data_base64 SpotInstanceRequest#user_data_base64}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userDataBase64", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? UserDataBase64
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#valid_from SpotInstanceRequest#valid_from}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "validFrom", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ValidFrom
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#valid_until SpotInstanceRequest#valid_until}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "validUntil", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ValidUntil
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#volume_tags SpotInstanceRequest#volume_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "volumeTags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true, isOverride: true)]
        public object? VolumeTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#vpc_security_group_ids SpotInstanceRequest#vpc_security_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? VpcSecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/spot_instance_request#wait_for_fulfillment SpotInstanceRequest#wait_for_fulfillment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "waitForFulfillment", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? WaitForFulfillment
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
