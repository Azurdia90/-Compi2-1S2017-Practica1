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
            CommentTerminal sbs_comment_multi = new CommentTerminal("Comentario_multi", "#*", "*#");
            CommentTerminal sbs_commnet = new CommentTerminal("Comentario", "#", "\n", "\r");
            NumberLiteral sbs_number = new NumberLiteral(SBSscript_Constans.t_number.ToString());
            RegexBasedTerminal sbs_file = new RegexBasedTerminal("[a-zA-Z]([a-zA-Z0-9])*.sbs");
            IdentifierTerminal sbs_ident = new IdentifierTerminal(SBSscript_Constans.t_identifier_sbs.ToString());

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
            var r_si = ToTerm("Si", SBSscript_Constans.r_si.ToString());
            var r_si_no = ToTerm("Sino", SBSscript_Constans.r_sino.ToString());
            var r_selecciona = ToTerm("Selecciona", SBSscript_Constans.r_seleccion.ToString());
            var r_valor = ToTerm("Valor", SBSscript_Constans.r_value.ToString());
            var r_para = ToTerm("Para", SBSscript_Constans.r_para.ToString());
            var r_hasta = ToTerm("Hasta", SBSscript_Constans.r_hasta.ToString());
            var r_mientras = ToTerm("Mientras", SBSscript_Constans.r_mientras.ToString());
            var r_continuar = ToTerm("Continuar", SBSscript_Constans.r_continuar.ToString());
            var r_detener = ToTerm("Detener", SBSscript_Constans.r_detener.ToString());
            var r_retorno = ToTerm("Retorno", SBSscript_Constans.r_retorno.ToString());
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
            var s_doble_dot = ToTerm("dot", SBSscript_Constans.s_doble_colon.ToString());
            var s_doble_plus = ToTerm("++", SBSscript_Constans.s_doble_plus.ToString());
            var s_doble_less = ToTerm("--", SBSscript_Constans.s_doble_less.ToString());
            var s_comparacion = ToTerm("==", SBSscript_Constans.s_comparation.ToString());
            var s_diferente = ToTerm("!=", SBSscript_Constans.s_not_equal.ToString());
            var s_menor_que = ToTerm("<", SBSscript_Constans.s_less_than.ToString());
            var s_mayor_que = ToTerm(">", SBSscript_Constans.s_greather_than.ToString());
            var s_menor_igual = ToTerm("<=", SBSscript_Constans.s_greather_than.ToString());
            var s_mayor_igual = ToTerm(">=", SBSscript_Constans.s_less_than.ToString());
            var s_or = ToTerm("||", SBSscript_Constans.s_or.ToString());
            var s_xor = ToTerm("!&", SBSscript_Constans.s_xor.ToString());
            var s_and = ToTerm("&", SBSscript_Constans.s_and.ToString());
            var s_not = ToTerm("!", SBSscript_Constans.s_not.ToString());
            var s_equivalente = ToTerm("~", SBSscript_Constans.s_equiavlent.ToString());


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
            NonTerminal SELECCIONA = new NonTerminal(SBSscript_Constans.nt_select.ToString());
            NonTerminal LISTA_CASOS = new NonTerminal(SBSscript_Constans.nt_value_list.ToString());
            NonTerminal VALOR = new NonTerminal(SBSscript_Constans.nt_value.ToString());
            NonTerminal PARA = new NonTerminal(SBSscript_Constans.nt_para.ToString());
            NonTerminal OP = new NonTerminal(SBSscript_Constans.nt_op.ToString());
            NonTerminal INSTRUCCIONES_ADICIONALES = new NonTerminal(SBSscript_Constans.nt_instruccion_adicional.ToString());
            NonTerminal RETORNO = new NonTerminal(SBSscript_Constans.nt_return.ToString());
            NonTerminal EXPRESION = new NonTerminal(SBSscript_Constans.nt_Operation_arithmetic.ToString());
            NonTerminal EXPRESION2 = new NonTerminal(SBSscript_Constans.nt_Operation_arithmetic2.ToString());
            NonTerminal EXPRESION3 = new NonTerminal(SBSscript_Constans.nt_Operation_arithmetic3.ToString());
            NonTerminal EXPRESION4 = new NonTerminal(SBSscript_Constans.nt_Operation_arithmetic4.ToString());
            NonTerminal COMENTARIO = new NonTerminal(SBSscript_Constans.nt_Comentario.ToString());
            #endregion

            #region Gramatica
        
            /*******************************PRODUCCION INICIAL******************************************/
            S.Rule = LISTA_ENCABEZADO + CUERPO
                     | CUERPO;

            /*****************************PRODUCCIONES DEL ENCABEZADO*************************/
            LISTA_ENCABEZADO.Rule = MakePlusRule(LISTA_ENCABEZADO, ENCABEZADO);

            ENCABEZADO.Rule = INCLUYE
                              | DEFINE;

            INCLUYE.Rule = r_include + sbs_file;

            DEFINE.Rule = r_define + sbs_string
                        | r_define + sbs_number;

            /*********************************PRODUCCIONES DEL CUERPO******************************/
            CUERPO.Rule = MakePlusRule(CUERPO, ORDENES);

            ORDENES.Rule = DECLARACION_VARIABLES
                           | DEFINICION_VARIABLES
                           | FUNCION_PRINCIPAL
                           | FUNCION_DIBUJAR_AST
                           | FUNCION_DIBUJAR_EXP
                           | FUNCION_MOSTRAR
                           | FUNCIONES;
            //-----------------VARIABLES-------------------------------------------
            DECLARACION_VARIABLES.Rule = MakePlusRule(DECLARACION_VARIABLES, VARIABLE);

            VARIABLE.Rule = TIPO + LISTA_ID + s_equal + EXPRESION + s_semi_colon
                            |TIPO + LISTA_ID+ s_semi_colon;

            DEFINICION_VARIABLES.Rule = MakePlusRule(DEFINICION_VARIABLES, sbs_ident + s_equal + EXPRESION + s_semi_colon);

            TIPO.Rule = r_number
                        | r_string
                        | r_bool;

            LISTA_ID.Rule = MakePlusRule(LISTA_ID, s_comma, sbs_ident);
            //-------------------------------------------------------------------
            //-----------------FUNCIONES-------------------------------------------
            FUNCION_PRINCIPAL.Rule = r_main + s_par_open + s_par_close + s_key_open + LISTA_INSTRUCCIONES + s_key_close;            

            FUNCIONES.Rule = r_void + sbs_ident + s_par_open + s_par_close + s_key_open + LISTA_INSTRUCCIONES  + s_key_close
                            | r_void + sbs_ident + s_par_open + PARAMETROS + s_par_close + s_key_open + LISTA_INSTRUCCIONES + s_key_close
                            |TIPO + sbs_ident + s_par_open + s_par_close + s_key_open + LISTA_INSTRUCCIONES + s_key_close 
                            |TIPO + sbs_ident + s_par_open + PARAMETROS  + s_par_close + s_key_open + LISTA_INSTRUCCIONES + s_key_close;

            PARAMETROS.Rule = MakePlusRule(PARAMETROS, s_comma, TIPO + sbs_ident);

            LLAMADAS_FUNCIONES.Rule = sbs_ident + s_par_open + LISTA_EXPRESION + s_par_close 
                                    | sbs_ident + s_par_open + s_par_close;

            FUNCION_MOSTRAR.Rule = r_show + s_par_open + sbs_string + s_par_close + s_semi_colon
                                  | r_show + s_par_open + sbs_string + s_comma + LISTA_EXPRESION + s_par_close + s_semi_colon;

            FUNCION_DIBUJAR_AST.Rule = r_graph_ast + s_par_open + sbs_ident + s_par_close + s_semi_colon;

            FUNCION_DIBUJAR_EXP.Rule = r_graph_exp + s_par_open + EXPRESION + s_par_close + s_semi_colon;

            LISTA_CADENAS.Rule = MakePlusRule(LISTA_CADENAS, s_comma, EXPRESION);

            //----------------------------------------------------------------------
            //-----------------CICLOS-----------------------------------------------
            SI.Rule = r_si + s_par_open + EXPRESION + s_par_close + s_key_open + LISTA_INSTRUCCIONES + s_key_close + r_si_no + s_key_open + LISTA_INSTRUCCIONES + s_key_close
                    | r_si + s_par_open + EXPRESION + s_par_close + s_key_open + LISTA_INSTRUCCIONES + s_key_close;

            SELECCIONA.Rule = r_selecciona + s_par_open + EXPRESION + s_par_close + LISTA_CASOS;

            LISTA_CASOS.Rule = MakePlusRule(LISTA_CASOS, VALOR);

            VALOR.Rule = r_valor + s_doble_dot + s_key_open + LISTA_INSTRUCCIONES + s_key_close;

            PARA.Rule = r_para + s_par_open + r_number + sbs_ident + s_equal + EXPRESION + s_semi_colon + EXPRESION + s_semi_colon + OP + s_par_close + s_key_open + LISTA_INSTRUCCIONES + s_key_close;

            OP.Rule = s_doble_plus
                    | s_doble_less;

            INSTRUCCIONES_ADICIONALES.Rule = r_hasta + s_par_open + EXPRESION + s_par_close + s_key_open + LISTA_INSTRUCCIONES + s_key_close
                                            | r_mientras + s_par_open + EXPRESION + s_par_close + s_key_open + LISTA_INSTRUCCIONES + s_key_close;

            RETORNO.Rule = r_retorno + EXPRESION + s_semi_colon
                           | r_retorno + s_semi_colon;
            //-------------------LISTA DE INSTRUCCIONES ---------------------------------

            LISTA_INSTRUCCIONES.Rule = MakePlusRule(LISTA_INSTRUCCIONES, INSTRUCCIONES);

            INSTRUCCIONES.Rule = LLAMADAS_FUNCIONES + s_semi_colon
                                | INSTRUCCIONES_ADICIONALES
                                | DECLARACION_VARIABLES
                                | DEFINICION_VARIABLES
                                | FUNCION_DIBUJAR_AST
                                | FUNCION_DIBUJAR_EXP
                                | FUNCION_MOSTRAR
                                | SELECCIONA
                                | RETORNO
                                | PARA
                                | SI
                                | r_detener + s_semi_colon
                                | r_continuar + s_semi_colon;
            //---------------------------------------------------------------------------
            //--------------------EXPRESIONES--------------------------------------------
            LISTA_EXPRESION.Rule = MakePlusRule(LISTA_EXPRESION, s_comma, EXPRESION);
             
            EXPRESION.Rule = EXPRESION + s_plus + EXPRESION                        //1
                            | EXPRESION + s_less + EXPRESION                       //1
                            | EXPRESION + s_time + EXPRESION                       //2 
                            | EXPRESION + s_div + EXPRESION                        //2
                            | EXPRESION + s_mod + EXPRESION                        //2
                            | EXPRESION + s_exp + EXPRESION                        //3
                            | s_less + EXPRESION                                   //4
                            | EXPRESION + s_comparacion + EXPRESION                //5
                            | EXPRESION + s_diferente + EXPRESION                  //5
                            | EXPRESION + s_menor_que + EXPRESION                  //5
                            | EXPRESION + s_mayor_que + EXPRESION                  //5
                            | EXPRESION + s_menor_igual + EXPRESION                //5
                            | EXPRESION + s_mayor_igual + EXPRESION                //5
                            | EXPRESION + s_or + EXPRESION                         //6
                            | EXPRESION + s_xor + EXPRESION                        //7
                            | EXPRESION + s_and + EXPRESION                        //8
                            | EXPRESION + s_not + EXPRESION                        //9
                            | EXPRESION + s_equivalente + EXPRESION
                            | s_par_open + EXPRESION + s_par_close                 //10
                            | sbs_number                                           //10 
                            | sbs_ident                                            //10
                            | sbs_string                                           //10
                            | LLAMADAS_FUNCIONES;                                  //10

            //---------------------------------------------------------------------------
            #endregion

            #region No Terminales para manejo de Errores
            LLAMADAS_FUNCIONES.ErrorRule = sbs_ident + s_par_open + SyntaxError + s_par_close;
            FUNCIONES.ErrorRule = r_void + sbs_ident + s_par_open + s_par_close + s_key_open + SyntaxError + s_key_close
                | r_void + sbs_ident + s_par_open + SyntaxError + s_par_close + s_key_open + SyntaxError + s_key_close
                | TIPO + sbs_ident + s_par_open + s_par_close + s_key_open + SyntaxError + s_key_close
                | TIPO + sbs_ident + s_par_open + SyntaxError + s_par_close + s_key_open + SyntaxError + s_key_close;
            VARIABLE.ErrorRule = SyntaxError + s_semi_colon;
            FUNCION_PRINCIPAL.ErrorRule = r_main + s_par_open + s_par_close + s_key_open + SyntaxError + s_key_close;
            SI.ErrorRule = r_si + s_par_open + EXPRESION + s_par_close + s_key_open + SyntaxError + s_key_close + r_si_no + s_key_open + SyntaxError + s_key_close
                    | r_si + s_par_open + EXPRESION + s_par_close + s_key_open + SyntaxError + s_key_close;
            SELECCIONA.ErrorRule = r_selecciona + s_par_open + SyntaxError + s_par_close + LISTA_CASOS;
            VALOR.ErrorRule = r_valor + s_doble_dot + s_key_open + SyntaxError + s_key_close;
            PARA.ErrorRule = r_para + s_par_open + SyntaxError + s_par_close + s_key_open + SyntaxError + s_key_close;
            INSTRUCCIONES_ADICIONALES.ErrorRule = r_hasta + s_par_open + SyntaxError + s_par_close + s_key_open + SyntaxError + s_key_close;
            RETORNO.ErrorRule = SyntaxError + s_semi_colon;
            #endregion

            #region Otros
            this.Root = S;
            MarkPunctuation(s_semi_colon, s_comma, s_par_open, s_par_close, s_key_open, s_key_close, s_equal, s_doble_dot);
            base.NonGrammarTerminals.Add(sbs_commnet);
            base.NonGrammarTerminals.Add(sbs_comment_multi);
            #endregion
        }
    }
}
