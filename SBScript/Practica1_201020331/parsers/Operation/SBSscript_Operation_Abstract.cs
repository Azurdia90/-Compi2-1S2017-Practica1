using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing;

namespace Practica1_201020331.parsers.Operation
{
    abstract class SBSscript_Operation_Abstract
    {
        protected ParseTreeNode Node_left;
        protected ParseTreeNode Node_rigth;
        protected int simbol;

        public SBSscript_Operation_Abstract(ParseTreeNode node_left, ParseTreeNode node_rigth, int simbol){
            this.Node_left = node_left;
            this.Node_rigth = node_rigth;
            this.simbol = simbol;
        }

        //public abstract operation_result oerate();

        protected int type_verify(int type_left, int type_rigth, int[][] matrix_type)
        {
            if(type_left < 0 && type_left >= matrix_type.Length)
            {
                return SBSscript_Constans.error_aritmetic;
            }
            if(type_rigth < 0 &&  type_rigth >= matrix_type[0].Length){
                return SBSscript_Constans.error_aritmetic;
            }
            return matrix_type[type_left][type_rigth];
        }
    }
}
