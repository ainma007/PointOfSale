using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointSystem
{
   public  class Helper
    {

        //=================================================
        // ******* Smart Methods For Super Market's System 
        // ******** Abu Ehab  Aprel 2015
        //=================================================
        #region "        Grid     "
        /// <summary>
        /// Use this method to 
        /// </summary>
        /// <param name="Dgv">DataGridView Name</param>
        ///
        public static void GridStyle(DataGridView Dgv)
        {
            if (Dgv.ColumnCount != 0)
            {
                Dgv.Cursor = Cursors.Hand;
                Dgv.RowHeadersWidth = 50;
                Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                foreach (DataGridViewRow R in Dgv.Rows)
                {
                    R.HeaderCell.Value = (R.Index + 1).ToString();
                }
            }

        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="Dgv">DataGridView Name</param>
        public static void GridFullStyle(DataGridView Dgv)
        {
            if (Dgv.ColumnCount != 0)
            {

                Dgv.Cursor = Cursors.Hand;
                Dgv.ReadOnly = true;
                Dgv.AllowUserToAddRows = false;
                Dgv.GridColor = Color.Red;
                Dgv.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
                Dgv.BackgroundColor = Color.Goldenrod;
                Dgv.DefaultCellStyle.SelectionBackColor = Color.Green;
                Dgv.DefaultCellStyle.SelectionForeColor = Color.Yellow;
                Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Dgv.AllowUserToResizeColumns = false;
                Dgv.RowsDefaultCellStyle.BackColor = Color.Bisque;
                Dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
                Dgv.RowHeadersWidth = 70;
                Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                foreach (DataGridViewRow R in Dgv.Rows)
                {
                    R.HeaderCell.Style.ForeColor = Color.Yellow;
                    R.HeaderCell.Style.BackColor = Color.Goldenrod;

                    R.HeaderCell.Value = (R.Index + 1).ToString();
                }
            }
        }



        /// <summary>
        /// Find Cell and Color it At DataGridView 
        /// </summary>
        /// <param name="Dgv">DataGridView Name </param>
        /// <param name="TargetCellValue">Insert The value That are looking for at Cell As String value </param>
        public static void GridSearchCell(DataGridView Dgv, string TargetCellValue)
        {
            if (Dgv.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in Dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.FormattedValue.ToString() == TargetCellValue)
                        {
                            cell.Style.ForeColor = Color.Gold;
                            cell.Style.BackColor = Color.Black;
                        }
                    }
                }
            }
        }

        /// <summary>
        ///  This method to Calculate Total Sum  Target Cells values at Targrt Column
        /// </summary>
        /// <param name="dggv">Target DataGridView </param>
        /// <param name="ColmnsIndx"> Columns Index</param>
        public static double TotalSumGridCellsValue(DataGridView Dgv, int CellIndx)
        {

            double tot = 0;
            if (Dgv.Rows.Count != 0)
            {
                tot = (from DataGridViewRow row in Dgv.Rows
                       where row.Cells[CellIndx].FormattedValue.ToString() != ""
                       select Convert.ToDouble(row.Cells[CellIndx].FormattedValue.ToString())).Sum();

            }
            return tot;
        }

        /// <summary>
        /// This method must be at DataGridView_CellValidating Event  
        /// Process : When you need to insert Numaric values at Columns
        /// </summary>
        /// <param name="dggv">DataGridView Name</param>
        /// <param name="e"> Insert e handle </param>
        /// <param name="ColmnsIndx"> Insert Columns index</param>
        public static void GridNomaricCell(DataGridView dgv, DataGridViewCellValidatingEventArgs e, params int[] ColmnsIndx)
        {
            foreach (var item in ColmnsIndx)
            {
                if (e.ColumnIndex == item)
                {
                    double i;

                    if (!double.TryParse(Convert.ToString(e.FormattedValue), out i) && e.FormattedValue != "")
                    {
                        e.Cancel = true;
                        _Alert.Error("أدخـــــل ارقـــــام فـــقط");
                    }
                }


            }
        }
        #endregion

        #region " ^^^ DataGridViewCell  AutoComplate "

        private static void FillData(AutoCompleteStringCollection col, string[] da)
        {
            foreach (string i in da)
            {
                col.Add(i);
            }
        }
        /// <summary>
        /// This Method Make DataGridView Cell AutoComplate 
        /// Note : This Method Must Be At DataGridView_EditingControlShowing Event
        /// </summary>
        /// <param name="dgv">DataGridView Name : </param>
        /// <param name="ColNameOrHeaderText">Insert Column Name Or Column HeaderText </param>
        /// <param name="YourData"> Insert DataSource Of Target Column  And Must Be ToArray() </param>
        /// <param name="e"> Insert The Handle Look Like e </param>
        public static void GridCellAutoComplate(DataGridView dgv, string ColNameOrHeaderText, string[] YourData, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewColumn clm = new DataGridViewColumn();
            clm.Name = ColNameOrHeaderText;
            clm.HeaderText = ColNameOrHeaderText;
            TextBox autoText = e.Control as TextBox;
            if (autoText != null)
            {
                autoText.AutoCompleteMode = AutoCompleteMode.Suggest;
                autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
                FillData(DataCollection, YourData);
                autoText.AutoCompleteCustomSource = DataCollection;
            }

        }
        #endregion

        #region "    ^^^^ TextBox Events    "
        /// <summary>
        ///  Use It at TextBox_KeyPress Event
        ///  Process : TextBox Accept numaric values only
        /// </summary>
        /// <param name="TargetTextBox">TextBox Name </param>
        /// <param name="e">Insert e Only</param>
        public static void TextKeyPress(TextBox TargetTextBox, object sender, KeyPressEventArgs e)
        {


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
        /// <summary>
        /// By Using This Mehtod : the current textbox accept numaric value without Dot {.}
        /// Insert this method at TextBox_KeyPress Event
        /// </summary>
        /// <param name="TargetTextBox"></param>
        /// <param name="e"></param>
        public static void TextKeyPressWithoutDot(TextBox TargetTextBox, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '£')
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }

        }


        //
        /// <summary>
        /// insert This method at TextBox_KeyDown Event
        /// Process : Use this method to search at textbox 
        /// </summary>
        /// <param name="TextBoxName">TextBox Name </param>
        /// <param name="e">Insert e Only</param>
        public static void TextKeyDown(TextBox TextBoxName, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (!TextBoxName.AutoCompleteCustomSource.Contains(TextBoxName.Text))
                {

                    TextBoxName.AutoCompleteCustomSource.Add(TextBoxName.Text);
                }

            }
            else if (e.KeyCode == Keys.Delete)
            {
                ((AutoCompleteStringCollection)TextBoxName.AutoCompleteCustomSource).Remove(TextBoxName.Text);
                TextBoxName.Clear();
            }
        }

        /// <summary>
        /// Use this method to search at textbox 
        /// </summary>
        /// <param name="TextBoxName">TextBox name </param>
        /// <param name="Datasource"> DataSource </param>
        public static void TextBoxAutoComplate(TextBox TextBoxName, string[] Datasource)
        {
            TextBoxName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TextBoxName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection TheSource = new AutoCompleteStringCollection();
            TextBoxName.AutoCompleteCustomSource = TheSource;
            TheSource.AddRange(Datasource);

        }
        #endregion

        #region "       Locked Folder       "
        /// <summary>
        /// This Mehtod : For Looked Selected Folder
        /// You can Choose As Boolean value to Looked Or Not  { True , False}
        /// </summary>
        /// <param name="FolderFullPatth">Insert Full Folder Path</param>
        /// <param name="LockedStatus">Insert True Or False</param>
        public static void LockedFolder(string FolderFullPatth, bool LockedStatus)
        {
            DirectoryInfo dInfo = new DirectoryInfo(FolderFullPatth);

            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            FileSystemAccessRule fSysARule = new FileSystemAccessRule(Environment.UserName,
                FileSystemRights.FullControl, AccessControlType.Deny);


            if (LockedStatus == true)
            {
                dSecurity.AddAccessRule(fSysARule);
            }
            else if (LockedStatus == false)
            {
                dSecurity.RemoveAccessRule(fSysARule);
            }

            dInfo.SetAccessControl(dSecurity);
        }

        #endregion

        #region  "   Discount "
        /// <summary>
        /// Use This Mehtod To Calculate Discount Value
        /// </summary>
        /// <param name="TotalCost"> Insert The Total Number that you need to get discount value from it </param>
        /// <param name="DiscountValue"> Insert The Discount value </param>
        /// <returns> Return Double Value</returns>
        public static double ComputeDiscount(double TotalCost, double DiscountValue)
        {
            var NetTotalCostPrice = TotalCost - (TotalCost * (DiscountValue / 100));

            return Math.Round(NetTotalCostPrice, 1);
        }

        #endregion

        #region " Edit Price      "
        public static double EditPrice(int OldQty, double OldPrice, int NewQty, double NewPrice)
        {
            double NetPrice;
            double FirstPrice = OldPrice * OldQty;
            double LastPrice = NewPrice * NewQty;

            int totalQty = OldQty + NewQty;
            double totalprice = FirstPrice + LastPrice;

            NetPrice = totalprice / totalQty;
            return Math.Round(NetPrice, 1);

        }

        #endregion

        #region "  Culture   "
        public static void SetKeyboardLanguage(string CultureName)
        {
            System.Globalization.CultureInfo MyLang = new System.Globalization.CultureInfo(CultureName);
            InputLanguage InLang = InputLanguage.FromCulture(MyLang);
            InputLanguage.CurrentInputLanguage = InLang;
        }

        #endregion

        #region "     Samular Item      "
        public static bool SamularItem(DataGridView Dgv, string searchValue)
        {

            int rowIndex = 1;

            Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (Dgv.Rows.Count != 0)
            {
                bool valueResulet = true;
                foreach (DataGridViewRow row in Dgv.Rows)
                {
                    if (row.Cells[rowIndex].Value.ToString().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        Dgv.Rows[rowIndex].Selected = true;
                        rowIndex++;
                        valueResulet = false;
                    }
                }
                if (valueResulet != true)
                {
                    _Alert.Attention("تنبيه", " موجود مسبقا " + searchValue);
                    return true;
                }
            }
            return false;
        }


        #endregion

        #region "       Edit Assets Price_Yearly        "

        static DataManager DbManager = new DataManager();
        public static void EditAssetsPrice_Yearly()
        {
            DbManager = new DataManager();
            var LstAssets = (from c in DbManager.ShopData.Assets
                             where c.Status == "Active"
                             select c).ToList();

            foreach (var ast in LstAssets)
            {
                DateTime TheTimeNow = DateTime.Parse(DateTime.Now.ToString()).Date;

                DateTime AssetDate = DateTime.Parse(ast.TheDate.ToString()).Date;

                TimeSpan xDays = TheTimeNow - AssetDate;

                if (xDays.TotalDays == 365 || xDays.TotalDays > 365 && ast.Price >= ast.DepreciateValue)
                {
                    // Start Edit Cose and date : 
                    #region  "  Assets Table      "

                    DbManager = new DataManager();
                    Db.AssetsRow Asst = DbManager.ShopData.Assets.NewAssetsRow();
                    Asst = DbManager.ShopData.Assets.Where(i => i.ID == ast.ID).Single();

                    Asst.Price -= Asst.DepreciateValue;
                    Asst.TheDate = DateTime.Now;

                    DbManager.SaveChanges();

                    #endregion

                    #region  "    $$$ The Pen $$$      "

                    ThePen.Writer("الاصول", 0, ast.AccountID, Asst.DepreciateValue, "خصم نسبة الاهلاك من  /  " + ast.AssetName);

                    #endregion


                }

            }





        }

        #endregion

        ~Helper() { }
        public void Dispose()
        {
            GC.SuppressFinalize(this);

        }
    }
}
