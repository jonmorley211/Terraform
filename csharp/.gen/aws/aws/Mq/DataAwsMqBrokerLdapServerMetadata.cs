using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Mq
{
    [JsiiClass(nativeType: typeof(aws.Mq.DataAwsMqBrokerLdapServerMetadata), fullyQualifiedName: "aws.mq.DataAwsMqBrokerLdapServerMetadata", parametersJson: "[{\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"complexComputedListIndex\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsMqBrokerLdapServerMetadata : HashiCorp.Cdktf.ComplexComputedList
    {
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public DataAwsMqBrokerLdapServerMetadata(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, string complexComputedListIndex): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexComputedListIndex}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMqBrokerLdapServerMetadata(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMqBrokerLdapServerMetadata(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "hosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Hosts
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "roleBase", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleBase
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "roleName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "roleSearchMatching", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleSearchMatching
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "roleSearchSubtree", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object RoleSearchSubtree
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "serviceAccountPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAccountPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceAccountUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAccountUsername
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userBase", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserBase
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userRoleName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserRoleName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userSearchMatching", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserSearchMatching
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userSearchSubtree", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object UserSearchSubtree
        {
            get => GetInstanceProperty<object>()!;
        }
    }
}
