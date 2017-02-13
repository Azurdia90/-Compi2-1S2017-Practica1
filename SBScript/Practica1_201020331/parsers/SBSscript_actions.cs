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
            if(root.ToString() != )
            return expression(root.ChildNodes.ElementAt(0));

        }

        private static double expression(ParseTreeNode root)
        {
            switch (root.ChildNodes.Count)
            {
                case 1:
                    switch (root.ChildNodes.ElementAt(1).ToString().Substring(0, 1))
                    {
                        case "500":
                            String[] numero = root.ChildNodes.ElementAt(0).ToString().Split(' ');
                            return Convert.ToDouble(numero[0]);
                        default:
                            return expression(root.ChildNode);
                    }
                case 3:
                    switch (root.ChildNodes.ElementAt(1).ToString().Substring(0, 1))
                    {
                        case "210":
                            return expression(root.ChildNodes.ElementAt(0)) + expression(root.ChildNodes.ElementAt(3));
                        case "211":
                            return expression(root.ChildNodes.ElementAt(0)) - expression(root.ChildNodes.ElementAt(3));
                        case "212":
                            return expression(root.ChildNodes.ElementAt(0)) * expression(root.ChildNodes.ElementAt(3));
                        case "213":
                            return expression(root.ChildNodes.ElementAt(0)) / expression(root.ChildNodes.ElementAt(3));
                        case "215":
                            return Math.Pow(expression(root.ChildNodes.ElementAt(0)), expression(root.ChildNodes.ElementAt(3)));
                        default:
                            return expression(root.ChildNodes.ElementAt(1));
                    }

            }
            
            return 0.0;
        }
    }
}
