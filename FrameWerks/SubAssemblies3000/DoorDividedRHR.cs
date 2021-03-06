#region Copyright (c) 2007 WeaselWare Software
/************************************************************************************
'
' Copyright  2007 WeaselWare Software 
'
' This software is provided 'as-is', without any express or implied warranty. In no 
' event will the authors be held liable for any damages arising from the use of this 
' software.
' 
' Permission is granted to anyone to use this software for any purpose, including 
' commercial applications, and to alter it and redistribute it freely, subject to the 
' following restrictions:
'
' 1. The origin of this software must not be misrepresented; you must not claim that 
' you wrote the original software. If you use this software in a product, an 
' acknowledgment (see the following) in the product documentation is required.
'
' Portions Copyright 2007 WeaselWare Software
'
' 2. Altered source versions must be plainly marked as such, and must not be 
' misrepresented as being the original software.
'
' 3. This notice may not be removed or altered from any source distribution.
'
'***********************************************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using FrameWorks;
using System.Runtime;

namespace FrameWorks.Makes.System3000
{
   
   public class DoorDividedRHR : SubAssemblyBase
   {

      #region Fields

      static int createID;
      Part part;
      string partleader;
      private DividedDoorLayout  m_dividedDoorCalc;

      #endregion

      #region Constructor

      public DoorDividedRHR()
      {
         m_subAssemblyID = Guid.NewGuid();
         this.ModelID = "Sys3000-DoorDividedRHR ";

      }

      #endregion

      #region Methods

      //Bill of Material
      public override void Build()
      {

         partleader =  this.Parent.UnitID + "." + this.CreateID.ToString();
         m_dividedDoorCalc = new DividedDoorLayout(m_subAssemblyHieght);

         #region Panel-Frame


         // StileRight -->>
         part = new Part(1167, "StileR", this, 1, m_subAssemblyHieght);
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "M-1775 Hinge";
         
         m_parts.Add(part);

         // StileLeft <<--
         part = new Part(1167, "StileL", this, 1, m_subAssemblyHieght);
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // RailTop ^^
         part = new Part(1167, "RailT", this, 1, m_subAssemblyWidth);
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // RailBottom ||
         part = new Part(1167, "RailB", this, 1, m_subAssemblyWidth);
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Built Out Stile
         part = new Part(1167, "Stile Doubler", this, 1, m_dividedDoorCalc.Doubler );
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "Miter Returned";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Handle Edge Return
         part = new Part(1167, "Doubler Return", this, 1, 1.3125m);
         part.PartGroupType = "Panel-Parts"; ;
         part.PartLabel = "Mitre Return";
         
         m_parts.Add(part);
 
         

         #endregion

         #region Filler

         part = new Part(1816, "Filler-Top", this, 1, m_subAssemblyWidth + 0.25m);
         part.PartGroupType = "Filler-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

         part = new Part(1817, "Filler-Bottom", this, 1, m_subAssemblyWidth + 0.25m);
         part.PartGroupType = "Filler-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

         part = new Part(1816, "Filler-Left", this, 1, m_subAssemblyHieght  + 0.25m);
         part.PartGroupType = "Filler-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

         part = new Part(1813, "Filler-Right", this, 1, m_subAssemblyHieght  + 0.25m);
         part.PartGroupType = "Filler-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

         #endregion

         #region Stop


         // StopFrontRight
         part = new Part(809, "StopFrontRight", this, 1, m_subAssemblyHieght - (1.3125m * 2.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

         // StopRearRight
         part = new Part(809, "StopRearRight", this, 1, m_subAssemblyHieght - (1.3125m * 2.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

         // StopFrontLeftUp
         part = new Part(809, "StopFrontLeftUp", this, 1, m_dividedDoorCalc.TopStopLength);
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);


         // StopRearLeftUp
         part = new Part(809, "StopRearLeftUp", this, 1, m_dividedDoorCalc.TopStopLength);
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);


         //StopFrontLeftLow
         part = new Part(809, "StopFrontLeftLow", this, 1, m_dividedDoorCalc.BottomStopLength);
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);


         //StopRearLeftLow
         part = new Part(809, "StopRearLeftLow", this, 1, m_dividedDoorCalc.BottomStopLength);
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);


         // StopFrontTop
         part = new Part(809, "StopFrontTop", this, 1, m_subAssemblyWidth - (1.3125m * 2.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);


         // StopFrontBot
         string crap;
         crap = FrameWorks.Functions.StopWeepMachining(m_subAssemblyWidth - 2.0m * 1.3125m);
         part = new Part(809, "StopFrontBot", this, 1, m_subAssemblyWidth - (1.3125m * 2.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "1) Miter Ends" + "\r\n" +
                          "2)" + crap;
         
         m_parts.Add(part);


         // StopRearBot
         part = new Part(809, "StopRearBot", this, 1, m_subAssemblyWidth - (1.3125m * 2.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "MiterEnds";
         
         m_parts.Add(part);


         #endregion

         #region Muntin



         //MuntinUpExtH1
         part = new Part(1862);
         part.FunctionalName = "MuntinUpExtH1";
         part.PartGroupType = "Muntin-Parts";
         part.Qnty = 1;
         part.ContainerAssembly = this;
         part.PartWidth = 1.0m;
         part.PartLength = m_subAssemblyWidth - (2.0625m * 2.0m);
         
         m_parts.Add(part);



         //MuntinUpExtH2
         part = new Part(1862);
         part.FunctionalName = "Applied Muntin Upper";
         part.PartGroupType = "Muntin-Parts";
         part.Qnty = 1;
         part.ContainerAssembly = this;
         part.PartWidth = 1.0m;
         part.PartLength = m_subAssemblyWidth - (2.0625m * 2.0m);
         
         m_parts.Add(part);



         //MuntinUpIntH1
         part = new Part(1862);
         part.FunctionalName = "MuntinUpIntH1";
         part.PartGroupType = "Muntin-Parts";
         part.Qnty = 1;
         part.ContainerAssembly = this;
         part.PartWidth = 1.0m;
         part.PartLength = m_subAssemblyWidth - (2.0625m * 2.0m);
         
         m_parts.Add(part);




         //MuntinUpIntH2
         part = new Part(1862);
         part.FunctionalName = "MuntinUpIntH2";
         part.PartGroupType = "Muntin-Parts";
         part.Qnty = 1;
         part.ContainerAssembly = this;
         part.PartWidth = 1.0m;
         part.PartLength = m_subAssemblyWidth - (2.0625m * 2.0m);
         
         m_parts.Add(part);



         //MuntinLowExtH1
         part = new Part(1862);
         part.FunctionalName = "MuntinLowExtH1";
         part.PartGroupType = "Muntin-Parts";
         part.Qnty = 1;
         part.ContainerAssembly = this;
         part.PartWidth = 1.0m;
         part.PartLength = m_subAssemblyWidth - ((1.3125m * 3.0m) + 1.5m);
         
         m_parts.Add(part);



         //MuntinLowIntH1
         part = new Part(1862);
         part.FunctionalName = "MuntinLowIntH1";
         part.PartGroupType = "Muntin-Parts";
         part.Qnty = 1;
         part.ContainerAssembly = this;
         part.PartWidth = 1.0m;
         part.PartLength = m_subAssemblyWidth - ((1.3125m * 3.0m) + 1.5m);
         
         m_parts.Add(part);



         #endregion

         #region HardWare Logic

         
         // Hinges
         part = new Part(1775, "Hinges", this, HingeCount(m_subAssemblyHieght), 0.0m);
         part.PartGroupType = "Hardware-Parts";
         part.PartLabel = ".25_RAD_Corner";
         
         m_parts.Add(part);

         // Assembly Braces
         part = new Part(1117, "Assembly Braces", this, 4, 0.0m);
         part.PartGroupType = "Hardware-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

         // Tube Backer
         part = new Part(1640, "Tube Backer", this, HingeCount(m_subAssemblyHieght), 0.0m);
         part.PartGroupType = "Hardware-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

         // Bar Backer
         part = new Part(2055, "Bar Backer", this, HingeCount(m_subAssemblyHieght) * 2, 0.0m);
         part.PartGroupType = "Hardware-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

         Hoppe hoppe = new Hoppe(m_subAssemblyHieght, this);
         foreach (Part innerpart in hoppe.Parts)
        {
           //inner
            this.Parts.Add(innerpart);

        }


         #endregion

         #region WeatherSeals

         //Door Bulb Seals
         part = new Part(1769, "Bulb Seal Door", this, 1, ((m_subAssemblyHieght * 2.0m)+ (m_subAssemblyWidth * 2.0m)));
         part.PartGroupType = "Seals-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Glazing Seal
         decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyWidth - (1.3125m * 2.0m),
          m_subAssemblyHieght- (1.3125m * 2.0m));
         part = new Part(1819, "Glazing Seal", this, 1, peri *= 2.0m);
         part.PartGroupType = "Seals-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Door Bottom
         part = new Part(1518, "Door Bottom", this, 1, m_subAssemblyWidth);
         part.PartGroupType = "Seals-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);



         #endregion

         #region Glass


         //Glass Panel
         part = new Part(-1);
         part.FunctionalName = "Glass";
         part.PartGroupType = "Glass-Parts";
         part.Qnty = 1;
         part.Source.MaterialDescription = "1.25 Insulated Glass";
         part.PartName = "PartName";
         part.PartLabel = "Notched For Handle";
         part.Source.MaterialName = "1.25 IGU";
         part.ContainerAssembly = this;
         part.PartThick = 1.25m;
         part.PartWidth =  m_subAssemblyWidth -(1.625m * 2.0m);
         part.PartLength = m_dividedDoorCalc.GlassHieght;
         part.Source.UOM = 9;

         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);


         #endregion

            #region Labor


         part = new LPart("Design", this, 4.0m, 80.0m);
         m_parts.Add(part);
         // Measure: Collect Information on Sizes from Contractor:
         // Provide Information for Approval:
         // Samples Correspondence: Ordering: Supervision

         part = new LPart("Draft", this, 3.0m, 80.0m);
         m_parts.Add(part);
         //Typical Drawings: Supervision

         part = new LPart("MetalHours", this, 8.0m, 80.0m);
         m_parts.Add(part);
         //1 Receive: 1 Handle: 1 Cut: 1 Machine: 2 Weld & Assemble: 1 Hardware Prep: 1 NailFin

         part = new LPart("MuntinHours", this, 6.0m, 80.0m);
         m_parts.Add(part);
         //.5 Per Bar this 12 Bars:

         part = new LPart("GlazingHours", this, (this.Area * 0.1m) + 4.5m, 80.0m);
         m_parts.Add(part);
         //.5 Recieve: 1.0 InspectReject: .5 StoreHandle: 1.0 GlazeShimCalk: .5 SetGlassStop: 05 InsertGasket 

         part = new LPart("FinishHours", this, 4.0m, 80.0m);
         m_parts.Add(part);
         //2 SandLineGrain: 2 Finish

         part = new LPart("Stage", this, 0.5m, 80.0m);
         m_parts.Add(part);
         //.5 Stage

         part = new LPart("Load", this, 1.0m, 80.0m);
         m_parts.Add(part);
          //1 Load


         #endregion



      }

      private int HingeCount(decimal HingeAxisLength)
      {
         int result = 0;

         if (HingeAxisLength < 84.0m)
         {
            result = 3;
         }
         else if ((HingeAxisLength >= 84.0m) && (HingeAxisLength < 114.0m))
         {
            result = 4;
         }
         else if ((HingeAxisLength >= 114.0m) && (HingeAxisLength < 134.0m))
         {
            result = 5;
         }
         else if ((HingeAxisLength >= 134.0m) && (HingeAxisLength < 164.0m))
         {
            result = 6;
         }


         return result;
      }

      

      #endregion

   }
}