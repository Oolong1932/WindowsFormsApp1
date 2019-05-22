using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HslCommunication.LogNet;
using System.IO;
using System.Data;
using System.Windows.Forms;




class _other
{


    #region  Log4Net
    public static ILogNet logNet = new LogNetDateTime(Application.StartupPath+"\\Log",GenerateMode.ByEveryDay); //每天產一筆Log
    #endregion

    #region ini處理
    //預設值建立

    //編輯ini節點名稱


    //新增ini節點資料

    //讀取ini節點名稱

    //讀取ini節點內容

    //讀取一個key值

    //刪除ini節點全部

    //刪除ini單一值




    #endregion






}

