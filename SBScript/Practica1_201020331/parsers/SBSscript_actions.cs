using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing;
using System.Windows.Forms;

namespace Practica1_201020331.parsers
{
    class SBSscript_actions
    {
         public static Double action_arithmetic(ParseTreeNode root)
        {
            return expression(root);
        }

        private static double expression(ParseTreeNode root)
        {
            switch (root.ChildNodes.Count)
            {
                case 0:
                    return Convert.ToDouble(root.Token.Text.ToString());
                case 1:
                        String[] numero = root.ChildNodes.ElementAt(0).ToString().Split(' ');
                        return Convert.ToDouble(numero[0]);    
                case 3:
                    switch (root.ChildNodes.ElementAt(1).Term.Name.ToString())
                    { 
                        case "210":
                            return expression(root.ChildNodes.ElementAt(0)) + expression(root.ChildNodes.ElementAt(2));
                        case "211":
                            return expression(root.ChildNodes.ElementAt(0)) - expression(root.ChildNodes.ElementAt(2));
                        case "212":
                            return expression(root.ChildNodes.ElementAt(0)) * expression(root.ChildNodes.ElementAt(2));
                        case "213":
                            return expression(root.ChildNodes.ElementAt(0)) / expression(root.ChildNodes.ElementAt(2));
                        case "214":
                            return Math.Pow(expression(root.ChildNodes.ElementAt(0)), expression(root.ChildNodes.ElementAt(2)));
                        default:
                            return expression(root.ChildNodes.ElementAt(1));
                    }

            }
            
            return 0.0;
        }
    }
}
