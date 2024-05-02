using System;
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
        string name;

        public ReportManager(string usr_name) 
        { 
            today_pays = DataManager.GetDatedPay(DateTime.Now);
            yesterday_pays = DataManager.GetDatedPay(DateTime.Now.AddDays(-1));
            name = usr_name;
        }

        // Получение данных за сегодняшний день
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
            
            List<double> today_data = new List<double>
            {
                cashless_payment,
                cash_payment
            }; 

            return today_data;  
        }

        // Получение данных за вчерашний день
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

            List<double> yesterday_data = new List<double>
            {
                cashless_payment,
                cash_payment
            };

            return yesterday_data;
        }

        // Сравнение сегодняшних и вчерашних данных
        public List<string> GetAnalizedData()
        {
            List<double> yesterday_data = GetYesterdayData();
            List<double> today_data = GetTodayData();
            string cash_analize = string.Empty;
            string cashless_analize = string.Empty;

            if (today_data[0] >= yesterday_data[0] & yesterday_data[0] != 0 & today_data[0] != 0)
            {
                cashless_analize = $"Это больше на {Math.Round(((today_data[0] / yesterday_data[0]) * 100 - 100), 2)}% чем вчера";
            }
            else if (today_data[0] < yesterday_data[0] & yesterday_data[0] != 0 & today_data[0] != 0)
            {
                cashless_analize = $"Это меньше на {Math.Round((100 - (today_data[0] / yesterday_data[0]) * 100), 2)}% чем вчера";
            }

            if (today_data[1] >= yesterday_data[1] & yesterday_data[1] != 0 & today_data[1] != 0)
            {
                cash_analize = $"Это больше на {Math.Round(((today_data[1] / yesterday_data[1]) * 100 - 100), 2)}% чем вчера";
            }
            else if (today_data[1] < yesterday_data[1] & yesterday_data[1] != 0 & today_data[1] != 0)
            {
                cash_analize = $"Это меньше на {Math.Round((100 - (today_data[1] / yesterday_data[1]) * 100), 2)}% чем вчера";
            }

            List<string> result = new List<string>
            {
                today_data[0].ToString(),
                cashless_analize,
                today_data[1].ToString(),
                cash_analize
            };

            return result;
        }

        // Формирование отчета
        public string GetReport()
        {
            List<string> result = new List<string>();
            result = GetAnalizedData();
            string message = "<h4>Art Coworking приветствует Вас!</h4>" +
                "<p>Еще один рабочий день позади и мы рады поделиться с Вами результатами!</p>" +
                $"Работник {name}" +
                $"<p><b>Сегодня наличными получено: </b> {result[2]} руб. {result[3]}</p>" +
                $"<p><b>Сегодня безналичными получено: </b> {result[0]} руб. {result[1]}</p>";
            return message;
        }
    }
}
