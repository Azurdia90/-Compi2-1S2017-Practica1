using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing;

namespace Practica1_201020331.parsers   
{
    class SBSscript_Grammar : Grammar
    {
        public SBSscript_Grammar() : base(caseSensitive: true)
        {
            #region Expresiones Regulares
            RegexBasedTerminal number = new RegexBasedTerminal(SBSscript_Constans.t_number.ToString(), "[0-9]+");
            #endregion

            #region Terminales
            var s_plus = ToTerm("+", SBSscript_Constans.s_plus.ToString());
            var s_less = ToTerm("-", SBSscript_Constans.s_minus.ToString());
            var s_time = ToTerm("*", SBSscript_Constans.s_times.ToString());
            var s_div = ToTerm("/", SBSscript_Constans.s_divided.ToString());
            var s_mod = ToTerm("%", SBSscript_Constans.s_modulus.ToString());
            var s_exp = ToTerm("^", SBSscript_Constans.s_exponentiation.ToString());

            var s_par_open = ToTerm("(", SBSscript_Constans.s_par_open.ToString());
            var s_par_close = ToTerm(")", SBSscript_Constans.s_par_close.ToString());

            #endregion

            #region  NO terminales
            NonTerminal S = new NonTerminal(SBSscript_Constans.nt_S.ToString());
            NonTerminal OPERACION_ARITMETICA = new NonTerminal(SBSscript_Constans.nt_Operation_arithmetic.ToString());
            NonTerminal OPERACION_ARITMETICA2 = new NonTerminal(SBSscript_Constans.nt_Operation_arithmetic2.ToString());
            NonTerminal OPERACION_ARITMETICA3 = new NonTerminal(SBSscript_Constans.nt_Operation_arithmetic3.ToString());
            NonTerminal OPERACION_ARITMETICA4 = new NonTerminal(SBSscript_Constans.nt_Operation_arithmetic4.ToString());
            #endregion

            #region Gramatica

            S.Rule = OPERACION_ARITMETICA;

            OPERACION_ARITMETICA.Rule = OPERACION_ARITMETICA + s_plus + OPERACION_ARITMETICA2
                                        | OPERACION_ARITMETICA + s_less + OPERACION_ARITMETICA2
                                        | OPERACION_ARITMETICA2;

            OPERACION_ARITMETICA2.Rule = OPERACION_ARITMETICA2 + s_time + OPERACION_ARITMETICA3
                                        | OPERACION_ARITMETICA2 + s_div + OPERACION_ARITMETICA3
                                        | OPERACION_ARITMETICA2 + s_mod + OPERACION_ARITMETICA3 
                                        | OPERACION_ARITMETICA3;

            OPERACION_ARITMETICA3.Rule = OPERACION_ARITMETICA3 + s_exp + OPERACION_ARITMETICA4
                                        |OPERACION_ARITMETICA4 ;

            OPERACION_ARITMETICA4.Rule = number;
            #endregion

            #region Otros
            this.Root = S;
            #endregion
        }
    }
}
