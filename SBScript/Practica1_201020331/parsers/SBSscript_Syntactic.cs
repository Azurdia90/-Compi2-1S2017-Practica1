﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing;
using System.Windows.Forms;
using Practica1_201020331.parsers.Table_Symbols;

namespace Practica1_201020331.parsers
{
    class SBSscript_Syntactic : Grammar
    {
        public static ParseTreeNode analyse(String text)
        {

            SBSscript_Grammar grammar_new = new SBSscript_Grammar();
            LanguageData language_new = new LanguageData(grammar_new);
            Parser parser_new = new Parser(language_new);
            ParseTree tree_new = parser_new.Parse(text);
            ParseTreeNode tree_root = tree_new.Root;
            return tree_root;
        }
        public static void generate_image(ParseTreeNode root)
        {
            String dot_Graph = Graphviz.DOT_Control.getDot(root);
            Console.WriteLine(dot_Graph);
            WINGRAPHVIZLib.DOT dot_new = new WINGRAPHVIZLib.DOT();
            WINGRAPHVIZLib.BinaryImage img_new = dot_new.ToPNG(dot_Graph);
            img_new.Save("AST.png");
        }

        public static void write_table(ParseTreeNode root)
        {
            
            foreach (ParseTreeNode node_child_aux in root.ChildNodes)
            {
                switch (node_child_aux.Term.Name.ToString())
                {
                    case "411" :
                        SBSscript_Function function_main = new SBSscript_Function("Principal", -1, node_child_aux.ChildNodes.ElementAt(1), false, true);
                        SBSscript_Table_Symbols.GetInstance().var_function_list.Add(function_main);
                        break;

                }                
                
                write_table(node_child_aux);
                              
            }
        }

        public static void test_table_symbols()
        {
            foreach(SBSscript_Function function_aux in SBSscript_Table_Symbols.GetInstance().var_function_list){
                MessageBox.Show(function_aux.var_name.ToString());
            }
        }

        public static void generate_error_report(ParseTreeNode root)
        {

        }
                                        
        
    }
}
