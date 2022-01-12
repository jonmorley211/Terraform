using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Organizations
{
    [JsiiClass(nativeType: typeof(aws.Organizations.DataAwsOrganizationsDelegatedServicesDelegatedServices), fullyQualifiedName: "aws.organizations.DataAwsOrganizationsDelegatedServicesDelegatedServices", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsOrganizationsDelegatedServicesDelegatedServices : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsOrganizationsDelegatedServicesDelegatedServices(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOrganizationsDelegatedServicesDelegatedServices(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOrganizationsDelegatedServicesDelegatedServices(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "delegationEnabledDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DelegationEnabledDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "servicePrincipal", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServicePrincipal
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
