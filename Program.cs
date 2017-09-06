
namespace CoreLibActiveAspose
{
    public static class Program
    {
        [FISCA.MainMethod]
        public static void Main()
        {
            //設定 ASPOSE 元件的 License。
            System.IO.Stream stream = new System.IO.MemoryStream(Properties.Resources.Aspose_Total);

            stream.Seek(0, System.IO.SeekOrigin.Begin);
            new Aspose.Words.License().SetLicense(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);
            new Aspose.Cells.License().SetLicense(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);
            new Aspose.BarCode.License().SetLicense(stream);
            stream.Seek(0, System.IO.SeekOrigin.Begin);
            new Aspose.Pdf.License().SetLicense(stream);

        }
    }
}
