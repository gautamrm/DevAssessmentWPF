using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace DevAssessmentWPF
{
    internal class APIRestURLs
    {
        const string baseURL = "https://gorest.co.in/public/v2";

        public string GetDataURL = baseURL + "";
        public string PostDataURL = baseURL + "";
        public string PatchDataURL = baseURL + "";
        public string DeleteDataURL = baseURL + "";
    }
}
