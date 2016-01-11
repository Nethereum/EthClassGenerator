using System;

namespace EthClassGenerator
{
    public class EthRPCClassGenerator
    {
        public String NoParamsTemplateInt =
            @"
using System;

namespace Ethereum.RPC
{{

    ///<Summary>
    {0}    
    ///</Summary>
    public class {1} : GenericRpcRequestResponseHandlerNoParamInt
    {{
            public {1}() : base(ApiMethods.{2}.ToString()) {{ }}
    }}

}}
            
        ";

        public String ParamsTemplate =
            @"

using System;
using System.Threading.Tasks;
using edjCase.JsonRpc.Client;
using edjCase.JsonRpc.Core;
using Ethereum.RPC.Eth;
using RPCRequestResponseHandlers;

namespace Ethereum.RPC
{{

    ///<Summary>
    {0}    
    ///</Summary>
    public class {1} : RpcRequestResponseHandler<{3}>
        {{
            public {1}() : base(ApiMethods.{2}.ToString()) {{ }}

            public async Task<{3}> SendRequestAsync(RpcClient client, {4}, string id = Constants.DEFAULT_REQUEST_ID)
            {{
                return await base.SendRequestAsync(client, id, {4});
            }}
            public RpcRequest BuildRequest({4}, string id = Constants.DEFAULT_REQUEST_ID)
            {{
                return base.BuildRequest(id, {4});
            }}
        }}

    }}

";

        public String NoParamsTemplate =
            @"
using System;

namespace Ethereum.RPC
{{

    ///<Summary>
    {0}    
    ///</Summary>
    public class {1} : GenericRpcRequestResponseHandlerNoParam<{3}>
    {{
            public {1}() : base(ApiMethods.{2}.ToString()) {{ }}
    }}

}}
            
        ";

        public String NoParamsTesterTemplate =
            @"
using edjCase.JsonRpc.Client;
using System;

namespace Ethereum.RPC.Sample.Testers
{{
    public class {0}Tester : IRPCRequestTester
    {{
        public async Task<dynamic> ExecuteTest(RpcClient client)
        {{
            var {1} = new {0}();
            return await {1}.SendRequestAsync(client);
        }}

        public Type GetRequestType()
        {{
            return typeof({0});
        }}
    }}
}}
        ";

        public void WriteParameterFiles(string summary, string className, string classNameInstance, string rpcMethodName, string returnType, string parameters)
        {
            string classOutput;
            classOutput = String.Format((string) ParamsTemplate, summary, className, rpcMethodName,
                returnType, parameters);

            var file = System.IO.File.CreateText(className + ".cs");

            file.Write(classOutput);
            file.Flush();
            file.Close();

            var testerOutput = String.Format((string) NoParamsTesterTemplate, className, classNameInstance);
            file = System.IO.File.CreateText(className + "Tester.cs");
            file.Write(testerOutput);
            file.Flush();
            file.Close();
        }

        public void WriteNoParametersFiles(string summary, string className, string classNameInstance, string rpcMethodName, string returnType)
        {
            string classOutput;
            if (returnType == "int")
            {
                classOutput = String.Format(NoParamsTemplateInt, summary, className, rpcMethodName);
            }
            else
                classOutput = String.Format(NoParamsTemplate, summary, className, rpcMethodName, returnType);

            var file = System.IO.File.CreateText(className + ".cs");

            file.Write(classOutput);
            file.Flush();
            file.Close();

            var testerOutput = String.Format(NoParamsTesterTemplate, className, classNameInstance);
            file = System.IO.File.CreateText(className + "Tester.cs");
            file.Write(testerOutput);
            file.Flush();
            file.Close();
        }

        public static string GetClassNameInstance(string className)
        {
            return className.Substring(0, 1).ToLower() + className.Substring(1);
        }

        public string FormatClassName(string unformattedClassName)
        {
            var classNameArray = unformattedClassName.Split(new[] {'_'}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < classNameArray.Length; i++)
            {
                classNameArray[i] = classNameArray[i].Substring(0, 1).ToUpper() + classNameArray[i].Substring(1);
            }

            var className = String.Join("", classNameArray);
            return className;
        }

        public static string FormatSummary(string summaryText)
        {
            String[] summaryArray = summaryText.Split(new string[] {Environment.NewLine}, StringSplitOptions.None);

            for (int i = 0; i < summaryArray.Length; i++)
            {
                summaryArray[i] = summaryArray[i].TrimStart(new[] {'/'});
                summaryArray[i] = "/// " + summaryArray[i];
            }

            var summary = String.Join(Environment.NewLine, summaryArray);
            return summary;
        }
    }
}
