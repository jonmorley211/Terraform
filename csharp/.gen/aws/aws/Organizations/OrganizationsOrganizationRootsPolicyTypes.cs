using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Organizations
{
    [JsiiClass(nativeType: typeof(aws.Organizations.OrganizationsOrganizationRootsPolicyTypes), fullyQualifiedName: "aws.organizations.OrganizationsOrganizationRootsPolicyTypes", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OrganizationsOrganizationRootsPolicyTypes : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public OrganizationsOrganizationRootsPolicyTypes(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OrganizationsOrganizationRootsPolicyTypes(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OrganizationsOrganizationRootsPolicyTypes(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }
    }
}
