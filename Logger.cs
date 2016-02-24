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

    public static void LogInfo(string message)
    {
      var logMessage = new LogMessage(message, ELogMessageType.Info);
      foreach (var listener in Instance.mListeners)
        listener.LogMessage(logMessage);
    }
  }
}
