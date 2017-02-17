using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing;

namespace Practica1_201020331.parsers.Table_Symbols
{
    class SBSscript_Function
    {
        private String name;
        private List<SBSscript_Variable> variable_list;
        private int level;
        private ParseTreeNode function;
        private Boolean call;
        private Boolean main;

        public SBSscript_Function(String name, int level, ParseTreeNode function, Boolean call, Boolean main)
        {
            this.name = name;
            this.level = level;
            this.function = function;
            this.call = call;
            variable_list = new List<SBSscript_Variable>();
            this.main = main;
        }

        public String var_name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = var_name;
            }
        }
        
        public List<SBSscript_Variable> var_variable_list
        {
            get
            {
                return this.variable_list;
            }
            set
            {
                this.variable_list = var_variable_list;
            }
        }

        public ParseTreeNode var_function
        {
            get
            {
                return this.function;
            }
            set
            {
                this.function = var_function;
            }
        }

        public Boolean var_call
        {
            get
            {
                return this.call;
            }
            set
            {
                this.call = var_call;
            }
        }

        public Boolean var_main
        {
            get
            {
                return this.main;
            }

            set
            {
                this.main = var_main;
            }
        }

    }
}
