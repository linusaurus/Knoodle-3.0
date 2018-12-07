using System;
using System.Collections.Generic;
using System.Text;

namespace FrameWorks
{
   
   public class RectSize
   {
      public decimal W;
      public decimal H;
   }
   
   
   
   public class PartsHelper
   {
      //public static Part[] MakePaired(string PartName,int sourceID,decimal adjustment,PartCloneType cloneType)
      //{
      //   Part[] _pair = new Part[2];
      //   Part _part = new Part(sourceID);
      //   //_part.PartLength =  
         
      //   return _pair;
      //}
      
      public static RectSize Matrix(decimal w, decimal h,int horizontalDivision, int VerticalDivision)
      {
           RectSize _rect = new RectSize();
           _rect.W = w / horizontalDivision;
           _rect.H = h / VerticalDivision;
           return _rect;
            
      }
      
   }
}
