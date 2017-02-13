using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Parsing;

namespace Practica1_201020331.parsers.Operation
{
    class SBSscript_Operation_Arithmetic : SBSscript_Operation_Abstract
    {
        public SBSscript_Operation_Arithmetic(ParseTreeNode node_left, ParseTreeNode node_rigth, int simbol) : base(node_left, node_rigth, simbol)
        {

        }
    }
}
