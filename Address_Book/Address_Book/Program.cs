using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcomne to Address Book Problem Statement");
                Console.WriteLine("-----------XXXXXX-----------");
                Operation Address = new Operation();
                int option;
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("Enter the Program number to get executed \n1.Add Data to Table \n2.Delete from Data Table\n3.Update Data  of Table\n4.View Data \n5.Exit");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            AddressBookModel data = new AddressBookModel();
                            data.firstname = "Aryan";
                            data.lastname = "Raj";
                            data.address = "Ring Road";
                            data.city = "Ranchi";
                            data.state = "Jharkhand";
                            data.zip = 442001;
                            data.phonenumber = 9579940987;
                            data.email = "aryan@gmail.com";
                            data.name = "friendsname";
                            data.type = "friend";
                            var result = Address.AddData(data);
                            if (result != null)
                            {
                                Console.WriteLine("Successfully Added");
                            }
                            else
                            {
                                Console.WriteLine("Not Added");
                            }
                            break;
                    case 2:
                        Console.WriteLine("Enter id to Delete Data");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Address.DeletePersonDetails(num);
                        Console.WriteLine("Data has been Deleted from Database!");
                        break;
                    case 3:
                        Console.WriteLine("Enter id of person whoes data you want to update");
                        int personid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter new name");
                        string newname = Console.ReadLine();
                        bool res = Address.UpdateAddressBookDetail(personid, newname);
                        if (res != null)
                        {
                            Console.WriteLine("Successfully updated");
                        }
                        else
                        {
                            Console.WriteLine("Not updated");
                        }
                        break;
                    case 4:
                        Address.GetAllContact();
                        break;
                    case 5:
                            flag = false;
                            break;
                    }
                }
            }
        }
    }
