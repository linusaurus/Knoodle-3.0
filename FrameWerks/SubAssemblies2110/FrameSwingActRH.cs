﻿#region Copyright (c) 2019 WeaselWare Software
/************************************************************************************
'
' Copyright  2019 WeaselWare Software 
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
' Portions Copyright 2019 WeaselWare Software
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
using FrameWorks.Makes.System2110;


namespace FrameWorks.Makes.System2110
{

    public class FrameSwingActRH : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts

        const decimal calkJoint = 0.125m;
        const decimal trhGutterAdd = 6.0m;

        //

        #endregion

        #region Constructor

        public FrameSwingActRH()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2110-FrameSwingActRH";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;

            ///////////////////////////////////////////////////////////////////////////

            #region Frame

            // JamAlumL <<-- 

            part = new Part(4352, "JamAlumL|<", this, 1, m_subAssemblyHieght - calkJoint );
            part.PartGroupType = "Frame";
            part.PartLabel = "1)MiterTop\r\n" +
                             "2)[1962.m]Position 0rigin Strike Plate";

            m_parts.Add(part);

            // JamAlumR -->> 

            decimal doorPanel = decimal.Zero;

            doorPanel = this.Parent.SubAssemblies[0].SubAssemblyHieght;

            part = new Part(4352, "JamAlumR>|", this, 1, m_subAssemblyHieght - calkJoint );
            part.PartGroupType = "Frame";
            decimal step = (doorPanel - 15.0m);
            step /= Convert.ToDecimal((FrameWorks.Functions.HingeCount(doorPanel) - 1));
            step = Math.Round(step, 4);
            //string msg = "";
            part.PartLabel = "1) MiterTop\r\n" +
                             "2) [911.m]Cope Jamb Bottom->\r\n" +
                             "3) Position 0rigin TOU @ ->" + (7.5m + 0.875m).ToString() + "\r\n" +
                             "4) Hinge Backer Prep->[1982.m] "
                   + FrameWorks.Functions.HingeCount(doorPanel).ToString() + "@<" + step.ToString() + ">O.C.";

            m_parts.Add(part);

            // HeadAlum ^^
            part = new Part(4352, "HeadAlum", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame";
            part.PartLabel = "1)MiterEnds\r\n" +
                             "2)[1987.m]Position 0rigin Shoot Strike";

            m_parts.Add(part);

            #endregion

            #region ThrehGutAssy

            // ThresGut ^^
            part = new Part(5587, "ThresGut", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "ThrehGutAssy";
            part.PartLabel = "Top";
            m_parts.Add(part);

            // ThresGutBot ^^
            part = new Part(5587, "ThresGut", this, 1, m_subAssemblyWidth + trhGutterAdd);
            part.PartGroupType = "ThrehGutAssy";
            part.PartLabel = "Bottom";
            m_parts.Add(part);


            // Drain ^^
            part = new Part(6911, "Drain", this, 1, 0.0m);
            part.PartGroupType = "ThrehGutAssy";
            part.PartLabel = "Body";
            m_parts.Add(part);


            // Drain ^^
            part = new Part(5477, "Drain", this, 1, 0.0m);
            part.PartGroupType = "ThrehGutAssy";
            part.PartLabel = "FlipperDoor";
            m_parts.Add(part);


            // Drain ^^
            part = new Part(5596, "Drain", this, 1, 0.0m);
            part.PartGroupType = "ThrehGutAssy";
            part.PartLabel = "Spout";
            m_parts.Add(part);
            #endregion

            #region AssyHrdwrFrame

            ///////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
            part = new Part(3206, "AglBrktAlum", this, 4, 0.0m);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////

            // PointSetScrew
            part = new Part(1545, "PointSetScrew", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare

            // StrikePlateRH_LHR
            part = new Part(5334, "StrikePlateRH_LHR", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";
            m_parts.Add(part);

            // ShootStrikeLH_RHR
            part = new Part(5308, "ShootStrikeLH_RHR", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";
            m_parts.Add(part);

            // ShootStrikeRH_LHR
            part = new Part(5310, "ShootStrikeRH_LHR", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";
            m_parts.Add(part);

            #endregion

            #region Seal/Weatherstripping

            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - calkJoint, m_subAssemblyWidth);

                //FrameSealKfolD
                part = new Part(2274, "FrameSealKfolD", this, 1, peri - m_subAssemblyWidth - 4.0m);
                part.PartGroupType = "Seal";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////

        }

        #endregion

    }

}