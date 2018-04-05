using NLog;
using System;

namespace NET.S._2018.Karakouski._11
{
    class NLoggerAdapter : ILogger
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public void Error(string message)
        {
            logger.Error(message);
        }

        public void Error(Exception ex, string message)
        {
            logger.Error(ex, message);
        }

        public void Fatal(string message)
        {
            logger.Fatal(message);
        }

        public void Fatal(Exception ex, string message)
        {
            logger.Fatal(ex, message);
        }

        public void Info(string message)
        {
            logger.Info(message);
        }

        public void Info(Exception ex, string message)
        {
            logger.Info(ex, message);
        }

        public void Warn(string message)
        {
            logger.Warn(message);
        }

        public void Warn(Exception ex, string message)
        {
            logger.Warn(ex, message);
        }
    }
}
