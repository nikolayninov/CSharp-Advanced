namespace LoggerApp.Appenders
{
    using System;

    using Contracts;
    using Layouts.Contracts;
    using LoggerApp.Loggers.Enums;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) : base(layout) { }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                this.MessagesCount++;
                System.Console.WriteLine(string.Format(this.Layout.Format, dateTime, reportLevel, message));
            }
        }
        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: { this.ReportLevel.ToString().ToUpper()}, Messages appended: { this.MessagesCount}";
        }
    }
}