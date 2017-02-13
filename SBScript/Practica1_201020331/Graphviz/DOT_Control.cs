using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing;

namespace Practica1_201020331.Graphviz
{
    class DOT_Control
    {
        private static int count;
        private static String dot_text;

        public static String getDot(ParseTreeNode root)
        {   
            dot_text = "digraph G{";
            dot_text += "nodo0[label=\""+ escape_text(root.ToString()) + "\"];\n";
            count = 1;
            AST_Path("nodo0", root);
            dot_text += "}";
            return dot_text;
        }

        private static void AST_Path(String root, ParseTreeNode node_child)
        {
            foreach (ParseTreeNode node_child_aux in node_child.ChildNodes)
            {
                String node_child_name = "nodo" + count.ToString();
                dot_text += node_child_name + "[label=\"" + escape_text(node_child_aux.ToString()) + "\"];\n";
                dot_text += root + "->" + node_child_name + ";\n";
                count++;
                AST_Path(node_child_name, node_child_aux);
            }
        }


        private static String escape_text(String text)
        {
            text = text.Replace("\\", "\\\\");
            text = text.Replace("\"", "\\\"");
            return text;
        }
    }
}
