using System;
using System.Collections.Generic;
using System.Text;

namespace NET.S._2018.Karakouski._11
{
    interface ILogger
    {

    void Error(string message);
    void Error(Exception ex, string message);
    void Fatal(string message);
    void Fatal(Exception ex, string message);
    void Info(string message);
    void Info(Exception ex, string message);
    void Warn(string message);
    void Warn(Exception ex, string message);

    }
}
