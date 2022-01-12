using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiInterface(nativeType: typeof(IGlueTriggerPredicate), fullyQualifiedName: "aws.glue.GlueTriggerPredicate")]
    public interface IGlueTriggerPredicate
    {
        /// <summary>conditions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_trigger#conditions GlueTrigger#conditions}
        /// </remarks>
        [JsiiProperty(name: "conditions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueTriggerPredicateConditions\"},\"kind\":\"array\"}}")]
        aws.Glue.IGlueTriggerPredicateConditions[] Conditions
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_trigger#logical GlueTrigger#logical}.</summary>
        [JsiiProperty(name: "logical", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Logical
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueTriggerPredicate), fullyQualifiedName: "aws.glue.GlueTriggerPredicate")]
        internal sealed class _Proxy : DeputyBase, aws.Glue.IGlueTriggerPredicate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>conditions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_trigger#conditions GlueTrigger#conditions}
            /// </remarks>
            [JsiiProperty(name: "conditions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glue.GlueTriggerPredicateConditions\"},\"kind\":\"array\"}}")]
            public aws.Glue.IGlueTriggerPredicateConditions[] Conditions
            {
                get => GetInstanceProperty<aws.Glue.IGlueTriggerPredicateConditions[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_trigger#logical GlueTrigger#logical}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logical", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Logical
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
