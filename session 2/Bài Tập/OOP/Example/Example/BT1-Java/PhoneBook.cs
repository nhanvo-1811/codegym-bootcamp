using System;
using System.Collections;
using System.Text;
using Example.BT1_Java.Models;

namespace Example.BT1_Java
{
    public class PhoneBook : Phone
    {
        private string name;
        private string phone;
        public ArrayList PhoneList = new ArrayList();

        public string Phone { get => phone; set => phone = value; }
        public string Name { get => name; set => name = value; }

        public override void insertPhone(string name, string phone)
        {
            if (PhoneList != null && UserIsExited(name))
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.name == name)
                    {
                        if (phoneItem.phoneNumber != phone)
                        {
                            phoneItem.phoneNumber += ":" + phone;
                        }
                    }

                }
            }
            else
            {
                var phoneItem = new PhoneItem();
                phoneItem.name = name;
                phoneItem.phoneNumber = phone;
                PhoneList.Add(phoneItem);
            }

        }

        public override void removePhone(string name)
        {
            if (PhoneList != null)
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.name == name)
                    {
                        PhoneList.Remove(phoneItem);
                        break;
                    }

                }
            }
        }
        public override void updatePhone(string name, string newphone)
        {
            if (PhoneList != null)
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.name == name)
                    {
                        phoneItem.phoneNumber = newphone;
                    }

                }
            }

        }
        public override void searchPhone(string name)
        {
            if (PhoneList != null)
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.name == name)
                    {
                        Console.WriteLine("Phonenumber's {0} is {1}", name, phoneItem.phoneNumber);
                        break;
                    }

                }
            }
        }

        public override void sort()
        {
            PhoneList.Sort(new sortPhone());
        }
        public class sortPhone : IComparer
        {
            int IComparer.Compare(Object a, Object b)
            {
                PhoneItem a1 = (PhoneItem)a;
                PhoneItem b1 = (PhoneItem)b;
                return ((new CaseInsensitiveComparer()).Compare(a1.name, b1.name));
            }
        }

        private bool UserIsExited(string userName)
        {
            if (PhoneList != null)
            {
                foreach (PhoneItem item in PhoneList)
                {
                    if (item.name == userName)
                        return true;
                }
            }
            return false;
        }


    }
}
