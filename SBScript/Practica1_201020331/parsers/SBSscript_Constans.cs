using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_201020331.parsers
{
    public class SBSscript_Constans
    {

        #region Errores todos los negativos 
        public static readonly int error_aritmetic = -1;
        #endregion

        #region  Palabras Reservadas 0 - 100
        public static readonly int r_incluye = 0;
        public static readonly int r_define = 1;
        public static readonly int r_number = 2;
        public static readonly int r_bool = 3;
        public static readonly int r_string = 4;
        public static readonly int r_true = 5;
        public static readonly int r_false = 6;
        public static readonly int r_principal = 7;
        public static readonly int r_retorno = 8;
        public static readonly int r_detener = 9;
        public static readonly int r_continuar = 10;
        public static readonly int r_si = 11;
        public static readonly int r_sino = 12;
        public static readonly int r_seleccion = 13;
        public static readonly int r_defecto = 14;
        public static readonly int r_para = 15;
        public static readonly int r_hasta = 16;
        public static readonly int r_mientras = 17;
        public static readonly int r_mostrar = 18;
        public static readonly int r_dibujar_ast = 19;
        public static readonly int r_dibujar_exp = 20;
        #endregion

        #region Operadores del 200 - 300
        public static readonly int s_equal = 200;
        public static readonly int s_not_equal = 201;
        public static readonly int s_less_than = 202;
        public static readonly int s_greather_than = 203;
        public static readonly int s_greather_equal = 204;
        public static readonly int s_less_equal = 205;
        public static readonly int s_plus = 210;
        public static readonly int s_minus = 211;
        public static readonly int s_times = 212;
        public static readonly int s_divided = 213;
        public static readonly int s_modulus = 214;
        public static readonly int s_exponentiation = 215;
        public static readonly int s_and = 220;
        public static readonly int s_or = 221;
        public static readonly int s_xor = 222;
        public static readonly int s_not = 223;
        public static readonly int s_similar = 230;

        #endregion

        #region No Terminales 300 - 400
        public static readonly int nt_S = 400;
        public static readonly int nt_Operation_arithmetic = 401;
        public static readonly int nt_Operation_arithmetic2 = 402;
        public static readonly int nt_Operation_arithmetic3 = 403;
        public static readonly int nt_Operation_arithmetic4 = 404;
        #endregion

        #region Terminales 400-500
        public static readonly int t_number = 500;
        #endregion

        #region Caracteres Despreciables del 600 en adelante

        public static readonly int s_key_open = 400;
        public static readonly int s_key_close = 401;
        public static readonly int s_par_open = 402;
        public static readonly int s_par_close = 403;
        public static readonly int s_semicolon = 404;
        public static readonly int s_doble_colon = 405;

        #endregion
    }
}
