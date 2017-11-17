using CustomTempForExam.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomTempForExam.Services
{
    public class HomeService
    {
        HomeRepository HomeRepository;

        public HomeService(HomeRepository homeRepository)
        {
            HomeRepository = homeRepository;
        }
    }
}
