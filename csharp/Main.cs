using System;
using System.IO;
using Constructs;
using HashiCorp.Cdktf;
using HashiCorp.Cdktf.Providers.Aws;
using HashiCorp.Cdktf.Providers.Aws.Ec2;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MyCompany.MyApp
{
    class MyApp : TerraformStack
    {
        static string subnetIdInput = "subnet-01e827b8a3058c36f";
        static string azInput = "eu-west-2a";
        static string hostName = "new-ec2";
        static string securitygroup = "";

        public MyApp(Construct scope, string id) : base(scope, id)
        {

            AwsProviderConfig config = new AwsProviderConfig();
            config.Region = "eu-west-2";

            config.AccessKey = System.Environment.GetEnvironmentVariable("AWS_KEY");
            config.SecretKey = System.Environment.GetEnvironmentVariable("AWS_SECRET");


            //config.SharedCredentialsFile = "%USERPROFILE%/.aws/credentials/";
            Console.WriteLine("Region was " + config.Region);

            AwsProvider aws = new AwsProvider(this, "aws", config);

            Instance newInstance = new Instance(this, id);
            newInstance.Ami = "ami-0d37e07bd4ff37148";
            newInstance.InstanceType = "t2.micro";
            newInstance.AvailabilityZone = azInput;
            newInstance.SubnetId = subnetIdInput;
            newInstance.SecurityGroups = new string[] { securitygroup };

        }


        //entry point for dotnet and cdktf deploy
        public static void Main(string[] args)
        {
            #region User input for config file output

            if (args.Length >0 && args[0].Equals("config"))
            {
                Console.WriteLine("####### USER CONFIG #######");

                Console.WriteLine("please input the subnet id");
                subnetIdInput = Console.ReadLine();

                Console.WriteLine("please input the availability zone");
                azInput = Console.ReadLine();

                Console.WriteLine("please input the EC2 host name");
                hostName = Console.ReadLine();

                Console.WriteLine("please input security group id");
                securitygroup = Console.ReadLine();

                JObject saveConfig = new JObject(
                    new JProperty("subnetid", subnetIdInput),
                    new JProperty("availablilityZone", azInput),
                    new JProperty("hostName", hostName),
                    new JProperty("securitygroup", securitygroup));

                File.WriteAllText(@"./configFile", saveConfig.ToString());
            }

            #endregion


            #region load up the config from the saved file

            string loadConfig = "";
            try
            {
                StreamReader sw = new StreamReader("./configFile");
                loadConfig = sw.ReadToEnd();
                JObject obj = JObject.Parse(loadConfig);

                subnetIdInput = (string)obj["subnetid"];
                azInput = (string)obj["availablilityZone"];
                hostName = (string)obj["hostName"];
                securitygroup = (string)obj["securitygroup"];

            }
            catch(Exception e)
            {
                Console.WriteLine("Could not load the config file " +e.Message);
            }

            #endregion


            App app = new App();
            new MyApp(app, "csharp");
            app.Synth();
            
            Console.WriteLine("App synth complete, run cdktf to deploy to AWS");
        }
    }




}
