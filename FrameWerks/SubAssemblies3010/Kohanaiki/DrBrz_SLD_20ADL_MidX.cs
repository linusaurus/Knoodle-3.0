#region Copyright (c) 2015 WeaselWare Software
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
using FrameWorks.Makes.System3010;


namespace FrameWorks.Makes.System3010
{

    public class DrBrz_SLD_20ADL_MidX : SubAssemblyBase
    {

        #region Fields


        // The values we can change for different layouts
        const int panelCount = 1;

        const decimal stopReduceX2 = 2.0m * 2.25m;
        const decimal glassReduceX2 = 2.0m * 2.59375m;
        const decimal spaceReduceX2 = 2.0m * 2.3936m;
        const decimal muntReduceX2 = 2.0m * 3.125m;
        const decimal muntWidth = 1.0m;


        #endregion

        #region Constructor

        public DrBrz_SLD_20ADL_MidX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3010-DrBrz_SLD_20ADL_MidX";
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

            #region DoorBzTB

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // StileBTBLeft
            part = new Part(4312, "StileBTBLeft", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "DoorBzTB-Parts";
            part.PartLabel = "1) Miter Ends";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // StileBTBRight
            part = new Part(4312, "StileBTBRight", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "DoorBzTB-Parts";
            part.PartLabel = "1) Miter Ends";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // RailBTBtop
            part = new Part(4312, "RailBTBtop", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "DoorBzTB-Parts";
            part.PartLabel = "1) Miter Ends ";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // RailBTBbot
            part = new Part(4312, "RailBTBbot", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "DoorBzTB-Parts";
            part.PartLabel = "1) Miter Ends ";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Muntin_1"

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //BrzMntHrz20Lt  
            for (int i = 0; i < 8; i++)
            {
                part = new Part(4313, "BrzMntHrz20Lt", this, 1, m_subAssemblyWidth - muntReduceX2);
                part.PartGroupType = "Muntin_1-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //BrzMntVrt20Lt 
            for (int i = 0; i < 30; i++)
            {
                part = new Part(4313, "BrzMntVrt20Lt", this, 1, (m_subAssemblyHieght - muntReduceX2 - 4.0m * muntWidth) / 5.0m);
                part.PartGroupType = "Muntin_1-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";
                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopBrz

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpVert
            part = new Part(4298, "BrzGlsStpVert", this, 2, m_subAssemblyHieght - stopReduceX2);
            part.PartGroupType = "StopBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpTopBot
            part = new Part(4298, "BrzGlsStpTopBot", this, 2, m_subAssemblyWidth - stopReduceX2);
            part.PartGroupType = "StopBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // BrzGlsSPCRVt
            part = new Part(4317, "BrzGlsSPCRVt", this, 2, m_subAssemblyHieght - spaceReduceX2);
            part.PartGroupType = "StopBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // BrzGlsSPCRHz 
            part = new Part(4317, "BrzGlsSPCRHz", this, 2, m_subAssemblyWidth - spaceReduceX2);
            part.PartGroupType = "StopBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // HDPE_LS_LockEdge
            part = new Part(4266, "HDPE_LS_LockEdge", this, 2, m_subAssemblyHieght);
            part.PartGroupType = "HDPE-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyBrackets

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //SS_0.4525_TYPE1
            part = new Part(4408, "SS_0.4525_TYPE1", this, 4, 0.0m);
            part.PartGroupType = "AssyBrackets-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //SS_0.6637 _TYPE2
            part = new Part(4409, "SS_0.6637 _TYPE2", this, 8, 0.0m);
            part.PartGroupType = "AssyBrackets-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //SS_1.0346_TYPE3
            part = new Part(4410, "SS_1.0346_TYPE3", this, 8, 0.0m);
            part.PartGroupType = "AssyBrackets-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region GuidesTop

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // TGParent_5651
            part = new Part(5651, "TGParent_5651", this, 2, 0.0m);
            part.PartGroupType = "GuidesTop-Parts";
            part.PartLabel = "Top_Guide_Parent";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // GuideTop
            part = new Part(2463, "FrontGuideTop", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "GuidesTop-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // GuideTop
            part = new Part(2480, "RearGuideTop", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "GuideTop-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HookCap

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // EndCap
            for (int i = 0; i < 2; i++)
            part = new Part(3938, "EndCap", this, 2, m_subAssemblyHieght + 0.0625m);
            part.PartGroupType = "HookCap-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // HookStrip
            part = new Part(3710, "HookStrip", this, 2, m_subAssemblyHieght + 0.0625m);
            part.PartGroupType = "HookCap-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //Glass Panel
            part = new Part(2137);
            part.FunctionalName = "Gls20ADL";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - glassReduceX2;
            part.PartLength = m_subAssemblyHieght - glassReduceX2;
            part.PartThick = 0.5625m;
            m_parts.Add(part);

            #endregion

            #region HardWare Logic

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // CarrageKit
            part = new Part(3422, "CarrageKit", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////


            // TandemRollerKit
            part = new Part(4116, "TandemRollerKit", this, 2, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // LinkRod

            if (m_subAssemblyWidth >= 25.5m && m_subAssemblyWidth < 130.0m)
            {
                if (m_subAssemblyWidth >= 25.5m && m_subAssemblyWidth <= 50.0m)
                {
                    part = new Part(5483, "LinkRod", this, 1, m_subAssemblyWidth);
                }
                if (m_subAssemblyWidth > 50.0m && m_subAssemblyWidth <= 78.0m)
                {
                    part = new Part(5483, "LinkRod", this, 1, m_subAssemblyWidth);
                }
                if (m_subAssemblyWidth > 78.0m && m_subAssemblyWidth <= 130.0m)
                {
                    part = new Part(3424, "LinkRod", this, 1, m_subAssemblyWidth);
                }

            }
            else
            {
                part = new Part(911, "LinkRod", this, 1, m_subAssemblyWidth);
            }

            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            //EPDMpreSet
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 2.581266m, m_subAssemblyWidth - 2.581266m);
                part = new Part(4314, "EPDMpreSet", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            //WedgEPDM
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 2.581266m, m_subAssemblyWidth - 2.581266m);

                part = new Part(4284, "WedgEPDM", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Edge & Bottom Seal
            part = new Part(1005, "Edge & Bottom Seal", this, 2, m_subAssemblyHieght + m_subAssemblyWidth);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Top Seal
            part = new Part(3783, "Top Seal", this, 2, m_subAssemblyWidth);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // HookPileT+Fin
            part = new Part(3959, "HookPileT+Fin", this, 2, m_subAssemblyHieght);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion

    }

}