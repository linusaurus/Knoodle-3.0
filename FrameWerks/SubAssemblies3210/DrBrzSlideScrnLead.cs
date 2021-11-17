#region Copyright (c) 2021 WeaselWare Software
/************************************************************************************
'
' Copyright  2021 WeaselWare Software 
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
' Portions Copyright 2021 WeaselWare Software
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
using FrameWorks.Makes.System3210;


namespace FrameWorks.Makes.System3210
{

    public class DrBrzSlideScrnLead : SubAssemblyBase
    {

        #region Fields


        // The values we can change for different layouts
        const int panelCount = 1;


        #endregion

        #region Constructor

        public DrBrzSlideScrnLead()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3210-DrBrzSlideScrnLead";
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

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region BrzSlideScreen 

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // StileLeft <--
            part = new Part(4190, "StileLeft", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "BrzSlideScreen";
            part.PartLabel = "1) Miter Ends";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // StileRight -->
            part = new Part(4190, "StileRight", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "BrzSlideScreen";
            part.PartLabel = "1) Miter Ends";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // RailTop ^^
            part = new Part(4190, "RailTop", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "BrzSlideScreen";
            part.PartLabel = "1) Miter Ends ";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // RailBot ||
            part = new Part(4190, "RailBot", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "BrzSlideScreen";
            part.PartLabel = "1) Miter Ends ";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region ACRE™

            //////////////////////////////////////////////////////////////////////////////

            // ACRE™edge <--
            part = new Part(4000, "ACRE™edge", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "ACRE™";
            part.PartLabel = "B-9";
            part.PartThick = 0.95m;
            part.PartWidth = 0.84m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // ACRE™edge -->
            part = new Part(4000, "ACRE™edge", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "ACRE™";
            part.PartLabel = "B-12";
            part.PartThick = 0.95m;
            part.PartWidth = 0.84m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // ACRE™ CornerBrace
            part = new Part(349, "ACRE™Brace", this, 4, 0.0m);
            part.PartGroupType = "ACRE™";
            part.PartLabel = "";
            part.PartThick = 0.86224308m;
            part.PartWidth = 2.10543329m;
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////

            #region FlushPulls

            // FP_RearShallow <--
            part = new Part(4674, "FP_RearShallow", this, 1, 0.0m);
            part.PartGroupType = "FlushPulls";
            part.PartLabel = "";
            m_parts.Add(part);

            // FP_RearShallow <--
            part = new Part(4675, "FP_FaceShallow", this, 1, 0.0m);
            part.PartGroupType = "FlushPulls";
            part.PartLabel = "";
            m_parts.Add(part);

            // MachScewOval30mm <--
            part = new Part(4677, "MachScewOval30mm", this, 2, 0.0m);
            part.PartGroupType = "FlushPulls";
            part.PartLabel = "";
            m_parts.Add(part);

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region Twin_Roller

            // TwinRoller
            part = new Part(4679, "Twin_Roller", this, 2, 0.0m);
            part.PartGroupType = "Twin_Roller";
            part.PartLabel = "Twin_Roller";
            m_parts.Add(part);

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region Seal/Weatherstripping

            //////////////////////////////////////////////////////////////////////////////

            // EdgeSeal
            part = new Part(7395, "EdgeSeal", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // BottomSeal
            part = new Part(5468, "BottomSeal", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // BottomSeal
            part = new Part(5468, "BottomSeal", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Seal";
            part.PartLabel = "";
            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

        }

        #endregion

    }

}