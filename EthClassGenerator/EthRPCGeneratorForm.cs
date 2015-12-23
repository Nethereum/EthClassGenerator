using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EthClassGenerator
{
    public partial class EthRPCGeneratorForm : Form
    {
        public EthRPCGeneratorForm()
        {
            InitializeComponent();
            ethRpcClassGenerator = new EthRPCClassGenerator();
        }

        public EthRPCClassGenerator EthRpcClassGenerator
        {
            get { return ethRpcClassGenerator; }
        }

        private void btnGenerateNoParams_Click(object sender, EventArgs e)
        {

            //summary formatting 
          
            var summary = EthRPCClassGenerator.FormatSummary(txtSummary.Text);

            var className = EthRpcClassGenerator.FormatClassName(txtMethodName.Text);

            var classNameInstance = EthRPCClassGenerator.GetClassNameInstance(className);

            var classOutput = String.Empty;

            //no params
            if (txtParams.Text == String.Empty)
            {
                EthRpcClassGenerator.WriteNoParametersFiles(summary, className, classNameInstance, txtMethodName.Text, txtReturnType.Text);
            }
            else
            {
                EthRpcClassGenerator.WriteParameterFiles(summary, className, classNameInstance, txtMethodName.Text, txtReturnType.Text, txtParams.Text);
            }
        }


        private readonly EthRPCClassGenerator ethRpcClassGenerator;
    }
}
