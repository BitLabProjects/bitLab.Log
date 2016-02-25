using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitLab.Log
{
  public class Logger
  {
    private static Logger mInstance;
    
    private List<ILogListener> mListeners;

    private Logger()
    {
      mListeners = new List<ILogListener>();
    }

    private static Logger Instance
    {
      get
      {
        if (mInstance == null)
          mInstance = new Logger();
        return mInstance;
      }
    }

    public static void Register(ILogListener listener)
    {
      Instance.mListeners.Add(listener);
    }

    public static void LogInfo(string message, int tag = 0)
    {
      Log(message, ELogMessageType.Info, tag);
    }

    public static void LogWarning(string message, int tag = 0)
    {
      Log(message, ELogMessageType.Warning, tag);
    }

    public static void LogError(string message, int tag = 0)
    {
      Log(message, ELogMessageType.Error, tag);
    }

    private static void Log(string message, ELogMessageType type, int tag)
    {
      var logMessage = new LogMessage(message, type, tag);
      foreach (var listener in Instance.mListeners)
        listener.LogMessage(logMessage);
    }
  }
}
