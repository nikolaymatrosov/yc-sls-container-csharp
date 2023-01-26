using System;
using Constructs;
using HashiCorp.Cdktf;
using MyTerraformStack;

namespace ServerlessConatinerDemo.CDK
{
    class Program
    {
        public static void Main(string[] args)
        {
            App app = new App();
            new MainStack(app, "cdk");
            app.Synth();
            Console.WriteLine("App synth complete");
        }
    }
}