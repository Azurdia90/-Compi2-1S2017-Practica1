using Practica1_201020331.parsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Irony.Ast;
using Irony.Parsing;

namespace Practica1_201020331
{
    public partial class Form_Principal : Form
    {
        private TabPage tab_page_new;
        private RichTextBox rich_text_box_new;

        private List<RichTextBox> rich_text_box_list;
        private String tab_page_title;
        public Form_Principal()
        {
            InitializeComponent();
            tab_page_new = null;
            rich_text_box_new = null;
            rich_text_box_list = new List<RichTextBox>(); //se crea la lista de richtexbox a utilizar
            rich_text_box_list.Add(rTB_entrada1); //se agrega el primer richtextbox a la lista
            tab_page_title = null;
        }

        #region Metodos Botones
        private void b_nuevo_Click(object sender, EventArgs e)
        {
            tab_new();
        }
        private void b_abrir_Click(object sender, EventArgs e)
        {
            doc_open();
        }

        private void b_Guardar_Como_Click(object sender, EventArgs e)
        {
            doc_save_as();
        }

        private void b_cerrar_Click(object sender, EventArgs e)
        {
            tab_delete();
        }

        private void b_ejecutar_Click(object sender, EventArgs e)
        {
            analyse_grammar(tab_get().Text);
        }

        #endregion

        #region Metodos Generados
        public void tab_new()
        {
            tab_page_title = "Archivo " + (tC_entradas.TabCount + 1).ToString();
            tab_page_new = new TabPage(tab_page_title);
            rich_text_box_new = new RichTextBox(); // se crea un nuevo richtextbox
            rich_text_box_new.Dock = DockStyle.Fill; //se setea que ocupe todo el tab
            rich_text_box_list.Add(rich_text_box_new); //se agrega a la lista de richtexbox
            tab_page_new.Controls.Add(rich_text_box_new);
            tC_entradas.TabPages.Add(tab_page_new);
            tC_entradas.SelectTab(tC_entradas.TabCount - 1); //se coloca en la posicion mas reciente
        }

        public RichTextBox tab_get()
        {
            int count_tab = tC_entradas.SelectedIndex;
            RichTextBox rich_text_box_active = rich_text_box_list[count_tab];
            return rich_text_box_active;
        }
        public void tab_delete()
        {
            if(tC_entradas.TabCount > 1)
            {
                rich_text_box_list.RemoveAt(tC_entradas.SelectedIndex);
                tC_entradas.TabPages.RemoveAt(tC_entradas.SelectedIndex);
                tC_entradas.SelectTab(tC_entradas.TabCount - 1);
            }else
            {
                MessageBox.Show("No puede eliminarse el unico tab disponible","Atención");
            }

        }

        public void doc_open()
        {
            //se crea un objeto de openfiledialogo que nos servira para abrir archivos
            OpenFileDialog Open = new OpenFileDialog();
            System.IO.StreamReader myStreamReader = null;
            //se especifica que tipos de archivos se podran abrir y se verifica si existe
            Open.Filter = "SBS File [*.sbs*]|*.sbs|All Files [*.*]|*.*";
            Open.CheckFileExists = true;
            Open.Title = "Abrir Archivo";
            Open.ShowDialog(this);
            try
            {
                //este codigo se utiliza para que se pueda pueda mostrar la informacion del archivo que queremos abrir en el rich textbox
                Open.OpenFile();
                myStreamReader = System.IO.File.OpenText(Open.FileName);
                tab_get().Text = myStreamReader.ReadToEnd();

            }
            catch (Exception) { }
        }

        public void doc_save_as()
        {
                        //se crea un objeto de tipo savefiledialog que nos servira para guardar el archivo
            SaveFileDialog Save = new SaveFileDialog();
            System.IO.StreamWriter myStreamWriter = null;
            //al igual que para abrir el tipo de documentos aqui se especifica en que extenciones se puede guardar el archivo
            Save.Filter = "SBS File (*.sbs)|*.sbs|All files(*.*)|*.*";
            Save.CheckPathExists = true;
            Save.Title = "Guardar como";
            Save.ShowDialog(this);
            try
            {
                //este codigo se utiliza para guardar el archivo de nuestro editor
                myStreamWriter = System.IO.File.AppendText(Save.FileName);
                myStreamWriter.Write(tab_get().Text);
                myStreamWriter.Flush();
 
            }
            catch (Exception) { }
        }

        public void analyse_grammar(String text)
        {
            ParseTreeNode result_analyse = null;
            if (text == "")
            {
                tB_consola.Text = "======DEBE INGRESAR UN TEXTO PARA PODER REALIZAR EL ANALISIS====";
                return;
            }

            result_analyse = SBSscript_Syntactic.analyse(text);

            if (result_analyse != null)
            {
                SBSscript_Syntactic.generate_image(result_analyse);
                SBSscript_Syntactic.write_table(result_analyse);
                SBSscript_Syntactic.test_table_symbols();
                tB_consola.Text += "\n";
                tB_consola.Text += "=========ANALISADO CON EXITO===========";
            }else
            {
                tB_consola.Text = "======EXISTEN ERRORES REVISE EL REPORTE DE ERRORES====";
            }

        }

        #endregion
    }
}
