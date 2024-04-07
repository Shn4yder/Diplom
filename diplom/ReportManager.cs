﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using diplom.Models;


namespace diplom
{
    internal class ReportManager
    {
        List<OrderPay> today_pays = new List<OrderPay>();
        List<OrderPay> yesterday_pays = new List<OrderPay>();

        public ReportManager() 
        { 
            today_pays = DataManager.GetDatedPay(DateTime.Now);
            yesterday_pays = DataManager.GetDatedPay(DateTime.Now.AddDays(-1));
        }

        public List<double> GetTodayData()
        {
            double cashless_payment = 0;
            double cash_payment = 0;    


            foreach (OrderPay pay in today_pays)
            {
                if(pay.Payment == "наличные")
                {
                    cash_payment += pay.Amount;
                }
                else { cashless_payment += pay.Amount; }

            }
            
            List<double> today_data = new List<double>(); 
            today_data.Add(cashless_payment);
            today_data.Add(cash_payment);

            return today_data;  
        }

        public List<double> GetYesterdayData()
        {
            double cashless_payment = 0;
            double cash_payment = 0;


            foreach (OrderPay pay in yesterday_pays)
            {
                if (pay.Payment == "наличные")
                {
                    cash_payment += pay.Amount;
                }
                else { cashless_payment += pay.Amount; }

            }

            List<double> yesterday_data = new List<double>();
            yesterday_data.Add(cashless_payment);
            yesterday_data.Add(cash_payment);

            return yesterday_data;
        }

        public List<string> GetAnalizedData()
        {
            List<double> yesterday_data = GetYesterdayData();
            List<double> today_data = GetTodayData();
            double percent_cashless_diff = 0;
            double percent_cash_diff = 0;
            string cash_analize = string.Empty;
            string cashless_analize = string.Empty;

            double cashless_difference = yesterday_data[0] - today_data[0];
            double cash_difference = yesterday_data[1] - today_data[1];

            if (cashless_difference > 0)
            {
                percent_cashless_diff = Math.Round(((yesterday_data[0] / today_data[0]) * 100 - 100), 2);
                cashless_analize = $"Безналичная выручка за вчерашний день больше на {percent_cashless_diff}% чем сегодня";
            }
            else
            {
                percent_cashless_diff = Math.Round(((today_data[0] / yesterday_data[0]) * 100 - 100), 2);
                cashless_analize = $"Безналичная выручка за сегодняшний день больше на {percent_cashless_diff}% чем вчера";
            }

            if (cash_difference > 0)
            {
                percent_cash_diff = Math.Round(((yesterday_data[0] / today_data[0]) * 100 - 100), 2);
                cash_analize = $"Наличная выручка за вчерашний день больше на {percent_cash_diff}% чем сегодня";
            }
            else
            {
                percent_cash_diff = Math.Round(((today_data[0] / yesterday_data[0]) * 100 - 100), 2);
                cash_analize = $"Наличная выручка за сегодняшний день больше на {percent_cash_diff}% чем вчера";
            }

            List<string> result = new List<string>();
            result.Add(today_data[0].ToString());
            result.Add(cashless_analize);
            result.Add(today_data[1].ToString());
            result.Add(cash_analize);

            return result;
        }

        public string GetReport()
        {
            List<string> result = new List<string>();
            result = GetAnalizedData();
            string message = "<h4>Art Coworking приветствует Вас!</h4>" +
                "<p>Еще один рабочий день позади и мы рады поделиться с Вами результатами!</p>" +
                $"<p><b>Сегодня наличными получено: </b> {result[2]}. {result[3]}</p>" +
                $"<p><b>Сегодня безналичными получено: </b> {result[0]}. {result[1]}</p>";
            return message;
        }
    }
}
