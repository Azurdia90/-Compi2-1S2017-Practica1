using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_201020331.parsers.Table_Symbols
{
    class SBSscript_Variable
    {
        private String name;
        private Object value;
        private Boolean global;
        
        public SBSscript_Variable(String name, Object value, Boolean global)
        {
            this.name = name;
            this.value = value;
            this.global = global;
        }

        public String var_name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.value = var_name;
            }
        }

        public Object var_value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = var_value;
            }
        }

        public Boolean var_global
        {
            get
            {
                return this.global;
            }
            set
            {
                this.global = var_global;
            }
        }
    }
}
