using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte2021
{
    class XMLOperations
    {        
        public static List<string> GetOptions(string strFile)
        {
            List<string> myOptions = new List<string>();
            StreamReader myStream;
            string linia, strCerca, strID;

            using (myStream = new StreamReader(strFile))
            {
                strCerca = "SolidarityAtHome";  // Element root
                
                linia = myStream.ReadLine();                
                while (linia != null && GetElementName(linia) != strCerca)
                {
                    linia = myStream.ReadLine();
                }

                linia = myStream.ReadLine();

                while (linia != null && GetElementName(linia) != "/" + strCerca)
                {
                    strID = GetElementName(linia);
                    myOptions.Add(strID);

                    while (linia != null && GetElementName(linia) != "/" + strID)
                    {
                        linia = myStream.ReadLine();
                    }
                    linia = myStream.ReadLine();                    
                }
            }
            myOptions.Sort();
            return myOptions;
        }

        public static List<string> GetDades(string strFile, string opcio, string fieldData)
        {
            List<string> myList = new List<string>();
            StreamReader myStream;

            using (myStream = new StreamReader(strFile))
            {
                string linia;
                string strValue, strName;

                linia = myStream.ReadLine();

                //Localizo opcio
                while (linia != null && GetElementName(linia) != opcio)
                {
                    linia = myStream.ReadLine();
                }

                //Fins final de l'opcio
                while (linia != null && GetElementName(linia) != ("/" + opcio))
                {
                    strName = GetElementName(linia);
                    if (strName == fieldData)
                    {
                        strValue = GetElement(linia);
                        myList.Add(strValue);
                    }
                    linia = myStream.ReadLine();
                }
            }
            return myList;
        }

        public static Dictionary<string, FoodDelivered> GetDeliveredFood(string strFile)
        {
            Dictionary<string, FoodDelivered> myFoodsDelivered = new Dictionary<string, FoodDelivered>();
            StreamReader myStream;

            using (myStream = new StreamReader(strFile))
            {
                string linia;
                string strValue, strName;
                FoodDelivered myFoodDelivered;

                linia = myStream.ReadLine();
                while (linia != null && GetElementName(linia) != "FoodsDelivered")
                {
                    linia = myStream.ReadLine();
                }

                //Fins el final
                linia = myStream.ReadLine();
                while (linia != null && GetElementName(linia) != ("/FoodsDelivered"))
                {
                    myFoodDelivered = new FoodDelivered();
                    linia = myStream.ReadLine();

                    while (linia != null && GetElementName(linia) != ("/FoodDelivered"))
                    {
                        strValue = GetElement(linia);
                        strName = GetElementName(linia);

                        switch (strName)
                        {
                            case "DeliveryNote":
                                myFoodDelivered = new FoodDelivered();
                                myFoodDelivered.Foods = new List<string>();

                                myFoodDelivered.DeliveredNote = strValue;
                                myFoodsDelivered.Add(strValue, myFoodDelivered);
                                break;
                            case "DeliveryDate":
                                myFoodDelivered.DeliveredDate = strValue;
                                break;
                            case "HostFullName":
                                myFoodDelivered.HostFullName = strValue;
                                break;
                            case "TotalPrice":
                                myFoodDelivered.TotalPrice = strValue;
                                break;
                            case "Items":
                                while (linia != null && GetElementName(linia) != ("/Items"))
                                {
                                    strValue = GetElement(linia);
                                    strName = GetElementName(linia);
                                    if (strName == "DescFood")
                                    {
                                        myFoodDelivered.Foods.Add(strValue);
                                    }

                                    linia = myStream.ReadLine();
                                }
                                break;
                        }

                        linia = myStream.ReadLine();
                    }
                    linia = myStream.ReadLine();
                }
            }
            return myFoodsDelivered;
        }

        public static Dictionary<string, Host> GetHosts(string strFile)
        {
            Dictionary<string, Host> myHosts = new Dictionary<string, Host>();
            StreamReader myStream;

            using (myStream = new StreamReader(strFile))
            {
                string linia, strValue, strName;
                Host myHost;

                //Localizo Hosts
                ReadUntilCondition(myStream, "Hosts");

                //Fins el final
                linia = myStream.ReadLine();
                myHost = new Host();
                while (linia != null && GetElementName(linia) != ("/Hosts"))
                {                  
                    linia = myStream.ReadLine();

                    while (linia != null && GetElementName(linia) != ("/Host"))
                    {
                        strValue = GetElement(linia);
                        strName = GetElementName(linia);

                        switch (strName)
                        {
                            case "FullName":
                                myHost = new Host();
                                myHost.Refugees = new List<string>();
                                myHost.FullName = strValue;
                                myHosts.Add(strValue, myHost);
                                break;
                            case "RefugeesHosted":
                                while (linia != null && GetElementName(linia) != ("/RefugeesHosted"))
                                {
                                    strValue = GetElement(linia);
                                    strName = GetElementName(linia);
                                    if (strName == "FullName")
                                    {
                                        myHost.Refugees.Add(strValue);
                                    }

                                    linia = myStream.ReadLine();
                                }
                                break;
                        }

                        linia = myStream.ReadLine();
                    }
                    linia = myStream.ReadLine();
                }
            }
            return myHosts;
        }

        private static void ReadUntilCondition(StreamReader myStream, String condition)
        {
            string linia;

            linia = myStream.ReadLine();
            while (linia != null && GetElementName(linia) != condition)
            {
                linia = myStream.ReadLine();
            }
        }

         private static String GetElementName(String linia)
        {
            int pos;

            pos = linia.IndexOf("<");
            linia = linia.Substring(pos + 1);
            pos = linia.IndexOf(">");
            linia = linia.Substring(0, pos);
            pos = linia.IndexOf(" ");

            if (pos >= 0)
            {
                linia = linia.Substring(0, pos).Trim();
            }
            return linia;
        }

        private static String GetElement(String linia)
        {
            if (linia.Length > 0)
            {
                int pos = linia.IndexOf(">");
                linia = linia.Substring(pos + 1);
                pos = linia.IndexOf("<");
                if (pos > -1)
                {
                    linia = linia.Substring(0, pos).Trim();
                }
            }
            return linia;
        }

        public static List<FoodDelivered> SearchFood(string textFood, Dictionary<string, FoodDelivered> myFoodsDelivered)
        {
            List<FoodDelivered> llista = new List<FoodDelivered>();

            foreach (KeyValuePair<string, FoodDelivered> tmp in myFoodsDelivered)
            {
                if (tmp.Value.Foods.IndexOf(textFood) != -1)
                {
                    llista.Add(tmp.Value);
                }
            }
            return llista;
        }

        public static List<FoodDelivered> SearchRefugee(string textRefugee, Dictionary<string, FoodDelivered> myFoodsDelivered, Dictionary<string, Host> myHosts)
        {
            List<FoodDelivered> llista = new List<FoodDelivered>();

            foreach (KeyValuePair<string, FoodDelivered> tmp in myFoodsDelivered)
            {
                if (myHosts[tmp.Value.HostFullName].Refugees.IndexOf(textRefugee) != -1)
                {
                    llista.Add(tmp.Value);
                }
            }
            return llista;
        }

        public static List<FoodDelivered> SearchHost(string textHost, Dictionary<string, FoodDelivered> myFoodsDelivered)
        {
            List<FoodDelivered> llista = new List<FoodDelivered>();

            foreach (KeyValuePair<string, FoodDelivered> tmp in myFoodsDelivered)
            {
                if (tmp.Value.HostFullName == textHost)
                {
                    llista.Add(tmp.Value);
                }
            }
            return llista;
        }

        public static List<FoodDelivered> SearchFoodDelivered(string textFoodDelivered, Dictionary<string, FoodDelivered> myFoodsDelivered)
        {
            List<FoodDelivered> llista = new List<FoodDelivered>();

            llista.Add(myFoodsDelivered[textFoodDelivered]);
            return llista;
        }
        public static void SaveFile(List<FoodDelivered> myFoodsDelivered, bool tipus)
        {
            StreamWriter myStream;
            string strFile = "dades.xml";

            using (myStream = new StreamWriter(strFile, tipus))
            {
                foreach (FoodDelivered tmp in myFoodsDelivered)
                {
                    myStream.WriteLine("-----------------------------------------------------");
                    myStream.WriteLine("DELIVERY NOTE: {0}", tmp.DeliveredNote);
                    myStream.WriteLine("DELIVERY DATE: {0}", tmp.DeliveredDate);
                    myStream.WriteLine("TOTAL COST: {0}", tmp.TotalPrice);
                }
                myStream.WriteLine("-----------------------------------------------------");
            }
        }
    }
}

