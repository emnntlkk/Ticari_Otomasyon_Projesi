using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
    class baglantiSinifi
    {
        public SqlConnection baglan()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-EPE6CU2L;Initial Catalog=DboTicariOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
