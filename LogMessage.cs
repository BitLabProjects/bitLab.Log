using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitLab.Log
{
  public class LogMessage
  {
    private string mMessage;
    private ELogMessageType mType;
    private int mTag;

    internal LogMessage(string message, 
                        ELogMessageType type,
                        int tag)
    {
      mMessage = message;
      mType = type;
      mTag = tag;
    }

    public string Message
    {
      get { return mMessage; }
    }
    public ELogMessageType Type
    {
      get { return mType; }
    }
    public int Tag
    {
      get { return mTag; }
    }
  }
}
