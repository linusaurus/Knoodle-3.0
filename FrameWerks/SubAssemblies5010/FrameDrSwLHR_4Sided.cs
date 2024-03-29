﻿#region Copyright (c) 2015 WeaselWare Software
/************************************************************************************
'
' Copyright  2015 WeaselWare Software 
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
' Portions Copyright 2015 WeaselWare Software
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

namespace FrameWorks.Makes.System5010
{

    public class FrameDrSwLHR_4Sided : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal gasketReduce = .8125m;
        const decimal bronzeCrnBrk = 0.640m;



        #endregion

        #region Constructor

        public FrameDrSwLHR_4Sided()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-FrameDrSwLHR_4Sided";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            #region Frame-Parts

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // JamBrzL -->>
            decimal doorPanel = decimal.Zero;

            doorPanel = this.Parent.SubAssemblies[0].SubAssemblyHieght;

            part = new Part(4306, "JamBrzL|<", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame";
            decimal step = (doorPanel - 15.0m);
            step /= Convert.ToDecimal((FrameWorks.Functions.HingeCount(doorPanel) - 1));
            step = Math.Round(step, 4);
            //string msg = "";
            part.PartLabel = "1) MiterEnds\r\n" +
                             "2) Position 0rigin TOU @ ->" + (7.5m + 0.875m).ToString() + "\r\n" +
                             "3) Hinge Backer Prep->[1982.m] "
                   + FrameWorks.Functions.HingeCount(doorPanel).ToString() + "@<" + step.ToString() + ">O.C.";

            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // JamBrzR -->> 
            part = new Part(4306, "JamBrzR|>", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame";
            part.PartLabel = "1)MiterEnds\r\n" +
                             "2)[1962.m]Position 0rigin Strike Plate";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // HeadBrz ^^
            part = new Part(4306, "HeadBrz", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame";
            part.PartLabel = "1)MiterEnds\r\n" +
                             "2)[1987.m]Position 0rigin Shoot Strike";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // ThreshBrz ^^
            part = new Part(4306, "ThreshBrz", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame";
            part.PartLabel = "1)MiterEnds\r\n" +
                             "2)[1987.m]Position 0rigin Shoot Strike";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////
            #endregion

            #region Wood-Clad

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Frame_CladJambs
            part = new Part(4361, "WoodCladJambs", this, 2, m_subAssemblyHieght);
            part.PartGroupType = "WoodFrameInt";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Frame_CladHeadThresh
            part = new Part(4361, "WoodCladHeadThresh", this, 2, m_subAssemblyWidth);
            part.PartGroupType = "WoodFrameInt";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyBrackets

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // BrzCnrBrkt
            part = new Part(4265, "BrzCnrBrkt", this, 8, bronzeCrnBrk);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // SocSetScrw.25_20
            part = new Part(1545, "SocSetScrw.25_20", this, 32, 0.0m);
            part.PartGroupType = "AssemblyHdw";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // Strike Plate
            part = new Part(4153, "Strike Plate", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // Shoot Strike 
            part = new Part(1988, "Shoot Strike", this, 2, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            ///////////////////////////////////////////////////////////////////////////////////////////////

            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);
           
            for (int i = 0; i < 1; i++)
            {
                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);
                //FrameSealKfolD
                part = new Part(2274, "FrameSealKfolD", this, 1, peri - 4.0m * gasketReduce);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}