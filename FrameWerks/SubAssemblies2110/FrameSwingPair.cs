#region Copyright (c) 2019 WeaselWare Software
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

    public class FrameSwingPair : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const decimal aluminumCrnBrk = 0.625m;
        const decimal calkJoint = 0.125m;
        const decimal trhGutterAdd = 6.0m;
        const decimal headReduct = 1.375m;
        const decimal botumRedut = .75m;
        const decimal kFoldRedut = .8125m;
        //
        #endregion

        #region Constructor

        public FrameSwingPair()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2110-FrameSwingPair";
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

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #region Frame

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // JambAlumL <-- 
            part = new Part(4352, "JambAlumL", this, 1, m_subAssemblyHieght - calkJoint);
            part.PartGroupType = "Frame";
            part.PartLabel = "1) MiterTop";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // JambAlumR -->
            part = new Part(4352, "JambAlumR", this, 1, m_subAssemblyHieght - calkJoint);
            part.PartGroupType = "Frame";
            part.PartLabel = "1) MiterTop";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // HeadAlum ^^
            part = new Part(4352, "HeadAlum", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame";
            part.PartLabel = "1)MiterEnd";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
            part = new Part(3206, "AglBrktAlum", this, 4, aluminumCrnBrk);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "Angle_1.5";
            m_parts.Add(part);

            // PointSetScrew
            part = new Part(1545, "PointSetScrew", this, 16, 0.0m);
            part.PartGroupType = "AssyHrdwrFrame";
            part.PartLabel = "1/4x20x.375";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare

            // PVC ASTRAGAL
            part = new Part(1901, "PVC ASTRAGAL", this, 1, m_subAssemblyHieght - headReduct - botumRedut);
            part.PartGroupType = "HardWare";
            part.PartLabel = "";
            m_parts.Add(part);

            // ASTRAGAL_COVER
            part = new Part(3062, "ASTRAGAL_COVER", this, 1, m_subAssemblyHieght - headReduct - botumRedut);
            part.PartGroupType = "HardWare";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Seal/Weatherstripping

            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - kFoldRedut - calkJoint, m_subAssemblyWidth - 2 * kFoldRedut);
                //FrameSealKfolD
                part = new Part(2274, "FrameSealKfolD", this, 1, peri - m_subAssemblyWidth);
                part.PartGroupType = "Seal";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        }

        #endregion

    }

}