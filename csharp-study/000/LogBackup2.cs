using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace LogBackup2
{
    class Program
    {
        static void Main(string[] args)
        {
            DoBackup("Application");
        }

        private static void DoBackup(string sLogName)
        {
            string sBackup = sLogName;  // could be for example "Application"
            EventLog log = new EventLog();
            log.Source = sBackup;

            var query = from EventLogEntry entry in log.Entries
                        orderby entry.TimeGenerated descending
                        select entry;

            string sBackupName = sBackup + "Log";
            var xml = new XDocument(
                new XElement(sBackupName,
                    from EventLogEntry entry in log.Entries
                    orderby entry.TimeGenerated descending
                    select new XElement("Log",
                      new XElement("Message", entry.Message),
                      new XElement("TimeGenerated", entry.TimeGenerated),
                      new XElement("Source", entry.Source),
                      new XElement("EntryType", entry.EntryType.ToString())
                    )
                  )
                );

            DateTime oggi = DateTime.Now;
            string sToday = DateTime.Now.ToString("yyyyMMdd_hhmmss");
            string path = String.Format("{0}_{1}.xml", sBackupName, sToday);
            xml.Save(Path.Combine(Environment.CurrentDirectory, path));
        }
    }
}
