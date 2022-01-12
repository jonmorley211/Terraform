using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Glue
{
    [JsiiByValue(fqn: "aws.glue.GlueMlTransformParametersFindMatchesParameters")]
    public class GlueMlTransformParametersFindMatchesParameters : aws.Glue.IGlueMlTransformParametersFindMatchesParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_ml_transform#accuracy_cost_trade_off GlueMlTransform#accuracy_cost_trade_off}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accuracyCostTradeOff", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? AccuracyCostTradeOff
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_ml_transform#enforce_provided_labels GlueMlTransform#enforce_provided_labels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enforceProvidedLabels", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? EnforceProvidedLabels
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_ml_transform#precision_recall_trade_off GlueMlTransform#precision_recall_trade_off}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "precisionRecallTradeOff", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? PrecisionRecallTradeOff
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/glue_ml_transform#primary_key_column_name GlueMlTransform#primary_key_column_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "primaryKeyColumnName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? PrimaryKeyColumnName
        {
            get;
            set;
        }
    }
}
