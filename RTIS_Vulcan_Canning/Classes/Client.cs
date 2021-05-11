using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace RTIS_Vulcan_Canning.Classes
{
    class Client
    {
        #region General
        public static string Login(string pin)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*CANNINGLOGIN*@" + pin);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        #endregion

        #region Printing
        public static string getCanningProducts(string itemCode)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*GETCANNINGPRODUCTS*@" + itemCode);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        public static string getRItemDesc(string itemCode)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*GETCANNINGRAWDESC*@" + itemCode);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        public static string recordCanningOut(string itemCode)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*RECORDCANNINGOUT*@" + itemCode);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        #endregion

        #region Reprinting
        public static string getReprintItemList()
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*GETCANNINGREPRINTLIST*@");
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        public static string getReprintLotList(string parameters)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*GETCANNINGREPRINTLOTLIST*@" + parameters);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        public static string getReprintPalletList(string parameters)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*GETCANNINGREPRINTPALLETLIST*@" + parameters);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        public static string reprintCanningLabel(string itemInfo)
        {
            string ServerDetails = "";

            IPAddress ServerIPAddress = null;
            ServerIPAddress = IPAddress.Parse(GlobalVars.ServerIP);
            IPEndPoint ServerEP = new IPEndPoint(ServerIPAddress, Convert.ToInt32(GlobalVars.ServerPort));
            Socket DataClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                byte[] sendbytes = new byte[21];
                byte[] receivebytes = new byte[3];
                ASCIIEncoding ascenc = new ASCIIEncoding();

                DataClient.SendTimeout = 30000;
                DataClient.ReceiveTimeout = 30000;

                //Send start request
                DataClient.Connect(ServerEP);

                sendbytes = ascenc.GetBytes("*REPRINTCANNINGLABEL*@" + itemInfo);
                DataClient.Send(sendbytes);

                receivebytes = new byte[131073];
                int length = DataClient.Receive(receivebytes);
                int count = length;
                while (length != 0)
                {
                    for (int i = 0; i <= length - 1; i++)
                    {
                        ServerDetails += Convert.ToChar(receivebytes[i]);
                        count = count - 1;
                    }
                    count = DataClient.Receive(receivebytes);
                    length = count;
                }

                DataClient.Close();
                return ServerDetails;
            }
            catch (Exception ex)
            {
                DataClient.Close();
                return "-2*Cannot connect to server:" + System.Environment.NewLine + ex.Message;
            }
        }
        #endregion
    }
}
