﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Net.NetworkInformation;
using System.Linq;
using RationCard.Model;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RationCard.Helper
{
    public static class ConnectionManager
    {
        public static string _workOnline = ConfigurationManager.AppSettings["WorkOnline"].ToString();
        public static string _connStr = (_workOnline == "1") ? SecurityEncrypt.Decrypt(ConfigurationManager.ConnectionStrings["Cloud"].ConnectionString, "nakshal")
                            : SecurityEncrypt.Decrypt(ConfigurationManager.ConnectionStrings["Local"].ConnectionString, "nakshal");
        public static DataSet Exec(string procName, List<SqlParameter> sqlParams, out ErrorEnum errType, out string errMsg, out bool isSuccess)
        {
            isSuccess = false;
            errMsg = "Error occured during procedure " + procName + Environment.NewLine + "Inputs of proc: " + Environment.NewLine;
            errType = ErrorEnum.Other;
            int count = 0;
            DataSet ds = new DataSet();
            using (var con = new SqlConnection(_connStr))
            {
                try
                {
                    using (var cmd = new SqlCommand(procName, con))
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        foreach (SqlParameter param in sqlParams)
                        {
                            errMsg += sqlParams[count].ParameterName + "  :  " + sqlParams[count].Value;
                            cmd.Parameters.Add(sqlParams[count]);
                            count++;
                        }

                        da.Fill(ds);
                        isSuccess = true;

                        if (procName.Contains("SP_App_Start"))
                        {
                            string msg = ds.Tables[0].Rows[0][1].ToString();
                            if (msg.Contains("Device is not registered. Please contact support"))
                            {
                                errType = ErrorEnum.MacNotAllowed;
                                isSuccess = false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    errMsg = ex.Message;
                    if (errMsg.Contains("Client with IP address"))
                    {
                        errType = ErrorEnum.IpNotAllowed;
                    }
                    else
                    {
                        errType = ErrorEnum.ProcFailure;
                    }
                    Logger.LogError(ex, errMsg);
                }
                finally
                {
                    con.Close();
                }
            }
            return ds;
        }

        public static List<MacAddr> GetMACAddresses()
        {
            return NetworkInterface.GetAllNetworkInterfaces()
                .Where(a => ((a.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                    //&& (a.OperationalStatus == OperationalStatus.Up)
                    ))
                    .Select(i => new MacAddr
                    {
                        MacId = i.GetPhysicalAddress().ToString(),
                        Connected = i.OperationalStatus.ToString(),
                        OperationalStatus = i.OperationalStatus.ToString(),
                        NetworkInterfaceType = i.NetworkInterfaceType.ToString(),
                        Desc = i.Description,
                        Name = i.Name
                    }).ToList();
        }
    }
}
