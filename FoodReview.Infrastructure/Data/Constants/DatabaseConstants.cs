using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodReview.Infrastructure.Data.Constants
{
    public static class DatabaseConstants
    {
        public const string Connection_String = "Server=172.17.192.1,1433;Database=FoodReview_Container;User Id=sa;Password=Maxmen111;TrustServerCertificate=True;";
        public const int Guid_Max_Length = 100;
        public const int Info_Max_Length = 200;
        public const int ProfilePicture_Max_Length = 500;
        public const int Username_Max_Length = 50;
        public const int FoodPlace_Name_Max_Length = 50;
        public const double Percent_Min_Range = 1;
        public const double Percent_Max_Pange = 100;
    }
}
