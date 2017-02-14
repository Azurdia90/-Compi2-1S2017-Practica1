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
            StringLiteral sbs_string = new StringLiteral(SBSscript_Constans.t_string_sbs.ToString(), "\"");                               
            CommentTerminal sbs_comment_multi = new CommentTerminal("Comentario", "#*", "*#");
            CommentTerminal sbs_commnet = new CommentTerminal("Comentario", "#", "\n", "\r");
            NumberLiteral sbs_number = new NumberLiteral(SBSscript_Constans.t_number.ToString());
            RegexBasedTerminal sbs_file = new RegexBasedTerminal("[a-zA-Z]([a-zA-Z0-9])*.sbs");
            //IdentifierTerminal sbs_ident = new IdentifierTerminal(SBSscript_Constans.t_identifier_sbs.ToString());
            IdentifierTerminal sbs_ident = new IdentifierTerminal("id");

            #endregion

            #region Terminales

            var r_include = ToTerm("Incluye", SBSscript_Constans.r_incluye.ToString());
            var r_define = ToTerm("Define", SBSscript_Constans.r_define.ToString());
            var r_number = ToTerm("Number", SBSscript_Constans.r_number.ToString());
            var r_bool = ToTerm("Bool", SBSscript_Constans.r_bool.ToString());
            var r_string = ToTerm("String", SBSscript_Constans.r_string.ToString());
            var r_void = ToTerm("Void", SBSscript_Constans.r_void.ToString());
            var r_main = ToTerm("Principal", SBSscript_Constans.r_principal.ToString());
            var r_show = ToTerm("Mostrar", SBSscript_Constans.r_mostrar.ToString());
            var r_graph_ast = ToTerm("DibujarAST", SBSscript_Constans.r_dibujar_ast.ToString());
            var r_graph_exp = ToTerm("DibujarEXP", SBSscript_Constans.r_dibujar_exp.ToString());
            var r_si = ToTerm("Si",SBSscript_Constans.r_si.ToString());
            var r_si_no = ToTerm("Sino", SBSscript_Constans.r_sino.ToString());
            var s_plus = ToTerm("+", SBSscript_Constans.s_plus.ToString());
            var s_less = ToTerm("-", SBSscript_Constans.s_minus.ToString());
            var s_time = ToTerm("*", SBSscript_Constans.s_times.ToString());
            var s_div = ToTerm("/", SBSscript_Constans.s_divided.ToString());
            var s_mod = ToTerm("%", SBSscript_Constans.s_modulus.ToString());
            var s_exp = ToTerm("^", SBSscript_Constans.s_exponentiation.ToString());
            var s_equal = ToTerm("=", SBSscript_Constans.s_equal.ToString());
            var s_comma = ToTerm(",", SBSscript_Constans.s_comma.ToString());
            var s_par_open = ToTerm("(", SBSscript_Constans.s_par_open.ToString());
            var s_par_close = ToTerm(")", SBSscript_Constans.s_par_close.ToString());
            var s_key_open = ToTerm("{", SBSscript_Constans.s_key_open.ToString());
            var s_key_close = ToTerm("}", SBSscript_Constans.s_key_close.ToString());
            var s_semi_colon = ToTerm(";", SBSscript_Constans.s_semicolon.ToString());


            #endregion

            #region  NO terminales
            NonTerminal S = new NonTerminal(SBSscript_Constans.nt_S.ToString());
            NonTerminal LISTA_ENCABEZADO = new NonTerminal(SBSscript_Constans.nt_head_list.ToString());
            NonTerminal ENCABEZADO = new NonTerminal(SBSscript_Constans.nt_head.ToString());
            NonTerminal CUERPO = new NonTerminal(SBSscript_Constans.nt_body.ToString());
            NonTerminal INCLUYE = new NonTerminal(SBSscript_Constans.nt_include.ToString());
            NonTerminal DEFINE = new NonTerminal(SBSscript_Constans.nt_define.ToString());
            NonTerminal ORDENES = new NonTerminal(SBSscript_Constans.nt_order.ToString());
            NonTerminal DECLARACION_VARIABLES = new NonTerminal(SBSscript_Constans.nt_declare_var.ToString());
            NonTerminal DEFINICION_VARIABLES = new NonTerminal(SBSscript_Constans.nt_declare_var.ToString());
            NonTerminal VARIABLE = new NonTerminal(SBSscript_Constans.nt_var.ToString());
            NonTerminal TIPO = new NonTerminal(SBSscript_Constans.nt_type.ToString());
            NonTerminal LISTA_ID = new NonTerminal(SBSscript_Constans.nt_var_list.ToString());
            NonTerminal FUNCION_PRINCIPAL = new NonTerminal(SBSscript_Constans.nt_funt_main.ToString());
            NonTerminal FUNCIONES = new NonTerminal(SBSscript_Constans.nt_funt.ToString());
            NonTerminal PARAMETROS = new NonTerminal(SBSscript_Constans.nt_param.ToString());
            NonTerminal LLAMADAS_FUNCIONES = new NonTerminal(SBSscript_Constans.nt_funt_call.ToString());
            NonTerminal FUNCION_MOSTRAR = new NonTerminal(SBSscript_Constans.nt_funt_show.ToString());
            NonTerminal FUNCION_DIBUJAR_AST = new NonTerminal(SBSscript_Constans.nt_funt_graph_ast.ToString());
            NonTerminal FUNCION_DIBUJAR_EXP = new NonTerminal(SBSscript_Constans.nt_funt_graph_exp.ToString());
            NonTerminal LISTA_CADENAS = new NonTerminal(SBSscript_Constans.nt_string_list.ToString());
            NonTerminal LISTA_EXPRESION = new NonTerminal(SBSscript_Constans.nt_operation_list.ToString());
            NonTerminal LISTA_INSTRUCCIONES = new NonTerminal(SBSscript_Constans.nt_instruccion_list.ToString());
            NonTerminal INSTRUCCIONES = new NonTerminal(SBSscript_Constans.nt_instruccion.ToString());
            NonTerminal SI = new NonTerminal(SBSscript_Constans.nt_si.ToString());
            NonTerminal EXPRESION = new NonTerminal(SBSscript_Constans.nt_Operation_arithmetic.ToString());
            NonTerminal EXPRESION2 = new NonTerminal(SBSscript_Constans.nt_Operation_arithmetic2.ToString());
            NonTerminal EXPRESION3 = new NonTerminal(SBSscript_Constans.nt_Operation_arithmetic3.ToString());
            NonTerminal EXPRESION4 = new NonTerminal(SBSscript_Constans.nt_Operation_arithmetic4.ToString());
            #endregion

            #region Gramatica

            S.Rule = LISTA_ENCABEZADO + CUERPO
                     | CUERPO;

            //PRODUCCIONES DEL ENCABEZADO
            LISTA_ENCABEZADO.Rule = MakePlusRule(LISTA_ENCABEZADO, ENCABEZADO);

            ENCABEZADO.Rule = INCLUYE
                              | DEFINE;

            INCLUYE.Rule = r_include + sbs_file;

            DEFINE.Rule = r_define + sbs_string
                        | r_define + sbs_number;

            //PRODUCCIONES DEL CUERPO
            CUERPO.Rule = MakePlusRule(CUERPO, ORDENES);

            ORDENES.Rule = DECLARACION_VARIABLES
                           | DEFINICION_VARIABLES
                           | FUNCION_PRINCIPAL
                           | FUNCIONES;

            DECLARACION_VARIABLES.Rule = MakePlusRule(DECLARACION_VARIABLES, VARIABLE);

            VARIABLE.Rule = TIPO + LISTA_ID + s_equal + EXPRESION + s_semi_colon
                            |TIPO + LISTA_ID+ s_semi_colon;

            DEFINICION_VARIABLES.Rule = MakePlusRule(DEFINICION_VARIABLES, sbs_ident + s_equal + EXPRESION + s_semi_colon);

            TIPO.Rule = r_number
                        | r_string
                        | r_bool;

            LISTA_ID.Rule = MakePlusRule(LISTA_ID, s_comma, sbs_ident);

            FUNCION_PRINCIPAL.Rule = r_main + s_par_open + s_par_close + s_key_open + s_key_close;

            FUNCIONES.Rule = r_void + sbs_ident + s_par_open + s_par_close + s_key_open + s_key_close
                            | r_void + sbs_ident + s_par_open + PARAMETROS + s_par_close + s_key_open + s_key_close
                            |TIPO + sbs_ident + s_par_open + s_par_close + s_key_open + s_key_close 
                            |TIPO + sbs_ident + s_par_open + PARAMETROS  + s_par_close + s_key_open + s_key_close;

            PARAMETROS.Rule = MakePlusRule(PARAMETROS, s_comma, TIPO + sbs_ident);

            LLAMADAS_FUNCIONES.Rule = sbs_ident + s_par_open + LISTA_EXPRESION + s_par_close + s_semi_colon;

            FUNCION_MOSTRAR.Rule = r_show + s_par_open + LISTA_CADENAS + s_par_close + s_semi_colon;

            FUNCION_DIBUJAR_AST.Rule = r_graph_ast + s_par_open + sbs_ident + s_par_close + s_semi_colon;

            FUNCION_DIBUJAR_EXP.Rule = r_graph_exp + s_par_open + EXPRESION + s_par_close + s_semi_colon;

            LISTA_CADENAS.Rule = MakePlusRule(LISTA_CADENAS, s_comma, sbs_string);

            LISTA_EXPRESION.Rule = MakePlusRule(LISTA_EXPRESION, s_comma, EXPRESION);
             
            EXPRESION.Rule = EXPRESION + s_plus + EXPRESION
                            | EXPRESION + s_less + EXPRESION
                            | EXPRESION + s_time + EXPRESION
                            | EXPRESION + s_div + EXPRESION
                            | EXPRESION + s_mod + EXPRESION 
                            | EXPRESION + s_exp + EXPRESION
                            | sbs_number;

            //PRODUCCION DE LAS INSTRUCCIONES

            LISTA_INSTRUCCIONES.Rule = MakePlusRule(LISTA_INSTRUCCIONES, INSTRUCCIONES);

            INSTRUCCIONES.Rule = SI
                                | SELECCIONA
                                | PARA
                                | HASTA
                                | MIENTRAS
                                | DETENER
                                | CONTINUAR
                                | FUNCION_MOSTRAR
                                | FUNCION_DIBUJAR_AST
                                | FUNCION_DIBUJAR_EXP;

            SI.Rule = r_si + s_par_open + EXPRESION + s_par_close + s_key_open + LISTA_INSTRUCCIONES + s_key_close + r_si_no + s_key_open + LISTA_INSTRUCCIONES + s_key_close
                    | r_si + s_par_open + EXPRESION + s_par_close + s_key_open + LISTA_INSTRUCCIONES + s_key_close; 

            #endregion

            #region Otros
            this.Root = S;
            MarkTransient(EXPRESION4);
            #endregion
        }
    }
}
