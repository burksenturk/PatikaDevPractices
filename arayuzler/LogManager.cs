using System;

namespace arayuzler
{
    public class LogManager: ILogger{

        public ILogger _logger;   //interface in instance nı yarattık
        public LogManager( ILogger logger)  //logger burada referans olarak yazdık //interfaceler new ile yaratılamaz
        {
            _logger = logger;
        }

        public void WriteLog()
        {
            _logger.WriteLog();
        }
   }
}