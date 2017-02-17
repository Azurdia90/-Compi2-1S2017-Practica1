using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing;


namespace Practica1_201020331.parsers.Table_Symbols
{
    class SBSscript_Table_Symbols
    {
        private static SBSscript_Table_Symbols instance = null;

        private List<SBSscript_Variable> variable_List;
        private List<SBSscript_Function> function_list;

        private SBSscript_Table_Symbols() {
            variable_List = new List<SBSscript_Variable>();
            function_list = new List<SBSscript_Function>();
        }

        public static SBSscript_Table_Symbols GetInstance()
        {  
            if (instance == null)
                instance = new SBSscript_Table_Symbols();

            return instance; 
        }

        public void Clear()
        {
            instance.Clear();
        }

        public List<SBSscript_Variable> var_variable_list
        {
            get
            {
                return this.variable_List;
            }

            set
            {
                this.variable_List = var_variable_list;
            }
        }

        public List<SBSscript_Function> var_function_list
        {
            get
            {
                return this.function_list;
            }
            set
            {
                this.function_list = var_function_list;
            }
        }

    }
}
