using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.emr.EmrClusterKerberosAttributes")]
    public class EmrClusterKerberosAttributes : aws.Emr.IEmrClusterKerberosAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#kdc_admin_password EmrCluster#kdc_admin_password}.</summary>
        [JsiiProperty(name: "kdcAdminPassword", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string KdcAdminPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#realm EmrCluster#realm}.</summary>
        [JsiiProperty(name: "realm", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Realm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#ad_domain_join_password EmrCluster#ad_domain_join_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adDomainJoinPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AdDomainJoinPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#ad_domain_join_user EmrCluster#ad_domain_join_user}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adDomainJoinUser", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AdDomainJoinUser
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#cross_realm_trust_principal_password EmrCluster#cross_realm_trust_principal_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "crossRealmTrustPrincipalPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CrossRealmTrustPrincipalPassword
        {
            get;
            set;
        }
    }
}
