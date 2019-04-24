using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestHomework00.Core.Homework02
{
    public class MessyAddressInformation
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class CleanAddressInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddres { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }

    public class MessyListToCleanList
    {
        public List<CleanAddressInformation> CleanAddresses(
            List<MessyAddressInformation> messyAddresses)
        {
            //creates a new CleanList
            List<CleanAddressInformation> cleanlist = new List<CleanAddressInformation>();


            foreach (var item in messyAddresses)
            {
                var clean = new CleanAddressInformation();

                if (item.Name != null)
                {
                    if (item.Name.Contains(' '))
                    {
                        //stoped here 4/22(date)
                        NameInMessyAddressContainsSpace(clean);
                    }
                    else
                    {
                        if (item.Name.Length > 0)
                        {
                            clean.FirstName = item.Name;
                            clean.LastName = "N/A";
                        }
                        else
                        {
                            clean.FirstName = "N/A";
                            clean.LastName = "N/A";
                        }
                        
                    }

                }

                if (item.Address != null)
                {
                    if (item.Address.Contains(','))
                    {
                        var addressToSplit = item.Address.Split(',');
                        clean.StreetAddres = addressToSplit[0];
                        clean.City = addressToSplit[1].Trim();
                        clean.State = addressToSplit[2].Trim();
                        clean.ZipCode = addressToSplit[3].Trim();

                        //if (clean.City.Length < 1 && clean.State.Length < 1 && clean.ZipCode.Length < 1)
                        //{
                        //    clean.StreetAddres = "N/A";
                        //}
                    }
                    else
                    {
                        clean.StreetAddres = "N/A";
                        clean.City = "N/A";
                        clean.State = "N/A";
                        clean.ZipCode = "N/A";
                    }
                }

                cleanlist.Add(clean);
            }

            return cleanlist;
        }

        private void NameInMessyAddressContainsSpace(CleanAddressInformation clean)
        {
            //stoped here
            var splitname = item.Name.Split(' ');
            clean.FirstName = splitname[0];
            clean.LastName = splitname[1];
        }
    }
}
