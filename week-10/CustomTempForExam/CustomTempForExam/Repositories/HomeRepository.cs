using CustomTempForExam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomTempForExam.Repositories
{
    public class HomeRepository
    {
        HomeContext HomeContext;

        public HomeRepository(HomeContext homeContext)
        {
            HomeContext = homeContext;
        }
    }
}
