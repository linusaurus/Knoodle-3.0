﻿#region Copyright (c) 2010 WeaselWare Software
/************************************************************************************
'
' Copyright  2010 WeaselWare Software 
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
' Portions Copyright 2010 WeaselWare Software
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

namespace FrameWorks.System3250
{

    
    public class FrameDoorSwingPairNicPlate : SubAssemblyBase
    {

        #region Fields

        static int createID;
        Part part;
        string partleader;

        #endregion

        #region Constructor

        public FrameDoorSwingPairNicPlate()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Sys3250-FrameDoorSwingPairNicPlate";
        }

        #endregion

        #region Error Handling

        System.Exception HardwareApplicationError(string description)
        {

            return new SystemException(description);
        }

        #endregion

        //Methods
        public override void Build()
        {

            partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            #region Door-Frame


            // JambLeft <<--
            part = new Part(2952, "JambL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "MachineFor2982";
            
            m_parts.Add(part);


            // JambRight -->>
            part = new Part(2952, "JambR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "MachineFor2991";
            
            m_parts.Add(part);


            // Head ^^
            part = new Part(2952, "Head", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "4202.M";
            
            m_parts.Add(part);


            #endregion

            #region Astragal



            // Channel_Astragal
            part = new Part(2763, "Channel_Astragal", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Astragal-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);



            // PVC_Astragal
            part = new Part(1901, "PVC_Astragal", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Astragal-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);



            #endregion

            #region HardWare

            // HingeTop
            part = new Part(2982, "HingeTop", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // HingeMid
            part = new Part(2982, "HingeMid", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // HingeBot
            part = new Part(2982, "HingeBot", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // HingeTop
            part = new Part(2991, "HingeTop", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // HingeMid
            part = new Part(2991, "HingeMid", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // HingeBot
            part = new Part(2991, "HingeBot", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // Hinge Backer
            part = new Part(3003, "HingeBacker", this, 6, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // Hinge Backer
            part = new Part(3004, "HingeBacker", this, 6, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // Assembly Braces
            part = new Part(1117, "Assembly Braces", this, 4, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            #endregion

            #region WeatherSeals

            //Door Bulb Seals
            decimal peri = m_subAssemblyHieght * 2.0m;
            peri += m_subAssemblyWidth;
            part = new Part(2274, "Frame Bulb Seal", this, 1, peri);
            part.PartGroupType = "Seals-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            #endregion

             #region Labor

            part = new LPart("MetalHours",this, 9.0m, 80.0m);
            m_parts.Add(part);
            //1 Receive: 1 Handle: 1.5 Cut: 1.5 Machine: 2 Weld & Assemble: 1 Hardware Prep: 1 NailFin

            part = new LPart("SandLineGrain",this, 2.0m, 80.0m);
            m_parts.Add(part);
            //2 SandLineGrain: 


            #endregion

        }







    }
}