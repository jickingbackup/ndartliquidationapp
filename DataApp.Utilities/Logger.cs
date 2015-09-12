using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Utilities
{
    public class Logger
    {

        public static void Write(Exception exception, string module = "Unknown")
        {
            try
            {
                using(LiteDB.LiteDatabase db = new LiteDB.LiteDatabase("errorlogs.db"))
                {
                    Log log = new Log();
                    log.Message = exception.Message;
                    log.Module = module;

                    if (exception.InnerException != null)
                        log.InnerMessage = exception.InnerException.Message;

                    db.GetCollection<Log>("logs").Insert(log);
                }
            }
            catch (Exception)
            {
                //do nothing
                return;
            }
        }

        internal class Log
        {
            public string Message { get; set; }
            public string InnerMessage { get; set; }
            public string Module { get; set; }
            public DateTime Date { get; set; }

            public Log()
            {
                this.Date = DateTime.Now;
            }
        }
    }
}
