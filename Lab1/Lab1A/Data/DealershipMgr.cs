using Lab1A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// I, Zachary Sojnocki, 000367577, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.
namespace Lab1A.Data
{
    public static class DealershipMgr
    {
        private static List<Dealership> dealershipList = new List<Dealership>();

        public static void AddDealership(Dealership dealership)
        {
            dealershipList.Add(dealership);
        }

        public static Dealership GetDealership(int ID)
        {
            return dealershipList.Find(x => x.ID == ID);
        }

        public static List<Dealership> GetDealershipList()
        {
            return dealershipList;
        }

        public static void DeleteDealership(int ID)
        {
            if (dealershipList.Find(x => x.ID == ID) != null)
                dealershipList.RemoveAt(dealershipList.FindIndex(x => x.ID == ID));
        }

        public static void UpdateDealership(int ID, Dealership dealership)
        {
            if(dealershipList.Find(x => x.ID == ID) != null)
                dealershipList[dealershipList.FindIndex(x => x.ID == ID)] = dealership;
        }
    }
}
