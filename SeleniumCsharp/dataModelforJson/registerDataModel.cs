using System;
namespace SeleniumCsharp.dataModelforJson
{
	public class registerDataModel
	{
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
    }

    // read multiple datas
    public class RegisterList
    {
        private List<registerDataModel> register;
        public List<registerDataModel> Register { get => register; set => register =value; }

    }
}

