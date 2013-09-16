namespace DataAccessLayer
{
    public class Data1Repository : IData1Repository
    {
        private readonly IFile1Repository _file1Repository;

        public Data1Repository(IFile1Repository file1Repository)
        {
            _file1Repository = file1Repository;
        }

        public string GetData1()
        {
            return _file1Repository.GetFileNameTest();
        }

        public string GetData2()
        {
            return "GetData2";
        }
    }
}
