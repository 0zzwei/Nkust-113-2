using CsvHelper.Configuration.Attributes;

namespace OpenDataAnalyzerMvc.Models
{
    public class ElderCareRecord
    {
        [Name("�ϰ�")]
        public string �ϰ� { get; set; }

        [Name("�q�ܰݦw")]
        public int �q�ܰݦw { get; set; }

        [Name("���ӪA��")]
        public int ���ӪA�� { get; set; }

        [Name("��L�A��")]
        public int ��L�A�� { get; set; }

        [Name("�X�p")]
        public int �X�p { get; set; }

        [Name("�A�ȤH��")]
        public int �A�ȤH�� { get; set; }
    }
}
