using System.Text;

namespace PW3SPP;

public partial class ReadWriteForm : Form
{
    public string FilesDirPath { get; private set; } = @"C:\Users\vlad\Desktop\Study\Subjets\OAiP_(C#)\CsharpSystemProgrammingPracticum\PW3SPP\TextFiles\";
    public string FileName {  get; private set; }

    public ReadWriteForm() => InitializeComponent();

    private void ReadWriteFormLoad(object sender, EventArgs e) => FileName = FilesDirPath + @"TextFile.txt";

    private void OpenButtonClick(object sender, EventArgs e)
    {
        try
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding encoding = Encoding.GetEncoding(1251);
            StreamReader reader = new(FileName, encoding);

            textBox1.Text = reader.ReadToEnd();
            reader.Close();
        }
        catch (FileNotFoundException ex)
        {
            MessageBox.Show(ex.Message + "\nНет такого файла", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }

    private void SaveButtonClick(object sender, EventArgs e)
    {
        try
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding encoding = Encoding.GetEncoding(1251);
            StreamWriter writer = new(FileName, false, encoding);

            File.WriteAllText(FilesDirPath + @"TempFile.tmp", textBox1.Text);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}