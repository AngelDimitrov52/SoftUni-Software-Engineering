using SOLID.Appernders;
using SOLID.Enums;
using SOLID.Layouts;
using SOLID.Loggers;
using System;
using System.Collections.Generic;

namespace SOLID
{
    class Program
    {

        private static ILayoutFactory layoutFactory;
        private static IApenderFactory apenderFactory;
        static void Main(string[] args)
        {
            layoutFactory = new LayoutFactory();
            apenderFactory = new AppenderFactory();

            int n = int.Parse(Console.ReadLine());

            List<IAppender> appenders = ReadAppender(n);

            Logger logger = new Logger(appenders.ToArray());

            LogErrors(logger);
           
            Console.WriteLine(logger);

        }

        private static void LogErrors(Logger logger)
        {
            string comand;
            while ((comand = Console.ReadLine()) != "END")
            {
                string[] comandArgs = comand.Split("|");

                ReportLevel reportLevel = Enum.Parse<ReportLevel>(comandArgs[0], true);
                string date = comandArgs[1];
                string messaage = comandArgs[2];

                if (reportLevel == ReportLevel.Info)
                {
                    logger.Info(date, messaage);
                }
                else if (reportLevel == ReportLevel.Critical)
                {
                    logger.Critical(date, messaage);
                }
                else if (reportLevel == ReportLevel.Fatal)
                {
                    logger.Fatal(date, messaage);
                }
                else if (reportLevel == ReportLevel.Warning)
                {
                    logger.Warning(date, messaage);
                }
                else if (reportLevel == ReportLevel.Error)
                {
                    logger.Error(date, messaage);
                }

            }
        }

        private static List<IAppender> ReadAppender(int n)
        {
            List<IAppender> appenders = new List<IAppender>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string apppender = data[0];
                string layuotType = data[1];
                ReportLevel reportLevel = ReportLevel.Info;

                ILayout layout = layoutFactory.CreateLayout(layuotType);

                if (data.Length == 3)
                {
                    reportLevel = Enum.Parse<ReportLevel>(data[2], true);
                }

                IAppender apender = apenderFactory.CreateAppender(apppender, layout, reportLevel);

                appenders.Add(apender);
            }
            return appenders;
        }
    }
}

