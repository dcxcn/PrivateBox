using System;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;

namespace PrivateBox.Model
{
    public class FileDBHelper
    {
        private dBHelper helperPBox = null;
        private dBHelper helperPData = null;
        private  int mb_1 = 1048576;
        private bool isSucces = true;       

        //2MB   - 2097152
        //5MB   - 5242880
        //10MB  - 10485760

        /*  Conversion
         *  1 Byte = 8 Bit
         *  1 Kilobyte = 1024 Bytes
         *  1 Megabyte = 1048576 Bytes
         *  1 Gigabyte = 1073741824 Bytes
         * */

        public Boolean GetSucces()
        {
            return isSucces;
        }



  

        public void deleteFile(Int32 fileID)
        {
            //Set variables
            isSucces = false;

            // Determin the ConnectionString
            string connectionString = DBSource.ConnectionStringPBox;

            // Determin the DataAdapter = CommandText + Connection
            string commandText = "SELECT * FROM FileMemo WHERE file_id=" + fileID;

            // Make a new object
            helperPData = new dBHelper(connectionString);
            {
                // Load Data
                if (helperPData.Load(commandText, "file_id") == true)
                {
                    // Determin if the row was found
                    if (helperPData.DataSet.Tables[0].Rows.Count == 1)
                    {
                        // Found, delete row
                        helperPData.DataSet.Tables[0].Rows[0].Delete();
                        try
                        {
                            // Save -> determin succes
                            if (helperPData.Save() == true)
                            {
                                isSucces = true;
                                helperPData.Dbgc();
                                Boolean delDataRs = deleteFileData(fileID);
                                if (!delDataRs) {
                                    MessageBox.Show("删除文件数据失败！");
                                }
                            }
                            else
                            {
                                isSucces = false;
                                MessageBox.Show("删除文件失败！");
                            }
                        }
                        catch (Exception ex)
                        {
                            // Show the Exception --> Dubbel ContactId/Name ?
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
            }

        }


        public Boolean deleteFileData(Int32 fileID)
        {
            //Set variables
            Boolean rtnSucces = false;

            // Determin the ConnectionString
            string connectionString = DBSource.ConnectionStringPData;

            // Determin the DataAdapter = CommandText + Connection
            string commandText = "SELECT * FROM FileStore WHERE file_id=" + fileID;

            // Make a new object
            helperPData = new dBHelper(connectionString);
            {
                // Load Data
                if (helperPData.Load(commandText, "file_id") == true)
                {
                    for (int i = helperPData.DataSet.Tables[0].Rows.Count-1; i >= 0; i--) {
                        // Found, delete row
                        helperPData.DataSet.Tables[0].Rows[i].Delete();                        
                    }
                    try
                    {
                        // Save -> determin succes
                        if (helperPData.Save() == true)
                        {
                            rtnSucces = true;
                            helperPData.Dbgc();
                        }
                        else
                        {
                            rtnSucces = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Show the Exception --> Dubbel ContactId/Name ?
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            return rtnSucces;

        }
 

        public void insertFileNode(String nodeName, int parentId) {
            string connectionString = DBSource.ConnectionStringPBox;
            DataRow dataRow = null;
            string commandText = "SELECT * FROM FileNode WHERE 1=0";
            helperPBox = new dBHelper(connectionString);
            {
                // Load Data
                if (helperPBox.Load(commandText, "node_id") == true)
                {
                    // Add a row and determin the row
                    helperPBox.DataSet.Tables[0].Rows.Add(helperPBox.DataSet.Tables[0].NewRow());
                    dataRow = helperPBox.DataSet.Tables[0].Rows[0];

                    // Enter the given values
                    dataRow["node_name"] = nodeName;
                    dataRow["parent_id"] = parentId;
                    try
                    {
                        // Save -> determin succes
                        if (helperPBox.Save() == true)
                        {
                            dataRow["disporder"] = dataRow["node_id"];
                            if (helperPBox.Save() == true)
                            {
                                isSucces = true;
                            }
                            else
                            {
                                isSucces = false;
                            }

                        }
                        else
                        {
                            isSucces = false;
                            MessageBox.Show("Error during Insertion");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Show the Exception --> Dubbel Id/Name ?
                        MessageBox.Show(ex.Message);
                    }


                }//END IF
            }
        }


        public void saveFileNode(String nodeName, int nodeID)
        {
            string connectionString = DBSource.ConnectionStringPBox;
            DataRow dataRow = null;
            string commandText = "SELECT * FROM FileNode WHERE node_id="+ nodeID;
            helperPBox = new dBHelper(connectionString);
            {
                if (helperPBox.Load(commandText, "node_id") == true)
                {
                    dataRow = helperPBox.DataSet.Tables[0].Rows[0];
                   
                    dataRow["node_name"] = nodeName;                   
                    try
                    {                     
                        if (helperPBox.Save() == true)
                        {
                            isSucces = true;

                        }
                        else
                        {
                            isSucces = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }//END IF
            }
        }
        public void saveFileNode(String nodeName, int nodeID,int parentID)
        {
            string connectionString = DBSource.ConnectionStringPBox;
            DataRow dataRow = null;
            string commandText = "SELECT * FROM FileNode WHERE node_id=" + nodeID;
            helperPBox = new dBHelper(connectionString);
            {
                if (helperPBox.Load(commandText, "node_id") == true)
                {
                    helperPBox.DataSet.Tables[0].Rows.Add(helperPBox.DataSet.Tables[0].NewRow());
                    dataRow = helperPBox.DataSet.Tables[0].Rows[0];
                    dataRow["node_name"] = nodeName;
                    dataRow["parent_id"] = parentID;
                    try
                    {
                        if (helperPBox.Save() == true)
                        {
                            isSucces = true;

                        }
                        else
                        {
                            isSucces = false;
                          
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }//END IF
            }
        }
        public void changeDisporder(Int32 nodeAID, Int32 nodeBID)
        {
            isSucces = true;
            string connectionString = DBSource.ConnectionStringPBox;
            int nodeAID_Disporder = 0;
            int nodeBID_Disporder = 0;
            string commandTextA = "SELECT * FROM FileNode WHERE node_id=" + nodeAID;
            string commandTextB = "SELECT * FROM FileNode WHERE node_id=" + nodeBID;
            helperPBox = new dBHelper(connectionString);
            if (helperPBox.Load(commandTextA, "node_id") == true)
            {
                foreach (DataRow dr in helperPBox.DataSet.Tables[0].Rows)
                {
                    nodeAID_Disporder = int.Parse(dr["disporder"].ToString());                   
                }
            }
            if (helperPBox.Load(commandTextB, "node_id") == true)
            {
                foreach (DataRow dr in helperPBox.DataSet.Tables[0].Rows)
                {
                    nodeBID_Disporder = int.Parse(dr["disporder"].ToString());
                }
            }
            string commandTextC1 = "update FileNode set disporder = "+ nodeBID_Disporder + " WHERE node_id=" + nodeAID;
            string commandTextC2 = "update FileNode set disporder = " + nodeAID_Disporder + " WHERE node_id=" + nodeBID;
            isSucces = isSucces && helperPBox.ExecuteNonQuery(commandTextC1);
            isSucces = isSucces && helperPBox.ExecuteNonQuery(commandTextC2);
        }
        public void deleteFileNode(Int32 nodeID)
        {
            isSucces = true;
            string connectionString = DBSource.ConnectionStringPBox;
            helperPBox = new dBHelper(connectionString);
            //1、先删除节点下的所有文件数据
            string commandText = "SELECT * FROM FileMemo WHERE file_nodeid=" + nodeID;
            if (helperPBox.Load(commandText, "file_nodeid") == true)
            {
                foreach (DataRow dr in helperPBox.DataSet.Tables[0].Rows)
                {
                    int curFileID = int.Parse(dr["file_id"].ToString());
                    isSucces = isSucces && deleteFileData(curFileID);
                }
            }
            //2、删除节点下的所有文件描述信息
            commandText = "delete FROM FileMemo WHERE file_nodeid=" + nodeID;            
            isSucces = isSucces && helperPBox.ExecuteNonQuery(commandText);
            //3、再删除节点下所有子节点
            commandText = "SELECT * FROM FileNode WHERE parent_id=" + nodeID;
            if (helperPBox.Load(commandText, "node_id") == true)
            {
                foreach (DataRow dr in helperPBox.DataSet.Tables[0].Rows)
                {
                    int curNodeID = int.Parse(dr["node_id"].ToString());
                    deleteFileNode(curNodeID);
                }
            }
            //4、删除自己
            commandText = "SELECT * FROM FileNode WHERE node_id=" + nodeID;
            if (helperPBox.Load(commandText, "node_id") == true)
            {
                if (helperPBox.DataSet.Tables[0].Rows.Count == 1)
                {
                    helperPBox.DataSet.Tables[0].Rows[0].Delete();
                    try
                    {
                        if (helperPBox.Save() == true)
                        {
                            isSucces = isSucces && true;                           
                        }
                        else
                        {
                            isSucces = isSucces && false;
                            MessageBox.Show("Delete failed");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public Int32[] InsertFiles(FileInfo[] fileInfos,int nodeID)
        {
            DataRow dataRow = null;
            isSucces = true;           
            
            if (fileInfos == null|| fileInfos.Length==0) return null;
            int[] fileids = new int[fileInfos.Length];
            int i = 0;
            foreach (FileInfo fileInfo in fileInfos) {
                //if no file was selected and no image was created return 0
                if (fileInfo == null) fileids[i]=-1;

                if (fileInfo != null)
                {
                    string connectionStringPBox = DBSource.ConnectionStringPBox;
                    string commandText = "SELECT * FROM FileMemo WHERE 1=0";

                    helperPBox = new dBHelper(connectionStringPBox);
                    {
                        if (helperPBox.Load(commandText, "file_id") == true)
                        {

                            helperPBox.DataSet.Tables[0].Rows.Add(helperPBox.DataSet.Tables[0].NewRow());
                            dataRow = helperPBox.DataSet.Tables[0].Rows[0];

                            dataRow["file_name"] = fileInfo.Name.Replace(fileInfo.Extension,"");
                            dataRow["file_size"] = fileInfo.Length;
                            dataRow["file_type"] = fileInfo.Extension.ToLower();
                            dataRow["file_nodeid"] = nodeID;

                            try
                            {
                                if (helperPBox.Save() == true)
                                {
                                    dataRow["disporder"] = dataRow["file_id"];
                                    isSucces = isSucces && saveFileData(int.Parse(""+dataRow["file_id"]), File.ReadAllBytes(fileInfo.FullName));
                                    if (helperPBox.Save() == true)
                                    {
                                        isSucces = isSucces && true;
                                    }
                                    else
                                    {
                                        isSucces = isSucces && false;
                                    }
                                }
                                else
                                {
                                    isSucces = isSucces && false;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
                fileids[i] = Convert.ToInt32(dataRow[0].ToString());
                i++;
            }
            return fileids;
        }
        public byte[] getPartFileData(byte[] fileData, int filePartID) {

            int startIndex = (filePartID - 1) * mb_1;
            int endIndex = (filePartID * mb_1 <= fileData.Length) ? filePartID * mb_1 : fileData.Length;
            int size = endIndex - startIndex;
            byte[] tempByte = new byte[size];
            for (int i = startIndex,j=0; i < endIndex; i++,j++) {
                tempByte[j] = fileData[i];
            }
            return tempByte;
        }

        public Boolean saveFileData(int fileID, byte[] fileData)
        {
            //先删除fileID的数据
            deleteFileData(fileID);
            //然后保存fileData
            Boolean saveRs = false;
            string connectionString = DBSource.ConnectionStringPData;
            DataRow dataRow = null;
            string commandText = "SELECT * FROM FileStore WHERE file_id=" + fileID;
            helperPData = new dBHelper(connectionString);
            {
                if (helperPData.Load(commandText, "file_id") == true)
                {
                    if (fileData.Length > mb_1)
                    {
                        int partCount = (fileData.Length + mb_1 - 1) / mb_1;
                        for (int i = 1; i <= partCount; i++)
                        {
                            helperPData.DataSet.Tables[0].Rows.Add(helperPData.DataSet.Tables[0].NewRow());
                            dataRow = helperPData.DataSet.Tables[0].Rows[i-1];
                            dataRow["file_id"] = fileID;
                            dataRow["file_part_data"] = getPartFileData(fileData,i);
                            dataRow["file_part_id"] = i;
                            try
                            {
                                if (helperPData.Save() == true)
                                {
                                    saveRs = true;

                                }
                                else
                                {
                                    saveRs = false;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    else {
                        helperPData.DataSet.Tables[0].Rows.Add(helperPData.DataSet.Tables[0].NewRow());
                        dataRow = helperPData.DataSet.Tables[0].Rows[0];
                        dataRow["file_id"] = fileID;
                        dataRow["file_part_data"] = fileData;
                        dataRow["file_part_id"] = 1;
                        try
                        {
                            if (helperPData.Save() == true)
                            {
                                saveRs = true;

                            }
                            else
                            {
                                saveRs = false;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
  


                }//END IF
            }
            return saveRs;
        }

        public List<Byte[]> getFileData(int fileID)
        {
            List<Byte[]> l_btye = new List<Byte[]>();
            try
            {
                string connectionString = DBSource.ConnectionStringPData;
                DataRow dataRow = null;
                string commandText = "SELECT * FROM FileStore WHERE file_id=" + fileID+" order by file_part_id asc";
                helperPData = new dBHelper(connectionString);
                {
                    if (helperPData.Load(commandText, "file_id") == true)
                    {
                        for (int i = 0; i < helperPData.DataSet.Tables[0].Rows.Count; i++) {
                            dataRow = helperPData.DataSet.Tables[0].Rows[i];
                            l_btye.Add((byte[])dataRow["file_part_data"]);
                        }

                    }//END IF
                }
            }
            catch (Exception exp) { }
            return l_btye;
        }

        public Boolean hasPData()
        {
           Boolean hasIt = false;
            try
            {
                string connectionString = DBSource.ConnectionStringPData;
                DataRow dataRow = null;
                string commandText = "SELECT * FROM FileStore where file_id=1";
                helperPData = new dBHelper(connectionString);
                {
                    if (helperPData.Load(commandText, "file_id") == true)
                    {

                        hasIt = true;

                    }//END IF
                }
            }
            catch (Exception exp) {
                hasIt = false;
            }
            return hasIt;
        }
        public void saveFile(int fileID, String fileName)
        {
            string connectionString = DBSource.ConnectionStringPBox;
            DataRow dataRow = null;
            string commandText = "SELECT * FROM FileMemo WHERE file_id=" + fileID;
            helperPBox = new dBHelper(connectionString);
            {
                if (helperPBox.Load(commandText, "file_id") == true)
                {
                    dataRow = helperPBox.DataSet.Tables[0].Rows[0];

                    dataRow["file_name"] = fileName;
                    try
                    {
                        if (helperPBox.Save() == true)
                        {
                            isSucces = true;

                        }
                        else
                        {
                            isSucces = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }//END IF
            }
        }


        public void saveUserAndPwd(String UserName, String Password)
        {
            string connectionString = DBSource.ConnectionStringPBox;
            DataRow dataRow = null;
            string commandText = "SELECT * FROM FileAdmin WHERE 1=0";
            helperPBox = new dBHelper(connectionString);
            {
                // Load Data
                if (helperPBox.Load(commandText, "admin_id") == true)
                {
                    // Add a row and determin the row
                    helperPBox.DataSet.Tables[0].Rows.Add(helperPBox.DataSet.Tables[0].NewRow());
                    dataRow = helperPBox.DataSet.Tables[0].Rows[0];

                    // Enter the given values
                    dataRow["admin_name"] = UserName;
                    dataRow["admin_pwd"] = Password;
                    try
                    {
                        // Save -> determin succes
                        if (helperPBox.Save() == true)
                        {
                            isSucces = true;
                        }
                        else
                        {
                            isSucces = false;
                            MessageBox.Show("Error during Insertion");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Show the Exception --> Dubbel Id/Name ?
                        MessageBox.Show(ex.Message);
                    }


                }//END IF
            }
        }
    }
}
