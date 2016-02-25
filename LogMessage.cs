using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitLab.Log
{
  public class LogMessage
  {
    private int mPrg;
    private string mMessage;
    private ELogMessageType mType;
    private int mTag;

    internal LogMessage(int prg,
                        string message, 
                        ELogMessageType type,
                        int tag)
    {
      mPrg = prg;
      mMessage = message;
      mType = type;
      mTag = tag;
    }

    public int Prg
    {
      get { return mPrg; }
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
