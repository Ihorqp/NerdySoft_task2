using Microsoft.AspNetCore.Mvc;
using NerdySoft_task2.Domain;
using NerdySoft_task2.Domain.Entities;
using NerdySoft_task2.Domain.Repositories.Abstract;
using NerdySoft_task2.Domain.Repositories.EntityFramework;
using NerdySoft_task2.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NerdySoft_task2.Controllers
{
    public class Top3Controller : Controller
    {
        private  readonly DataManager dataManager;
        public Top3Controller(DataManager dataManager)
        {
            this.dataManager = dataManager;
            
        }

        private static bool HaveCommonWord(string s1, string s2)
        {
            char[] simbols = { ' '};
            var words = new HashSet<String>(s1.Split(' '), StringComparer.InvariantCultureIgnoreCase);
            return s2.Split().Any(words.Contains);
        }

            private List<ServiceItem> Print()
        {
            var A = dataManager.ServiceItems.GetServiceItems().ToList();
            List<ServiceItem> C = new ();
            if(A.Count>1)
            for (int i=0, top3 = 0; i<A.Count;i++) {
                if (top3 == 3)
                    break;

                    for (int j = i + 1; j < A.Count; j++)
                    {
                       
                            if (HaveCommonWord(A[i].Title, A[j].Title) ||
                                HaveCommonWord(A[i].Text, A[j].Text))
                            {
                                C.Add(A[i]);
                                top3++;
                            break;
                            }
                        
                }
                
                }

            return C;
        }
        
        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.ServiceItems.GetServiceItemById(id));
            }

            ViewBag.TextField = dataManager.ServiceItems.GetServiceItemById(id);
            return View(Print());
        }
    }
}