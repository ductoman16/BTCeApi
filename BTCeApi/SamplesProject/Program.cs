﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTCeApi;
using BtceApi.Models;
using ServiceStack.Text;
using BtceApi = BTCeApi.Btce;


namespace SamplesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var apiSecret = "Your_Secret";
            var apiKey = "Your_Key";
            var btce = new Btce(apiKey,apiSecret);
            //var info = btce.GetInfo();

            //var activeOrders = btce.ActiveOrders(Pair.btc_usd);

            //var transactionsHistory = btce.TransactionsHistory();

           // var tradeHistory = btce.TradeHistory();

           // var trade = btce.Trade(Pair.btc_usd, OperationType.buy, 10.1, 1.1);

           // var cancelOrder = btce.CancelOrder(222052617);
           
        }
    }
}