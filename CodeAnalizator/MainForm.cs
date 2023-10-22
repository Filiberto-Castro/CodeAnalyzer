using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using CodeAnalyzer;

namespace CodeAnalizator
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            // logica para mover ventanas
            MoverComponente moverComponente = new MoverComponente();
            moverComponente.Attach(headerMainForm);
        }

        private void btnAnalizador_Click_1(object sender, EventArgs e)
        {
            deshabilitarComponentes();
            String txtCodigoFuente = cbCodigoFuente.Text;

            // Logica para ejecutar el analizador que corresponde (c++ o java)
            switch (cbLenguaje.SelectedIndex)
            {
                case 0:
                    analizadorLexicoCPP(txtCodigoFuente);
                    break;
                case 1:
                    analizadorLexicoJava(txtCodigoFuente);
                    break;
            }

        }


        // Metodo para el analizado lexico de C++
        public void analizadorLexicoCPP(String codigo)
        {

            // Inicialización de patrones con sus respectivos tokens
            string includeDirectivePattern = @"#include\s+[<\""].*[>\""]";
            string keywordPattern = @"\b(alignas|alignof|and|and_eq|asm|auto|bitand|bitor|bool|break|case|catch|char|char8_t|char16_t|char32_t|class|compl|concept|const|consteval|constexpr|constinit|continue|co_await|co_return|co_yield|decltype|default|delete|do|dynamic_cast|else|enum|explicit|export|extern|false|for|friend|goto|if|inline|mutable|namespace|new|noexcept|not|not_eq|nullptr|operator|or|or_eq|private|protected|public|register|reinterpret_cast|requires|return|sizeof|static|static_assert|static_cast|struct|switch|template|this|thread_local|throw|true|try|typedef|typeid|typename|union|using|virtual|void|volatile|wchar_t|while|xor|xor_eq)\b";
            string assignmentOperatorPattern = @"(=|\+=|-=|\*=|/=|%=|<<=|>>=|\&=|\|=|\^=)";
            string operatorPattern = @"(\+|-|\*|/|%|<<|>>|\&\&|\|\||~|&|\||\^|<<=|>>=|::|\.\*|->|->\*|\?|::=|\+\.|\-\.|\*\.|/\.|%\.|\&\.|\|\.)";
            string identifierPattern = @"[a-zA-Z_]\w*";
            string numberPattern = @"\b\d+(\.\d*)?([eE][+-]?\d+)?\b";
            string stringLiteralPattern = "\"(\\.|[^\"])*\"";
            string relationalOperatorPattern = @"(==|!=|<|>|<=|>=)";
            string delimiterPattern = @"(\(\)|\(|\)|\[|\]|\{|\})";
            string incrementDecrementOperatorPattern = @"(\+\+|--)";
            string dataTypePattern = @"\b(int|char|bool|float|double|void|long|short|unsigned|signed)\b";


            // Logica para identificar y devolver el tipo de patron
            string IdentificarTipoPatron(string patron)
            {
                if (Regex.IsMatch(patron, includeDirectivePattern))
                    return "Biblioteca";
                else if (Regex.IsMatch(patron, keywordPattern))
                    return "Palabra clave";
                else if (Regex.IsMatch(patron, assignmentOperatorPattern))
                    return "Operador de asignación";
                else if (Regex.IsMatch(patron, operatorPattern))
                    return "Operador";
                else if (Regex.IsMatch(patron, relationalOperatorPattern))
                    return "Operador relacional";
                else if (Regex.IsMatch(patron, numberPattern))
                    return "Número";
                else if (Regex.IsMatch(patron, stringLiteralPattern))
                    return "Literal de cadena";
                else if (Regex.IsMatch(patron, dataTypePattern))
                    return "Tipo de dato";
                else if (Regex.IsMatch(patron, incrementDecrementOperatorPattern))
                    return "Operador de incremento y decremento";
                else if (Regex.IsMatch(patron, delimiterPattern))
                    return "Signo de agrupación";
                else if (Regex.IsMatch(patron, identifierPattern))
                    return "Identificador";
                else
                    return "Desconocido";
            }

            // Combinar los patrones en una expresión regular
            string combinedPattern = string.Join("|", includeDirectivePattern, keywordPattern, assignmentOperatorPattern, operatorPattern, relationalOperatorPattern, identifierPattern, numberPattern, stringLiteralPattern, dataTypePattern, delimiterPattern);

            // Crear la expresión regular
            Regex regex = new Regex(combinedPattern);

            // Buscar y mostrar tokens en el código
            MatchCollection matches = regex.Matches(codigo);

            foreach (Match match in matches)
            {
                string tipoPatron = IdentificarTipoPatron(match.Value);
                rtbResultado.AppendText(tipoPatron + ": "+ match.Value + Environment.NewLine);
            }

        }


        // Metodo para el analizado lexico de Java
        public void analizadorLexicoJava(String codigo)
        {

            // Inicialización de patrones con sus respectivos tokens
            string includeDirectivePattern = @"import\s+[\w.]+[.;]";
            string keywordPattern = @"\b(abstract|assert|break|case|catch|class|const|continue|default|do|else|enum|extends|final|finally|for|goto|if|implements|import|instanceof|interface|long|native|new|package|private|protected|public|return|short|static|strictfp|super|switch|synchronized|this|throw|throws|transient|try|volatile|while)\b";
            string assignmentOperatorPattern = @"(=|\+=|-=|\*=|/=|%=|<<=|>>=|\&=|\|=|\^=)";
            string operatorPattern = @"(\+|-|\*|/|%|<<|>>|\&\&|\|\||~|&|\||\^|<<=|>>=|::|\.\*|->|->\*|\?|::=|\+\.|\-\.|\*\.|/\.|%\.|\&\.|\|\.)";
            string identifierPattern = @"[a-zA-Z_]\w*";
            string numberPattern = @"\b\d+(\.\d*)?([eE][+-]?\d+)?\b";
            string stringLiteralPattern = "\"(\\.|[^\"])*\"";
            string relationalOperatorPattern = @"==|!=|<|>|<=|>=|instanceof";
            string delimiterPattern = @"\(\)|\(|\)|\[\]|\[|\]|\{|\}|::";
            string incrementDecrementOperatorPattern = @"(\+\+|--)";
            string dataTypePattern = @"\b(byte|short|int|long|float|double|boolean|char|void|String)\b";

            // Logica para identificar y devolver el tipo de patron
            string IdentificarTipoPatron(string patron)
            {
                if (Regex.IsMatch(patron, includeDirectivePattern))
                    return "Biblioteca";
                else if (Regex.IsMatch(patron, keywordPattern))
                    return "Palabra clave";
                else if (Regex.IsMatch(patron, assignmentOperatorPattern))
                    return "Operador de asignación";
                else if (Regex.IsMatch(patron, operatorPattern))
                    return "Operador";
                else if (Regex.IsMatch(patron, relationalOperatorPattern))
                    return "Operador relacional";
                else if (Regex.IsMatch(patron, numberPattern))
                    return "Número";
                else if (Regex.IsMatch(patron, stringLiteralPattern))
                    return "Literal de cadena";
                else if (Regex.IsMatch(patron, dataTypePattern))
                    return "Tipo de dato";
                else if (Regex.IsMatch(patron, incrementDecrementOperatorPattern))
                    return "Operador de incremento y decremento";
                else if (Regex.IsMatch(patron, delimiterPattern))
                    return "Signo de agrupación";
                else if (Regex.IsMatch(patron, identifierPattern))
                    return "Identificador";
                else
                    return "Desconocido";
            }

            string combinedPattern = string.Join("|", includeDirectivePattern, keywordPattern, assignmentOperatorPattern, operatorPattern, relationalOperatorPattern, identifierPattern, numberPattern, stringLiteralPattern, dataTypePattern, delimiterPattern);
            Regex regex = new Regex(combinedPattern);
            MatchCollection matches = regex.Matches(codigo);

            foreach (Match match in matches)
            {
                string tipoPatron = IdentificarTipoPatron(match.Value);
                rtbResultado.AppendText(tipoPatron + ": " + match.Value + Environment.NewLine);
            }
        }

        private void deshabilitarComponentes()
        {
            cbCodigoFuente.ReadOnly = true;
            rtbResultado.ReadOnly = true;
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            vaciarTXT();

            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configura el cuadro de diálogo para que solo muestre archivos .txt
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string nombreArchivo = openFileDialog.FileName;

                try
                {
                    // Lee el contenido del archivo seleccionado
                    string contenido = File.ReadAllText(nombreArchivo);

                    // Almacena el contenido en una cadena (string)
                    cbCodigoFuente.Text = contenido;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al cargar el archivo: " + ex.Message);
                }

                cbCodigoFuente.ReadOnly = false;
                cbCodigoFuente.Focus();
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            cbCodigoFuente.ReadOnly = false;
            cbCodigoFuente.Focus();
            vaciarTXT();
        }

        private void vaciarTXT()
        {
            cbCodigoFuente.Text = string.Empty;
            rtbResultado.Text = string.Empty;
        }

        private void btnExportarTexto_Click(object sender, EventArgs e)
        {
            if (rtbResultado.Text != "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                // Configura el cuadro de diálogo para que solo permita guardar archivos .txt
                saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string nombreArchivo = saveFileDialog.FileName;

                    try
                    {
                        // Obtiene el contenido del RichTextBox
                        string contenido = rtbResultado.Text;

                        // Escribe el contenido en el archivo seleccionado
                        File.WriteAllText(nombreArchivo, contenido);

                        MessageBox.Show("Análisis del codigo fuente exportado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al exportar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender; // Convierte el sender en un Panel

            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 20; // Ajusta el valor del radio según lo desees
                Rectangle rect = new Rectangle(0, 0, panel.Width, panel.Height);

                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(112, 185, 190))) // Color personalizado
                {
                    e.Graphics.FillPath(brush, path);
                }
                e.Graphics.DrawPath(Pens.LightBlue, path); // Puedes ajustar el color del borde según lo desees
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;

            using (GraphicsPath path = new GraphicsPath())
            {
                int radius = 20;
                Rectangle rect = new Rectangle(0, 0, panel.Width, panel.Height);

                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(112, 185, 190)))
                {
                    e.Graphics.FillPath(brush, path);
                }
                e.Graphics.DrawPath(Pens.LightBlue, path);
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Hide();
            // Instanciar y mostrar el formulario manual de usuario
            ManualDeUsuario manual = new ManualDeUsuario();
            manual.ShowDialog();
            this.Show();
        }
    }
}
