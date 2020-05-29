namespace Covid19Solution.Models.ViewModels
{
    public class CaseInfoModal
    {
        public int id { get; set; }
       
        public string name { get; set; }
    
        public int age { get; set; }
       
        public string gender { get; set; }
            
        public string address { get; set; }
       
        public string city { get; set; }

        public string country { get; set; }
      
        public string status { get; set; }

    }

    public class DataResult
    {
        public int Id { get; set; }
        public string Result { get; set; }
       

    }

    public class SearchModel
    {
        public string SearchQuery { get; set; }
        public int PageIndex { get; set; }

        public int PageRow { get; set; }
    }
}

