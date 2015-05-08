using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointSystem
{
   public  class DataManager
    {


        private string Dir;
        private string DataFileName;
        private string FullPath;

        public Db ShopData { get; set; }

        private bool WriteChanges()
        {
            try
            {
                ShopData.GetChanges().WriteXml(FullPath);
                return true;
            }
            catch (Exception ex)
            {
                ShopData.GetChanges().WriteXml(FullPath);
                return true;
                //  throw ex;
            }

        }
        private bool initlizationData(string Path)
        {
            try
            {
                ShopData.ReadXml(Path);
                Application.DoEvents();
                return true;
            }
            catch (Exception)
            {
                ShopData.WriteXmlSchema(Path);
                Application.DoEvents();
                ShopData.ReadXml(Path);
                return true;
            }
        }
        private bool ReadData(string path)
        {
            try
            {
                ShopData.ReadXml(path);
                Application.DoEvents();
                return true;
            }
            catch (Exception ex)
            {
                ShopData.WriteXmlSchema(FullPath);
                return true;
                // throw new Exception("Error in Reading Data File ");
            }
        }
        private bool WriteData(string Path)
        {
            try
            {
                ShopData.WriteXml(Path);
                Application.DoEvents();
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Error in Write Data Please Review File");
            }
        }
        private bool BackUpData(string from, string To)
        {
            try
            {
                if (ReadData(from))
                {
                    Application.DoEvents();
                    WriteData(To);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {

                throw new Exception("Error in Back Up Data");
            }
        }
        private bool RestoreData(string from, string To)
        {
            try
            {
                if (ReadData(from))
                {
                    Application.DoEvents();
                    WriteData(To);
                    return true;

                }


                return false;

            }
            catch (Exception ex)
            {

                throw new Exception("Error in Restoring Data");
            }
        }

        public void BackUp(string ToPath)
        {
            BackUpData(FullPath, ToPath);
        }
        public void Restore(string fromPath)
        {
            BackUpData(fromPath, FullPath);
        }
        public bool SaveChanges()
        {
            return WriteChanges();
        }

        public DataManager()
        {
            Dir = Application.StartupPath + "\\SuperMarketData";
            if (!Directory.Exists(Dir))
            {
                Directory.CreateDirectory(Dir);
            }
            ShopData = new Db();
            //-- End Createing Directory
            DataFileName = "MarketData.AbuEhab";
            FullPath = Dir + "\\" + DataFileName;

            ReadData(FullPath);
            //---- Read Data
        }

        //===============================================================
        ~DataManager() { }
        public void Dispose()
        {
            GC.SuppressFinalize(this);

        }



    }
}
