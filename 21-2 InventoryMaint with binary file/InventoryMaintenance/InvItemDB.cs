using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InventoryMaintenance
{
    public static class InvItemDB
    {
        private const string dir = @"..\..\";
        private const string path = dir + "InventoryItems.dat";

        public static List<InvItem> GetItems()
        {
            // Add code here to read the binary file into the List<InvItem> object.

            //creates file if file doesn't already exist
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            BinaryReader binaryIn = new BinaryReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            // create the list
            List<InvItem> items = new List<InvItem>();
            while (binaryIn.PeekChar() != -1)
            {
                InvItem item = new InvItem();

                //converts accoridngly
                item.ItemNo = binaryIn.ReadInt32();
                item.Description = binaryIn.ReadString();
                item.Price = binaryIn.ReadDecimal();
                items.Add(item);
            }
            binaryIn.Close();

            return items;
        }

        public static void SaveItems(List<InvItem> items)
        {
            // Add code here to write the List<InvItems> object to a text file.
            BinaryWriter binaryOut = new BinaryWriter(new FileStream(path, FileMode.Create, FileAccess.Write));


            //separates and writes out binary into .dat file
            foreach (InvItem item in items)
            {
                binaryOut.Write(item.ItemNo);
                binaryOut.Write(item.Description);
                binaryOut.Write(item.Price);
            }

            binaryOut.Close();
        }
    }
}
